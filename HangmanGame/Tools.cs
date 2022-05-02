using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    internal class Tools
    {

        internal static string RandomWordGenerator()
        {
            List<string> wordList = new List<string>();
            wordList.Add("whale");
            wordList.Add("panther");
            wordList.Add("tiger");
            wordList.Add("giraffe");
            wordList.Add("penguin");
            wordList.Add("bear");
            wordList.Add("snake");
            wordList.Add("poodle");
            wordList.Add("alligator");
            Random random = new Random();
            int index = random.Next(wordList.Count);
            string randomWord = wordList[index];

            return randomWord;
        }


        // Method to print out the word as user guesses the correct letters in the secret word.
        internal static int PrintWord(List<char> guessedLetters, string randomWord)
        {
            int correctLetters = 0;  // Counter for correct guessed letters

            foreach (char letter in randomWord)
            {
                if (guessedLetters.Contains(letter))
                {
                    Console.Write($"{letter} ");
                    correctLetters++;
                }
                else
                {
                    Console.Write("_ ");
                }
            }
            return correctLetters;
        }
    }
}
