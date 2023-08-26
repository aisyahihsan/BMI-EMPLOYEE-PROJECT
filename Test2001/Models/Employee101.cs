using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2001.Models
{
    public class Employee101
    {
        public string EmpId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Campus { get; set; }
        public double Salary { get; set; }
        public double Deduction
        {
            get
            {
                if (Salary < 8000)
                {
                    return Salary * 0.005;
                }
                else
                {
                    return Salary * 0.01;
                }
            }
        }
    }
}
