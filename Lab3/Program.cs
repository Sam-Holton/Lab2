using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Please enter a number between 1 and 100: ");
                int userEntry = int.Parse(Console.ReadLine());

                if (userEntry % 2 == 1)
                {
                    Console.WriteLine($"{userEntry} Odd");
                }

                if (userEntry % 2 == 0 && userEntry < 25)
                {
                    Console.WriteLine("Even and less than 25");
                }

                if (userEntry > 25 && userEntry < 61 && userEntry % 2 == 0)
                {
                    Console.WriteLine("Even");
                }

                if (userEntry >= 60 && userEntry % 2 == 0)
                {
                    Console.WriteLine($"{userEntry} Even");
                }

                if (userEntry >= 60 && userEntry % 2 == 1)
                {
                    Console.WriteLine($"{userEntry} Odd");
                }

                Console.Write("Continue? (y/n) ");
                char userContinue = Console.ReadLine();

            } while (userContinue == 'y');

        }
    }
}
