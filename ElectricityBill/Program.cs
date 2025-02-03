namespace ElectricityBill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter customer name:");
            string name=Console.ReadLine();
            Console.WriteLine("Enter Customer Id:");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the unit consued:");
            int unit=Convert.ToInt32(Console.ReadLine());
            double cost = unit * 4.5;
            Console.WriteLine("Customer bill details");
            Console.WriteLine("Customer name:"+name);
            Console.WriteLine("Customer Id:" + id);
            Console.WriteLine("Consumber Electricity in unit:" + unit);
            Console.WriteLine("Bill to be paid:" + cost+"rs");
        }
    }
}
