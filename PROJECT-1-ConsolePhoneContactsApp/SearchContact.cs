using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_1_ConsolePhoneContactsApp
{
    public class SearchContact
    {
        public static void SearchNumber(List<PhoneContacts> contacts)
        {
            Console.WriteLine("Please enter the way of the searching.");
            Console.WriteLine("To search with name/surname enter (1)");
            Console.WriteLine("To search with phone number enter (2)");
            byte processChoice = byte.Parse(Console.ReadLine());

            if (processChoice == 1)
            {
                Console.WriteLine("Please enter the name/surname that you want to search in the contacts: ");
                string searchingName = Console.ReadLine().ToLower();

                var searchedContacts = contacts.Where(x =>
                    x.Name.ToLower().Contains(searchingName.ToLower()) ||
                    x.Surname.ToLower().Contains(searchingName.ToLower()));

                foreach (var searchedContact in searchedContacts)
                {
                    Console.WriteLine("*******************************************************");
                    Console.WriteLine("Name: " + searchedContact.Name);
                    Console.WriteLine("Surname: " + searchedContact.Surname);
                    Console.WriteLine("Phone Number: " + searchedContact.PhoneNumber);
                    Console.WriteLine("*******************************************************");
                }

            }

            else if (processChoice == 2)
            {
                Console.WriteLine("Please enter the number that you want to search: ");
                string searchingNumber = Console.ReadLine();

                var searchedContacts = contacts.Where(x => x.PhoneNumber.Contains(searchingNumber));
                foreach (PhoneContacts contact in searchedContacts)
                {
                    Console.WriteLine("*******************************************************");
                    Console.WriteLine("Name: " + contact.Name);
                    Console.WriteLine("Surname: " + contact.Surname);
                    Console.WriteLine("Phone Number: " + contact.PhoneNumber);
                    Console.WriteLine("*******************************************************");
                }
            }
        }
    }
}
