using System.Runtime.InteropServices;

namespace Third_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 11);

            bool guessedCorrectly = false;

            while (!guessedCorrectly)
            {
                for (int attempt = 1; attempt <= 5; attempt++)
                {
                    Console.Write($"Attempt {attempt}/5 - Guess a number between 1 and 10: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int guess) && guess >= 1 && guess <= 10)
                    {
                        if (guess == secretNumber)
                        {
                            Console.WriteLine("Congratulations! You guessed the correct number!");
                            guessedCorrectly = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Wrong guess!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 1 and 10.");
                    }
                }

                if (!guessedCorrectly)
                {
                    Console.WriteLine($"Sorry! You did not guess the number in 5 attempts.");
                    Console.WriteLine($"The correct number was {secretNumber}.");
                    break;
                }
            }
            Console.ReadKey();
        }
     }
 }