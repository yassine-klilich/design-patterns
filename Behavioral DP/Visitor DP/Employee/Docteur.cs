using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns.Behavioral_DP.Visitor_DP;

namespace Design_Patterns.Behavioral_DP.Visitor_DP.Employee
{
    internal class Docteur : Employee
    {
        public int NumberOfSurgeries { get; set; }

        public override void PaySalary(IPaymentVisitor payment)
        {
            payment.SendMoney();
        }
    }
}
