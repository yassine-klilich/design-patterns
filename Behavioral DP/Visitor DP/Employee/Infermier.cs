using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns.Behavioral_DP.Visitor_DP;

namespace Design_Patterns.Behavioral_DP.Visitor_DP.Employee
{
    internal class Infermier : Employee
    {
        public LevelNurse LevelNurse { get; set; }

        public override void PaySalary(IPaymentVisitor payment)
        {
            payment.SendMoney();
        }
    }

    public enum LevelNurse
    {
        Level_1 = 1,
        Level_2 = 2,
        Level_3 = 3
    }
}
