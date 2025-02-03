using System.IO;
namespace filerename
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string originalFilePath = @"C:\Users\Adarsh\OneDrive\Desktop\program.txt";
            string destination = @"C:\Users\Adarsh\OneDrive\Desktop";
            string newFileName = "Copy.txt";
            string dstFile = Path.Combine(destination, newFileName);
            string renameFile = Path.Combine(destination, "renameFile.txt");
            try
            {
                if (File.Exists(originalFilePath))
                {
                    Console.WriteLine("Source file exists.");
                    Console.WriteLine("Enter text to fill in the file");
                    string str = Console.ReadLine();
                    StreamWriter write = new StreamWriter(originalFilePath, append: true);
                    write.WriteLine(str);
                    write.Close();
                    File.Copy(originalFilePath, dstFile);
                    Console.WriteLine("File copied successfully.");
                    File.Move(dstFile, renameFile);
                    Console.WriteLine("File renamed successfully.");
                    Console.WriteLine("The Content inside the new renamed file : " + File.ReadAllText(renameFile));
                }
                else
                {
                    Console.WriteLine("Source file does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}