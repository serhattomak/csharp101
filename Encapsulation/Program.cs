Student student = new Student();
student.Name = "Serhat";
student.Surname = "Tomak";
student.StudentNo = 751;
student.StudentClass = 3;

student.GetStudentInfo();
student.SkipClass();
student.GetStudentInfo();

Student student2 = new Student("Deniz","Arda",256,1);
student2.ReduceClass();
student2.ReduceClass();
student2.GetStudentInfo();

class Student
{
    private string name;
    private string surname;
    private int studentNo;
    private int studentClass;

    public string Name { get => name; set => name = value; }

    public string Surname { get => surname; set => surname = value; }

    public int StudentNo { get => studentNo; set => studentNo = value; }

    public int StudentClass
    {
        get => studentClass;
        set
        {
            if (value < 1)
            {
                Console.WriteLine("Student's class must be 1 at minimum.");
                studentClass = 1;
            }
            else
            {
                studentClass = value;
            }
        }
    }

    public Student(string name, string surname, int studentNo, int studentClass)
    {
        Name = name;
        Surname = surname;
        StudentNo = studentNo;
        StudentClass = studentClass;
    }

    public Student() { }

    public void GetStudentInfo()
    {
        Console.WriteLine("***** Student Info *****");
        Console.WriteLine("Student Name          :{0}", this.Name);
        Console.WriteLine("Student Surname       :{0}", this.Surname);
        Console.WriteLine("Student Number        :{0}", this.StudentNo);
        Console.WriteLine("Student's Class       :{0}", this.StudentClass);
    }

    public void SkipClass()
    {
        this.StudentClass = this.StudentClass + 1;
    }

    public void ReduceClass()
    {
        this.StudentClass = this.studentClass - 1;
    }
}
