using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_1_ConsolePhoneContactsApp
{
    public class UpdateContact
    {
        public static void UpdateNumber(List<PhoneContacts> contacts)
        {
            Console.WriteLine("Please enter the name or surname of the contact that you want to update: ");
            string input = Console.ReadLine().ToLower();
            bool checkPerson = false;

            while (!checkPerson)
            {
                foreach (PhoneContacts contact in contacts)
                {
                    if (contact.Name.ToLower()==input)
                    {
                        Console.WriteLine("Please enter the new number of "+contact.Name+": ");
                        string number = Console.ReadLine();
                        contact.PhoneNumber = number;
                        checkPerson=true;
                        break;
                    }
                    else if (contact.Surname.ToLower()==input)
                    {
                        Console.WriteLine("Please enter the new number of " + contact.Surname + ": ");
                        string number= Console.ReadLine();
                        contact.PhoneNumber = number;
                        checkPerson=true;
                        break;
                    }
                }

                if (!checkPerson)
                {
                    Console.WriteLine("There is no person found with the name you've entered in the contacts.");
                    Console.WriteLine("**********************************************************************");
                    Console.WriteLine("Enter (1) to end the process.");
                    Console.WriteLine("Enter (2) to try again with new input.");
                    byte processChoice = byte.Parse(Console.ReadLine());

                    if (processChoice == 1)
                    {
                        checkPerson = true;
                    }
                    else if (processChoice == 2)
                    {
                        checkPerson = false;
                        Console.WriteLine("Please enter the name or surname of the contact that you want to update: ");
                        input = Console.ReadLine().ToLower();
                    }
                }
            }
        }
    }
}
