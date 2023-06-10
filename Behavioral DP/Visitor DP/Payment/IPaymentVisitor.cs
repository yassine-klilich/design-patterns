using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_DP.Visitor_DP
{
    internal interface IPaymentVisitor
    {
        public void SendMoney();
    }
}
