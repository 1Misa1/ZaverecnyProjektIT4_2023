using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaverecnyProjekt_IT4
{
    public class SqlRepository
    {
        private static string connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MainData;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public static SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            return conn;

        }

        public static List<Employee> EmployeeList()
        {
            SqlConnection conn = Connect();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Employees";
            SqlDataReader reader = cmd.ExecuteReader();
            List<Employee> employee = new List<Employee>();
            while (reader.Read())
            {
                employee.Add(new Employee(reader.GetInt32(0),reader.GetString(1),reader.GetString(2),reader.GetDateTime(3),reader.GetString(4),reader.GetString(5)));
            }
            reader.Close();
            conn.Close();
            return employee;
        }
    }
}

