//List<T> class
//System.Collections.Generic
//T-> object.

List<int> numberList=new List<int>();

numberList.Add(23);
numberList.Add(10);
numberList.Add(4);
numberList.Add(5);
numberList.Add(92);
numberList.Add(34);

List<string> colorList=new List<string>();
colorList.Add("Red");
colorList.Add("Blue");
colorList.Add("Orange");
colorList.Add("Yellow");
colorList.Add("Green");

//Count
Console.WriteLine(colorList.Count);
Console.WriteLine(numberList.Count);

//Access to Members of List with Foreach and List.ForEach
foreach (var number in numberList)
{
    Console.WriteLine(number);
}
foreach (var color in colorList)
{
    Console.WriteLine(color);
}
numberList.ForEach(number=>Console.WriteLine(number));
colorList.ForEach(color=>Console.WriteLine(color));

//Removing a member from the list
numberList.Remove(4);
colorList.Remove("Green");

numberList.RemoveAt(0);
colorList.RemoveAt(1);

numberList.ForEach(number => Console.WriteLine(number));
colorList.ForEach(color => Console.WriteLine(color));

//Searching on the list
if (numberList.Contains(10))
{
    Console.WriteLine("10 is on the list!");
}
//Accessing to index with member.
Console.WriteLine(colorList.BinarySearch("Yellow"));

//Changing array to list
string[] animals = {"Cat", "Dog", "Bird"};
List<string> animalsList = new List<string>(animals);

//How to clean the list?
animalsList.Clear();

//Adding object to a list
List<Users> userList=new List<Users>();
Users user1= new Users();
user1.Name = "Serhat";
user1.Surname = "Tomak";
user1.Age = 21;

Users user2= new Users();
user2.Name = "Oğuzhan";
user2.Surname = "Tomak";
user2.Age = 29;

userList.Add(user1);
userList.Add(user2);

List<Users> newList=new List<Users>();

newList.Add(new Users(){Name = "Sibel",Surname = "Tomak",Age = 51});

foreach (var users in userList)
{
    Console.WriteLine($"Name: {users.Name}");
    Console.WriteLine($"Surname: {users.Surname}");
    Console.WriteLine($"Age: {users.Age}");
}

newList.Clear();

public class Users
{
    private string name;
    private string surname;
    int age;

    public string Name
    {
        get => name; set => name = value;
    }

    public string Surname
    {
        get => surname;set=> surname = value;
    }

    public int Age
    {
        get => age;set=> age = value;
    }
}