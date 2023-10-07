using System;

namespace CSharpDiscovery.Quest03
{
    public class Campus : PointOfInterest
    {
        public int Capacity { get; set; }

        public Campus(string name, double latitude, double longitude, int capacity)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
            Capacity = capacity;
        }

        public override string ToString()
        {
            return $"{Name} is a campus with a capacity of {Capacity} students";
        }
    }
}
