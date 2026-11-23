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

            Console.Write("Votre choix: ");
            //Variable stores user's phrase
            int choice;
            //Empty variable to store phrase after translation

            bool choiceIsValide = int.TryParse(Console.ReadLine(), out choice);

            if (choice > 0 && choice < 8)
            {
                switch (choice)
                {
                    case 1:
                        DecimalBinary.Run();
                        break;
                }
            }
        }
    }
}
