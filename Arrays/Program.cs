string[] colors = new string[5];

string[] animals = { "Cat", "Dog", "Bird", "Monkey" };

int[] array;
array=new int[5];

//Value assignments to the arrays

colors[0] = "Blue";
array[3] = 10;

Console.WriteLine(array[3]);
Console.WriteLine(animals[1]);
Console.WriteLine(colors[0]);

//Using loops with arrays
//Calculating the average of the values entered with the keyboard
Console.WriteLine("Please enter the dimension of the array: ");
int dimension = int.Parse(Console.ReadLine());
int[] numberArray = new int[dimension];

for (int i = 0;i < dimension; i++)
{
    Console.Write("Please enter the next number ({0}): ", i+1);
    numberArray[i] = int.Parse(Console.ReadLine());
}

int result = 0;
foreach (var number in numberArray)
{
    result += number;
}
Console.WriteLine("Average: " + result / dimension);