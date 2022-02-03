using Baratheon_Trippin.Models;
using System;

namespace Baratheon_Trippin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataStore = new DataStore();
            ViewMenu();
            string answer = Console.ReadLine();
            while (answer != null)
            {

                switch (answer)
                {
                    case "1":
                        Console.WriteLine("You pressed 1 -- Enter District Sales");
                        ViewMenu();
                        break;
                    case "2":
                        Console.WriteLine("You pressed 2 -- Generate District Report");
                        ViewMenu();
                        break;
                    case "3":
                        Console.WriteLine("You pressed 3 -- Add New Employee");
                        ViewEmployeeMenu(dataStore);
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("You pressed 4 -- Add a Store/District");
                        CreateNewStore();
                        break;
                    case "5":
                        System.Environment.Exit(0);
                        break;
                }
                ViewMenu();
                answer = Console.ReadLine();
            }
        }

        private static void ViewEmployeeMenu(DataStore dataStore)
        {
            Console.WriteLine(@"What is the Employee's title?
0. District Manager
1. Store Manager
2. Assistant Manager
3. Associate");
            var choice = Console.ReadLine();
            var title = (Title)Enum.Parse(typeof(Title), choice);
            Console.WriteLine(@"------------------");
            Console.WriteLine(@"What is the Employee's name?");
            var name = Console.ReadLine();
            Console.WriteLine(@"------------------");
            Console.WriteLine(@"How much did the Employee earn for the company?");
            var sales = Console.ReadLine();

            var employee = new Employee(title, name, sales);
            dataStore.Employees.Add(employee);
            Console.WriteLine($"Added new employee: {employee.Name}");
        }

        private static void ViewMenu()
        {
            Console.Clear();
            Console.WriteLine(@"Baratheon QuickTrip
'Ours is the fury!'
___________________________
Select your option:
1. Enter District Sales
2. Generate District Report
3. Add New Employee
4. Add a Store/District
5. Exit
___________________________");
        }
        private static Store CreateNewStore()
        {
            var question1 = "Enter New Store Number:";
            Console.WriteLine(question1);
            var storeNum = Console.ReadLine();
            var parsedStoreNum = int.Parse(storeNum);

            var gasYearly = 0;
            var gasQtr = 0;
            var retailYearly = 0;
            var retailQtr = 0;

            var newStore = new Store(parsedStoreNum, gasYearly, gasQtr, retailYearly, retailQtr);
            Console.WriteLine($"You have added store # {newStore.StoreNum}");

            returnToMenu();
            return newStore;


            static void returnToMenu()
            {
                Console.WriteLine($"Press any key to return to main menu.");
                ConsoleKeyInfo keyInfo;

                do
                {
                    keyInfo = Console.ReadKey();
                    ViewMenu();
                } while (keyInfo.Key != ConsoleKey.Escape);
            }
        }
    }
}
