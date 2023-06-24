using Design_Patterns.Behavioral_DP.Visitor_DP.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_DP.Strategy_DP
{
    internal class VirementStrategy : IPaymentStrategy
    {
        public void PayerSalaire(Employee emp)
        {
            Console.WriteLine("Payer par virement");
        }
    }
}
