using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZaverecnyProjekt_IT4.Classes;

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

        // čtení zaměstnanců z tabulky
        public static List<Employee> EmployeeList()
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Employees";
            SqlDataReader reader = cmd.ExecuteReader();
            List<Employee> employee = new List<Employee>();
            while (reader.Read())
            {
                employee.Add(new Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetString(4), reader.GetString(5)));
            }
            reader.Close();
            conn.Close();
            return employee;
        }

        // mazání zaměstnanců
        public static void DeleteEmployeebyId(int id)
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Employees WHERE Id=@id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // přidávání zaměstnanců
        public static void AddEmployee(Employee employee)
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Employees (FirstName, LastName, BirthDate, Email, PhoneNumber) VALUES (@firstname, @lastname, @birthdate, @email, @phonenumber)";
            cmd.Parameters.AddWithValue("firstname", employee.FirstName);
            cmd.Parameters.AddWithValue("lastname", employee.LastName);
            cmd.Parameters.AddWithValue("birthdate", employee.BirthDate);
            cmd.Parameters.AddWithValue("email", employee.Email);
            cmd.Parameters.AddWithValue("phonenumber", employee.PhoneNumber);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // editace zaměstnanců
        public static void EditEmployee(int id, Employee employee)
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Employees SET FirstName=@firstname, LastName=@lastname, BirthDate=@birthdate, Email=@email, PhoneNumber=@phonenumber WHERE id=@id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("firstname", employee.FirstName);
            cmd.Parameters.AddWithValue("lastname", employee.LastName);
            cmd.Parameters.AddWithValue("birthdate", employee.BirthDate);
            cmd.Parameters.AddWithValue("email", employee.Email);
            cmd.Parameters.AddWithValue("phonenumber", employee.PhoneNumber);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // čtení contractu z tabulky
        public static List<Contract> ContractList()
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Contract";
            SqlDataReader reader = cmd.ExecuteReader();
            List<Contract> contracts = new List<Contract>();
            while (reader.Read())
            {
                contracts.Add(new Contract(reader.GetInt32(0),reader.GetString(1), reader.GetString(2)));
            }
            reader.Close();
            conn.Close();
            return contracts;
        }

        // přidávání do contactu 
        public static void AddContract(Contract contract)
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Contract (Customer, Description) VALUES (@customer, @description)";
            cmd.Parameters.AddWithValue("customer", contract.Customer);
            cmd.Parameters.AddWithValue("description", contract.Description);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // editování contractu
        public static void EditContract(int id, Contract contract)
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Contract SET Customer=@customer, Description=@description WHERE id=@id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("customer", contract.Customer);
            cmd.Parameters.AddWithValue("description", contract.Description);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //mazání contractu
        public static void DeleteContractbyId(int id)
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Contract WHERE Id=@id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // načtení dat z worktypes tabulky 
        public static List<WorkType> WorktypeList()

        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Worktypes";
            SqlDataReader reader = cmd.ExecuteReader();
            List<WorkType> worktype = new List<WorkType>();
            while (reader.Read())
            {
                worktype.Add(new WorkType(reader.GetInt32(0),reader.GetString(1), reader.GetString(2)));
            }
            reader.Close();
            conn.Close();
            return worktype;
        }

        // přidávíní do tabulky worktype
        public static void AddWorktype(WorkType worktype)
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Worktypes (Name, Description) VALUES (@name, @description)";
            cmd.Parameters.AddWithValue("name", worktype.Name);
            cmd.Parameters.AddWithValue("description", worktype.Description);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // editování v tabulce worktype
        public static void EditWorktype(int id, WorkType worktype)
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Worktypes SET Name=@name, Description=@description WHERE id=@id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("name", worktype.Name);
            cmd.Parameters.AddWithValue("description", worktype.Description);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // mazání z tabulky worktype
        public static void DeleteWorktypebyId(int id)
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Worktypes WHERE Id=@id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static List<WorkHours> WorkhoursList()
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "";
            SqlDataReader reader = cmd.ExecuteReader();
            List<WorkHours> workhours = new List<WorkHours>();
            while (reader.Read())
            {
                //workhours.Add(new WorkHours(reader.GetInt32(0),reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4),reader.GetDateTime(5), reader.GetInt32(6));
            }
            reader.Close();
            conn.Close();
            return workhours;
        }

        public static List<User> UsersList()
        {
            List<User> users = new List<User>();
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM [User]";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                users.Add(new User(reader.GetInt32(0), reader.GetString(1), GetRoleByID(reader.GetInt32(4))));
            }
            reader.Close();
            conn.Close();
            return users;
        }

        public static void AddUser(string name, string password, int roleid)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            HMACSHA512 hmac = new HMACSHA512();
            cmd.CommandText = "INSERT INTO [User] (name,passwordhash,passwordsalt,role) VALUES (@name,@hash,@salt,@role)";
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("hash", hmac.ComputeHash(Encoding.UTF8.GetBytes(password)));
            cmd.Parameters.AddWithValue("salt", hmac.Key);
            cmd.Parameters.AddWithValue("role", roleid);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void EditUser(int id, User user)
        {
            
        }

        public static void DeleteUserbyId(int id)
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM [User] WHERE Id=@id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void ChangePassword(int id, string newpassword)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            HMACSHA512 hmac = new HMACSHA512();
            command.CommandText = "Update [User] SET PasswordHash=@hash,PasswordSalt=@salt WHERE ID=@id";
            command.Parameters.AddWithValue("hash", hmac.ComputeHash(Encoding.UTF8.GetBytes(newpassword)));
            command.Parameters.AddWithValue("salt", hmac.Key);
            command.Parameters.AddWithValue("id", id);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public static Role GetRoleByID(int id)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Role WHERE id=@id";
            command.Parameters.AddWithValue("id", id);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Role(reader.GetInt32(0), reader.GetString(1), reader.GetBoolean(2));
            }
            return null;
        }

        public static User CheckLogin(string username, string password)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM [User] WHERE Name=@name";
            command.Parameters.AddWithValue("name", username);
            SqlDataReader reader = command.ExecuteReader();
            User user = null;
            if (reader.Read())
            {
                HMACSHA512 hmac = new HMACSHA512((byte[])reader[3]);
                if (hmac.ComputeHash(Encoding.UTF8.GetBytes(password)).SequenceEqual((byte[])reader[2]))
                {
                    user = new User(reader.GetInt32(0), reader.GetString(1), GetRoleByID(reader.GetInt32(4)));
                }
            }
            reader.Close();
            conn.Close();
            return user;
        }

    }
}

