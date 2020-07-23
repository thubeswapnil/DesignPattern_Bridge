using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Bridge
{
    abstract class Payment
    {
       // public IPaymentGateway paymentGateway;
       public abstract void MakePayment(IPaymentGateway paymentGateway);
    }
}
