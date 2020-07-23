using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Bridge
{
    class HDFCPaymentGateway : IPaymentGateway
    {
        public void ProcessPayment(string message)
        {
            Console.WriteLine("HDFC Payement Gateway"+message);
        }
    }
}
