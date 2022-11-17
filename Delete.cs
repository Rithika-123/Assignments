using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.net_demo
{
    internal class Delete
    {

        public static void Main()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=rithikaVM; Initial catalog=Employee; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);



            sqlConnection.Open();
            try
            {
                Console.WriteLine("enter the id value that u want to delete ");
                int EmpID = int.Parse(Console.ReadLine());



                string deletequery = "delete from Employee where EmpID=" + EmpID;
                SqlCommand deleteCommand = new SqlCommand(deletequery, sqlConnection);



                deleteCommand.ExecuteNonQuery();
                Console.WriteLine("deleted data successfully");
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
        