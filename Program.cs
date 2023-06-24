
using Design_Patterns.Behavioral_DP.Chain_of_Responsibility_DP;
using Design_Patterns.Behavioral_DP.Strategy_DP;
using Design_Patterns.Behavioral_DP.Visitor_DP;
using Design_Patterns.Behavioral_DP.Visitor_DP.Payment;
using Design_Patterns.Behavioral_DP.Visitor_DP.Employee;

public class Program
{
    static void Main() {

        Employee docteur = new Docteur();
        Employee infermier = new Infermier();
        Employee reception = new Reception();

        /*
         Strategy Design Pattern
        */
        PaymentContext payment = new PaymentContext();

        payment.SetStrategy(new PayPalStrategy());

        payment.Payer(docteur);
        payment.Payer(infermier);
        payment.Payer(reception);


        /*
         Visitor Design Pattern
        */
        IPaymentVisitor bitcoin = new Bitcoin();
        IPaymentVisitor cash = new PayPal();
        IPaymentVisitor transfer = new Virement();

        docteur.PaySalary(bitcoin);
        infermier.PaySalary(cash);
        reception.PaySalary(transfer);








        /*
         Chain Of Responsibility Design Pattern
         */
        //BaseHandler handler = new BaseHandler();
        //var hA = new Handler_A();
        //var hB = new Handler_B();
        //var hC = new Handler_C();

        //handler.SetNextHandler(hA)
        //    .SetNextHandler(hB)
        //    .SetNextHandler(hC);

        //handler.Handle("B");
    }
}


