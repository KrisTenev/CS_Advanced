
using _405_Enumerations;

Payment payment = Payment.Bank;
Console.WriteLine(payment);

DoPayment(payment);
DoPayment(Payment.GoToCanada);

static void DoPayment(Payment type)
{
    if (type == Payment.GoToCanada)
    { 
    
    }

}

