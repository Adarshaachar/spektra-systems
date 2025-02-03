namespace OddAndEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] a= new int[n];    
            Console.WriteLine("Enter array element:");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int oddSize = 0;
            int evenSize = 0;
            for(int i = 0;i < n;i++)
            {
                if (a[i]%2 != 0) {
                oddSize++;
                }
                else
                {
                    evenSize++;
                }
            }
            int[] b= new int[oddSize];
            int[] c= new int[evenSize];
            oddSize = 0;
            evenSize = 0;
            for(int i = 0;i<n ; i++)
            {
                if (a[i] % 2 != 0)
                {

                    b[oddSize] = a[i];
                    oddSize++;
                }
                else
                {
                    c[evenSize]= a[i];
                    evenSize++;
                }
            }
            Console.WriteLine("Odd aray:");
            foreach(int i in b)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\nEven array:");
            foreach (int i in c)
            {
                Console.Write(i+" ");
            }
        }
    }
}
