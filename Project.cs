using System;

namespace program
{
    class program
    {
        static void Main(string [] args)
        {
            bool isWorking = true;

            while (isWorking)
            {
                Console.WriteLine("Enter password: ");
                string password = Console.ReadLine();

                if (password == "admin123")
                {
                    Console.WriteLine("Welcome");
                    {
                        Console.WriteLine("Opening main menu...");
                    }
                    isWorking = false;
                }

                else
                {
                    Console.WriteLine("Access Denied");
                    isWorking = true;
                }
            }
        }
    }
}