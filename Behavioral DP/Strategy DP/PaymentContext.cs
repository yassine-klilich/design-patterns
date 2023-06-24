using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns.Behavioral_DP.Visitor_DP.Employee;

namespace Design_Patterns.Behavioral_DP.Strategy_DP
{
    internal class PaymentContext
    {
        private IPaymentStrategy strategy;

        public void SetStrategy(IPaymentStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Payer(Employee emp)
        {
            strategy.PayerSalaire(emp);
        }

    }
}
