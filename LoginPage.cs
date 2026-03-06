using System;

namespace  LoginProgram
{
    class LoginProgram
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Enter your username: ");
            string userName = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();

            if (userName == "Admin123" && password == "admin123")
            {
                Console.Clear();
                Console.WriteLine("DashBoard: ");
                Console.WriteLine("\n1. Analytics ");
                Console.WriteLine("\n2. Customer Details ");
                Console.WriteLine("\n3. Stock Details ");
                Console.WriteLine("\n4. Employees ");
            }

            else if (userName == "Customer01" && password == "12345678")
            {
                Console.Clear();
                Console.WriteLine("Account: ");
                Console.WriteLine("\n1. Cart ");
                Console.WriteLine("\n2. Items ");
                Console.WriteLine("\n3. Settings ");
                Console.WriteLine("\n4. Payment Details ");
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Incorrect details entered, now closing application");
            }
        }
    }
}