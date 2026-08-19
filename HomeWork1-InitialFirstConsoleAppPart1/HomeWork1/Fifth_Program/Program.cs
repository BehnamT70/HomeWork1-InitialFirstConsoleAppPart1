namespace Fifth_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                Console.Write("Enter a positive integer: ");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) &&
                    int.TryParse(input, out n) &&
                    n >= 1)
                {
                    break;
                }

                Console.WriteLine("Invalid input. Please enter a number greater than 0.");
            }

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"The sum of odd numbers from 1 to {n} is: {sum}");
            Console.ReadKey();
        }
    }
}
