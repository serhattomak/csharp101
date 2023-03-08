//System.Collections namespace

using System.Collections;

ArrayList list =new ArrayList();
//list.Add("Ayşe");
//list.Add(2);
//list.Add(true);
//list.Add('A');

//Access to the data
//Console.WriteLine(list[1]);

//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}

//AddRange
Console.WriteLine("**** AddRange ****");
//string[] colors = {"Red", "Yellow", "Green"};
List<int> numbers = new List<int>() {1, 8, 3, 7, 9, 92, 5};

//list.AddRange(colors);
list.AddRange(numbers);

foreach (var item in list)
{
    Console.WriteLine(item);
}

//Sort
Console.WriteLine("**** Sort ****");
list.Sort();

foreach (var item in list)
{
    Console.WriteLine(item);
}

// Binary Search
Console.WriteLine("**** Binary Search ****");
Console.WriteLine(list.BinarySearch(9));

//Reverse
Console.WriteLine("**** Reverse ****");
list.Reverse();
foreach (var item in list)
{
    Console.WriteLine(item);
}

//Clear
Console.WriteLine("**** Clear ****");
foreach (var item in list)
{
    Console.WriteLine(item);
}