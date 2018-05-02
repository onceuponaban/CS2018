using System;

namespace Isen.Cs.Library.Lessons
{
    public class A_Types
    {
        public void PrimitiveTypes()
        {
            // short : entier 16 bits signé
            short s = 12;
            // short et System.Int16 sont synonymes
            Int16 shortMin = short.MinValue;
            short shortMax = short.MaxValue;
            // Concaténation avec +
            Console.WriteLine("short (Int16) range: " + shortMin + " < " + s + " < " + shortMax);
            // String Format (comme en java)
            Console.WriteLine(String.Format("short (Int16) range : {0} < {1} < {2}", shortMin, s, shortMax));
            // Syntaxe $"....{variable}...." : string interpolation (C# 6 et +)
            Console.WriteLine($"short (Int16) range : {shortMin} < {s} < {shortMax}");
        }
    }
}