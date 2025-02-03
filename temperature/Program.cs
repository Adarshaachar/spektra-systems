namespace temperature
{
    class TempCannotBeZeroException : Exception
    {
        public TempCannotBeZeroException(string message) : base(message)
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current temperature:");
            int temp=Convert.ToInt32(Console.ReadLine());
            try
            {
                if (temp == 0) {
                    throw new TempCannotBeZeroException("temperature cannot be zero");
                }
                Console.WriteLine("temperature is:" + temp);
            }
            catch (TempCannotBeZeroException e){
                Console.WriteLine(e.GetType()+":"+e.Message);
            }
            
        }
    }
}
