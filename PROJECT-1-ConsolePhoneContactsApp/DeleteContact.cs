using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_1_ConsolePhoneContactsApp
{
    public class DeleteContact
    {
        public static void DeleteNumber(List<PhoneContacts> contacts)
        {
            Console.WriteLine("Please enter the name or surname of the contact that you want to delete: ");
            string input = Console.ReadLine().ToLower();
            bool checkPerson = false;

            while (!checkPerson)
            {
                foreach (PhoneContacts contact in contacts)
                {
                    if (contact.Name.ToLower() == input)
                    {
                        Console.WriteLine(contact.Name +" "+ contact.Surname + " is going to remove from the list. Do you really want to delete? (y/n) ");
                        char confirmation = char.Parse(Console.ReadLine());

                        if (confirmation == 'y')
                        {
                            contacts.Remove(contact);
                            Console.WriteLine(contact.Name + " is removed.");
                            checkPerson = true;
                            break;
                        }
                        else
                        {
                            checkPerson = true;
                        }
                    }
                    else if (contact.Surname.ToLower() == input)
                    {
                        Console.WriteLine(contact.Name +" "+ contact.Surname + " is going to remove from the list. Do you really want to delete? (y/n) ");
                        char confirmation = char.Parse(Console.ReadLine());

                        if (confirmation == 'y')
                        {
                            contacts.Remove(contact);
                            Console.WriteLine(contact.Surname + " is removed.");
                            checkPerson = true;
                            break;
                        }
                        else
                        {
                            checkPerson = true;
                        }
                    }
                }

                if (!checkPerson)
                {
                    Console.WriteLine("There is no person found with the name you've entered in the contacts.");
                    Console.WriteLine("**********************************************************************");
                    Console.WriteLine("Enter (1) to end the process.");
                    Console.WriteLine("Enter (2) to try again with new input.");
                    byte processChoice = byte.Parse(Console.ReadLine());

                    if (processChoice==1)
                    {
                        checkPerson = true;
                    }
                    else if (processChoice==2)
                    {
                        checkPerson = false;
                        Console.WriteLine("Please enter the name or surname of the contact that you want to delete: ");
                        input = Console.ReadLine().ToLower();
                    }
                }
            }
        }
    }
}
