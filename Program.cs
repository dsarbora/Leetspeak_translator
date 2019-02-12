using System;
using System.Collections.Generic;

namespace Leetspeak
{
    public class Program
    {
        public static void Main()
        {
            LeetTranslator translator = new LeetTranslator();
            Console.WriteLine("Give me a line and I will translate.");
            string input = Console.ReadLine();
            char[] characters = input.ToCharArray();
            List<char> characterList = new List<char>{};
            
            foreach (char character in characters)
            {
                characterList.Add(character);
            }
            
            for (var i = 0; i<characterList.Count; ++i)
            {
                
                characterList[i]= translator.Translate(characterList[i]);
            }

            char[] leetCharacters = characterList.ToArray();
            string leetString = new string(leetCharacters);
            Console.WriteLine(leetString);


        }
    }
}