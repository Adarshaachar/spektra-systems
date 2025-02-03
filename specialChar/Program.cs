

using System.Text.RegularExpressions;

namespace specialChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str=Console.ReadLine();
            Console.WriteLine("Updated string:"+updateString(str));
        }
        static string updateString(string str)
        {
            string exp = "[^a-zA-Z0-9_ -]";
            string newstr = Regex.Replace(str, exp, "");
            return newstr;
        }
    }
}
