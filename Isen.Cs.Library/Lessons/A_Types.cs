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
            // Liste des primitifs entiers (pages 14 et 15)
            // Toujours préferer la version courte quand elle existe
            // short/Int16
            // ushort/UInt16
            // int/Int32
            // uint/UInt32
            // long/Int64
            // ulong/UInt64

            // Litéraux
            // litéral de stirng
            string myString = "hello"; // Ceci est un littéral
            // Littéraux des entiers
            // Le underscore est autorisé sur les types numériques
            // Pour la lisibilité
            int veryMuch = 123_456_789;
            // Type numériques décimaux
            // Par défaut, un littéral à virgule est un double
            double dbl = 12.3; // 12.3 est un double par défaut
            double dblExplicit = 12.3d;
            float flt = 12.3f; // juste 12.3 ne marcherait pas!
            decimal dec = 12.3m; // pareil, juste 12.3 ne marcherait pas!
            // Cast explicite
            double castDbl = (double)flt;

            // Bits (bool), octets (Bytes)
            bool bTrue = true;
            Boolean bFalse = !bTrue;

            // sbyte : entier signé
            sbyte byteB = 0xB;
            SByte minusByteB = -0xB;
            // Byte : non signé
            byte byteBB = 0xAB;
            Byte byteBB2 = 0xAC;

            
        }
    }
}