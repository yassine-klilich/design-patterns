using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_DP.Visitor_DP.Employee
{
    internal abstract class HospitalEmployee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int CNE { get; set; }
        public int Salary { get; set; }
        public int WorkingHours { get; set; }

        public abstract void PaySalary(IPaymentVisitor payment);
    }
}
