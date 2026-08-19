namespace Second_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // دریافت نام از کاربر
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine().Trim();

            // بررسی خالی نبودن نام
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name Cannot be Empty.");
                Console.Write("Enter Your Name: ");
                name = Console.ReadLine().Trim();
            }

            // دریافت سن از کاربر
            int age;
            while (true)
            {
                Console.Write("Enter Your Age: ");
                string ageText = Console.ReadLine().Trim();

                if (int.TryParse(ageText, out age) && age >= 1 && age <= 130)
                {
                    break;
                }

                Console.WriteLine("Please Enter a Valid Age Between 1 and 130.");
            }

            // نمایش اطلاعات
            Console.WriteLine($"Hello, {name}. You Are {age} Years Old.");
        }
    }
}
