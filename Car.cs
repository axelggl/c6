namespace CSharpDiscovery.Quest04
{
    public class Car : Vehicule
    {
        public string Model {get; set;}

        public Car() : base()
        {
            Model = "Unknown";
        }

        public Car (string Model, string Brand, string Color, int CurrentSpeed = 0) : base(Brand, Color, CurrentSpeed)
        {
            this.Model = Model;
        }

        public override string ToString()
        {
            return $"{Color} {Brand} {Model}";
        }
    }
}