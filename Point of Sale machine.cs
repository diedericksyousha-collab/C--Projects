using System;

namespace POSmach
{
    class POSmach
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==================================");
                Console.WriteLine("   Welcome to your inventory");
                Console.WriteLine("==================================");
                Console.WriteLine();
                Console.WriteLine("Press ENTER to go to Inventory");
                Console.WriteLine("Press ESC to Exit");

                var key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Enter)
                {
                    ShowInventory.ShowInventory1();
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid key... Press any key to try again");
                    Console.ReadKey();
                }
            }
        }
    }

    class ShowInventory
    {
        public static void ShowInventory1() // <-- FIXED HERE
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("========= INVENTORY =========");
                Console.WriteLine("1. View Items");
                Console.WriteLine("2. Add Item");
                Console.WriteLine("3. Back to Main Menu");

                var key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.WriteLine("\nViewing items...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.WriteLine("\nAdding item...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        return;

                    default:
                        Console.WriteLine("\nInvalid option");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
