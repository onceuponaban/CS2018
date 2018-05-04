using System;
using System.Collections.Generic;
using System.Text;

namespace Isen.Cs.Library.Lessons
{
    public class C_Arrays
    {
        public static void StaticRunner()
        {
            new C_Arrays().RunValuesAndRefs();
        }

        private void RunValuesAndRefs()
        {
            // Types Valeurs (ValueTypes) et Types référence
            int four = 4;
            Console.WriteLine($"{nameof(four)}={four} (expected : 4)");
            AddOneByValue(four);
            Console.WriteLine($"{nameof(four)}={four} (expected : 4)");
            four = AddOneAsPureMethod(four);
            Console.WriteLine($"{nameof(four)}={four} (expected : 5)");
            AddOneByRef(ref four);
            Console.WriteLine($"{nameof(four)}={four} (expected : 6)");
            TryParseInt("42", out var parsed);
            Console.WriteLine($"{nameof(parsed)}={parsed} (expected : 42)");

            // String : passage par valeur ou ref ?
            //      / ! \ string est un type référence mais passé par valeur
            var lowerString = "hello";
            Console.WriteLine($"{nameof(lowerString)}={lowerString} (expected : hello)");
            UpperCaseMyString(lowerString);
            Console.WriteLine($"{nameof(lowerString)}={lowerString} (expected : hello)");
            UpperCaseMyStringByRef(ref lowerString);
            Console.WriteLine($"{nameof(lowerString)}={lowerString} (expected : HELLO)");


        }

        public void UpperCaseMyString(string input) { input.ToUpper(); }
        public void UpperCaseMyStringByRef(ref string input) { input.ToUpper(); }

        // Passage par copie. a ne ressort jamais de la méthode et n'est pas modifiée
        // en dehors du score de la méthode
        public void AddOneByValue(int a) { a++; }
        // C#6 : Expression bdy
        public int AddOneAsPureMethod(int a) => ++a; //return ++a
        // Passage par référence : out
        public void AddOneByRef (ref int a) { a++; }
        // Parser vers result, qui n'est pas init
        // Donc c'est du out et pas du ref
        public bool TryParseInt(string input, out int result)
        {
            try
            {
                result = int.Parse(input);
                return true;
            }

            catch
            {
                result = int.MinValue;
                return false;
            }
        }
    }
}
