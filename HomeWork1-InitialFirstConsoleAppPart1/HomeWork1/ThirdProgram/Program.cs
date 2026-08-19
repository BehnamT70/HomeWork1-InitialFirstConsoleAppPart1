namespace ThirdProgram
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
                    Console.Write($"Attempt {attempt}/5 - Guess a Number Between 1 and 10: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int guess) && guess >= 1 && guess <= 10)
                    {
                        if (guess == secretNumber)
                        {
                            Console.WriteLine("Congratulations! You Guessed The Correct Number!");
                            guessedCorrectly = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Wrong Guess!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please Enter a Number Between 1 and 10.");
                    }
                }

                if (!guessedCorrectly)
                {
                    Console.WriteLine($"Sorry! You Did Not Guess The Number In 5 Attempts.");
                    Console.WriteLine($"The Correct Number Was {secretNumber}.");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
