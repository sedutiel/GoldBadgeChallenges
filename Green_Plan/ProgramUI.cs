using KomodoGreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Repo;

namespace Green_Plan
{
    class ProgramUI
    {

        private VehicleRepo _repo = new VehicleRepo();

        public void Run()
        {

            SeedContent();
            Vehicle();
        }

        private void SeedContent()
        {
            Vehicle hybrid = new Vehicle(
                "A",
                "Prius",
                "Toyota",
                 2020,
                 56.0



            );
            Vehicle electric = new Vehicle(
                "B",
                "Chevy",
                "Bolt",
                2019,
                127.0


            );
            Vehicle gas = new Vehicle(
                "C",
              "Wrangler",
              "Jeep",
              2018,
              29.0



             );

            _repo.AddVehicleToList(hybrid);
            _repo.AddVehicleToList(electric);
            _repo.AddVehicleToList(gas);
        }

        private void Vehicle()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                // .Clear will clear the screen and prints the menu
                // concatenate strings, can hit enter inside of string and vs code will concatenate for you
                // makes it easier to read as a developer
                Console.WriteLine(
                    "Welcome!\n" +
                    "Select Item:\n" +
                    "1. Show All Vehicles\n" +
                    "2. Add New Vehicle\n" +
                    "3. Show Vehicle By Type\n" +
                    "4. Update Vehicle\n" +
                    "5. Delete Vehicle\n" +
                    "4. Exit");

                string userInput = Console.ReadLine();


                Console.Clear();
                switch (userInput)
                {
                    case "1":
                        ShowAllVehicles();
                        break;
                    case "2":
                        AddVehicleToList();
                        break;
                    case "3":
                        UpdateVehicle();
                        break;
                    case "4":
                        DeleteVehicle();
                        break;
                    case "5":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        Console.ReadKey();
                        break;
                }
                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey();
            }
        }

        private void ShowAllVehicles()
        {
            Console.Clear();
            List<Vehicle> listofContent = _repo.GetFullList();
            foreach (Vehicle vehicleList in listofContent)
            {
                Console.WriteLine(vehicleList.Type);
                Console.WriteLine(vehicleList.Make);
                Console.WriteLine(vehicleList.Model);
                Console.WriteLine(vehicleList.MPG);
                Console.WriteLine(vehicleList.Year);
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }

        private void AddVehicleToList()
        {
            Console.Clear();

            Vehicle newVehicle = new Vehicle();

            Console.WriteLine("Please enter vehicle Type.");
            newVehicle.Type = Console.ReadLine();

            Console.WriteLine("Please enter vehicle Make.");
            newVehicle.Make = Console.ReadLine();

            Console.WriteLine("Please enter vehicle Model.");
            newVehicle.Model = Console.ReadLine();

            Console.WriteLine("Please enter vehicle MPG.");
            newVehicle.MPG = Console.ReadLine();

            Console.WriteLine("Please enter vehicle Year.");
            string yearAsString = Console.ReadLine();
            double yearAsDouble = double.Parse(yearAsString);
            newVehicle.Year = yearAsDouble;

            _repo.AddVehicleToList(newVehicle);

        }

        private void DeleteVehicle()
        {
            ShowAllVehicles();
            Console.WriteLine("Enter the letter of the menu item you would like to delete.");
            string vehicleTypeToDelete = Console.ReadLine();

            Vehicle vehicleToDelete = _repo.GetVehicleByType(vehicleTypeToDelete);
            bool wasDeleted =_repo.DeleteExistingVehicle(vehicleToDelete);

            if (wasDeleted)
            {
                Console.WriteLine("This content was successfully deleted.");
            }
            else
            {
                Console.WriteLine("Content could not be deleted");
            }
        }
    }
}