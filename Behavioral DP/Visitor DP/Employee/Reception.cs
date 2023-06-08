using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_DP.Visitor_DP.Employee
{
    internal class Reception : HospitalEmployee
    {
        public override void PaySalary(IPayment payment)
        {
            payment.SendMoney();
        }
    }
}
