using System;
using System.Collections.Generic;
using System.Text;

namespace Isen.Cs.Library.Lessons
{
    public class C_Arrays
    {
        public static void StaticRunner()
        {
            new C_Arrays().RunArrays();
        }

        private void RunArrays()
        {
            // Types Valeurs (ValueTypes) et Types référence
            int four = 4;
            Console.WriteLine($"{nameof(four)}={four} (expected : 4)");
            AddOneByValue(four);
            Console.WriteLine($"{nameof(four)}={four} (expected : 4)");
            four = AddOneAsPureMethod(four);
            Console.WriteLine($"{nameof(four)}={four} (expected : 5)");
        }

        public void AddOneByValue(int a)
        {
            a++;
        }

        public int AddOneAsPureMethod(int a)
        {
            return ++a;
        }
    }
}
