using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    internal class WordPrinter
    {
        // Method to print out the word as user guesses the correct letters in the secret word.
        internal static int PrintWord(List<char> guessedLetters, String randomWord)
        {
            int counter = 0; // Simple counter
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
                counter++;
            }
            return correctLetters;
        }
    }
}
