namespace TwoList
{
    class student
    {
        public string name;
        public int age;
    }
    class Class
    {
        public string name;
        public string subject;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<student> students = new List<student>
           {
               new student {name="kiran",age=22},
               new student {name="naveen",age=21},
               new student {name="akhi",age=17},
               new student {name="adarsha",age=19},
               new student {name="bhargav",age=15},
               new student {name="brunda",age=16}
           };
            List<Class> classes = new List<Class>
            {
                new Class {name="kiran",subject="Math"},
                new Class {name="naveen",subject="CS"},
                new Class {name="akhi",subject="ML"},
                new Class {name="adarsha", subject="Fullstack"},
                new Class {name="bhargav",subject="Math"},
                new Class {name="brunda",subject="CS"}
            };
            var query = from student in students 
                        where student.age > 18
                        join classes_ in classes on student.name equals classes_.name 
                        select new { student.name, classes_.subject}; 
            Console.WriteLine("students whose age are above 18");
            foreach(var names in query)
            {
                Console.WriteLine(names.name+" "+names.subject);
            }
           
        }
    }
}
