using System;

namespace CSharpDiscovery.Quest03
{
    public class PointOfInterest
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Name { get; set; }

        public static string GoogleMapsUrlTemplate = "https://www.google.com/maps/search/?api=1&query={0},{1}";
    }
}