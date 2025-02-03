namespace checkSalary
{
    class Employee
    {
        public string Name;
        public int Id;
        public string Dept;
        public int Salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {Name="Kiran",Id=101,Dept="Developer",Salary=700},
                new Employee {Name="Bhargav",Id=102,Dept="Tester",Salary=500},
                new Employee {Name="Bhoomi",Id=103,Dept="HR",Salary=900},
                new Employee {Name="Adarsha",Id=104,Dept="Developer",Salary=700},
                new Employee {Name="Divya",Id=105,Dept="HR",Salary=900}
            };
            var salaryName=from empName in employees 
                           where (empName.Salary>=600 && empName.Salary<=800)
                           select empName.Name;
            Console.WriteLine("Employee having salary between 600 and 800");
            foreach(var names in salaryName)
            {
                Console.WriteLine(names);
            }
        }
    }
}
