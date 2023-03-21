using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_1_ConsolePhoneContactsApp
{
    public class ListingContacts
    {
        public static void ListingNumbers(List<PhoneContacts> contacts)
        {
            foreach (PhoneContacts contact in contacts)
            {
                Console.WriteLine("Name: "+contact.Name);
                Console.WriteLine("Surname: "+contact.Surname);
                Console.WriteLine("Phone Number: "+contact.PhoneNumber);
                Console.WriteLine("----------------------------------");
            }
        }
    }
}
