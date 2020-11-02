using _02_Komodo_Email_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ProgramUI
{

    private List<Recipients> _repo = new List<Recipients>();

    private List<Email_Repo> _emailRepo = new List<Email_Repo>();

    public void Run()
    {

        SeedRecipients();
        SeedMessages();
        Email_Repo();
        Recipients();

    }
    private void AddRecipient()
    {
        Console.Clear();

        Recipients newRecipient = new Recipients();

        Console.WriteLine("Please enter a Meal Letter.");
        newRecipient.FirstName = Console.ReadLine();

        Console.WriteLine("Please enter a Meal Name.");
        newRecipient.LastName = Console.ReadLine();

        Console.WriteLine("Please enter a Meal Description.");
        newRecipient.EmailAddress = Console.ReadLine();

        Console.WriteLine("Please enter Meal Ingredients.");
        newRecipient.CustomerType = Console.ReadLine();


        _repo.Add(newRecipient);

    }

    private void SeedRecipients()
    {
        Recipients newCustomer1 = new Recipients(
            "John",
            "Smith",
            "johnsmith@js.com",
             1


        );
        Recipients newCustomer2 = new Recipients(
          "Karen",
          "Lowe",
          "klowe@aol.com",
           2
      );
        Recipients newCustomer3 = new Recipients(
         "Brian",
         "Clark",
         "bclark@gmail.com",
          3


      );
        Recipients newCustomer4 = new Recipients(
           "Susan",
           "Brown",
           "sbrown@yahoo.com",
            2


       );

        _repo.Add(newCustomer1);
        _repo.Add(newCustomer2);
        _repo.Add(newCustomer3);
        _repo.Add(newCustomer4);
    }

    public void SeedMessages()
    {
        Email_Message newmessage1 = new Email_Message("Thank you for your business!", "Thank you for your work with us.We appreciate your loyalty.Here's a coupon.");
        Email_Message newmessage2 = new Email_Message("We've missed you!", "It's been a long time since we've heard from you, we want you back.");
        Email_Message newmessage3 = new Email_Message("We've got a deal for you!", "We currently have the lowest rates on Helicopter Insurance!");

        _emailRepo.Add(newmessage1);
        _emailRepo.Add(newmessage2);
        _emailRepo.Add(newmessage3);
    }

    private void Recipients()
    {
        bool continueToRun = true;
        while (continueToRun)
        {
            Console.Clear();
            // .Clear will clear the screen and prints the menu
            // concatenate strings, can hit enter inside of string and vs code will concatenate for you
            // makes it easier to read as a developer
            Console.WriteLine(
                "Menu!\n" +
                "1. Show All Recipients\n" +
                "2. Add Recipient\n" +
                "3. Delete Recipient\n" +
                "3. UpdateRecipient\n" +
                "4. Exit");

            string userInput = Console.ReadLine();


            Console.Clear();
            switch (userInput)
            {
                case "1":
                    ShowAllRecipients();
                    break;
                case "2":
                    AddRecipient();
                    break;
                case "3":
                    DeleteRecipient();
                    break;
                case "4":
                    UpdateRecipient();
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

        private void ShowAllRecipients()
        {
            Console.Clear();
            List<Recipients> listofContent = _repo.ShowAllRecipients();
            foreach (Recipients menuItem in listofContent)
            {
                Console.WriteLine(menuItem.FirstName);
                Console.WriteLine(menuItem.LastName);
                Console.WriteLine(menuItem.EmailAddress);
                Console.WriteLine(menuItem.CustomerType);
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }

        public string GetRecipientType(int customerType)
        {
            switch (customerType)
            {
                case 1:
                    return "Current";
                case 2:
                    return "Past";
                case 3:
                    return "Potential";
                default:
                    return "N/A";
            }
        }

        private void DeleteRecipient()
        {
            ShowAllRecipients();
            Console.WriteLine("Enter the last name of the recipient you would like to delete.");
            string recipientToDelete = Console.ReadLine();

            Recipients recipeientToDelete = _repo.ShowByLastName(recipientToDelete);
            bool wasDeleted = _repo.DeleteRecipients(recipientToDelete);

            if (wasDeleted)
            {
                Console.WriteLine("This recipient was successfully deleted.");
            }
            else
            {
                Console.WriteLine("Recipient could not be deleted");
            }
        }



    }
}