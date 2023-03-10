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

Worker worker1 = new Worker();
worker1.Name = "Ayşe";
worker1.Surname = "Kara";
worker1.No = 23425634;
worker1.Department = "HR";
worker1.WorkerInfo();
Console.WriteLine("********************");
Worker worker2 = new Worker();
worker2.Name = "Deniz";
worker2.Surname = "Arda";
worker2.No = 25646789;
worker2.Department = "Sales Department";

worker2.WorkerInfo();

class Worker
{
    public string Name;
    public string Surname;
    public int No;
    public string Department;

    public void WorkerInfo()
    {
        Console.WriteLine("Worker's name: {0}", Name);
        Console.WriteLine("Worker's surname: {0}", Surname);
        Console.WriteLine("Worker's number: {0}", No);
        Console.WriteLine("Worker's department: {0}", Department);
    }
}