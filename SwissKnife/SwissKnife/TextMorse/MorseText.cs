using System;
using System.Collections.Generic;
using System.Text;

namespace SwissKnife.TextMorse
{
    internal class MorseText
    {
        public static void Run()
        {
            Console.WriteLine("=== Morse → Texte ===");
            Console.WriteLine("Morse (. - espace /) :");

            //Variable stores user's phrase, I add a space at the end of the phrase so that the last letter is also processed by the loop
            string phrase = Console.ReadLine() + " ";
            //Empty variable to store phrase after translation
            string phraseInText = "";
            //In Morse code, a single letter can consist of several characters; this variable will store the characters that make up a single letter.
            string oneLetter = "";

            //For each symbol in user's phrase
            foreach (char symbol in phrase)
            {
                //If the symbole is a space, then the word has ended
                if (Convert.ToString(symbol) == " ")
                {
                    //Try to find every symbol of user phrase in dictionary, convert to the text and add to the phraseInText, which will be displayed
                    try
                    {
                        phraseInText += TextMorseDictionary.TextMorse.FirstOrDefault(x => x.Value == oneLetter).Key;
                        oneLetter = "";
                    }
                    //Throw an error if the dictionary do not contain a symbol
                    catch
                    {
                        throw new Exception("Veuillez saisir une valeur correcte");
                    }
                }

                //If symbol is . or -
                else
                {
                    oneLetter += symbol;
                }
            }

            Console.WriteLine("Résultat en Morse :");
            Console.WriteLine(phraseInText);
        }
    }
}
