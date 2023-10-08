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

        public override void Accelerate(int Speed)
        {
            if (CurrentSpeed + Speed <= 180)
            {
                CurrentSpeed += Speed;
            }
            else
            {
                CurrentSpeed = 180;
            }
        }

        public override void Brake(int BrakePower)
        {
            if (CurrentSpeed - BrakePower >= 0)
            {
                CurrentSpeed -= BrakePower;
            }
            else
            {
                CurrentSpeed = 0;
            }
        }

    }
}