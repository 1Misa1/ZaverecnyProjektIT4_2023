using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjekt_IT4
{
    public class SqlRepository
    {
       
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataMain;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private Dictionary<string, User> users = new Dictionary<string, User>()
        {
            {"admin", new User("admin","admin") },
            {"user", new User("user", "user") },
        };

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from [Login]";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User(reader["UserName"].ToString(), reader["Password"].ToString()));
                        }
                    }
                }
                conn.Close();
            }
            return users;
        }

        public User GetUser(string username)
        {
            User user = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from [Login] where UserName=@UserName";
                    cmd.Parameters.AddWithValue("UserName", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User(reader["UserName"].ToString(), reader["Password"].ToString());
                        }
                    }
                }
                conn.Close();
            }
            return user;
        }

        public void SaveUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update [Login] set PasswordSalt=@Salt, PasswordHash=@Hash where UserName=@UserName";
                    cmd.Parameters.AddWithValue("UserName", user.Username);
                    cmd.Parameters.AddWithValue("Salt", user.PasswordSalt);
                    cmd.Parameters.AddWithValue("Hash", user.PasswordHash);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void ConvertUsersFromPasswordToPasswordHash()
        {
            var users = GetUsers();
            foreach (var user in users)
            {
                SaveUser(user);
            }
        }
    }
}

