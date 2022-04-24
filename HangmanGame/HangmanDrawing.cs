using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    internal class HangmanDrawing
    {
        // Method to print the hanging man with each wrong guess of letters.
        internal static void PrintHangman(int wrongGuess)
        {
            if (wrongGuess == 0)
            {
                Console.WriteLine("   +-----+\n         |\n         |\n         |\n         |\n         |\n         |\n         |\n===========");
            }
            else if (wrongGuess == 1)
            {
                Console.WriteLine("   +-----+\n   |     |\n         |\n         |\n         |\n         |\n         |\n         |\n===========");
            }
            else if (wrongGuess == 2)
            {
                Console.WriteLine("   +-----+\n   |     |\n   O     |\n         |\n         |\n         |\n         |\n         |\n===========");
            }
            else if (wrongGuess == 3)
            {
                Console.WriteLine("   +-----+\n   |     |\n   O     |\n   |     |\n         |\n         |\n         |\n         |\n===========");
            }
            else if (wrongGuess == 4)
            {
                Console.WriteLine("   +-----+\n   |     |\n   O     |\n  /|     |\n         |\n         |\n         |\n         |\n===========");
            }
            else if (wrongGuess == 5)
            {
                Console.WriteLine("   +-----+\n   |     |\n   O     |\n  /|\\    |\n         |\n         |\n         |\n         |\n===========");
            }
            else if (wrongGuess == 6)
            {
                Console.WriteLine("   +-----+\n   |     |\n   O     |\n  /|\\    |\n  /      |\n         |\n         |\n         |\n===========");
            }
            else if (wrongGuess == 7)
            {
                Console.WriteLine("   +-----+\n   |     |\n   O     |\n  /|\\    |\n  / \\    |\n         |\n         |\n         |\n===========");
            }
        }
    }
}
