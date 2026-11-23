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
            string reversedResult = "";

            Console.Write("Nombre décimal : ");

            //Variable stores user's phrase
            int number;

            bool numberIsInt = int.TryParse(Console.ReadLine(), out number);

            while (number > 1)
            {
                reversedResult += number % 2;

                number = number / 2;
            }

            reversedResult += number;

            string finalResult = "";

            for (int i = reversedResult.Length - 1; i >= 0; i--)
            {
                finalResult += reversedResult[i];
            }

            Console.WriteLine($"Résultat : {finalResult}");
        }
    }
}
