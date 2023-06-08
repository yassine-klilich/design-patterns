

using Design_Patterns.Behavioral_DP.Visitor_DP;
using Design_Patterns.Behavioral_DP.Visitor_DP.Employee;
using Design_Patterns.Behavioral_DP.Visitor_DP.Payment;

HospitalEmployee doctor = new Doctor();
HospitalEmployee nurse = new Nurse();
HospitalEmployee reception = new Reception();

IPayment bitcoin = new Bitcoin();
IPayment cash = new Cash();
IPayment transfer = new Transfer();

doctor.PaySalary(bitcoin);
nurse.PaySalary(cash);
reception.PaySalary(transfer);