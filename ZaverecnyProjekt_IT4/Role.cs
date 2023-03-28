using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjekt_IT4
{
    public class Role
    {
        public int ID { get; } = 1;
        public string Name { get; }

        public Role(string name)
        {
            Name = name;
        }
    }

}

