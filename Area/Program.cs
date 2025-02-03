namespace Area
{
    abstract class AreaFind
    {
        public abstract double Area(double a);
        public abstract int Area(int a);
        public abstract double Area(int b,int h);
    }
    class FindArea : AreaFind
    {
        public override double Area(double r)
        {
            return r * r * 3.142;
            
        }
        public override int Area(int a)

        {
            return a *a;
        }
        public override double  Area(int b,int h)
        {
            return 0.5*b*h;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FindArea obj = new FindArea();
            Console.WriteLine("Enter radius of circle:");
            double r=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area of circle :"+obj.Area(r));
            Console.WriteLine("Enter side of Square:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of Square:"+obj.Area(a));
            Console.WriteLine("Enter the base and height of triangle:");
            int b = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of triangle is:"+obj.Area(b,h));
        }
    }
}
