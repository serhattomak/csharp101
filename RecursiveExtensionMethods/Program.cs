//Recursive - Self repeat
//3^4 = 3*3*3*3

int result = 1;
for (int i = 1; i < 5; i++)
    result = result * 3;
Console.WriteLine(result);

Operation instance = new();
Console.WriteLine(instance.Expo(3, 4));

//Extension Methods
string phrase = "Serhat Tomak";
bool result1 = phrase.CheckSpaces();
Console.WriteLine(result1);
if (result1)
    Console.WriteLine(phrase.RemoveWhiteSpaces());
Console.WriteLine(phrase.MakeUpperCase());
Console.WriteLine(phrase.MakeLowerCase());

int[] numberArray = { 9, 3, 6, 2, 1, 5, 0 };
numberArray.SortArray();
numberArray.Print();

int number = 5;
Console.WriteLine(number.IsEven());

Console.WriteLine(phrase.GetFirstCharacter());

public class Operation
{
    public int Expo(int number, int power)
    {
        if (power < 2)
            return number;
        return Expo(number, power - 1) * number;
    }
    //Expo(3,4)
    //Expo(3,3)*3;
    //Expo(3,2)*3*3;
    //Expo(3,1)*3*3*3;
    //3*3*3*3=3^4;
}

public static class Extension
{
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }

    public static string RemoveWhiteSpaces(this string param)
    {
        string[] array = param.Split(' ');
        return string.Join("*", array);
    }

    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }
    public static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }
    public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }

    public static void Print(this int[] param)
    {
        foreach (int item in param)
        {
            Console.WriteLine(item);
        }
    }
    
    public static bool IsEven(this int param)
    {
        return param % 2 == 0;
    }

    public static string GetFirstCharacter(this string param)
    {
        return param.Substring(0, 1);
    }
}