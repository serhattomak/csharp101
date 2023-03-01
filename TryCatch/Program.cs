try
{
    Console.WriteLine("Enter a number:");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Number:" + sayi);
}
catch (Exception ex)
{
    Console.WriteLine("Hata:" + ex.Message.ToString());
    throw;
}
//finally
//{
//    Console.WriteLine("Process completed.");
//}

try
{
    //int a = int.Parse(null);
    //int a=int.Parse("test");
    int a = int.Parse("-20000000000");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("The value is empty.");
    Console.WriteLine(ex);
}
catch(FormatException ex)
{
    Console.WriteLine("Value type is not valid");
    Console.WriteLine(ex);
}
catch(OverflowException ex)
{
    Console.WriteLine("You've entered too small or too large value.");
    Console.WriteLine(ex);
}
finally
{
    Console.WriteLine("Process completed successfully.");
}

