using System;

namespace CSharpDiscovery.Quest02
{
    public class SecretSanta_Exercice
    {
        public static Dictionary<string,string> SecretSantaDraw(HashSet<string> people)
        {
            List<string> mixedPeople = people.ToList();
            Random rng = new Random();
            
            for (int i = mixedPeople.Count - 1; i > 0; i--)
            {
                int j = rng.Next(0, i + 1);
                string temp = mixedPeople[i];
                mixedPeople[i] = mixedPeople[j];
                mixedPeople[j] = temp;
            }

            Dictionary<string, string> assignments = new Dictionary<string, string>();
            for (int i = 0; i < mixedPeople.Count - 1; i++)
            {
                assignments[mixedPeople[i]] = mixedPeople[i + 1];
            }

            assignments[mixedPeople[^1]] = mixedPeople[0];

            return assignments;
        }
    }
}