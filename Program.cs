using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRepairManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();

            Console.ReadKey();
        }

        static void WelcomeMessage()
        {
            Console.WriteLine("###########################################################################");
            Console.WriteLine("#                            WELCOME                                      #");
            Console.WriteLine("#                              TO                                         #");
            Console.WriteLine("#               Car Repair Management System (CRMS)                       #");
            Console.WriteLine("###########################################################################");
        }
        static void MainMenu()
        {
            //To clear the previous console
            Console.Clear();

            //calls the welcome message method
            WelcomeMessage();

            //Prints options of Menu 1:
            Console.WriteLine("You are in Main Menu:");
            Console.WriteLine();
            Console.WriteLine("Available Options to proceed : ");
            Console.WriteLine("\tPress 1 to modify vehicles");
            Console.WriteLine("\tPress 2 to modify inventory");
            Console.WriteLine("\tPress 3 to modify repair");
            Console.WriteLine("\tPress 4 to exit program");
            Console.Write("\nPlease choose a command : ");
            //int choice;
            try
            {
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        MenuForVehicles();
                        break;
                    case 2:
                        MenuForInventory();
                        break;
                    case 3:
                        MenuForRepair();
                        break;
                    case 4:
                        ExitProgram();
                        break;
                    default:
                        Console.WriteLine("\nInvalid command! Please type a number between 1 to 4.");
                        Console.Write("Press any key to continue.");
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Invalid input! Please, type a number between 1 to 4. ");
                Console.WriteLine("Press any key to continue!");
            }
            

           
            Console.ReadKey();

            MainMenu();
        }
        static void MenuForVehicles()
        {
            Console.Clear();
            WelcomeMessage();
            Console.WriteLine("You are in : Main Menu > Vehicles option...");
            Console.WriteLine();
            //Prints options of Menu 1:
            Console.WriteLine("Available Options to proceed : ");
            Console.WriteLine("\tPress 1 to list all vehicles");
            Console.WriteLine("\tPress 2 to add a new vehicle");
            Console.WriteLine("\tPress 3 to update vehicle");
            Console.WriteLine("\tPress 4 to delete vehicle");
            Console.WriteLine("\tPress 5 to return to main menu");
            Console.Write("\nPlease choose a command : ");

            try
            {
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Method to call : List of all vehicles!");
                        break;
                    case 2:
                        Console.WriteLine("Method to call : Add new Vehicle!");
                        
                        break;
                    case 3:
                        Console.WriteLine("Method to call : Update new Vehicle!");
                        break;
                    case 4:
                        Console.WriteLine("Method to call : Delete new Vehicle!");
                        break;
                    case 5:
                        MainMenu();
                        break;
                    default:
                        Console.WriteLine("\nInvalid command! Please type a number between 1 to 5.");
                        Console.Write("Press any key to continue.");
                        break;
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Invalid input! Please type a number between 1 to 5 : ");
                Console.WriteLine("Press any key to continue!");
                //Console.log(e);
            }
            Console.ReadLine();
            MenuForVehicles();

        }
        static void MenuForInventory()
        {
            Console.Clear();
            WelcomeMessage();
            Console.WriteLine("You are in : Main Menu > Inventory option...");
            Console.WriteLine();
            //Prints options of Menu 1:
            Console.WriteLine("Available Options to proceed : ");
            Console.WriteLine("\tPress 1 to view inventory for a vehicle");
            Console.WriteLine("\tPress 2 to add a new inventory");
            Console.WriteLine("\tPress 3 to update inventory");
            Console.WriteLine("\tPress 4 to delete inventory");
            Console.WriteLine("\tPress 5 to return to main menu");
            Console.Write("\nPlease choose a command : ");

            try
            {
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Method to call : List of all inventory!");
                        break;
                    case 2:
                        Console.WriteLine("Method to call : Add new inventory!");

                        break;
                    case 3:
                        Console.WriteLine("Method to call : Update  inventory!");
                        break;
                    case 4:
                        Console.WriteLine("Method to call : Delete  inventory!");
                        break;
                    case 5:
                        MainMenu();
                        break;
                    default:
                        Console.WriteLine("\nInvalid command! Please type a number between 1 to 5.");
                        Console.Write("Press any key to continue.");
                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Invalid input! Please type a number between 1 to 5 : ");
                Console.WriteLine("Press any key to continue!");
                //Console.log(e);
            }
            Console.ReadLine();
            MenuForInventory();
        }

        static void MenuForRepair()
        {
            Console.Clear();
            WelcomeMessage();
            Console.WriteLine("You are in : Main Menu > Repair option...");
            Console.WriteLine();
            //Prints options of Menu:
            Console.WriteLine("Available Options to proceed : ");
            Console.WriteLine("\tPress 1 to view all repairs");
            Console.WriteLine("\tPress 2 to add a new record of repair");
            Console.WriteLine("\tPress 3 to update  record of repair");
            Console.WriteLine("\tPress 4 to delete record of repair");
            Console.WriteLine("\tPress 5 to return to main menu");
            Console.Write("\nPlease choose a command : ");

            try
            {
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Method to call : List of all repair!");
                        break;
                    case 2:
                        Console.WriteLine("Method to call : Add new repair!");

                        break;
                    case 3:
                        Console.WriteLine("Method to call : Update  repair!");
                        break;
                    case 4:
                        Console.WriteLine("Method to call : Delete  repair!");
                        break;
                    case 5:
                        MainMenu();
                        break;
                    default:
                        Console.WriteLine("\nInvalid command! Please type a number between 1 to 5.");
                        Console.Write("Press any key to continue.");
                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("\nInvalid input! Please type a number between 1 to 5 : ");
                Console.WriteLine("Press any key to continue!");
                //Console.log(e);
            }
            Console.ReadLine();
            MenuForRepair();
        }

        static void ExitProgram()
        {
            System.Environment.Exit(0);
        }

        //Methods to manage vehicles
        static void ListAllVehicles()
        {
            Console.WriteLine("List of all vehicles....");
        }

        static bool AddNewVehicle()
        {

            return true;
        }
    }
}
