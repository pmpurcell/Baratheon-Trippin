using System;
using Baratheon_Trippin.Models;

namespace Baratheon_Trippin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataStore = new DataStore();
            var sales = new Sales();
            var district = new District();
            ViewMenu();
            string answer = Console.ReadLine();
            string answerTwo;
            while (answer != null)
            {

                switch (answer)
                {
                    case "1":
                        Console.WriteLine("You pressed 1 -- Enter District Sales");
                        sales.EnterSales();
                        break;
                    case "2":
                        Console.WriteLine("You pressed 2 -- Generate District Report");
                        break;
                    case "3":
                        Console.WriteLine("You pressed 3 -- Add New Employee");
                        ViewEmployeeMenu(dataStore);
                        break;
                    case "4":
                        Console.WriteLine("You pressed  -- Add New District/Store");
                        ViewSubMenu();
                        answerTwo = Console.ReadLine();
                        while (answerTwo != null)
                        {

                        switch (answerTwo)
                        {
                            case "1":
                                    Console.Clear();
                                    Console.WriteLine("You pressed 1 -- Add a District");
                                    district.DistrictMenuPrint();
                                    answerTwo = null;
                                break;
                            case "2":
                                    Console.Clear();
                                    Console.WriteLine("You pressed 2 -- Add a Store");                                    
                                    CreateNewStore(district);
                                    answerTwo = null;
                                    break;
                            case "3":
                                answerTwo = null;
                                break;
                        }
                        }
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

        private static void ViewSubMenu()
        {
            Console.WriteLine(@"Which would you like to add?
___________________________
Select your option:
1. Add New District
2. Add New Store
3. Exit to Main Menu
___________________________");
        }

            public static Store CreateNewStore(District district)
            {
            Console.Clear();
            if (district.Districts == null)
            {

                Console.WriteLine("Please input district first.");
                return null;

            }
            else
            {
                
                var question1 = "Enter New Store Number:";
                Console.WriteLine(question1);
                var storeNum = Console.ReadLine();
                var parsedStoreNum = int.Parse(storeNum);
                Console.WriteLine("Please Type District name you wish to add this store too");
                district.PrintCurrentDistricts();
                var districtName = Console.ReadLine();
                var gasYearly = 0;
                var gasQtr = 0;
                var retailYearly = 0;
                var retailQtr = 0;

                var newStore = new Store(parsedStoreNum, gasYearly, gasQtr, retailYearly, retailQtr);
                district.AddStoreToDistrict(districtName, newStore);
                Console.WriteLine($"You have added store # {newStore.StoreNum}");
                district.PrintDistrictDetails();

                return newStore;
            }

        }
        }
    }
