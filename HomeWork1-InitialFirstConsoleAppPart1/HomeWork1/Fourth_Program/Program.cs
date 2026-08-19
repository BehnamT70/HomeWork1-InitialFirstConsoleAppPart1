namespace Fourth_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "CSharp";
            string userGuess = "";
            int attempts = 0;

            while (userGuess.ToLower() != secretWord.ToLower())
            {
                Console.Write("Guess the secret word: ");
                userGuess = Console.ReadLine();

                attempts++;

                if (userGuess.ToLower() == secretWord.ToLower())
                {
                    Console.WriteLine("Congratulations! You guessed the word correctly.");
                }
                else
                {
                    Console.WriteLine("Wrong guess. Try again.");
                }
            }

            Console.WriteLine($"Total attempts: {attempts}");
            Console.ReadKey();
        }
    }
}
