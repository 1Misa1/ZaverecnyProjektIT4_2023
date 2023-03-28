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
    public class User
    {
        public int ID { get; } = -1;
        public string Name { get; }
        public Role Role { get; }

        public User(string name, Role role)
        {
            Name = name;
            Role = role;
        }

        public User(int iD, string name, Role role)
        {
            ID = iD;
            Name = name;
            Role = role;
        }


    }
}
