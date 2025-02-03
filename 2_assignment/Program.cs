namespace _2_assignment
{
    public delegate double Calculator(double a, double b);
    public class calculate
    {
        public static double add(double a, double b)
        {
            return a + b;
        }
        public static double subtract(double a, double b)
        {
            return a - b;
        }
        public static double multiply(double a, double b) { 
        return a * b;
        }
        public static double divide(double a, double b) 
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Cannot be divisible by zero");
                return 0;
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c = null;
            Console.WriteLine("Enter the value of a:");
            double a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of b:");
            double b=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("select one operation \n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
            int k=Convert.ToInt32(Console.ReadLine());

            switch(k)
            {
                case 1:
                    c = calculate.add;
                    break;
                case 2:
                    c = calculate.subtract;
                    break;
                case 3:
                    c = calculate.multiply;
                    break;
                case 4:
                    c = calculate.divide;
                    break;
                default:Console.WriteLine("Invalid operation.");
                    return;

            }
            double result = c(a, b);
            Console.WriteLine("result="+result);
           
        }
    }
}
