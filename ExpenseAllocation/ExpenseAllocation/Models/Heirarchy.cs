using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseAllocation.Enums;

namespace ExpenseAllocation.Models
{
    public class Heirarchy
    {
        public EmployeeType LeadET { get; set; }
        public int Managers { get; set; }
        public int Developers { get; set; }
        public int QATesters { get; set; }
    }
}
