using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_DP.Visitor_DP.Employee
{
    internal class Doctor : HospitalEmployee
    {
        public int NumberOfSurgeries { get; set; }

        public override void PaySalary(IPayment payment)
        {
            payment.SendMoney();
        }
    }
}
