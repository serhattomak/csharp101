﻿int time = DateTime.Now.Hour;

if (time >= 6 && time < 11)
    Console.WriteLine("Good Morning!");
else if (time <= 18)
    Console.WriteLine("Have a nice day!");
else
    Console.WriteLine("Good Night!");

string result = time <= 18 ? "Have a nice day!" : "Good Night!";

result = time >= 6 && time < 11 ? "Good Morning!" : time <=18 ? "Have a good day!" : "Good Night!";
Console.WriteLine(result);
