using System.Data.SqlClient;

namespace ASSIGNMENT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("data source=ADARSHA\\SQLEXPRESS;database=AdventureWorks2019;Integrated Security=SSPI");
                SqlCommand comm = new SqlCommand("CREATE TABLE MYTABLE3(Id INT PRIMARY KEY,Name VARCHAR(100),Email VARCHAR(50))", conn);
                conn.Open();
                comm.ExecuteNonQuery();
                Console.WriteLine("Table Created Successfully");
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }finally
            {
                conn.Close();
            }
        }
    }
}
