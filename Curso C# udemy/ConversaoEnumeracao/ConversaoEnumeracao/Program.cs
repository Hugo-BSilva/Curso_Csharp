using ConversaoEnumeracao.Entities;
using ConversaoEnumeracao.Entities.Enums;
using System;

namespace ConversaoEnumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1800,
                Moment = DateTime.Now,
                Status = OrderStatus.Processing
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            //Enum.Parse<parametrizar>
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            OrderStatus oss = Enum.Parse<OrderStatus>("Shipped");

            Console.WriteLine(txt);
            Console.WriteLine(os);
            Console.WriteLine(oss);
        }
    }
}
