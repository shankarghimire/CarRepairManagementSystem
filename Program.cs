using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRepairManagementSystem
{
    class Program
    {
        static List<Vehicle> vehicleList = new List<Vehicle>();
        static List<Inventory> inventoryList = new List<Inventory>();
        static List<Repair> repairList = new List<Repair>();
        //public Program()
        //{
        //    //vehicleList = new List<Vehicle>();
        //    //inventoriesList = new List<Inventory>();
        //    //repairsList = new List<Repair>();



        //}
        static void Main(string[] args)
        {

            //Calls method to load Vehicles data
            LoadInitialVehicleData();
            LoadInitialInventoryData();
            LoadInitialRepairData();


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
            catch (Exception e)
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
            bool operationResult;
            int vId;
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
                        //Console.WriteLine("Method to call : List of all vehicles!");
                        DisplayListAllVehicles();
                        break;
                    case 2:
                        //Console.WriteLine("Method to call : Add new Vehicle!");
                        operationResult = AddNewVehicle();
                        if (operationResult)
                        {
                            Console.WriteLine("\nSuccess! New vehicle has been added to the database!");

                        }
                        else
                        {
                            Console.WriteLine("\nSomething went wrong! Please try again.");
                        }
                        Console.WriteLine("Press any key to continue!");
                        break;
                    case 3:
                        //Console.WriteLine("Method to call : Update new Vehicle!");
                        Console.Write("Please enter the vehicle id which you want to update : ");
                        vId = int.Parse(Console.ReadLine());
                        operationResult = UpdateVehicle(vId);
                        if (operationResult)
                        {
                            Console.WriteLine("\n\tSuccess! Vehicle has been successfully updated!");
                            Console.WriteLine(" Press any key to continue!");
                        }
                        else
                        {
                            Console.WriteLine("\tERROR! Something went wrong! Please try again.");
                            Console.WriteLine(" Press any key to continue!");
                        }
                        break;
                    case 4:
                        //Console.WriteLine("Method to call : Delete new Vehicle!");
                        Console.Write("Please enter the vehicle id which you want to delete : ");
                        vId = int.Parse(Console.ReadLine());
                        operationResult = DeleteVehicle(vId);
                        if (operationResult)
                        {
                            Console.WriteLine("\n\tSuccess! Vehicle has been successfully deleted!");
                            Console.WriteLine(" Press any key to continue!");
                        }
                        else
                        {
                            Console.WriteLine("\tERROR! Something went wrong! Please try again.");
                            Console.WriteLine(" Press any key to continue!");
                        }
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
            MenuForVehicles();

        }
        static void MenuForInventory()
        {
            int iId;
            bool operationResult;
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
                        //Console.WriteLine("Method to call : List of all inventory!");
                        DisplayListAllInventories();
                        break;
                    case 2:
                        //Console.WriteLine("Method to call : Add new inventory!");
                        operationResult = AddNewInventory();
                        if (operationResult)
                        {
                            Console.WriteLine("\nSuccess! New vehicle has been added to the database!");
                        }
                        else
                        {
                            Console.WriteLine("\nSomething went wrong! Please try again.");
                        }
                        Console.WriteLine("Press any key to continue!");

                        break;
                    case 3:
                        //Update Inventory Info
                        //Console.WriteLine("Method to call : Update  inventory!");
                        Console.Write("Please enter the vehicle id which you want to update : ");
                        iId = int.Parse(Console.ReadLine());
                        operationResult = UpdateInventory(iId);
                        if (operationResult)
                        {
                            Console.WriteLine("\n\tSuccess! Vehicle has been successfully updated!");
                            Console.WriteLine(" Press any key to continue!");
                        }
                        else
                        {
                            Console.WriteLine("\tERROR! Something went wrong! Please try again.");
                            Console.WriteLine(" Press any key to continue!");
                        }
                        break;
                    case 4:
                        //Delete Inventory Record
                        //Console.WriteLine("Method to call : Delete  inventory!");
                        Console.Write("Please enter the Inventory id which you want to delete : ");
                        iId = int.Parse(Console.ReadLine());
                        operationResult = DeleteInventory(iId);
                        if (operationResult)
                        {
                            Console.WriteLine("\n\tSuccess! Inventory record has been successfully deleted!");
                            Console.WriteLine("\tPress any key to continue!");
                        }
                        else
                        {
                            Console.WriteLine("\tERROR! Something went wrong! Please try again.");
                            Console.WriteLine(" Press any key to continue!");
                        }
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
                        //Console.WriteLine("Method to call : List of all repair!");
                        DisplayListAllRepairs();
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

        /*###########################################################*/
        //Methods to manage vehicles
        static void DisplayListAllVehicles()
        {
            //Console.WriteLine("List of all vehicles....");
            var vehicles = from v in vehicleList
                           select v;

            //print list of all vehicles
            Console.WriteLine();
            Console.WriteLine("List of All Vehicles:");
            Console.WriteLine("\tId\tMake\t\tModel\t\t\tYear\tStatus");
            Console.WriteLine("\t--\t----\t\t-----\t\t\t----\t------");
            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine($"\t{v.Id}\t{v.Make}\t\t{v.Model}\t\t{v.Year}\t{v.VehicleStatus}");
            }
            //Console.WriteLine("------------------------------------");

            Console.WriteLine("\n\n");
            Console.Write("Press any key to continue. ");

        }

        static bool AddNewVehicle()
        {
            bool result = true;
            try
            {
                Console.Write("Enter the Vehicle Id : ");
                int vId = int.Parse(Console.ReadLine());
                bool status = CheckVehicleId(vId);
                if (status)
                {
                    throw new Exception(" \tERROR! Duplicate vehicle Id NOT allowed! \n\tPlease, enter unique vehicle Id.");
                }

                Console.Write("Enter the vehicle make information : ");
                string vMake = Console.ReadLine();

                Console.Write("\nEnter the vehicle model information : ");
                string vModel = Console.ReadLine();

                Console.Write("\nEnter the vehicle manufactured year : ");
                int vYear = int.Parse(Console.ReadLine());

                Console.Write("\nEnter the vehicle status(0 for Used, 1 for New)  : ");
                int vUserInput = int.Parse(Console.ReadLine());
                VehicleStatus vStatus;
                switch (vUserInput)
                {
                    case 0:
                        vStatus = VehicleStatus.Used;
                        break;
                    case 1:
                        vStatus = VehicleStatus.New;
                        break;
                    default:
                        throw new Exception("\t ERROR! Inalid option. Please enter either 0 or 1.");
                        break;
                }

                Vehicle tempVehicle = new Vehicle();
                tempVehicle.Id = vId.ToString();
                tempVehicle.Make = vMake;
                tempVehicle.Model = vModel;
                tempVehicle.Year = vYear;
                tempVehicle.VehicleStatus = vStatus;

                vehicleList.Add(tempVehicle);

                result = true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = false;

            }
            return result;
        }

        static bool UpdateVehicle(int id)
        {

            bool result = false;
            List<Vehicle> tempVehicleList = new List<Vehicle>();
            try
            {
                var vehicletoUpdate = vehicleList.Single(v => v.Id == id.ToString());

                Console.Write("Enter the vehicle make information : ");
                string vMake = Console.ReadLine();

                Console.Write("\nEnter the vehicle model information : ");
                string vModel = Console.ReadLine();

                Console.Write("\nEnter the vehicle manufactured year : ");
                int vYear = int.Parse(Console.ReadLine());

                Console.Write("\nEnter the vehicle status(0 for Used, 1 for New)  : ");
                int vUserInput = int.Parse(Console.ReadLine());
                VehicleStatus vStatus;
                switch (vUserInput)
                {
                    case 0:
                        vStatus = VehicleStatus.Used;
                        break;
                    case 1:
                        vStatus = VehicleStatus.New;
                        break;
                    default:
                        throw new Exception("\t ERROR! Invalid option. Please enter either 0 or 1.");
                        //break;
                }

                Vehicle tempVehicle = new Vehicle();
                //tempVehicle.Id = vId.ToString();
                vehicletoUpdate.Make = vMake;
                vehicletoUpdate.Model = vModel;
                vehicletoUpdate.Year = vYear;
                vehicletoUpdate.VehicleStatus = vStatus;

                result = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = false;
            }

            return result;
        }

        static bool CheckVehicleId(int id)
        {
            bool result = false;
            try
            {
                var vehicles = from vList in vehicleList

                               select vList;
                foreach (var v in vehicles)
                {
                    if (id == int.Parse(v.Id))
                    {
                        //throw new Exception("\n\tERROR!\n\tDuplicate id now allowed!");
                        result = true;
                        break;
                        //throw new Exception();

                    }
                }
                

            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
                //Console.WriteLine("Duplicate Ids nowt allowed!");
                //Console.WriteLine("Please, try again!");
                result = false;
            }

            return result;

        }

        static bool DeleteVehicle(int id)
        {
            bool result = false;
            //List<Vehicle> tempVehicleList = new List<Vehicle>();
            try
            {
                var vehicletoRemove = vehicleList.Single(v => v.Id == id.ToString());
                vehicleList.Remove(vehicletoRemove);
                result = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = false;

            }
            return result;
        }



        /*###########################################################*/
        //Methods to handle Inventory class
        static void DisplayListAllInventories()
        {
            //Console.WriteLine("List of all vehicles....");
            var inventories = from inv in inventoryList
                              orderby inv.Id
                              select inv;

            //print list of all vehicles
            Console.WriteLine();
            Console.WriteLine("List of All Inventories:");
            Console.WriteLine("\tId\tVehicleId\tNumber Of Hand\t\tPrice\t\tCost");
            Console.WriteLine("\t--\t---------\t--------------\t\t-----\t\t----");
            foreach (var inv in inventories)
            {
                Console.WriteLine($"\t{inv.Id}\t{inv.VehicleId}\t\t{inv.NumberOnHand}\t\t\t{inv.Price}\t\t{inv.Cost}");
            }
            //Console.WriteLine("------------------------------------");

            Console.WriteLine("\n\n");
            Console.Write("Press any key to continue. ");

        }
        static bool AddNewInventory()
        {
            bool result = true;
            bool status;
            try
            {
                Console.Write("Enter the Inventory Id : ");
                int iId = int.Parse(Console.ReadLine());
                status = CheckInventoryId(iId);
                if (!status)
                {
                    throw new Exception(" \tERROR! Duplicate Invenotry Id NOT allowed! \n\tPlease, enter unique Invenotry Id.");
                }

                Console.Write("Enter the vehicle Id information : ");
                int vId = int.Parse( Console.ReadLine());
                status = CheckVehicleId(vId);
                if (!status)
                {
                    throw new Exception("Vehicle Id does not match with existing Vehicle IDs!\nPlease, confirm the Vehicle Id and try again.");
                }

                Console.Write("\nEnter the number of hands for Inventory : ");
                int num = int.Parse( Console.ReadLine());

                Console.Write("\nEnter the price  : ");
                decimal price  = decimal.Parse(Console.ReadLine());

                Console.Write("\nEnter the cost  : ");
                decimal cost = decimal.Parse(Console.ReadLine());

                Inventory newInventory = new Inventory();

                newInventory.Id = iId.ToString();
                newInventory.VehicleId = vId.ToString();
                newInventory.NumberOnHand = num;
                newInventory.Price = price;
                newInventory.Cost = cost;

                inventoryList.Add(newInventory);

                result = true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = false;

            }
            return result;
        }

        static bool UpdateInventory(int id)
        {

            bool result = false;
            //List<Vehicle> tempVehicleList = new List<Vehicle>();
            try
            {
                var inventoryToUpdate = inventoryList.Single(i => i.Id == id.ToString());

                Console.Write("Enter the Vehicle Id : ");

                int vId = int.Parse(Console.ReadLine());
                bool status = CheckVehicleId(vId);
                if (!status)
                {
                    throw new Exception("\nError\tVehicle Id does not match with existing Vehicle IDs!\nPlease, confirm the Vehicle Id and try again.");
                }

                Console.Write("\nEnter the Number of Hands  : ");
                int numOnHand = int.Parse( Console.ReadLine());

                Console.Write("\nEnter the Price : ");
                decimal price  =decimal.Parse(Console.ReadLine());

                Console.Write("\nEnter the cost  : ");
                decimal cost = decimal.Parse(Console.ReadLine());

                //Inventory tempInventory = new Inventory();
                inventoryToUpdate.VehicleId = vId.ToString();
                inventoryToUpdate.NumberOnHand = numOnHand;
                inventoryToUpdate.Price = price;
                inventoryToUpdate.Cost = cost;

                result = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = false;
            }

            return result;
        }
        static bool DeleteInventory(int id)
        {
            bool result = false;
            //List<Inventory> tempInventoryList = new List<Inventory>();
            try
            {
                var inventoryToRemove = inventoryList.Single(inv => inv.Id == id.ToString());                             
                inventoryList.Remove(inventoryToRemove);
                result = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = false;

            }
            return result;
        }

        static bool CheckInventoryId(int id)
        {
            bool result = true;
            try
            {
                var inventories = from iList in inventoryList

                               select iList;
                foreach (var v in inventories)
                {
                    if (id == int.Parse(v.Id))
                    {
                        //throw new Exception("\n\tERROR!\n\tDuplicate id now allowed!");
                        throw new Exception();

                    }
                }

            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
                //Console.WriteLine("Duplicate Ids nowt allowed!");
                //Console.WriteLine("Please, try again!");
                result = false;
            }

            return result;

        }
        /*###########################################################*/
        //All methods related to Repail class
        static void DisplayListAllRepairs()
        {
            //Console.WriteLine("List of all vehicles....");
            var repairs = from inv in repairList
                          orderby inv.Id
                          select inv;

            //print list of all vehicles
            Console.WriteLine();
            Console.WriteLine("List of All Repairs:");
            Console.WriteLine("\tId\tInventoryId\t\tWhat to Repair");
            Console.WriteLine("\t--\t----\t\t\t-----");
            foreach (var rep in repairs)
            {
                Console.WriteLine($"\t{rep.Id}\t{rep.InventoryId}\t\t\t{rep.WhatToRepair}");
            }
            //Console.WriteLine("------------------------------------");

            Console.WriteLine("\n\n");
            Console.Write("Press any key to continue. ");

        }
        static void LoadInitialVehicleData()
        {
            //Add records to vehicles list
            vehicleList.Add(new Vehicle("1", "Toyota", "Series-2021", 2021, VehicleStatus.Used));
            vehicleList.Add(new Vehicle("2", "Tesla", "Series-2021", 2020, VehicleStatus.New));
            vehicleList.Add(new Vehicle("3", "Tesla", "Series-2020", 2021, VehicleStatus.New));
            vehicleList.Add(new Vehicle("4", "BMW", "Series-77", 2019, VehicleStatus.Used));
            vehicleList.Add(new Vehicle("5", "Hundai", "Series-99", 2020, VehicleStatus.New));
        }

        static void LoadInitialInventoryData()
        {
            inventoryList.Add(new Inventory("101", "1", 1, 26999, 24999));
            inventoryList.Add(new Inventory("102", "2", 1, 26999, 24999));
            inventoryList.Add(new Inventory("103", "3", 1, 26999, 24999));
            inventoryList.Add(new Inventory("104", "4", 1, 26999, 24999));
            inventoryList.Add(new Inventory("105", "5", 1, 26999, 24999));
        }

        static void LoadInitialRepairData()
        {
            repairList.Add(new Repair("1001", "101", "None"));
            repairList.Add(new Repair("1002", "102", "None"));
            repairList.Add(new Repair("1003", "103", "None"));
            repairList.Add(new Repair("1004", "104", "None"));
            repairList.Add(new Repair("1005", "105", "None"));

        }
    }
}
