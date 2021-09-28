using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Count the number of times each character occurs in a string and then print the results to the console.
            Console.WriteLine("Counting Chars App!");
            Console.WriteLine("Please enter a sentence to count: ");
            string sentence = Console.ReadLine();

            // Make the character counts case-insensitive.
            sentence = sentence.ToLower();
            sentence = GetLettersOnly(sentence);

            // Loop through the string one character at a time
            Dictionary<char, int> letters = new Dictionary<char, int>(30);
            foreach (char letter in sentence)
            {
                // does the dictionary have this letter?
                // if not, add (letter, 1)
                if (!letters.ContainsKey(letter))
                {
                    letters.Add(letter, 1);
                }
                else // if yes, add one to that char count
                {
                    letters[letter] += 1;
                }
                // does the dictionary have this letter?
                // if not,
                    // add (letter, 1)
                // if yes,
                    // letter.charName += 1;
            }
          
            foreach (KeyValuePair<char, int> entry in letters){
                Console.WriteLine($"{entry.Key} : {entry.Value}");
            }

            //Store and/or update the count for a given character using an appropriate data structure.

        }
        // Will return a string with only letters (removes all other whitespace and non characters) // Exclude non-alphabetic characters
        public static string GetLettersOnly(string sentence)
        {
            string newSentence = "";
            foreach (char letter in sentence)
            {
                if (Char.IsLetter(letter)) {
                    newSentence += letter;
                }
            }
            return newSentence;
        }
    }
}
