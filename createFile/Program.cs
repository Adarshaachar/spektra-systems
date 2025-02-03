namespace createFile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string filePath = @"C:\Users\Adarsh\OneDrive\Desktop\program2.txt";
                if (!File.Exists(filePath))
                {
                     File.CreateText(filePath);
                     Console.WriteLine("File created successfully.");
                }
                else
                {
                    Console.WriteLine("File already exists.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

 }

