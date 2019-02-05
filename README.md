Turn the FAA NASR subscription data into a csv of your choosing.  

To run:

1) Download the latest NASR subscription [here](https://www.faa.gov/air_traffic/flight_info/aeronav/aero_data/NASR_Subscription/)
2) Extract the files
3) Copy `APT.txt` into the `Data` directory
4) Adjust the columns if you'd like
5) Run it
6) Output is placed in `Data/Output.txt`

If the column format changes do the following
1) Add the new `apt_rf.txt` to the `Data` directory
2) Pass `saveModel: true` into `PopulateColumnsAsync` like so: `PopulateColumnsAsync(saveModel: true)`
3) Run the program at least through `PopulateColumnsAsync`, this will read the new column data and save the `Models/Airport.cs` file.
4) With the new Model, run the program again and hope it works!
