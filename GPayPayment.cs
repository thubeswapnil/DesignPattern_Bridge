using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Bridge
{
    class GPayPayment : Payment
    {
        public override void MakePayment(IPaymentGateway paymentGateway)
        {
            paymentGateway.ProcessPayment("G Pay Payment processed");
        }
    }
}
