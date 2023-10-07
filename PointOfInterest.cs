using System;

namespace CSharpDiscovery.Quest03
{
    public class PointOfInterest
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Name { get; set; }

        public static string GoogleMapsUrlTemplate { get; } = "https://www.google.com/maps/place/{0}/@{1},{2},15z/";

        public PointOfInterest()
        {
            Name = "Bordeaux Ynov Campus";
            Latitude = 44.854186;
            Longitude = -0.5663056;
        }

        public PointOfInterest(string name, double latitude, double longitude)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
        }

        public string GetGoogleMapsUrl()
        {
            string nameFormatted = Name.Replace(" ", "+");
            return string.Format(GoogleMapsUrlTemplate, nameFormatted, Latitude, Longitude);
        }

        public override string ToString()
        {
            return $"{Name} (Lat={Latitude}, Long={Longitude})";
        }

        public int GetDistance(PointOfInterest other)
        {
            const double EarthRadiusKm = 6371.0;

            double lat1 = Latitude * (Math.PI / 180.0);
            double lon1 = Longitude * (Math.PI / 180.0);
            double lat2 = other.Latitude * (Math.PI / 180.0);
            double lon2 = other.Longitude * (Math.PI / 180.0);

            double dlat = lat2 - lat1;
            double dlon = lon2 - lon1;

            double a = Math.Pow(Math.Sin(dlat / 2), 2) + Math.Cos(lat1) * Math.Cos(lat2) * Math.Pow(Math.Sin(dlon / 2), 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return (int)Math.Round(EarthRadiusKm * c);
        }

        public static int GetDistance(PointOfInterest p1, PointOfInterest p2)
        {
            return p1.GetDistance(p2);
        }
    }
}