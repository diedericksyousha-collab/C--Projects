using System;

namespace Program
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Welcome to the calculator, please enter your first digit: ");
            int x = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Now enter your second digit: ");
            int y = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Now choose your sign: *, /, - or +");
            char sign = Console.ReadLine()[0];

            if(sign == '-')
            {
                Console.WriteLine(x - y);                
            }

            else if(sign == '+')
            {
                Console.WriteLine(x + y);
            }

            else if(sign == '/')
            {
                Console.WriteLine(x / y);
            }

            else if(sign == '*')
            {
                Console.WriteLine(x * y);
            }
        }
    }
}