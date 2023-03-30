using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjekt_IT4
{
    public class Role
    {
        public int ID { get; }
        public string Name { get; }
        public bool IsAdmin { get; }

        public Role(string name, bool isAdmin)
        {
            Name = name;
            IsAdmin = isAdmin;
        }

    }

}

