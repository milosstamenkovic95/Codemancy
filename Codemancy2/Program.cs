using System;

namespace Codemancy2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Please enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (IsPrime(number))
            {
                Console.WriteLine("Number is prime");
            }
            else
            {
                Console.WriteLine("Number is not prime");
            }
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
