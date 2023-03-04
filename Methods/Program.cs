//Methods
int a = 2;
int b = 3;

Console.WriteLine(a + b);

int result = Sum(a, b);
Console.WriteLine(result);

Methods example = new Methods();
example.Print(Convert.ToString(result));

int result2 = example.RaiseAndSum(ref a, ref b);
example.Print(Convert.ToString(result2));
example.Print(Convert.ToString(a + b));

static int Sum(int value1, int value2)
{
    return value1 + value2;
}

class Methods
{
    public void Print(string data)
    {
        Console.WriteLine(data);
    }

    public int RaiseAndSum(ref int value1, ref int value2)
    {
        value1 += 1;
        value2 += 1;
        return value1 + value2;
    }
}