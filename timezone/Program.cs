
namespace timezone
{
     class Program
    {
        static void Main(string[] args)
        {
            TimeZoneInfo timezone = TimeZoneInfo.Local;
           
            Console.WriteLine("Current time zone:"+ timezone.DisplayName);
        }
    }
}
