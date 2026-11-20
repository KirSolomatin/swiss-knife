using System;
using System.Collections.Generic;
using System.Text;

namespace SwissKnife.Conversion
{
    public static class DecimalBinary
    {
        public static void Run()
        {
            //Empty variable to store phrase after translation
            string result = "";

            Console.Write("Nombre décimal : ");

            //Variable stores user's phrase
            string number;

            bool numberIsInt = int.TryParse(Console.ReadLine(), out result);
        }
    }
}
