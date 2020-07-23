using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Bridge
{
    sealed class DebitCardPayment : Payment
    {
        public override void MakePayment(IPaymentGateway paymentGateway)
        {
            paymentGateway.ProcessPayment("Debit card payment");
        }
    }
}
