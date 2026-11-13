using System;
using System.Collections.Generic;
using System.Text;

namespace SwissKnife.TextMorse
{
    internal class TextMorseDictionary
    {
        //a dictionary that stores a letter and its corresponding meaning in Morse code
        public static Dictionary<string, string> TextMorse = new Dictionary<string, string>
        {
            { "a", ".-" }, 
            { "b", "-..." },
            { "c", "-.-." },
            { "d", "-.." },
            { "e", "." },
            { "f", "..-." },
            { "g", "--." },
            { "h", "...." },
            { "i", ".." },
            { "j", ".---" },
            { "k", "-.-" },
            { "l", ".-.." },
            { "m", "--" },
            { "n", "-." },
            { "o", "---" },
            { "p", ".--." },
            { "q", "--.-" },
            { "r", ".-." },
            { "s", "..." },
            { "t", "-" },
            { "u", "..-" },
            { "v", "...-" },
            { "w", ".--" },
            { "x", "-..-" },
            { "y", "-.--" },
            { "z", "--.." },
            { "1", ".----" },
            { "2", "..---" },
            { "3", "...--" },
            { "4", "....-" },
            { "5", "....." },
            { "6", "-...." },
            { "7", "--..." },
            { "8", "---.." },
            { "9", "----." },
            { "0", "-----" },
            { " ", "/" }
        };
    }
}
