namespace CSharpDiscovery.Quest01
{
    public class SetPiValue_Exercice
    {
        public static float SetPiValue(float pi)
        {
            float roundedPi = (float)Math.Round(pi, 5);

            return roundedPi;
        }
    }
}