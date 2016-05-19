using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenseAllocation;
using ExpenseAllocation.Models;
using ExpenseAllocation.Enums;
using ExpenseAllocation.Data;

namespace ExpenseAllocationTest
{
    [TestClass]
    public class ExpenseAllocationTest
    {

        [TestMethod]
        public void CalculateAllocation()
        {
            List<Heirarchy> heirarchies = createHeirarchies();
            Calculator calculator = new Calculator(heirarchies);
            //double allocationAmount = calculator.CalculateAllocation(heirarchies);

            Console.WriteLine("the allocationAmount is " + calculator.GetSumAllocation().ToString());
            Assert.AreEqual(2100, calculator.GetSumAllocation());
        }

        private List<Heirarchy> createHeirarchies()
        {
            Heirarchy heirarchy = new Heirarchy()
            {
                LeadET = EmployeeType.TopManager,
                Managers = 1
            };

            Heirarchy heirarchy2 = new Heirarchy()
            {
                LeadET = EmployeeType.Manager,
                Developers = 1,
                QATesters = 1
            };

            List<Heirarchy> heirarchies = new List<Heirarchy>();
            heirarchies.Add(heirarchy);
            heirarchies.Add(heirarchy2);

            return heirarchies;
        }
    }
}
