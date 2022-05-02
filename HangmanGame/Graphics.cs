using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    internal class Graphics
    {
        // Method to print welcome text and rules.
        internal static void WelcomeTextPrinter()
        {
            Console.SetCursorPosition(18, 1); Console.WriteLine("Welcome to Hangman");
            Console.SetCursorPosition(18, 3); Console.WriteLine("Rules:");
            Console.SetCursorPosition(18, 4); Console.WriteLine("You can't type in the same letter twice.");
            Console.SetCursorPosition(18, 6); Console.WriteLine("You have 7 lives. Lose them all and you lose!\n");
        }

        // Method to print the hanging man with each wrong guess of letters.
        internal static void HangmanPrinter(int wrongGuess)
        {
            if (wrongGuess == 0) { Console.WriteLine("   +-----+\n         |\n         |\n         |\n         |\n         |\n         |\n         |\n==========="); }
            else if (wrongGuess == 1) { Console.WriteLine("   +-----+\n   |     |\n         |\n         |\n         |\n         |\n         |\n         |\n==========="); }
            else if (wrongGuess == 2) { Console.WriteLine("   +-----+\n   |     |\n   O     |\n         |\n         |\n         |\n         |\n         |\n==========="); }
            else if (wrongGuess == 3) { Console.WriteLine("   +-----+\n   |     |\n   O     |\n   |     |\n         |\n         |\n         |\n         |\n==========="); }
            else if (wrongGuess == 4) { Console.WriteLine("   +-----+\n   |     |\n   O     |\n  /|     |\n         |\n         |\n         |\n         |\n==========="); }
            else if (wrongGuess == 5) { Console.WriteLine("   +-----+\n   |     |\n   O     |\n  /|\\    |\n         |\n         |\n         |\n         |\n==========="); }
            else if (wrongGuess == 6) { Console.WriteLine("   +-----+\n   |     |\n   O     |\n  /|\\    |\n  /      |\n         |\n         |\n         |\n==========="); }
            else if (wrongGuess == 7) { Console.WriteLine("   +-----+\n   |     |\n   O     |\n  /|\\    |\n  / \\    |\n         |\n         |\n         |\n==========="); }
        }
    }
}
