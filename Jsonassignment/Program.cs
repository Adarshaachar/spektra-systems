using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Jsonassignment
{
    class product
    {
        public int PId;
        public string PName;
        public int Price;
        public int Quantity;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<product> products = new List<product>();
            Console.WriteLine("Enter number of product to be added:");
            int n=Convert.ToInt32(Console.ReadLine());  
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Details of "+(i+1)+" Product");
                Console.Write("Enter the product Id:");
                int id= Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter product Name:"); ;
                string name= Console.ReadLine();
                Console.Write("Enter the price of product:");
                int price= Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Quantity:");
                int quantity= Convert.ToInt32(Console.ReadLine());  
                products.Add( new product { PId = id,PName=name, Price = price, Quantity = quantity });
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Product details");
            string json=JsonConvert.SerializeObject(products,Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
