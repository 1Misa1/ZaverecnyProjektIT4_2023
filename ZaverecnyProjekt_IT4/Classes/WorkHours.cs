using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjekt_IT4.Classes
{
    public class WorkHours
    {
        public int ID { get; set; }
        public Employee Employee { get; set; }
        public Contract Contract { get; set; }
        public WorkType WorkType { get; set; }
        public int Hours { get; set; }
        public DateTime InsertDate { get; set; }
        //public User InsertUser { get; set; }

        public WorkHours(int iD, Employee employee, Contract contract, WorkType workType, int hours, DateTime insertDate)
        {
            ID = iD;
            Employee = employee;
            Contract = contract;
            WorkType = workType;
            Hours = hours;
            InsertDate = insertDate;
        }


    }
}
