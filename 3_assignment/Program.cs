namespace _3_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of item");
            int n=Convert.ToInt32(Console.ReadLine());
            List<string> items = new List<string>();
            Console.WriteLine("Enter the list item:");
            for(int i=0; i<n; i++) { 
                string k=Console.ReadLine();
                items.Add(k);
            }
            Action<List<string>> printList = (list) =>
            {
                Console.WriteLine("List of items:");
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            };
            printList(items);
        }
    }
}
