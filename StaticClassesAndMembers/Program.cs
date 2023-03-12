Console.WriteLine("Number of Workers: {0}", Worker.WorkerNumber);

Worker worker = new Worker("Ayşe","Yılmaz","HR");
Console.WriteLine("Number of Workers: {0}", Worker.WorkerNumber);
Worker worker2 = new Worker("Deniz","Arda","HR");
Worker worker3 = new Worker("Serhat","Tomak","HR");
Console.WriteLine("Number of Workers: {0}", Worker.WorkerNumber);

Console.WriteLine("Result: {0}", Operations.Sum(100, 200));
Console.WriteLine("Result: {0}", Operations.Extract(400, 50));

class Worker
{
    private static int workerNumber;

    public static int WorkerNumber { get => workerNumber; }

    private string Name;
    private string Surname;
    private string Department;

    static Worker()
    {
        workerNumber = 0;
    }

    public Worker(string name, string surname, string department)
    {
        this.Name = name;
        this.Surname = surname;
        this.Department = department;
        workerNumber++;
    }
}

static class Operations
{
    public static long Sum(int number1, int number2)
    {
        return number1 + number2;
    }

    public static long Extract(int number1, int number2)
    {
        return number1 - number2;
    }
}