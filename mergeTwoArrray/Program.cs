
namespace mergeTwoArrray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            Console.WriteLine("enter first array element:");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("enter second array element:");
            for (int i = 0; i < n; i++)
            {
                b[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] mergedArray = a.Concat(b).ToArray();
            Array.Sort(mergedArray);
            Console.WriteLine("merged array in sorted order:");
            foreach (int i in mergedArray)
            {
                Console.Write(i + " ");
            }
        }
    }
}
