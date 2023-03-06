//First Task
Console.WriteLine("***** Checking the Even Numbers in Given Numbers *****");
CheckPositive:
Console.WriteLine("Please enter the dimension of numbers: ");
int number;

bool controllednumber;
do
{
    Console.WriteLine("Please enter a positive number: ");
    number = int.Parse(Console.ReadLine());
    controllednumber = Control(number);

} while (!controllednumber);


int[] numbers = new int[number];
int evenNumbers = 0;
int posNumber;


for (int i = 0; i < number; i++)
{
    Console.WriteLine("Enter the number {0}", i);
    do
    {
        Console.WriteLine("Please enter a positive number: ");
        posNumber = int.Parse(Console.ReadLine());
        controllednumber = Control(posNumber);

    } while (!controllednumber);
    numbers[i] = posNumber;
}

Console.WriteLine("**********");
for (int i = 0; i < number; i++)
{
    if (numbers[i] % 2 == 0)
    {
        evenNumbers++;
        Console.WriteLine("{0} is an even number.", numbers[i]);
    }
}
if (evenNumbers == 0)
    Console.WriteLine("There are no even numbers.");

//Second Task

Console.WriteLine("***** Checking the Divisors in Given Numbers *****");
Console.WriteLine("Enter the first parameter: ");
int number2;

do
{
    Console.WriteLine("Please enter a positive number: ");
    number2 = int.Parse(Console.ReadLine());
    controllednumber = Control(number2);
} while (!controllednumber);

int[] divisorNumbers = new int[number2];
int divisor = 0;
int posNumber2;

for (int i = 0; i < number2; i++)
{

    Console.WriteLine("Enter the number {0}", i);
    do
    {
        Console.WriteLine("Please enter a positive number: ");
        posNumber2 = int.Parse(Console.ReadLine());
        controllednumber = Control(posNumber2);

    } while (!controllednumber);
    divisorNumbers[i] = posNumber2;
}

Console.WriteLine("**********");
for (int i = 0; i < number2; i++)
{
    if (divisorNumbers[i] == number2 || divisorNumbers[i] % number2 == 0 || divisorNumbers[i] % number2 == 1)
    {
        divisor++;
        Console.WriteLine("{0} is a divisor of {1}.", divisorNumbers[i], number2);
    }
}
if (divisor == 0)
    Console.WriteLine("There is no divisor.");

Console.WriteLine("**********");
//Third Task

Console.WriteLine("***** Sorting the Given Words *****");
Console.WriteLine("Please enter the number of words: ");
int number3;

do
{
    Console.WriteLine("Please enter a positive number: ");
    number3 = int.Parse(Console.ReadLine());
    controllednumber = Control(number3);

} while (!controllednumber);

string[] givenWords = new string[number3];
string word;

for (int i = 0; i < number3; i++)
{
    Console.WriteLine("Enter the word {0}", i);
    word = Console.ReadLine();
    givenWords[i] = word;
}

Console.WriteLine("Word/Words: ");
Array.Reverse(givenWords);
foreach (var words in givenWords)
{
    Console.WriteLine(words);
}

Console.WriteLine("**********");
//Fourth Task
Console.WriteLine("***** Printing the Number of Words and Letters in Sentence *****");
Console.WriteLine("Please enter a sentence: ");
string sentence = Console.ReadLine();

int wordCounter = sentence != null ? sentence.Split(' ').Length : 0;
int letterCounter = sentence != null ? sentence.Replace(".", "").Replace(",","").Replace(" ","").Length : 0;

Console.WriteLine("The sentence has {0} letter/letters.",letterCounter);
Console.WriteLine("The sentence has {0} word/words.",wordCounter);


bool Control(double number)
{
    if (number > 0)
    {
        return true;
    }
    return false;
}