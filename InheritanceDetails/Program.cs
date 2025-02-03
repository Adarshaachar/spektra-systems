namespace InheritanceDetails
{
    public class Teacher
    {
        public string Name;
        public int Age;
        public string Address;

        public Teacher(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        public void DisplayTeacher()
        {
            Console.WriteLine("Teacher Details:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Address: " + Address);
        }
    }

    public class Student : Teacher
    {
        public string StudentName;
        public int StudentAge;
        public string StudentAddress;

        public Student(string name, int age, string address, string studentName, int studentAge, string studentAddress) : base(name, age, address)
        {
            StudentName = studentName;
            StudentAge = studentAge;
            StudentAddress = studentAddress;
        }

        public void DisplayStudent()
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine("Name: " + StudentName);
            Console.WriteLine("Age: " + StudentAge);
            Console.WriteLine("Address: " + StudentAddress);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           
            Student obj= new Student("Bhargav",33,"Shivamogga","Adarsha",22,"bengaluru");
            Teacher obj1 = new Teacher("Bhargav", 33, "Shivamogga");
            obj.DisplayStudent();
            Console.WriteLine();
            obj1.DisplayTeacher();
           

        }
    }
}
