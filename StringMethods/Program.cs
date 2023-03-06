string instance = "Lesson: CSharp. Welcome!";
string instance2 = "CSharp";

//Length;
Console.WriteLine(instance.Length);

//ToUpper, ToLower
Console.WriteLine(instance.ToUpper());
Console.WriteLine(instance.ToLower());

//Concat
Console.WriteLine(String.Concat(instance, " Hello!"));

//Compare, CompareTo

Console.WriteLine(instance.CompareTo(instance2)); //0,1,-1
Console.WriteLine(String.Compare(instance, instance2, true)); //0,1,-1
Console.WriteLine(String.Compare(instance, instance2, false)); //0,1,-1

//Contains
Console.WriteLine(instance.Contains(instance2));
Console.WriteLine(instance.EndsWith("Welcome!"));
Console.WriteLine(instance.StartsWith("Hello!"));

//IndexOf
Console.WriteLine(instance.IndexOf("CS"));
Console.WriteLine(instance.IndexOf("Serhat"));
Console.WriteLine(instance.LastIndexOf("i"));

//Insert
Console.WriteLine(instance.Insert(0, "Hello! "));

//PadLeft, PadRight;
Console.WriteLine(instance + instance2.PadLeft(30));
Console.WriteLine(instance + instance2.PadLeft(30,'*'));
Console.WriteLine(instance.PadRight(50) + instance2);
Console.WriteLine(instance.PadRight(50,'-') + instance2);

//Remove
Console.WriteLine(instance.Remove(10));
Console.WriteLine(instance.Remove(5,3));
Console.WriteLine(instance.Remove(0,1));

//Replace
Console.WriteLine(instance.Replace("CSharp","C#"));
Console.WriteLine(instance.Replace(" ","*"));

//Split
Console.WriteLine(instance.Split(' ')[1]);

//Substring
Console.WriteLine(instance.Substring(4));
Console.WriteLine(instance.Substring(4,6));