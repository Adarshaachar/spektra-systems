namespace filehandle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = "C:\\Users\\Adarsh\\OneDrive\\Desktop\\program.txt";
                if (File.Exists(path))
                {
                    Console.WriteLine("Enter text to fill in the file");
                    string str = Console.ReadLine();
                    StreamWriter write = new StreamWriter(path, append: true);
                    write.WriteLine(str);
                    write.Close();
                    StreamReader read = new StreamReader(path);
                    Console.WriteLine("Text file Content:");
                    string content;
                    while ((content = read.ReadLine()) != null)
                    {
                        Console.WriteLine(content);
                    }
                    read.Close();
                }       
                else
                {
                    Console.WriteLine("File does not exists");
                }
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
      
        }
    }
}
