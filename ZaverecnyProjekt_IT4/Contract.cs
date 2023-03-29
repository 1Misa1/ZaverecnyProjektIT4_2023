using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjekt_IT4
{
    public class Contract
    {
        public int ID { get; set; }
        public string Customer { get; set; }
        public string Description { get; set; }

        public Contract(string customer, string description)
        {
            Customer = customer;
            Description = description;
        }

        public Contract(int iD, string customer, string description)
        {
            ID = iD;
            Customer = customer;
            Description = description;
        }
    }
}
