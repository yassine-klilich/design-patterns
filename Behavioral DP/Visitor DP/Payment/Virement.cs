﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_DP.Visitor_DP.Payment
{
    internal class Virement : IPaymentVisitor
    {
        public void SendMoney()
        {
            Console.WriteLine("Pay salary via Virement");
        }
    }
}
