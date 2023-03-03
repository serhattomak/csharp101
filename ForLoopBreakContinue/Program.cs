
//Write the numbers one by one until the entered number.
Console.WriteLine("Please enter a number:");
int counter =int.Parse(Console.ReadLine());
Console.WriteLine("*****");

for (int i = 1; i <= counter; i++)
{
	if (i%2==1)
		Console.WriteLine(i);
    //commands
}

//Sum the even and odd numbers between 1 and 1000 then print them to console.
int oddSum = 0;
int evenSum = 0;
for (int i = 1; i <= 1000; i++)
{
	if (i % 2 == 1)
		oddSum += i; //oddSum = oddSum + i;
	else
		evenSum += i; //evenSum = evenSum + i;
}
Console.WriteLine("Odd Sum:" + oddSum);
Console.WriteLine("Even Sum:"+evenSum);

//break, continue

for (int i = 1; i < 10; i++)
{
	if (i == 4)
		break;
	Console.WriteLine(i);
}

for (int i = 1; i < 10; i++)
{
    if (i == 4)
        continue;
    Console.WriteLine(i);
}