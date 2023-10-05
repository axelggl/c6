using System;
using System.Globalization;

namespace CSharpDiscovery.Quest02
{
    public class FromStringToDateTime_Exercice
    {
        public static DateTime FromStringToDateTime(string dateStr)
        {
            DateTime result = DateTime.ParseExact(dateStr, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            return result;
        }
    }
}