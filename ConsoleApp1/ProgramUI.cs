using Komo_Cafe.repo;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;



namespace Komo_Cafe_Console
{
    class ProgramUI
    {
        private Menu_Repo _menuRepo = new Menu_Repo();

        public void Run()
        {

            SeedContent();
            KMenu();
        }

        private void SeedContent()
        {
            KMenu burgerMeal = new KMenu(
                "A",
                "Burger Meal",
                "Burger and side",
                "Patty, Bun, Lettuce,Tomato",
                 6.00


            );
            KMenu soupMeal = new KMenu(
                "B",
                "Soup Meal",
                "Soup and side",
                "Various soup and side",
                 5.00


            );
            KMenu saladMeal = new KMenu(
                "C",
                "Salad Meal",
                "Salad and side",
                "Various Salad and side",
                 4.00



             );
            KMenu sandwhichMeal = new KMenu(
                "D",
                "Sandwhich Meal",
                "Sandwhich and side",
                "Various sandwhich and side",
                8.00


            );

            _menuRepo.AddMenu(burgerMeal);
            _menuRepo.AddMenu(soupMeal);
            _menuRepo.AddMenu(saladMeal);
            _menuRepo.AddMenu(sandwhichMeal);
        }

        private void KMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                // .Clear will clear the screen and prints the menu
                // concatenate strings, can hit enter inside of string and vs code will concatenate for you
                // makes it easier to read as a developer
                Console.WriteLine(
                    "Welcome to Komodo Cafe!\n" +
                    "Select KMenu Item:\n" +
                    "1. Show Full KMenu\n" +
                    "2. Create New Item\n" +
                    "3. Delete KMenu Item\n" +
                    "4. Exit");

                string userInput = Console.ReadLine();


                Console.Clear();
                switch (userInput)
                {
                    case "1":
                        ShowFullMenu();
                        break;
                    case "2":
                        CreateNewMenuItem();
                        break;
                    case "3":
                        DeleteExistingItem();
                        break;
                    case "4":
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




        private void ShowFullMenu()
        {
            Console.Clear();
            List<KMenu> listofContent = _menuRepo.GetFullMenu();
            foreach (KMenu menuItem in listofContent)
            {
                Console.WriteLine(menuItem.MealLetter);
                Console.WriteLine(menuItem.MealName);
                Console.WriteLine(menuItem.MealDescription);
                Console.WriteLine(menuItem.MealIngredients);
                Console.WriteLine(menuItem.MealPrice);
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }

        private void CreateNewMenuItem()
        {
            Console.Clear();

            KMenu newMenuItem = new KMenu();

            Console.WriteLine("Please enter a Meal Letter.");
            newMenuItem.MealLetter = Console.ReadLine();

            Console.WriteLine("Please enter a Meal Name.");
            newMenuItem.MealName = Console.ReadLine();

            Console.WriteLine("Please enter a Meal Description.");
            newMenuItem.MealDescription = Console.ReadLine();

            Console.WriteLine("Please enter Meal Ingredients.");
            newMenuItem.MealIngredients = Console.ReadLine();

            Console.WriteLine("Please enter a Meal Price.");
            string priceAsString = Console.ReadLine();
            double priceAsDouble = double.Parse(priceAsString);
            newMenuItem.MealPrice = priceAsDouble;

            _menuRepo.AddMenu(newMenuItem);

        }

        private void DeleteExistingItem()
        {
            ShowFullMenu();
            Console.WriteLine("Enter the letter of the menu item you would like to delete.");
            string menuLetterToDelete = Console.ReadLine();

            KMenu contentToDelete = _menuRepo.GetMealByLetter(menuLetterToDelete);
            bool wasDeleted = _menuRepo.DeleteExistingItem(contentToDelete);

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
