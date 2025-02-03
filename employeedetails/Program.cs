namespace employeedetails
{
    class employee
    {
        private string name,jobId,department,location,gender;
        public employee(string name, string jobId, string department, string location, string gender)
        {
            this.name = name;
            this.jobId = jobId;
            this.department = department;
            this.location = location;
            this.gender = gender;
        }
        public string this[string fieldName]
        {
            get
            {
                switch (fieldName)
                {
                    case "name": return name;
                    case "jobid": return jobId;
                    case "department": return department;
                    case "location": return location;
                    case "gender": return gender; 
                    default: return "Invalid field name."; 
                }
            }
            set
            {
                switch (fieldName)
                {
                    case "name": name = value;break;
                    case "jobid": jobId = value; break;
                    case "department": department = value; break;
                    case "location": location = value; break;
                    case "gender": gender = value; break;
                    default: throw new ArgumentException("Invalid field name.");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee details ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Job ID: ");
            string jobId = Console.ReadLine();
            Console.Write("Department: ");
            string department = Console.ReadLine();
            Console.Write("Location: ");
            string location = Console.ReadLine();
            Console.Write("Gender: ");
            string gender = Console.ReadLine();
            employee emp = new employee(name, jobId, department, location, gender);
            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine("Name: " + emp["name"]);
            Console.WriteLine("Job ID: " + emp["jobid"]);
            Console.WriteLine("Department: " + emp["department"]);
            Console.WriteLine("Location: " + emp["location"]);
            Console.WriteLine("Gender: " + emp["gender"]);
        }
    }
}
   