using System.Data.SqlClient;

namespace ASSIGNMENT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con=null;
            try
            {
                con = new SqlConnection("Data Source =ADARSHA\\SQLEXPRESS; Initial Catalog = AdventureWorks2019; Integrated Security = SSPI");
                Console.WriteLine("ENTER ID to fetch the data");
                int id = Convert.ToInt32(Console.ReadLine());
                SqlCommand comm = new SqlCommand("EXEC ProductRankLocation @id;", con);
                comm.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader=comm.ExecuteReader();
                Console.WriteLine(new string('-', 100));
                Console.WriteLine($"|{"ProductID",-20}| {"Name",-25}| {"Quantity",20}| {"Ranking",-20}|");
                Console.WriteLine(new string('-', 100));
                while (reader.Read())
                {
                    Console.WriteLine($"|{reader["ProductID"],-20}| {reader["Name"],-25}| {reader["Quantity"],20}| {reader["Ranking"],-20 }|");
                }
                Console.WriteLine(new string('-', 100));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }finally
            {
                if (con != null) con.Close();
            }
        }
    }
}
