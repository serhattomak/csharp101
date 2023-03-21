using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_1_ConsolePhoneContactsApp
{
    public class SaveContact
    {
        public static void SaveNumber(List<PhoneContacts> contacts)
        {
            Console.WriteLine("Enter the name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter the number: ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("*******************************************************");

            PhoneContacts contact = new PhoneContacts{Name = name, Surname = surname, PhoneNumber = phoneNumber};
            Contacts.contacts.Add(contact);
        }
    }
}
