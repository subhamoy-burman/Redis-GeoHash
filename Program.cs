using StackExchange.Redis;

internal class Program
{
    private static void Main(string[] args)
    {
        // Connect to Redis
        ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");
        IDatabase db = redis.GetDatabase();

        // Add geospatial data
        // Add geospatial data
        db.GeoAdd("locations", new GeoEntry(-122.4194, 37.7749, "1")); // Within 2 miles
        db.GeoAdd("locations", new GeoEntry(-122.4190, 37.7740, "2")); // Within 2 miles
        db.GeoAdd("locations", new GeoEntry(-122.4180, 37.7750, "3")); // Within 2 miles
        db.GeoAdd("locations", new GeoEntry(-122.4200, 37.7755, "4")); // Within 2 miles
        db.GeoAdd("locations", new GeoEntry(-122.4210, 37.7760, "5")); // Within 2 miles
        db.GeoAdd("locations", new GeoEntry(-122.4300, 37.7800, "6")); // Outside 2 miles
        db.GeoAdd("locations", new GeoEntry(-122.4100, 37.7700, "7")); // Within 2 miles
        db.GeoAdd("locations", new GeoEntry(-122.4400, 37.7900, "8")); // Outside 2 miles
        db.GeoAdd("locations", new GeoEntry(-122.4150, 37.7720, "9")); // Within 2 miles
        db.GeoAdd("locations", new GeoEntry(-122.4500, 37.8000, "10")); // Outside 2 miles
        db.GeoAdd("locations", new GeoEntry(-122.4250, 37.7780, "11")); // Within 2 miles
        db.GeoAdd("locations", new GeoEntry(-122.4550, 37.8050, "12")); // Outside 2 miles
        db.GeoAdd("locations", new GeoEntry(-122.4205, 37.7752, "13")); // Within 2 miles
        db.GeoAdd("locations", new GeoEntry(-122.4195, 37.7745, "14")); // Within 2 miles
        db.GeoAdd("locations", new GeoEntry(-122.4220, 37.7765, "15")); // Within 2 miles
        db.GeoAdd("locations", new GeoEntry(-122.4600, 37.8100, "16")); // Outside 2 miles
        db.GeoAdd("locations", new GeoEntry(-122.4170, 37.7730, "17")); // Within 2 miles
        db.GeoAdd("locations", new GeoEntry(-122.4350, 38.7850, "18")); // Outside 2 miles
        db.GeoAdd("locations", new GeoEntry(-122.4920, 37.7710, "19")); // Within 2 miles
        db.GeoAdd("locations", new GeoEntry(-123.4450, 39.7950, "20")); // Outside 2 miles

        // Query for nearby businesses within a 2-mile radius
        var results = db.GeoRadius("locations", -122.4190, 37.7750, 2, GeoUnit.Miles);

        // Display results
        foreach (var result in results)
        {
            Console.WriteLine("Following Business ID are within the 2 mile radius");
            Console.WriteLine($"Business ID: {result.Member}");
        }
    }
}