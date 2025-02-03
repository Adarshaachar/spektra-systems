namespace freequencyOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] a= new int[n];
            Console.WriteLine("enter array element:");

            for(int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(a);
            int count = 1;
            for(int i = 1; i < n; i++)
            {
                if (a[i] == a[i - 1])
                {

                    count++;

                }
                else
                {
                    Console.WriteLine(a[i - 1] + " repeated : " + count);
                    count = 1;
                }

            }
            Console.WriteLine(a[n - 1] + " repeated : " + count);
        }
    }
}
