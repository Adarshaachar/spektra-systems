namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of member in List:");

            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 40));
            List<int> list = new List<int>();
           
            for (int i = 0; i < n; i++)
            {
                Console.Write("Member "+i+" :");
                int k = Convert.ToInt32(Console.ReadLine());
                list.Add(k);
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 40));
            Console.Write("Input the value above which you want to display the members of the List : ");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 40));
            Console.WriteLine();
            var v = from num in list
                    where num >= key
                    select num;
            Console.WriteLine("Number greater than "+key+" value:");
            foreach(var a in v)
            {
                Console.WriteLine(a);
            }

        }
    }
}
