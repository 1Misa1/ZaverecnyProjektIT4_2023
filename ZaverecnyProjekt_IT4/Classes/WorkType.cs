using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjekt_IT4
{
    public class WorkType
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public WorkType(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public WorkType(int iD, string name, string description)
        {
            ID = iD;
            Name = name;
            Description = description;
        }
    }
}
