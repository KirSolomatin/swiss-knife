using System;
using System.Collections.Generic;
using System.Text;

namespace SwissKnife.Conversion
{
    public static class DecimalHex
    {
        public static void Run()
        {
            //Empty variable to store phrase after translation
            string reversedResult = "";

            Console.Write("Nombre décimal : ");

            //Variable stores user's phrase
            int number;
            //Check if variable is int
            bool numberIsInt = int.TryParse(Console.ReadLine(), out number);

            if (numberIsInt)
            {
                while (number > 15)
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
            else
            {
                Console.WriteLine("Votre nombre ne doit pas contenir les lettres");
            }
        }
    }
}
