namespace char4Name
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
                new Employee {Name="Div",Id=105,Dept="HR",Salary=900},
                new Employee {Name="xyz",Id=104,Dept="Developer",Salary=800},
                new Employee {Name="abc",Id=104,Dept="Developer",Salary=700},
                new Employee {Name="sut",Id=104,Dept="Developer",Salary=900},
            };
            var query = from i in employees 
                        where i.Name.Length < 4
                        select i;
            foreach(var v in query)
            {
                Console.WriteLine(v.Name);
            }
        }
    }
}
