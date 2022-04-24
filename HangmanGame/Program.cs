namespace HangmanGame
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("   +-----+\n   |     |\n   O     |\n  /|\\    |\n  / \\    |\n         |\n         |\n         |\n===========");

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


            foreach (char letter in randomWord)
            {
                
                Console.Write("_ ");
            }

            int lenghtOfSecretWord = randomWord.Length;
            int incorrectGuesses = 0;
            List<char> currentLettersGuessed = new List<char>();
            int currentLettersRight = 0;

            while (incorrectGuesses != 7 && currentLettersRight != lenghtOfSecretWord)
            {
                
                Console.SetCursorPosition(18, 1); Console.WriteLine("Welcome to Hangman");
                Console.SetCursorPosition(18, 3); Console.WriteLine("Rules:");
                Console.SetCursorPosition(18, 4); Console.WriteLine("You can only type in letters.");
                Console.SetCursorPosition(18, 5); Console.WriteLine("You can only guess one letter at a time.");
                Console.SetCursorPosition(18, 6); Console.WriteLine("You have 7 lives. Lose them all and you lose!\n");
                
                Console.Write($"\n\nLetters Guessed:");
                foreach  (char letter in currentLettersGuessed)
                {
                    Console.Write(char.ToUpper(letter) + " "); ;
                }

                // User input
                Console.Write("\n\nGuess a letter: ");
                char letterGuessed = Console.ReadLine()[0];

                Console.Clear();
                // Check if letter has already been guessed
                if (currentLettersGuessed.Contains(letterGuessed))
                {
                    
                    HangmanDrawing.PrintHangman(incorrectGuesses);
                    currentLettersRight = WordPrinter.PrintWord(currentLettersGuessed, randomWord);
 
                    
                    Console.WriteLine("     ERROR! Unable to guess the same letter twice");
                }

                else
                {
                    // Check if letter is in word
                    bool rightGuess = false;
                    for (int i = 0; i < randomWord.Length; i++)
                    {
                        if (letterGuessed == randomWord[i])
                        {
                            rightGuess = true;
                        }
                    }


                    if (rightGuess)
                    {
                        HangmanDrawing.PrintHangman(incorrectGuesses);
                        currentLettersGuessed.Add(letterGuessed);
                        currentLettersRight = WordPrinter.PrintWord(currentLettersGuessed, randomWord);
                        Console.WriteLine();
                        
                    }
                    else
                    {
                        incorrectGuesses++;
                        currentLettersGuessed.Add(letterGuessed);
                        HangmanDrawing.PrintHangman(incorrectGuesses);
                        currentLettersRight = WordPrinter.PrintWord(currentLettersGuessed, randomWord);
                        Console.WriteLine();
                        

                    }

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
                    if (incorrectGuesses != 7 && currentLettersRight == lenghtOfSecretWord) 
                        {
                        Console.WriteLine("\nCONGRATULATIONS! You win!");
                        } 

                }
                

            }
            Console.WriteLine("\nThanks for playing!");




        }
    }
}