using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseAllocation.Enums
{
    public enum EmployeeType
    {
        [Display(Name = "None")]
        None = 0,

        [Display(Name = "Department")]
        Department = 100,

        [Display(Name = "Top Level Manager")]
        TopManager = 200,

        [Display(Name = "Manager")]
        Manager = 300,

        [Display(Name = "Developer")]
        Developer = 400,

        [Display(Name = "QA Tester")]
        QATester = 500
    }
}
