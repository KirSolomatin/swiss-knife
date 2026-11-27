using System;
using System.Collections.Generic;
using System.Text;

namespace SwissKnife.Conversion
{
    internal class BinaryDecimal
    {
        public static void Run()
        {
            //Empty variable to store the result
            double result = 0;

            Console.Write("Nombre binaire : ");

            //Variable stores user's number
            int number;

            //We check if user's number is a number
            bool numberIsInt = int.TryParse(Console.ReadLine(), out number);
            //Variable that check if user's number is binary
            bool numberIsBinary = true;

            if (numberIsInt && numberIsBinary)
            {
                //We multiply each digit of the binary number by the corresponding power of two
                for (int i = 0; i < Convert.ToString(number).Length; i++)
                {
                    int digit = Convert.ToString(number)[i] - 48;
                    //Check if digit of number is binary
                    if (digit == 1 || digit == 0)
                    {
                        result += digit * Math.Pow(2, Convert.ToString(number).Length - 1 -i);
                    }
                    else
                    {
                        numberIsBinary = false;
                        break;
                    }
                }
                if(numberIsBinary) Console.WriteLine($"Résultat : {result}");
            }

            if(!numberIsBinary)
            {
                Console.WriteLine("Ce n'est pas un nombre binaire");
            }
        }
    }
}
