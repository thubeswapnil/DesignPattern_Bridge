using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Bridge
{
    interface IPaymentGateway
    {
       void ProcessPayment(string message);
    }
}
