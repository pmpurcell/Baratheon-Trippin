using System;

namespace Baratheon_Trippin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ViewMenu();
                string answer = Console.ReadLine();
            while (answer != null)
            {

                switch (answer)
                {
                    case "1":
                        Console.WriteLine("You pressed 1 -- Enter District Sales");
                        ViewMenu();
                        answer = Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("You pressed 2 -- Generate District Report");
                        ViewMenu();
                        answer = Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("You pressed 3 -- Add New Employee");
                        ViewMenu();
                        answer = Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("You pressed 4 -- Add a Store/District");
                        ViewMenu();
                        answer = Console.ReadLine();
                        break;
                    case "5":
                        System.Environment.Exit(0);
                        break;
                }
            }
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
    }
    }
