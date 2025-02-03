namespace EmployeeDetails
{
    class Employee
    {
        private string name;
        private int age;
        private int id;
        private int salary;
        public string Name
        {
            get {return name; }
            set{ name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public void displayDetails()
        {
            Console.WriteLine("Employee name:" + name);
            Console.WriteLine("Employee age:" + age);
            Console.WriteLine("Employee id:" + id);
            Console.WriteLine("Employee salary:" + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp=new Employee();
            Console.WriteLine("Enter Employee name:");
            emp.Name = Console.ReadLine();
            Console.WriteLine("Enter Employee age:");
            emp.Age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee id:");
            emp.Id= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee salary:");
            emp.Salary=Convert.ToInt32(Console.ReadLine());
            emp.displayDetails();
        }
    }
}
