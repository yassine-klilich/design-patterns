
using Design_Patterns.Behavioral_DP.Chain_of_Responsibility_DP;
using Design_Patterns.Behavioral_DP.Visitor_DP;
using Design_Patterns.Behavioral_DP.Visitor_DP.Employee;
using Design_Patterns.Behavioral_DP.Visitor_DP.Payment;

/*
 Visitor Design Pattern
 */
//HospitalEmployee doctor = new Doctor();
//HospitalEmployee nurse = new Nurse();
//HospitalEmployee reception = new Reception();

//IPaymentVisitor bitcoin = new Bitcoin();
//IPaymentVisitor cash = new Cash();
//IPaymentVisitor transfer = new Transfer();

//doctor.PaySalary(bitcoin);
//nurse.PaySalary(cash);
//reception.PaySalary(transfer);




/*
 Chain Of Responsibility Design Pattern
 */
BaseHandler handler = new BaseHandler();
var hA = new Handler_A();
var hB = new Handler_B();
var hC = new Handler_C();

handler.SetNextHandler(hA)
    .SetNextHandler(hB)
    .SetNextHandler(hC);

handler.Handle("B");