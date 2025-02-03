namespace GenricList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>();
            Console.WriteLine("Enter size of list:");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter List element:");
            for(int i = 0; i < n; i++)
            {
                mylist.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Accessing using for loop:");
            for(int i = 0;i < mylist.Count; i++)
            {
                Console.WriteLine(mylist[i]);
            }
            Console.WriteLine("Accessing using for each loop:");
           foreach(int k in mylist)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("Accessing using index:");
            Console.WriteLine(mylist[0]);
            Console.WriteLine(mylist[1]);
            Console.WriteLine(mylist[2]);
        }
    }
}
