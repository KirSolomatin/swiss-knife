using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SwissKnife.Conversion
{
    public static class BasicConversion
    {
        public static void Rune()
        {
            Console.WriteLine("=== Conversion de bases ===");

            Console.WriteLine("1. Décimal => Binaire");
            Console.WriteLine("2. Binaire => Décimal");
            Console.WriteLine("3. Décimal => Octal");
            Console.WriteLine("4. Octal => Décimal");
            Console.WriteLine("5. Binaire => Octal");
            Console.WriteLine("6. Octal => Binaire");
            Console.WriteLine("7. Décimal => Hexadécimal");
            Console.WriteLine("8. Hexadécimal => Décimal");

            Console.Write("Votre choix: 1");
            //Variable stores user's phrase
            string choice = Console.ReadLine();
            //Empty variable to store phrase after translation
        }
    }
}
