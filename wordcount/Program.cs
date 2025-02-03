using System.ComponentModel;
namespace wordcount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string str = Console.ReadLine().Trim();
            int count = 0;
            if (str.Length > 0)
            {
                count++;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ' ')
                    {
                        count++;

                    }
                }
            }
            Console.WriteLine("number of words:"+count);

        }
    }
}
