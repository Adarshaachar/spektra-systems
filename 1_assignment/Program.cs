namespace _1_assignment
{
    public class Employee
    {
        public string Ename;
        public string EID;
        public Employee(string name,string id) {
            Ename = name;
            EID = id;

        }
    }
    public class SalesAssociate : Employee
    {
        private int sales;
        public SalesAssociate(string name,string id):base (name,id) {
                sales = 0;
        }
        public void NumberOfSales(int monthlySales)
        {
            sales=monthlySales;
        }
        public double SalesBonus()
        {
            double bonus = 0;
            if (sales > 30)
            {
                bonus = 0.20;
            }else if(sales > 20)
            {
                bonus = 0.10;
            }else if(sales > 10)
            {
                bonus = 0.05;
            }
          return  bonus * sales;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sales person name:");
            string name=Console.ReadLine();
            Console.WriteLine("Enter sales person id:");
            string id=Console.ReadLine();   
            SalesAssociate s = new SalesAssociate(name, id);
            Console.WriteLine("Enter number of sales done:");
            int n=Convert.ToInt32(Console.ReadLine());
            s.NumberOfSales(n);
            Console.WriteLine(s.Ename + " earn a sales bonus of amount=" + s.SalesBonus());
        }
    }
}
