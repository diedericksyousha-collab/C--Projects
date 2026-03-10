using System;

namespace  LoginProgram
{
    class LoginPage
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
                UserInterface.Admin();
            }

            else if (userName == "Customer01" && password == "12345678")
            {
                UserInterface.Customer();
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Incorrect details entered, now closing application");
            }
        }
    }

    class UserInterface
    {
        public static void Admin()
        {
            Console.Clear();
            Console.WriteLine("DashBoard: ");
            Console.WriteLine("\n1. Analytics ");
            Console.WriteLine("\n2. Customer Details ");
            Console.WriteLine("\n3. Stock Details ");
            Console.WriteLine("\n4. Employees ");
        }

        public static void Customer()
        {
            Console.Clear();
            Console.WriteLine("Account: ");
            Console.WriteLine("\n1. Cart ");
            Console.WriteLine("\n2. Items ");
            Console.WriteLine("\n3. Settings ");
            Console.WriteLine("\n4. Payment Details ");
        }
    }
}
