using System.Collections.Generic;

public static class Categories
{
    public static Dictionary<string, string[]> Rules = new()
    {
        {
            "Food",
            new[]
            {
                "Cafe",
                "Restaurant",
                "Market"
            }
        },

        {
            "Transport",
            new[]
            {
                "Taxi",
                "Bus",
                "Metro"
            }
        },

        {
            "Shopping",
            new[]
            {
                "Store",
                "Mall"
            }
        },

        {
            "Utilities",
            new[]
            {
                "Electricity",
                "Water"
            }
        }
    };
}
