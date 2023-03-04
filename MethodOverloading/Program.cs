// Out Paramters
string number = "999";

bool result = int.TryParse(number, out int outNumber);
if (result)
{
    Console.WriteLine("Successful!");
    Console.WriteLine(outNumber);
}
else
{
    Console.WriteLine("Unsuccessful!");
}

Methods instance = new Methods();
instance.Sum(4, 5, out int sumResult);
Console.WriteLine(sumResult);

//Method Overloading

int phrase = 999;
instance.Print(Convert.ToString(phrase));
instance.Print(phrase);
instance.Print("Serhat", "Tomak");

// Method Signature
// methodName + number of parameters + parameter

class Methods
{
    public void Sum(int a, int b, out int sum)
    {
        sum = a + b;
    }
    public void Print(string data)
    {
        Console.WriteLine(data);
    }
    public void Print(int data)
    {
        Console.WriteLine(data);
    }
    public void Print(string data1, string data2)
    {
        Console.WriteLine(data1+data2);
    }
}