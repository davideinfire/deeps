using System.Collections.Generic;

public static class SampleStatement
{
    public static List<Transaction> Load()
    {
        return new()
        {
            new("Cafe Milano",18.40m),
            new("Restaurant Roma",64.00m),
            new("Taxi Ride",19.50m),
            new("Electronics Store",145.99m),
            new("Electricity Bill",42.00m),
            new("Water Service",14.00m),
            new("Local Market",12.00m)
        };
    }
}
