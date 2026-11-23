using SwissKnife.Conversion;
using SwissKnife.TextMorse;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace SwissKnife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool active = true;

            //The cycle will repeat until one of the options isn't selected
            while (active)
            {
                Console.WriteLine("=== Couteau Suisse ===");
                Console.WriteLine("1.Texte => Morse"); //Translate from text to morse
                Console.WriteLine("2.Morse => Texte"); //Translate from morse to text
                Console.WriteLine("3.Conversion de bases");
                Console.WriteLine("4. (à venir)");
                Console.WriteLine("0.Quitter");
                Console.Write("Votre choix : ");

                //The variable stores the user's input
                string choice = Console.ReadLine();

                switch(choice)
                {
                    //If user choiced 1 option
                    case "1":
                        TextMorse.TextMorse.Run();
                        active = false;
                        break;
                    case "2":
                        MorseText.Run();
                        active = false;
                        break;
                    case "3":
                        BasicConversion.Rune();
                        active = false;
                        break;
                    default:
                        Console.WriteLine("Choix invalide");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}