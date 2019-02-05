namespace AirportParser.Models
{
    public class Airport
    {
        // J  T   L   S L   E N
        // U  Y   E   T O   L U
        // S  P   N   A C   E M
        // T  E   G   R A   M B
        //        T   T T   E E
        //        H     I   N R
        //              O   T
        //              N           FIELD DESCRIPTION
        
        // AN 0003 00001  N/A     RECORD TYPE INDICATOR.                             APT: BASIC LANDING FACILITY DATA 
        public string RECORD_TYPE_INDICATOR__APT__BASIC_LANDING_FACILITY_DATA {get; set;}

        // AN 0011 00004  DLID    LANDING FACILITY SITE NUMBER                             A UNIQUE IDENTIFYING NUMBER WHICH,                             TOGETHER WITH THE LANDING FACILITY TYPE CODE,                             FORMS THE KEY TO THE AIRPORT RECORD.                             FILE.  EXAMPLE: 04508.*A   
        public string LANDING_FACILITY_SITE_NUMBER_A_UNIQUE_IDENTIFYING_NUMBER_WHICH__TOGETHER_WITH_THE_LANDING_FACILITY_T {get; set;}

        // AN 0013 00015  DLID    LANDING FACILITY TYPE                              AIRPORT                             BALLOONPORT                             SEAPLANE BASE                             GLIDERPORT                             HELIPORT                             ULTRALIGHT 
        public string LANDING_FACILITY_TYPE_AIRPORT_BALLOONPORT_SEAPLANE_BASE_GLIDERPORT_HELIPORT_ULTRALIGHT {get; set;}

        // AN 0004 00028  E7      LOCATION IDENTIFIER                             UNIQUE 3-4 CHARACTER ALPHANUMERIC IDENTIFIER                             ASSIGNED TO THE LANDING FACILITY.                             (EX. 'ORD' FOR CHICAGO O'HARE)
        public string LOCATION_IDENTIFIER_UNIQUE_3_4_CHARACTER_ALPHANUMERIC_IDENTIFIER_ASSIGNED_TO_THE_LANDING_FACILITY {get; set;}

        // AN 0010 00032  N/A     INFORMATION EFFECTIVE DATE (MM/DD/YYYY)                             THIS DATE COINCIDES WITH THE 56-DAY                             CHARTING AND PUBLICATION CYCLE DATE.                           -----------------------------------------------                                     DEMOGRAPHIC DATA                          ----------------------------------------------- 
        public string INFORMATION_EFFECTIVE_DATE__MM_DD_YYYY__THIS_DATE_COINCIDES_WITH_THE_56_DAY_CHARTING_AND_PUBLICATION {get; set;}

        // AN 0003 00042  A6      FAA REGION CODE                             CODE           REGION NAME                             ----           -----------                             AAL            ALASKA                             ACE            CENTRAL                             AEA            EASTERN                             AGL            GREAT LAKES                             AIN            INTERNATIONAL                             ANE            NEW ENGLAND                             ANM            NORTHWEST MOUNTAIN                             ASO            SOUTHERN                             ASW            SOUTHWEST                             AWP            WESTERN-PACIFIC 
        public string FAA_REGION_CODE_CODE_REGION_NAME_AAL_ALASKA_ACE_CENTRAL_AEA_EASTERN_AGL_GREAT_LAKES_AIN_INTERNATIONA {get; set;}

        // AN 0004 00045  A6A     FAA DISTRICT OR FIELD OFFICE CODE                             (EX. CHI)
        public string FAA_DISTRICT_OR_FIELD_OFFICE_CODE {get; set;}

        // AN 0002 00049  A4      ASSOCIATED STATE POST OFFICE CODE                             STANDARD TWO LETTER ABBREVIATION                             FOR U.S. STATES AND TERRITORIES                             (EX. IL,PR,CQ)
        public string ASSOCIATED_STATE_POST_OFFICE_CODE_STANDARD_TWO_LETTER_ABBREVIATION_FOR_U_S__STATES_AND_TERRITORIES {get; set;}

        // AN 0020 00051  A4      ASSOCIATED STATE NAME                             (EX. ILLINOIS)
        public string ASSOCIATED_STATE_NAME {get; set;}

        // AN 0021 00071  A5      ASSOCIATED COUNTY (OR PARISH) NAME                             (EX. COOK)                             (FOR NON-US AREODROMES THIS MAY BE                             TERRITORY OR PROVINCE NAME)
        public string ASSOCIATED_COUNTY__OR_PARISH__NAME {get; set;}

        // AN 0002 00092  A5      ASSOCIATED COUNTY'S STATE (POST OFFICE CODE)                             STATE WHERE THE ASSOCIATED COUNTY IS                             LOCATED; MAY NOT BE THE SAME AS THE                             ASSOCIATED CITY'S STATE CODE.                             (EX. IL)                              FOR NON-US AERODROME FACILITIES, THESE                             "STATE" CODES ARE INTERNAL TO THIS SYSTEM AND MAY                             NOT CORRESPOND TO STANDARD STATE OR COUNTRY CODES                             IN USE ELSEWHERE. NONSTANDARD                             "COUNTY_ASSOCIATED_STATE" AND "COUNTY" NAMES                             CURRENTLY IN USE INCLUDE:                                 COUNTY_ASSOC_STATE  COUNTY NAME                                ------------------  ---------------------                                AI                  ANGUILLA                                AN                  NETHERLANDS ANTILLES                                AS                  AMERICAN SAMOA                                BL                  SAINT BARTHELEMY                                     BM                  BERMUDA                                BS                  BAHAMAS                                CN                  B.C., CANADA                                CN                  QUEBEC, CANADA                                CN                  P.E.I., CANADA                                CN                  ALBERTA, CANADA                                CN                  ONTARIO, CANADA                                CN                  NUNAVUT, CANADA                                CN                  MANITOBA, CANADA                                CN                  YUKON TERR, CANADA                                CN                  NOVA SCOTIA, CANADA                                CN                  SASKATCHEWAN, CANADA                                CN                  NEWFOUNDLAND, CANADA                                CN                  NORTHWEST TERR,CANADA                                CN                  NEW BRUNSWICK, CANADA                                FM                  FED STS MICRONESIA                                GL                  GREENLAND                                GP                  GUADELOUPE                                GU                  GUAM                                IO                  BRITISH INDIAN OCEAN                                IQ                  US MISC PACIFIC IS                                MF                  SAINT MARTIN                                MH                  MARSHALL ISLANDS                                MP                  N MARIANA ISLANDS                                MQ                  MIDWAY ISLANDS                                PW                  PALAU                                SH                  SAINT HELENA                                TC                  TURKS AND CAICOS                                TQ                  -TRUST TERR. OF PAC-                                VG                  VIRGIN ISLANDS, BRIT                                VI                  VIRGIN ISLANDS                                WQ                  WAKE ISLAND  
        public string ASSOCIATED_COUNTY_S_STATE__POST_OFFICE_CODE__STATE_WHERE_THE_ASSOCIATED_COUNTY_IS_LOCATED__MAY_NOT_B {get; set;}

        // AN 0040 00094  A1      ASSOCIATED CITY NAME                             (EX. CHICAGO)
        public string ASSOCIATED_CITY_NAME {get; set;}

        // AN 0050 00134  A2      OFFICIAL FACILITY NAME                             (EX. CHICAGO O'HARE INTL)                           -----------------------------------------------                                     OWNERSHIP DATA                          ----------------------------------------------- 
        public string OFFICIAL_FACILITY_NAME {get; set;}

        // AN 0002 00184  A10     AIRPORT OWNERSHIP TYPE                             PU - PUBLICLY OWNED                             PR - PRIVATELY OWNED                             MA - AIR FORCE OWNED                             MN - NAVY OWNED                             MR - ARMY OWNED                             CG - COAST GUARD OWNED
        public string AIRPORT_OWNERSHIP_TYPE_PU_PUBLICLY_OWNED_PR_PRIVATELY_OWNED_MA_AIR_FORCE_OWNED_MN_NAVY_OWNED_MR_ARMY {get; set;}

        // AN 0002 00186  A18     FACILITY USE                             PU - OPEN TO THE PUBLIC                             PR - PRIVATE
        public string FACILITY_USE_PU_OPEN_TO_THE_PUBLIC_PR_PRIVATE {get; set;}

        // AN 0035 00188  A11     FACILITY OWNER'S NAME
        public string FACILITY_OWNER_S_NAME {get; set;}

        // AN 0072 00223  A12     OWNER'S ADDRESS
        public string OWNER_S_ADDRESS {get; set;}

        // AN 0045 00295  A12A    OWNER'S CITY, STATE AND ZIP CODE
        public string OWNER_S_CITY__STATE_AND_ZIP_CODE {get; set;}

        // AN 0016 00340  A13     OWNER'S PHONE NUMBER                            DATA FORMATS:                              NNN-NNN-NNNN  (AREA CODE + PHONE NUMBER)                              1-NNN-NNNN    (DIAL 1-800 THEN NUMBER)                              8-NNN-NNNN    (DIAL 800 THEN NUMBER) 
        public string OWNER_S_PHONE_NUMBER_DATA_FORMATS__NNN_NNN_NNNN__AREA_CODE___PHONE_NUMBER__1_NNN_NNNN__DIAL_1_800_TH {get; set;}

        // AN 0035 00356  A14     FACILITY MANAGER'S NAME
        public string FACILITY_MANAGER_S_NAME {get; set;}

        // AN 0072 00391  A15     MANAGER'S ADDRESS
        public string MANAGER_S_ADDRESS {get; set;}

        // AN 0045 00463  A15A    MANAGER'S CITY, STATE AND ZIP CODE
        public string MANAGER_S_CITY__STATE_AND_ZIP_CODE {get; set;}

        // AN 0016 00508  A16     MANAGER'S PHONE NUMBER                            DATA FORMATS:                              NNN-NNN-NNNN  (AREA CODE + PHONE NUMBER)                              1-NNN-NNNN    (DIAL 1-800 THEN NUMBER)                              8-NNN-NNNN    (DIAL 800 THEN NUMBER)                           -----------------------------------------------                                           GEOGRAPHIC DATA                          ----------------------------------------------- 
        public string MANAGER_S_PHONE_NUMBER_DATA_FORMATS__NNN_NNN_NNNN__AREA_CODE___PHONE_NUMBER__1_NNN_NNNN__DIAL_1_800 {get; set;}

        // AN 0015 00524  A19     AIRPORT REFERENCE POINT LATITUDE (FORMATTED)
        public string AIRPORT_REFERENCE_POINT_LATITUDE__FORMATTED {get; set;}

        // AN 0012 00539  A19S    AIRPORT REFERENCE POINT LATITUDE (SECONDS)
        public string AIRPORT_REFERENCE_POINT_LATITUDE__SECONDS {get; set;}

        // AN 0015 00551  A20     AIRPORT REFERENCE POINT LONGITUDE (FORMATTED)
        public string AIRPORT_REFERENCE_POINT_LONGITUDE__FORMATTED {get; set;}

        // AN 0012 00566  A20S    AIRPORT REFERENCE POINT LONGITUDE (SECONDS)
        public string AIRPORT_REFERENCE_POINT_LONGITUDE__SECONDS {get; set;}

        // AN 0001 00578  A19A    AIRPORT REFERENCE POINT DETERMINATION METHOD                             E - ESTIMATED                             S - SURVEYED
        public string AIRPORT_REFERENCE_POINT_DETERMINATION_METHOD_E_ESTIMATED_S_SURVEYED {get; set;}

        // AN 0007 00579  A21     AIRPORT ELEVATION  (NEAREST TENTH OF A FOOT MSL)                             ELEVATION IS MEASURED AT THE HIGHEST POINT                             ON THE CENTERLINE OF THE USABLE LANDING                             SURFACE                             (EX. 1200.5; -10.0 FOR 10 FEET BELOW SEA LEVEL)
        public string AIRPORT_ELEVATION__NEAREST_TENTH_OF_A_FOOT_MSL__ELEVATION_IS_MEASURED_AT_THE_HIGHEST_POINT_ON_THE_CE {get; set;}

        // AN 0001 00586  A21     AIRPORT ELEVATION DETERMINATION METHOD                             E - ESTIMATED                             S - SURVEYED
        public string AIRPORT_ELEVATION_DETERMINATION_METHOD_E_ESTIMATED_S_SURVEYED {get; set;}

        // AN 0003 00587  E28     MAGNETIC VARIATION AND DIRECTION                             MAGNETIC VARIATION TO NEAREST DEGREE                             (EX. 03W)
        public string MAGNETIC_VARIATION_AND_DIRECTION_MAGNETIC_VARIATION_TO_NEAREST_DEGREE {get; set;}

        // AN 0004 00590  E28     MAGNETIC VARIATION EPOCH YEAR                             (EX. 1985)
        public string MAGNETIC_VARIATION_EPOCH_YEAR {get; set;}

        // AN 0004 00594  E147    TRAFFIC PATTERN ALTITUDE  (WHOLE FEET AGL)                             (EX. 1000)
        public string TRAFFIC_PATTERN_ALTITUDE__WHOLE_FEET_AGL {get; set;}

        // AN 0030 00598  A7      AERONAUTICAL SECTIONAL CHART ON WHICH FACILITY                          APPEARS. (EX. WASHINGTON)
        public string AERONAUTICAL_SECTIONAL_CHART_ON_WHICH_FACILITY_APPEARS {get; set;}

        // AN 0002 00628  A3      DISTANCE FROM CENTRAL BUSINESS DISTRICT OF                          THE ASSOCIATED CITY TO THE AIRPORT                             (NEAREST NAUTICAL MILE - EX. 08)
        public string DISTANCE_FROM_CENTRAL_BUSINESS_DISTRICT_OF_THE_ASSOCIATED_CITY_TO_THE_AIRPORT__NEAREST_NAUTICAL_MILE {get; set;}

        // AN 0003 00630  A3      DIRECTION OF AIRPORT FROM CENTRAL BUSINESS                          DISTRICT OF ASSOCIATED CITY                             (NEAREST 1/8 COMPASS POINT - EX. NE)
        public string DIRECTION_OF_AIRPORT_FROM_CENTRAL_BUSINESS_DISTRICT_OF_ASSOCIATED_CITY__NEAREST_1_8_COMPASS_POINT_EX {get; set;}

        // AN 0005 00633  A22     LAND AREA COVERED BY AIRPORT (ACRES)                           -----------------------------------------------                                    FAA SERVICES                          ----------------------------------------------- 
        public string LAND_AREA_COVERED_BY_AIRPORT__ACRES__FAA_SERVICES {get; set;}

        // AN 0004 00638  E146A   BOUNDARY ARTCC IDENTIFIER                             THE BOUNDARY ARTCC IS THE FAA AIR ROUTE                             TRAFFIC CONTROL CENTER WITHIN WHOSE                             PUBLISHED BOUNDARIES THE AIRPORT LIES.                             IT MAY NOT BE THE CONTROLLING ARTCC                             FOR THE AIRPORT IF A LETTER OF AGREEMENT                             EXISTS BETWEEN THE BOUNDARY ARTCC AND                             ANOTHER ARTCC.                             (EX. ZDC FOR WASHINGTON ARTCC)
        public string BOUNDARY_ARTCC_IDENTIFIER_THE_BOUNDARY_ARTCC_IS_THE_FAA_AIR_ROUTE_TRAFFIC_CONTROL_CENTER_WITHIN_WHOS {get; set;}

        // AN 0003 00642  E146B   BOUNDARY ARTCC (FAA) COMPUTER IDENTIFIER                             (EX. ZCW FOR WASHINGTON ARTCC)
        public string BOUNDARY_ARTCC__FAA__COMPUTER_IDENTIFIER {get; set;}

        // AN 0030 00645  E146C   BOUNDARY ARTCC NAME                             (EX. WASHINGTON)
        public string BOUNDARY_ARTCC_NAME {get; set;}

        // AN 0004 00675  E156A   RESPONSIBLE ARTCC IDENTIFIER                             THE RESPONSIBLE ARTCC IS THE FAA AIR ROUTE                             TRAFFIC CONTROL CENTER WHO HAS ASSUMED                             CONTROL                             OVER THE AIRPORT THROUGH A LETTER OF                             AGREEMENT WITH THE BOUNDARY ARTCC.                             (EX. ZDC FOR WASHINGTON ARTCC)
        public string RESPONSIBLE_ARTCC_IDENTIFIER_THE_RESPONSIBLE_ARTCC_IS_THE_FAA_AIR_ROUTE_TRAFFIC_CONTROL_CENTER_WHO_H {get; set;}

        // AN 0003 00679  E156B   RESPONSIBLE ARTCC (FAA) COMPUTER IDENTIFIER                             (EX. ZCW FOR WASHINGTON ARTCC)
        public string RESPONSIBLE_ARTCC__FAA__COMPUTER_IDENTIFIER {get; set;}

        // AN 0030 00682  E156C   RESPONSIBLE ARTCC NAME                             (EX. WASHINGTON)
        public string RESPONSIBLE_ARTCC_NAME {get; set;}

        // AN 0001 00712  A87     TIE-IN FSS PHYSICALLY LOCATED ON FACILITY                             Y - TIE-IN FSS IS ON THE AIRPORT                             N - TIE-IN FSS IS NOT ON AIRPORT
        public string TIE_IN_FSS_PHYSICALLY_LOCATED_ON_FACILITY_Y_TIE_IN_FSS_IS_ON_THE_AIRPORT_N_TIE_IN_FSS_IS_NOT_ON_AIRP {get; set;}

        // AN 0004 00713  A86     TIE-IN FLIGHT SERVICE STATION (FSS) IDENTIFIER                             (EX. DCA FOR WASHINGTON FSS)
        public string TIE_IN_FLIGHT_SERVICE_STATION__FSS__IDENTIFIER {get; set;}

        // AN 0030 00717  A86     TIE-IN FSS NAME                             (EX. WASHINGTON)
        public string TIE_IN_FSS_NAME {get; set;}

        // AN 0016 00747  A88     LOCAL PHONE NUMBER FROM AIRPORT TO FSS                          FOR ADMINISTRATIVE SERVICES
        public string LOCAL_PHONE_NUMBER_FROM_AIRPORT_TO_FSS_FOR_ADMINISTRATIVE_SERVICES {get; set;}

        // AN 0016 00763  A89     TOLL FREE PHONE NUMBER FROM AIRPORT TO FSS                          FOR PILOT BRIEFING SERVICES
        public string TOLL_FREE_PHONE_NUMBER_FROM_AIRPORT_TO_FSS_FOR_PILOT_BRIEFING_SERVICES {get; set;}

        // AN 0004 00779  A86A    ALTERNATE FSS IDENTIFIER                             PROVIDES THE IDENTIFIER OF A FULL-TIME                             FLIGHT SERVICE STATION THAT ASSUMES                             RESPONSIBILITY FOR THE AIRPORT DURING THE OFF                             HOURS OF A PART-TIME PRIMARY FSS.                             (EX. 'DCA' FOR WASHINGTON FSS)
        public string ALTERNATE_FSS_IDENTIFIER_PROVIDES_THE_IDENTIFIER_OF_A_FULL_TIME_FLIGHT_SERVICE_STATION_THAT_ASSUMES {get; set;}

        // AN 0030 00783  A86A    ALTERNATE FSS NAME                             (EX. 'WASHINGTON' FOR WASHINGTON FSS)
        public string ALTERNATE_FSS_NAME {get; set;}

        // AN 0016 00813  E3A     TOLL FREE PHONE NUMBER FROM AIRPORT TO                          ALTERNATE FSS FOR PILOT BRIEFING SERVICES
        public string TOLL_FREE_PHONE_NUMBER_FROM_AIRPORT_TO_ALTERNATE_FSS_FOR_PILOT_BRIEFING_SERVICES {get; set;}

        // AN 0004 00829  E2B     IDENTIFIER OF THE FACILITY RESPONSIBLE FOR                          ISSUING NOTICES TO AIRMEN (NOTAMS) AND                          WEATHER INFORMATION FOR THE AIRPORT                             (EX. ORD)
        public string IDENTIFIER_OF_THE_FACILITY_RESPONSIBLE_FOR_ISSUING_NOTICES_TO_AIRMEN__NOTAMS__AND_WEATHER_INFORMATIO {get; set;}

        // AN 0001 00833  E139    AVAILABILITY OF NOTAM 'D' SERVICE AT AIRPORT                             Y - YES                             N - NO                           -----------------------------------------------                                  FEDERAL STATUS                          ----------------------------------------------- 
        public string AVAILABILITY_OF_NOTAM__D__SERVICE_AT_AIRPORT_Y_YES_N_NO_FEDERAL_STATUS {get; set;}

        // AN 0007 00834  E157    AIRPORT ACTIVATION DATE (MM/YYYY)                             PROVIDES THE MONTH AND YEAR THAT THE                             FACILITY WAS ADDED TO THE NFDC AIRPORT                             DATABASE.   NOTE: THIS INFORMATION                             IS ONLY AVAILABLE FOR THOSE                             FACILITIES OPENED SINCE 1981.                             (EX. 06/1981) 
        public string AIRPORT_ACTIVATION_DATE__MM_YYYY__PROVIDES_THE_MONTH_AND_YEAR_THAT_THE_FACILITY_WAS_ADDED_TO_THE_NFD {get; set;}

        // AN 0002 00841  N/A     AIRPORT STATUS CODE                             CI - CLOSED INDEFINITELY                             CP - CLOSED PERMANENTLY                             O  - OPERATIONAL 
        public string AIRPORT_STATUS_CODE_CI_CLOSED_INDEFINITELY_CP_CLOSED_PERMANENTLY_O_OPERATIONAL {get; set;}

        // AN 0015 00843  A26     AIRPORT ARFF CERTIFICATION TYPE AND DATE                             FORMAT IS THE CLASS CODE ('I', 'II', 'III',                             OR 'IV') FOLLOWED BY A ONE CHARACTER CODE                             A, B, C, D, E, OR L, FOLLOWED BY A                             ONE CHARACTER CODE S OR U, FOLLOWED                             BY THE MONTH/YEAR OF CERTIFICATION.                             (EX. 'I A S 07/1980'   'I C S 01/1983'                             'II A U 09/1983')                              CODES A,B,C,D,E ARE FOR AIRPORTS                             HAVING A FULL CERTIFICATE UNDER CFR PART                             139, AND IDENTIFIES THE AIRCRAFT RESCUE                             AND FIREFIGHTING INDEX FOR THE AIRPORT.                             CODE L IS FOR AIRPORTS HAVING LIMITED                             CERTIFICATION UNDER CFR PART 139.                              CODE S IS FOR AIRPORTS RECEIVING SCHEDULED                             AIR CARRIER SERVICE FROM CARRIERS                             CERTIFICATED BY THE CIVIL AERONAUTICS BOARD.                             CODE U IS FOR AIRPORTS NOT RECEIVING THIS                             SCHEDULED SERVICE.                              BLANK INDICATES THE FACILITY IS NOT CERTIFICATED. 
        public string AIRPORT_ARFF_CERTIFICATION_TYPE_AND_DATE_FORMAT_IS_THE_CLASS_CODE___I____II____III___OR__IV___FOLLOW {get; set;}

        // AN 0007 00858  A25     NPIAS/FEDERAL AGREEMENTS CODE                             A COMBINATION OF 1 TO 7 CODES THAT                             INDICATE THE TYPE OF FEDERAL AGREEMENTS                             EXISTING AT THE AIRPORT (EX. NGH)                              N - NATIONAL PLAN OF INTEGRATED AIRPORT                                 SYSTEMS (NPIAS)                             B - INSTALLATION OF NAVIGATIONAL FACILITIES                                 ON PRIVATELY OWNED AIRPORTS UNDER F&E PROGRAM                             G - GRANT AGREEMENTS UNDER FAAP/ADAP/AIP                             H - COMPLIANCE WITH ACCESSIBILITY TO THE                                 HANDICAPPED                             P - SURPLUS PROPERTY AGREEMENT UNDER                                 PUBLIC LAW 289                             R - SURPLUS PROPERTY AGREEMENT UNDER                                 REGULATION 16-WAA                             S - CONVEYANCE UNDER SECTION 16, FEDERAL                                 AIRPORT ACT OF 1946 OR SECTION 23,                                 AIRPORT AND AIRWAY DEVELOPMENT ACT OF 1970                             V - ADVANCE PLANNING AGREEMENT UNDER FAAP                             X - OBLIGATIONS ASSUMED BY TRANSFER                             Y - ASSURANCES PURSUANT TO TITLE VI,                                 CIVIL RIGHTS ACT OF 1964                             Z - CONVEYANCE UNDER SECTION 303(C),                                 FEDERAL AVIATION ACT OF 1958                             1 - GRANT AGREEMENT HAS EXPIRED; HOWEVER,                                 AGREEMENT REMAINS IN EFFECT FOR THIS                                 FACILITY AS LONG AS IT IS PUBLIC USE.                             2 - SECTION 303(C) AUTHORITY FROM FAA ACT                                 OF 1958 HAS EXPIRED; HOWEVER, AGREE-                                 MENT REMAINS IN EFFECT FOR THIS                                 FACILITY AS LONG AS IT IS PUBLIC USE.                             3 - AP-4 AGREEMENT UNDER DLAND OR DCLA                                 HAS EXPIRED                          NONE - NO GRANT AGREEMENT EXISTS                          BLANK- NO GRANT AGREEMENT EXISTS 
        public string NPIAS_FEDERAL_AGREEMENTS_CODE_A_COMBINATION_OF_1_TO_7_CODES_THAT_INDICATE_THE_TYPE_OF_FEDERAL_AGREEM {get; set;}

        // AN 0013 00865  E111    AIRPORT AIRSPACE ANALYSIS DETERMINATION                             CONDL  (CONDITIONAL)                             NOT ANALYZED                             NO OBJECTION                             OBJECTIONABLE 
        public string AIRPORT_AIRSPACE_ANALYSIS_DETERMINATION_CONDL__CONDITIONAL__NOT_ANALYZED_NO_OBJECTION_OBJECTIONABLE {get; set;}

        // AN 0001 00878  E79     FACILITY HAS BEEN DESIGNATED BY THE U.S. TREASURY                          AS AN INTERNATIONAL AIRPORT OF ENTRY FOR CUSTOMS                            Y - YES                            N - NO
        public string FACILITY_HAS_BEEN_DESIGNATED_BY_THE_U_S__TREASURY_AS_AN_INTERNATIONAL_AIRPORT_OF_ENTRY_FOR_CUSTOMS_Y {get; set;}

        // AN 0001 00879  E80     FACILITY HAS BEEN DESIGNATED BY THE U.S. TREASURY                          AS A CUSTOMS LANDING RIGHTS AIRPORT                            Y - YES                            N - NO
        public string FACILITY_HAS_BEEN_DESIGNATED_BY_THE_U_S__TREASURY_AS_A_CUSTOMS_LANDING_RIGHTS_AIRPORT_Y_YES_N_NO {get; set;}

        // AN 0001 00880  E115    FACILITY HAS MILITARY/CIVIL JOINT USE AGREEMENT                          THAT ALLOWS CIVIL OPERATIONS AT A MILITARY AIRPORT                            Y - YES                            N - NO
        public string FACILITY_HAS_MILITARY_CIVIL_JOINT_USE_AGREEMENT_THAT_ALLOWS_CIVIL_OPERATIONS_AT_A_MILITARY_AIRPORT_Y {get; set;}

        // AN 0001 00881  E116    AIRPORT HAS ENTERED INTO AN AGREEMENT THAT                          GRANTS LANDING RIGHTS TO THE MILITARY                            Y - YES                            N - NO                           -----------------------------------------------                                  AIRPORT INSPECTION DATA                          ----------------------------------------------- 
        public string AIRPORT_HAS_ENTERED_INTO_AN_AGREEMENT_THAT_GRANTS_LANDING_RIGHTS_TO_THE_MILITARY_Y_YES_N_NO_AIRPORT {get; set;}

        // AN 0002 00882  E155    AIRPORT INSPECTION METHOD                             F - FEDERAL                             S - STATE                             C - CONTRACTOR                             1 - 5010-1 PUBLIC USE MAILOUT PROGRAM                             2 - 5010-2 PRIVATE USE MAILOUT PROGRAM
        public string AIRPORT_INSPECTION_METHOD_F_FEDERAL_S_STATE_C_CONTRACTOR_1_5010_1_PUBLIC_USE_MAILOUT_PROGRAM_2_5010 {get; set;}

        // AN 0001 00884  A111    AGENCY/GROUP PERFORMING PHYSICAL INSPECTION                             F - FAA AIRPORTS FIELD PERSONNEL                             S - STATE AERONAUTICAL PERSONNEL                             C - PRIVATE CONTRACT PERSONNEL                             N - OWNER
        public string AGENCY_GROUP_PERFORMING_PHYSICAL_INSPECTION_F_FAA_AIRPORTS_FIELD_PERSONNEL_S_STATE_AERONAUTICAL_PERS {get; set;}

        // AN 0008 00885  A112    LAST PHYSICAL INSPECTION DATE (MMDDYYYY)
        public string LAST_PHYSICAL_INSPECTION_DATE__MMDDYYYY {get; set;}

        // AN 0008 00893  A113    LAST DATE INFORMATION REQUEST WAS COMPLETED                          BY FACILITY OWNER OR MANAGER  (MMDDYYYY)                           -----------------------------------------------                                  AIRPORT SERVICES                          ----------------------------------------------- 
        public string LAST_DATE_INFORMATION_REQUEST_WAS_COMPLETED_BY_FACILITY_OWNER_OR_MANAGER__MMDDYYYY__AIRPORT_SERVICES {get; set;}

        // AN 0040 00901  A70     FUEL TYPES AVAILABLE FOR PUBLIC USE AT THE                          AIRPORT. THERE CAN BE UP TO 8 OCCURENCES                          OF A FIXED 5 CHARACTER FIELD.                          (EX. 80___100__100LL115__)                           80        Grade 80 gasoline (Red)                                   100       Grade 100 gasoline (Green)                                         100LL     100LL gasoline (low lead) (Blue)                                                     115       Grade 115 gasoline (115/145 military                                         specification) (Purple)                                      A         Jet A, Kerosene, without FS�II*,                                         FP** minus 40� C.                                    A+        Jet A, Kerosene, with FS�II*,                                         FP** minus 40�C.                                               A++       Jet A, Kerosene, with FS�II*, CI/LI#,                                         SDA##, FP** minus 40�C.                                      A++10     (A++100) Jet A, Kerosene, with FS�II*,                                         CI/LI#, SDA##, FP** minus 40�C, with                                         +100 fuel additive that improves                                         thermal stability characteristics of                                         kerosene jet fuels.                                      A1        Jet A�1, Kerosene, without FS�II*,                                         FP** minus 47�C.                                          A1+       Jet A�1, Kerosene with FS�II*,                                         FP** minus 47� C.                          B         Jet B, Wide�cut, turbine fuel                                         without FS�II*, FP** minus 50� C.                          B+        Jet B, Wide�cut, turbine fuel                                         with FS�II*, FP** minus 50� C.                          J4        (JP4)(JP�4 military specification)                                         FP** minus 58� C.                          J5        (JP5)(JP�5 military specification) Kerosene                                         with FS�II, FP** minus 46�C.                          J8        (JP8)(JP�8 military specification) Jet A�1,                                         Kerosene with FS�II*, CI/LI#, SDA##,                                         FP** minus 47�C.                          J8+10     (J8+100) (JP�8 military specification) Jet                                         A�1, Kerosene with FS�II*, CI/LI#,                                         SDA##, FP** minus 47�C, with +100 fuel                                         additive that improves thermal                                         stability characteristics of kerosene                                         jet fuels.                           J         (Jet Fuel Type Unknown)                           MOGAS     Automobile gasoline which is to be used                                         as aircraft fuel.                           UL91      Unleaded Grade 91 gasoline                           UL94      Unleaded Grade 94 gasoline                           *(Fuel System Icing Inhibitor)                           **(Freeze Point)                           # (Corrosion Inhibitors/Lubricity Improvers)                           ## (Static Dissipator Additive)                              
        public string FUEL_TYPES_AVAILABLE_FOR_PUBLIC_USE_AT_THE_AIRPORT__THERE_CAN_BE_UP_TO_8_OCCURENCES_OF_A_FIXED_5_CHA {get; set;}

        // AN 0005 00941  A71     AIRFRAME REPAIR SERVICE AVAILABILITY/TYPE                             MAJOR                             MINOR                             NONE
        public string AIRFRAME_REPAIR_SERVICE_AVAILABILITY_TYPE_MAJOR_MINOR_NONE {get; set;}

        // AN 0005 00946  A72     POWER PLANT (ENGINE) REPAIR AVAILABILITY/TYPE                             MAJOR                             MINOR                             NONE
        public string POWER_PLANT__ENGINE__REPAIR_AVAILABILITY_TYPE_MAJOR_MINOR_NONE {get; set;}

        // AN 0008 00951  A73     TYPE OF BOTTLED OXYGEN AVAILABLE (VALUE REPRESENTS                          HIGH AND/OR LOW PRESSURE REPLACEMENT BOTTLE)                             HIGH                             LOW                             HIGH/LOW                             NONE
        public string TYPE_OF_BOTTLED_OXYGEN_AVAILABLE__VALUE_REPRESENTS_HIGH_AND_OR_LOW_PRESSURE_REPLACEMENT_BOTTLE__HIGH {get; set;}

        // AN 0008 00959  A74     TYPE OF BULK OXYGEN AVAILABLE (VALUE REPRESENTS                          HIGH AND/OR LOW PRESSURE CYLINDERS)                             HIGH                             LOW                             HIGH/LOW                             NONE                           -----------------------------------------------                                  AIRPORT FACILITIES                          ----------------------------------------------- 
        public string TYPE_OF_BULK_OXYGEN_AVAILABLE__VALUE_REPRESENTS_HIGH_AND_OR_LOW_PRESSURE_CYLINDERS__HIGH_LOW_HIGH_LO {get; set;}

        // AN 0007 00967  A81     AIRPORT LIGHTING SCHEDULE                             VALUE IS THE BEGINNING-ENDING TIMES (LOCAL TIME)                             THAT THE STANDARD AIRPORT LIGHTS ARE OPERATED.                             VALUE CAN BE "SS-SR" (INDICATING SUNSET-SUNRISE),                             BLANK, OR "SEE RMK", INDICATING THAT THE DETAILS                             ARE IN A FACILITY REMARK DATA ENTRY.
        public string AIRPORT_LIGHTING_SCHEDULE_VALUE_IS_THE_BEGINNING_ENDING_TIMES__LOCAL_TIME__THAT_THE_STANDARD_AIRPORT {get; set;}

        // AN 0007 00974  A81     BEACON LIGHTING SCHEDULE                             VALUE IS THE BEGINNING-ENDING TIMES (LOCAL TIME)                             THAT THE ROTATING AIRPORT BEACON LIGHT IS OPERATED.                             VALUE CAN BE "SS-SR" (INDICATING SUNSET-SUNRISE),                             BLANK, OR "SEE RMK", INDICATING THAT THE DETAILS                             ARE IN A FACILITY REMARK DATA ENTRY.
        public string BEACON_LIGHTING_SCHEDULE_VALUE_IS_THE_BEGINNING_ENDING_TIMES__LOCAL_TIME__THAT_THE_ROTATING_AIRPORT {get; set;}

        // AN 0001 00981  A85     AIR TRAFFIC CONTROL TOWER LOCATED ON AIRPORT                             Y - YES                             N - NO
        public string AIR_TRAFFIC_CONTROL_TOWER_LOCATED_ON_AIRPORT_Y_YES_N_NO {get; set;}

        // AN 0007 00982  A82     UNICOM FREQUENCY AVAILABLE AT THE AIRPORT
        public string UNICOM_FREQUENCY_AVAILABLE_AT_THE_AIRPORT {get; set;}

        // AN 0007 00989  E100    COMMON TRAFFIC ADVISORY FREQUENCY (CTAF)                             (EX. 122.800)
        public string COMMON_TRAFFIC_ADVISORY_FREQUENCY__CTAF {get; set;}

        // AN 0004 00996  A84     SEGMENTED CIRCLE AIRPORT MARKER SYSTEM ON THE AIRPORT                             Y - YES                             N - NO                             NONE                             Y-L - YES, LIGHTED
        public string SEGMENTED_CIRCLE_AIRPORT_MARKER_SYSTEM_ON_THE_AIRPORT_Y_YES_N_NO_NONE_Y_L_YES__LIGHTED {get; set;}

        // AN 0003 01000  A80     LENS COLOR OF OPERABLE BEACON LOCATED ON THE AIRPORT                             CG    CLEAR-GREEN (LIGHTED LAND AIRPORT)                             CY    CLEAR-YELLOW (LIGHTED SEAPLANE BASE)                             CGY   CLEAR-GREEN-YELLOW (HELIPORT)                             SCG   SPLIT-CLEAR-GREEN (LIGHTED MILITARY AIRPORT)                             C     CLEAR (UNLIGHTED LAND AIRPORT)                             Y     YELLOW (UNLIGHTED SEAPLANE BASE)                             G     GREEN  (LIGHTED LAND AIRPORT)                             N     NONE
        public string LENS_COLOR_OF_OPERABLE_BEACON_LOCATED_ON_THE_AIRPORT_CG_CLEAR_GREEN__LIGHTED_LAND_AIRPORT__CY_CLEAR {get; set;}

        // AN 0001 01003  A24     LANDING FEE CHARGED TO NON-COMMERCIAL USERS OF                          AIRPORT                             Y - YES                             N - NO
        public string LANDING_FEE_CHARGED_TO_NON_COMMERCIAL_USERS_OF_AIRPORT_Y_YES_N_NO {get; set;}

        // AN 0001 01004  NONE    A "Y" IN THIS FIELD INDICATES THAT THE LANDING                          FACILITY IS USED FOR MEDICAL PURPOSES                           -----------------------------------------------                                   BASED AIRCRAFT                          ----------------------------------------------- 
        public string A__Y__IN_THIS_FIELD_INDICATES_THAT_THE_LANDING_FACILITY_IS_USED_FOR_MEDICAL_PURPOSES_BASED_AIRCRAFT {get; set;}

        //  N 0003 01005  A90     SINGLE ENGINE GENERAL AVIATION AIRCRAFT
        public string SINGLE_ENGINE_GENERAL_AVIATION_AIRCRAFT {get; set;}

        //  N 0003 01008  A91     MULTI ENGINE GENERAL AVIATION AIRCRAFT
        public string MULTI_ENGINE_GENERAL_AVIATION_AIRCRAFT {get; set;}

        //  N 0003 01011  A92     JET ENGINE GENERAL AVIATION AIRCRAFT
        public string JET_ENGINE_GENERAL_AVIATION_AIRCRAFT {get; set;}

        //  N 0003 01014  A93     GENERAL AVIATION HELICOPTER
        public string GENERAL_AVIATION_HELICOPTER {get; set;}

        //  N 0003 01017  A94     OPERATIONAL GLIDERS
        public string OPERATIONAL_GLIDERS {get; set;}

        //  N 0003 01020  A95     OPERATIONAL MILITARY AIRCRAFT (INCLUDING HELICOPTERS)
        public string OPERATIONAL_MILITARY_AIRCRAFT__INCLUDING_HELICOPTERS {get; set;}

        //  N 0003 01023  A96     ULTRALIGHT AIRCRAFT                           -----------------------------------------------                                  ANNUAL OPERATIONS                          ----------------------------------------------- 
        public string ULTRALIGHT_AIRCRAFT_ANNUAL_OPERATIONS {get; set;}

        //  N 0006 01026  A100    COMMERCIAL SERVICES                             SCHEDULED OPERATIONS BY CAB-CERTIFICATED CARRIERS                             OR INTRASTATE CARRIERS
        public string COMMERCIAL_SERVICES_SCHEDULED_OPERATIONS_BY_CAB_CERTIFICATED_CARRIERS_OR_INTRASTATE_CARRIERS {get; set;}

        //  N 0006 01032  A101    COMMUTER SERVICES                             SCHEDULED COMMUTER/CARGO CARRIERS
        public string COMMUTER_SERVICES_SCHEDULED_COMMUTER_CARGO_CARRIERS {get; set;}

        //  N 0006 01038  A102    AIR TAXI                             AIR TAXI OPERATORS CARRYING PASSENGERS, MAIL, OR                             MAIL FOR REVENUE
        public string AIR_TAXI_AIR_TAXI_OPERATORS_CARRYING_PASSENGERS__MAIL__OR_MAIL_FOR_REVENUE {get; set;}

        //  N 0006 01044  A103    GENERAL AVIATION LOCAL OPERATIONS                             THOSE OPERATING IN THE LOCAL TRAFFIC PATTERN OR                             WITHIN A 20-MILE RADIUS OF THE AIRPORT
        public string GENERAL_AVIATION_LOCAL_OPERATIONS_THOSE_OPERATING_IN_THE_LOCAL_TRAFFIC_PATTERN_OR_WITHIN_A_20_MILE_R {get; set;}

        //  N 0006 01050  A104    GENERAL AVIATION ITINERANT OPERATIONS                             THOSE GENERAL AVIATION OPERATIONS (EXCLUDING                             COMMUTER OR AIR TAXI) NOT QUALIFYING AS LOCAL
        public string GENERAL_AVIATION_ITINERANT_OPERATIONS_THOSE_GENERAL_AVIATION_OPERATIONS__EXCLUDING_COMMUTER_OR_AIR_T {get; set;}

        //  N 0006 01056  A105    MILITARY AIRCRAFT OPERATIONS
        public string MILITARY_AIRCRAFT_OPERATIONS {get; set;}

        // AN 0010 01062  NONE    12-MONTH ENDING DATE ON WHICH ANNUAL OPERATIONS DATA                          IN ABOVE SIX FIELDS IS BASED (MM/DD/YYYY)                           -----------------------------------------------                                  ADDITIONAL AIRPORT DATA                          ----------------------------------------------- 
        public string _12_MONTH_ENDING_DATE_ON_WHICH_ANNUAL_OPERATIONS_DATA_IN_ABOVE_SIX_FIELDS_IS_BASED__MM_DD_YYYY__ADDI {get; set;}

        // AN 0016 01072  NONE    AIRPORT POSITION SOURCE
        public string AIRPORT_POSITION_SOURCE {get; set;}

        // AN 0010 01088  NONE    AIRPORT POSITION SOURCE DATE (MM/DD/YYYY)
        public string AIRPORT_POSITION_SOURCE_DATE__MM_DD_YYYY {get; set;}

        // AN 0016 01098  NONE    AIRPORT ELEVATION SOURCE
        public string AIRPORT_ELEVATION_SOURCE {get; set;}

        // AN 0010 01114  NONE    AIRPORT ELEVATION SOURCE DATE (MM/DD/YYYY)
        public string AIRPORT_ELEVATION_SOURCE_DATE__MM_DD_YYYY {get; set;}

        // AN 0001 01124  NONE    CONTRACT FUEL AVAILABLE                             Y - YES                             N - NO
        public string CONTRACT_FUEL_AVAILABLE_Y_YES_N_NO {get; set;}

        // AN 0012 01125  A75     TRANSIENT STORAGE FACILITIES                          A COMMA-SEPARATED LIST OF TRANSIENT STORAGE                          FACILITY TYPES AVAILABLE AT THE AIRPORT.  THERE                          ARE THREE POSSIBLE SUCH FACILITIES:                             BUOY - INDICATES BUOY STORAGE FACILITIES                             HGR  - INDICATES HANGAR STORAGE FACILITIES                             TIE  - INDICATES TIE-DOWN STORAGE FACILITIES
        public string TRANSIENT_STORAGE_FACILITIES_A_COMMA_SEPARATED_LIST_OF_TRANSIENT_STORAGE_FACILITY_TYPES_AVAILABLE_AT {get; set;}

        // AN 0071 01137  A76     OTHER AIRPORT SERVICES AVAILABLE                          A COMMA-SEPARATED LIST OF OTHER AIRPORT SERVICES                          AVAILABLE AT THE AIRPORT, WHICH INCLUDE:                             AFRT  - AIR FREIGHT SERVICES                             AGRI  - CROP DUSTING SERVICES                             AMB   - AIR AMBULANCE SERVICES                             AVNCS - AVIONICS                             BCHGR - BEACHING GEAR                             CARGO - CARGO HANDLING SERVICES                             CHTR  - CHARTER SERVICE                             GLD   - GLIDER SERVICE                             INSTR - PILOT INSTRUCTION                             PAJA  - PARACHUTE JUMP ACTIVITY                             RNTL  - AIRCRAFT RENTAL                             SALES - AIRCRAFT SALES                             SURV  - ANNUAL SURVEYING                             TOW   - GLIDER TOWING SERVICES
        public string OTHER_AIRPORT_SERVICES_AVAILABLE_A_COMMA_SEPARATED_LIST_OF_OTHER_AIRPORT_SERVICES_AVAILABLE_AT_THE_A {get; set;}

        // AN 0003 01208  A83     WIND INDICATOR                          SHOWS WHETHER A WIND INDICATOR EXISTS AT THE                          AIRPORT                            N   - NO WIND INDICATOR                            Y   - UNLIGHTED WIND INDICATOR EXISTS                            Y-L - LIGHTED WIND INDICATOR EXISTS
        public string WIND_INDICATOR_SHOWS_WHETHER_A_WIND_INDICATOR_EXISTS_AT_THE_AIRPORT_N_NO_WIND_INDICATOR_Y_UNLIGHTED {get; set;}

        // AN 0007 01211  NONE    ICAO IDENTIFIER                          INTERNATIONAL CODING FOR AIRPORT 
        public string ICAO_IDENTIFIER_INTERNATIONAL_CODING_FOR_AIRPORT {get; set;}

        // AN 0001 01218  NONE    MINIMUM OPERATIONAL NETWORK(MON)
        public string MINIMUM_OPERATIONAL_NETWORK_MON {get; set;}

        // AN 0311 01219  NONE    AIRPORT RECORD FILLER (BLANK)   
        public string AIRPORT_RECORD_FILLER__BLANK {get; set;}

    }
}
