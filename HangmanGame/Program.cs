namespace HangmanGame
{
    class Program
    {

        static void Main(string[] args)
        {
            Graphics.HangmanPrinter(7);
            string randomWord = Tools.RandomWordGenerator();

            for (int i = 0; i < randomWord.Length; i++)
            {
                Console.Write("_ ");
            }

            int lenghtOfSecretWord = randomWord.Length;
            int incorrectGuesses = 0; // ++ later in code
            List<char> currentLettersGuessed = new List<char>();
            int currentLettersRight = 0;

            while (incorrectGuesses != 7 && currentLettersRight != lenghtOfSecretWord)
            {
                Graphics.WelcomeTextPrinter();

                Console.Write($"\n\nLetters Guessed:");
                foreach (char letter in currentLettersGuessed)
                {
                    Console.Write(char.ToUpper(letter) + " ");
                }

                // User input
                Console.Write("\n\nGuess a letter: ");
                char userInputGuess = Console.ReadKey().KeyChar;

                Console.Clear();

                // Check if letter has already been guessed
                if (currentLettersGuessed.Contains(userInputGuess))
                {
                    Graphics.HangmanPrinter(incorrectGuesses);
                    currentLettersRight = Tools.PrintWord(currentLettersGuessed, randomWord);
                    Console.WriteLine("     ERROR! Unable to guess the same letter twice");
                }

                else
                {
                    // Check if letter is in word
                    bool rightGuess = false;
                    for (int i = 0; i < randomWord.Length; i++)
                    {
                        if (userInputGuess == randomWord[i])
                        {
                            rightGuess = true;
                        }
                    }

                    // If true
                    if (rightGuess == true)
                    {
                        currentLettersGuessed.Add(userInputGuess);
                    }

                    // If rightGuess is not true, add 1 to incorrect guesses variable
                    else
                    {
                        incorrectGuesses++;
                    }
                    Graphics.HangmanPrinter(incorrectGuesses);
                    currentLettersRight = Tools.PrintWord(currentLettersGuessed, randomWord);

                    // Losing output
                    if (incorrectGuesses == 7)
                    {
                        Console.WriteLine($"\n\nNo lives left! Game over!\nThe correct word was {randomWord} - Better luck next time!");
                    }

                    // Shows how many lives left
                    else if (incorrectGuesses < 7)
                    {
                        int numberOfGuessesLeft = 7 - incorrectGuesses;
                        Console.Write($"\nLives left:  { numberOfGuessesLeft}");
                    }

                    // Victory output
                    if (currentLettersRight == lenghtOfSecretWord)
                    {
                        Console.WriteLine("\n\nCONGRATULATIONS! You win!");
                    }
                }
            }
            Console.WriteLine("\nThanks for playing!");
        }
    }
}