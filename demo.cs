using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ado.net_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=rithikaVM;Initial Catalog=Employee;Integrated Security=True");



            SqlCommand cmd = new SqlCommand("Select * from Employee", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();



            while (dr.Read())
            {
                string EmpID = dr["EmpID"].ToString();
                string FirstName = dr["FirstName"].ToString();
                string LastName = dr["LastName"].ToString();
                string Salary = dr["Salary"].ToString();
                Console.WriteLine(EmpID + " " + FirstName + " " + LastName + " " + Salary);
            }



            dr.Close();



            conn.Close();
            Console.ReadLine();
        }
    }
}