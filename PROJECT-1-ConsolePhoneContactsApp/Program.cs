using PROJECT_1_ConsolePhoneContactsApp;

Console.WriteLine("Please enter the number of the process you want to do: ");
Console.WriteLine("*******************************************************");
Console.WriteLine("(1) Add a New Contact");
Console.WriteLine("(2) Delete an Existing Contact");
Console.WriteLine("(3) Update an Existing Contact");
Console.WriteLine("(4) List Contacts");
Console.WriteLine("(5) Search on the Contacts");
Console.WriteLine("(6) Exit");
Console.WriteLine("*******************************************************");
byte process = byte.Parse(Console.ReadLine());
Console.WriteLine("*******************************************************");

Contacts contact = new Contacts();
bool control = true;

while (control)
{
    switch (process)
    {
        case 1:
            SaveContact.SaveNumber(Contacts.contacts);
            break;
        case 2:
            DeleteContact.DeleteNumber(Contacts.contacts);
            break;
        case 3:
            UpdateContact.UpdateNumber(Contacts.contacts);
            break;
        case 4:
            ListingContacts.ListingNumbers(Contacts.contacts);
            break;
        case 5:
            SearchContact.SearchNumber(Contacts.contacts);
            break;
        case 6:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Enter a valid number!");
            break;
    }

    if (control)
    {
        Console.WriteLine("(1) Add a New Contact");
        Console.WriteLine("(2) Delete an Existing Contact");
        Console.WriteLine("(3) Update an Existing Contact");
        Console.WriteLine("(4) List Contacts");
        Console.WriteLine("(5) Search on the Contacts");
        Console.WriteLine("(6) Exit");
        Console.WriteLine("*******************************************************");
        Console.WriteLine("To choose a process please enter: ");
        process = byte.Parse(Console.ReadLine());
        Console.WriteLine("*******************************************************");
    }
}

Console.ReadLine();
