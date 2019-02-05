using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AirportParser.Models;

namespace AirportParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var properties = PopulateColumnsAsync().GetAwaiter().GetResult();
            //Note: the example data file only has a small subset of airports due to github's file size limits
            var airports = GetAirportsAsync(properties).GetAwaiter().GetResult();

            var sb = new StringBuilder();
            sb.AppendJoin(Environment.NewLine, airports.Where(a => !string.IsNullOrWhiteSpace(a.ICAO_IDENTIFIER_INTERNATIONAL_CODING_FOR_AIRPORT)).Select(GetAirportData));

            File.WriteAllText("Data/Output.txt", sb.ToString());
        }

        private static string GetAirportData(Airport a)
        {
            return string.Join(",", new[] {
                a.ICAO_IDENTIFIER_INTERNATIONAL_CODING_FOR_AIRPORT,
                a.ICAO_IDENTIFIER_INTERNATIONAL_CODING_FOR_AIRPORT?.Substring(1),
                a.OFFICIAL_FACILITY_NAME,
                a.ASSOCIATED_CITY_NAME,
                a.ASSOCIATED_STATE_NAME,
                GetCountry(a.ICAO_IDENTIFIER_INTERNATIONAL_CODING_FOR_AIRPORT),
                GetDecimalDegrees(a.AIRPORT_REFERENCE_POINT_LATITUDE__SECONDS).ToString(),
                GetDecimalDegrees(a.AIRPORT_REFERENCE_POINT_LONGITUDE__SECONDS).ToString(),
                a.AIRPORT_ELEVATION__NEAREST_TENTH_OF_A_FOOT_MSL__ELEVATION_IS_MEASURED_AT_THE_HIGHEST_POINT_ON_THE_CE,
                a.MAGNETIC_VARIATION_AND_DIRECTION_MAGNETIC_VARIATION_TO_NEAREST_DEGREE});
        }

        private static string GetCountry(string icao)
        {
            switch (icao.First())
            {
                case 'C':
                    return "Canada";
                case 'F':
                    return "Saint Helena, Ascension and Tristan da Cunha";
                case 'K':
                    return "United States";
                case 'M':
                    switch (icao.Substring(1, 1))
                    {
                        case "B":
                            return "Turks and Caicos Islands";
                        case "Y":
                            return "Bahamas";
                        default:
                            return "Unknown";
                    }
                case 'N':
                    return "Samoa";
                case 'P':
                    return "United States";
                case 'T':
                    switch (icao.Substring(1, 1))
                    {
                        case "F":
                            return "France";
                        case "I":
                        case "J":
                            return "United States";
                        case "N":
                            return "Caribbean Netherlands, Aruba, Curaçao, Sint Maarten";
                        case "Q":
                        case "U":
                        case "X":
                            return "United Kingdom";
                        default:
                            return "Unknown";
                    }
                default:
                    return "Unknown";
            }

            // C-Canada
            // F-Saint Helena, Ascension and Tristan da Cunha
            // K-United States
            // MB-Turks and Caicos Islands
            // MY-Bahamas
            // NS-Samoa, United States (American Samoa)
            // PA-US (Alaska)
            // PF-US (Alaska)
            // PG-US (Guam, Northern Mariana Islands)
            // PH-US (Hawaii)
            // PK-Marshall Islands
            // PM-US (Midway Island)
            // PP-US (Alaska) 
            // PT-Federated States of Micronesia, Palau
            // PW-US (Wake Island)
            // TF-France (Guadeloupe, Martinique, Saint Barthélemy, Saint Martin)
            // TI-US (U.S. Virgin Islands)
            // TJ-US (Puerto Rico)
            // TN-Caribbean Netherlands, Aruba, Curaçao, Sint Maarten
            // TQ-UK (Anguilla)
            // TU-UK (British Virgin Islands)
            // TX-UK (Bermuda)
        }

        private static double GetDecimalDegrees(string latitudeInSeconds)
        {
            var isNegative = false;
            if (latitudeInSeconds.EndsWith("S") || latitudeInSeconds.EndsWith("W"))
            {
                isNegative = true;
            }
            var seconds = int.Parse(string.Join("", latitudeInSeconds.AsEnumerable().TakeWhile(c => char.IsDigit(c))));
            var hours = seconds / 3600;
            var leftovers = seconds % 3600;
            return (hours + (leftovers / 3600.0)) * (isNegative ? -1.0 : 1.0);
        }

        private async static Task<List<Airport>> GetAirportsAsync(List<ColumnData> properties)
        {
            //https://www.faa.gov/air_traffic/flight_info/aeronav/aero_data/NASR_Subscription_2019-01-31/
            var airports = new List<Airport>();
            var lines = (await File.ReadAllLinesAsync("Data/APT.txt")).Where(line => line.StartsWith("APT"));
            foreach (var line in lines)
            {
                var airport = new Airport();
                foreach (var property in properties)
                {
                    var val = line.Substring(property.StartIndex - 1, property.Length).Trim();
                    airport.GetType().GetProperty(property.PropertyName).SetValue(airport, val);
                }
                airports.Add(airport);
            }

            return airports;
        }

        private async static Task<List<ColumnData>> PopulateColumnsAsync(bool saveModel = false)
        {
            // "https://nfdc.faa.gov/webContent/28DaySub/2019-01-31/Layout_Data/apt_rf.txt";
            var properties = new List<ColumnData>();
            var data = await File.ReadAllTextAsync("Data/apt_rf.txt");
            if (data != null)
            {
                data = data.Substring(data.IndexOf("*          L A N D I N G   F A C I L I T Y   D A T A                   *"));
                data = data.Substring(0, data.IndexOf("J  T   L   S L   E N"));
                var splits = data.Split(new[] { "\r\nL ", "\r\nR " }, StringSplitOptions.RemoveEmptyEntries).Skip(1);//.Where(line => line.StartsWith("L") || line.StartsWith("R"));
                splits = splits.Select(s => s.Replace("\r\n", " "));
                splits = splits.Select(s => s.Replace("\n", " "));

                var sb = new StringBuilder();
                sb.AppendLine("namespace AirportParser.Models");
                sb.AppendLine("{");
                sb.AppendLine("    public class Airport");
                sb.AppendLine("    {");

                sb.AppendLine("        // J  T   L   S L   E N");
                sb.AppendLine("        // U  Y   E   T O   L U");
                sb.AppendLine("        // S  P   N   A C   E M");
                sb.AppendLine("        // T  E   G   R A   M B");
                sb.AppendLine("        //        T   T T   E E");
                sb.AppendLine("        //        H     I   N R");
                sb.AppendLine("        //              O   T");
                sb.AppendLine("        //              N           FIELD DESCRIPTION");
                sb.AppendLine();

                foreach (var line in splits)
                {
                    sb.AppendLine($"        // {line}");
                    var propertyName = Sanitize(line.Substring(23).Trim());
                    sb.AppendLine($"        public string {propertyName} {{get; set;}}");
                    sb.AppendLine();

                    properties.Add(new ColumnData
                    {
                        StartIndex = int.Parse(line.Substring(8, 5)),
                        Length = int.Parse(line.Substring(3, 4)),
                        PropertyName = propertyName
                    });
                }

                sb.AppendLine("    }");
                sb.AppendLine("}");

                if (saveModel)
                {
                    await File.WriteAllTextAsync(@"Models\Airport.cs", sb.ToString());
                }
            }
            return properties;
        }

        //From: https://stackoverflow.com/a/32838640
        private static string Sanitize(string s)
        {
            if (char.IsDigit(s.First()))
            {
                s = $"_{s}";
            }
            s = Regex.Replace(s, @"-+", " ");
            s = Regex.Replace(s, @"\s+", " ");
            if (s.Contains("(EX. "))
            {
                s = s.Substring(0, s.IndexOf("(EX. "));
            }
            if (s.Contains("//DATA FORMATS:"))
            {
                s = s.Substring(0, s.IndexOf("//DATA FORMATS:"));
            }

            return String.Join("", s.AsEnumerable().Take(100).Select(chr => char.IsLetter(chr) || char.IsDigit(chr)
                                                   ? chr.ToString()      // valid symbol
                                                   : "_") // invalid symbol
                              ).TrimEnd('_');
        }
    }
}
