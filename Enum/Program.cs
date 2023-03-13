Console.WriteLine(Days.Sunday);
Console.WriteLine((int)Days.Saturday);

int temperature = 32;

if (temperature<=(int)Weather.Normal)
{
    Console.WriteLine("We can wait a bit to go outside.");
}
else if (temperature>=(int)Weather.Hot)
{
    Console.WriteLine("It is very hot to go outside. ");
}
else if (temperature>=(int)Weather.Normal&&temperature<(int)Weather.VeryHot)
{
    Console.WriteLine("Let's go outside!");
}

enum Days
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday = 23,
    Saturday,
    Sunday
}

enum Weather
{
    Cold=5,
    Normal=20,
    Hot=25,
    VeryHot=30
}