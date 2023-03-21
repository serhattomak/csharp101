using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_1_ConsolePhoneContactsApp
{
    public class Contacts
    {
        public static List<PhoneContacts> contacts=new List<PhoneContacts>();

        public Contacts()
        {
            PhoneContacts contact1 = new PhoneContacts { Name = "Ali", Surname = "Kaya", PhoneNumber = "5319371820" };
            PhoneContacts contact2 = new PhoneContacts { Name = "Veli", Surname = "Yılmaz", PhoneNumber = "5327594316" };
            PhoneContacts contact3 = new PhoneContacts { Name = "Zeynep", Surname = "Güçlü", PhoneNumber = "5338643795" };
            PhoneContacts contact4 = new PhoneContacts { Name = "Murat", Surname = "Albayrak", PhoneNumber = "5344567318" };
            PhoneContacts contact5 = new PhoneContacts { Name = "Deniz", Surname = "Erdoğan", PhoneNumber = "5359563471" };

            contacts.Add(contact1);
            contacts.Add(contact2);
            contacts.Add(contact3);
            contacts.Add(contact4);
            contacts.Add(contact5);
        }
    }
}
