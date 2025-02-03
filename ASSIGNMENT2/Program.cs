using System.Data.SqlClient;

namespace ASSIGNMENT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           SqlConnection con= null;
            try
            {
                con = new SqlConnection("data source=ADARSHA\\SQLEXPRESS;database=AdventureWorks2019;integrated security=SSPI");
                SqlCommand comm = new SqlCommand(@"SELECT DISTINCT CONCAT(A.FirstName,' ',A.MiddleName,' ',A.LastName) AS Employee_name from Person.Person A
                                                   JOIN Sales.SalesOrderHeader B ON A.BusinessEntityID=B.SalesPersonID
                                                   JOIN Sales.SalesOrderDetail C ON B.SalesOrderId=c.SalesOrderId
                                                   JOIN Production.Product D ON C.productID=D.productID
                                                   WHERE D.ProductNumber='BK-M18S-40'", con);
                con.Open();
               SqlDataReader read=comm.ExecuteReader();
                while (read.Read()) {
                    Console.WriteLine(read["Employee_name"]);                
                }

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }finally
            {
                if (con != null) con.Close();
            }
        }
    }
}
