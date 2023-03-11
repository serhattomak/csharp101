//Classes
// class ClassName
// {
//      [Access Modifier] [Value Type] SpecName;
//      [Access Modifier] [Return Type] Method Name([Parameter List])
//      {
//      //Method Commands
//      }

// Access Modifiers
// * Public
// * Private
// * Internal
// * Protected
Console.WriteLine("***** Worker 1 *****");
Worker worker1 = new Worker("Ayşe","Kara",23425634,"HR");
worker1.WorkerInfo();

Console.WriteLine("***** Worker 2 *****");
Worker worker2 = new Worker();
worker2.Name = "Deniz";
worker2.Surname = "Arda";
worker2.No = 25646789;
worker2.Department = "Sales Department";
worker2.WorkerInfo();

Console.WriteLine("***** Worker 3 *****");
Worker worker3 = new Worker("Serhat", "Tomak");
worker3.WorkerInfo();

class Worker
{
    public string Name;
    public string Surname;
    public int No;
    public string Department;

    public Worker(string name, string surname, int no, string department)
    {
        Name = name;
        Surname = surname;
        No = no;
        Department = department;
    }
    public Worker(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

    public Worker(){}

    public void WorkerInfo()
    {
        Console.WriteLine("Worker's name: {0}", Name);
        Console.WriteLine("Worker's surname: {0}", Surname);
        Console.WriteLine("Worker's number: {0}", No);
        Console.WriteLine("Worker's department: {0}", Department);
    }
}