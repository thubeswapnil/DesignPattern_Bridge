using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Bridge
{
    class SBIPaymentGateway : IPaymentGateway
    {
        public void ProcessPayment(string message)
        {
           
            Console.WriteLine("SBI Payement Gateway "+message);
        }
    }
}
