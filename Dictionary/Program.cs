//System.Collection.Generic
Dictionary<int, string> users = new Dictionary<int, string>();

users.Add(10, "Ayşe Yılmaz");
users.Add(12, "Ahmet Yılmaz");
users.Add(18, "Deniz Arda");
users.Add(20, "Özcan Coşar");

//Access to element of array
Console.WriteLine("**** Access to the Elements ****");
Console.WriteLine(users[12]);
foreach (var item in users)
{
    Console.WriteLine(item);
}

//Count
Console.WriteLine("**** Count ****");
Console.WriteLine(users.Count);

//Contains
Console.WriteLine("**** Contains ****");
Console.WriteLine(users.ContainsKey(12));
Console.WriteLine(users.ContainsValue("Serhat Tomak"));

//Remove
Console.WriteLine("**** Remove ****");
users.Remove(12);
foreach (var item in users)
{
    Console.WriteLine(item);
}

//Keys
Console.WriteLine("**** Keys ****");
foreach (var item in users.Keys)
{
    Console.WriteLine(item);
}
//Values
Console.WriteLine("**** Values ****");
foreach (var item in users.Values)
{
    Console.WriteLine(item);
}