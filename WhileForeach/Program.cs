//While
//A programme that calculating the average of the numbers of 1 to value which is getting by the console. (Including the entered number)

Console.WriteLine("Please enter a number: ");
int number = int.Parse(Console.ReadLine());
int counter = 1;
int result = 0;

while (counter <= number)
{
    result += counter;
    counter++;
}

Console.WriteLine(result / number);

//Write all the letter from 'a' to 'z' to the console.

char character = 'a';
while (character<='z')
{
    Console.WriteLine(character);
    character++;
}

Console.WriteLine("***** Foreach *****");

string[] cars = { "BMW", "Ford", "Toyota", "Nissan" };

foreach (var car in cars)
{
    Console.WriteLine(car);
}