using System.ComponentModel;
using System.Dynamic;

namespace cordinate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the value of x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(findCordinate(x, y));
        }
        static string findCordinate(int x, int y)
        {
            if (x == 0 && y == 0)
                {
                    return "point lies on center";
                }
            else if (x==0)
            {
                return "points lies on x-axis";

            }
            else if (y == 0)
            {
                return "points lies  on y-axis";

            }
            else if (x > 0 && y > 0)
                {
                    return "points lies in first co ordinate";
                }
                else if (x < 0 && y > 0)
                {
                    return "points lies in second co ordinate";

            }
            else if (x < 0 && y < 0)
            {
                return "points lies in third co ordinate";

            }
            else 
            {
                return "points lies in fourth co ordinate";

            }

        }
    }
 }

