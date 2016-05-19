using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseAllocation.Enums;
using ExpenseAllocation.Models;
using ExpenseAllocation.Data;

namespace ExpenseAllocation
{
    public class Calculator
    {
        private List<Heirarchy> hierarchies { get; set; }
        private double sumAllocation { get; set; }

        double managerAllocation = 0;
        double developerAllocation = 0;
        double qaTesterAllocation = 0;


        public Calculator(List<Heirarchy> heirarchies)
        {
            CalculateAllocation(heirarchies);
        }

        /// <summary>
        /// Calculates and the Allocation Amounts.
        /// </summary>
        /// <param name="heirarchies">List of Heirarchy objects defining the number of employee types being calculated.</param>
        /// <returns></returns>
        private void CalculateAllocation(List<Heirarchy> heirarchies)
        {
            foreach (Heirarchy item in heirarchies)
            {
                managerAllocation += item.LeadET == EmployeeType.TopManager ? Allocation.Manager : 0;
                managerAllocation += item.Managers * Allocation.Manager;
                developerAllocation += item.Developers * Allocation.Developer;
                developerAllocation += item.QATesters * Allocation.QATester;
            }

            sumAllocation = managerAllocation + developerAllocation + qaTesterAllocation;
            //return sumAllocation;
        }

        public double GetSumAllocation()
        {
            return sumAllocation;
        }
        
        public double GetManagerAllocation() 
        {
            return managerAllocation;
        }

        public double GetDeveloperAllocation()
        {
            return developerAllocation;
        }

        public double GetQATestersAllocation()
        {
            return qaTesterAllocation;
        }
    }
}
