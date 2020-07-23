using Akka.Dispatch;
using System;

namespace DesignPattern_Bridge
{
    class Program
    {
        //1. Interface
        //2. Concrete implementar
        //3. abstract class


        ExecutorService executor = Executors.newFixedThreadPool(7);
        static void Main(string[] args)
        {
            Payment order = new DebitCardPayment();
            //order.paymentGateway = new HDFCPaymentGateway();
            order.MakePayment(new HDFCPaymentGateway());

            //order.paymentGateway = new SBIPaymentGateway();
            order.MakePayment(new SBIPaymentGateway());

            order = new GPayPayment();
            //order.paymentGateway = new HDFCPaymentGateway();
            order.MakePayment(new HDFCPaymentGateway());

            //order.paymentGateway = new SBIPaymentGateway();
            order.MakePayment(new SBIPaymentGateway());

            Console.Read();
        }
    }
}
