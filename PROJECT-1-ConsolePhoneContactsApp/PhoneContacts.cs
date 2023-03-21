using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace PROJECT_1_ConsolePhoneContactsApp
{
    public class PhoneContacts
    {
        private string name;
        private string surname;
        private string phoneNumber;

        public string Name
        {
            get => name; set => name = value;
        }

        public string Surname
        {
            get => surname; set => surname = value;
        }

        public string PhoneNumber
        {
            get => phoneNumber; set => phoneNumber = value;
        }
    }
}
