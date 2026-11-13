using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SwissKnife.TextMorse
{
    public class TextMorse
    {
        public static void Run()
        {
            Console.WriteLine("=== Texte → Morse ===");
            Console.WriteLine("Texte (lettres A-Z, chiffres) :");

            //Variable stores user's phrase
            string phrase = Console.ReadLine();
            //Empty variable to store phrase after translation
            string phraseInMorse = "";

            //For each symbol in user's phrase
            foreach (char letter in phrase)
            {
                //Try to find every symbol of user phrase in dictionary, convert to the morse and add to the last sentence, which will be displayed
                try
                {
                    phraseInMorse += TextMorseDictionary.TextMorse[Convert.ToString(letter).ToLower()];
                }

                //Throw an error if the dictionary do not contain a symbol
                catch 
                {
                    throw new Exception("Veuillez saisir une lettre ou un chiffre, sans caractères spéciaux");
                }
            }

            Console.WriteLine("Résultat en Morse :");
            Console.WriteLine(phraseInMorse);
        }
    }
}
