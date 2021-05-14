using System;
using System.Text;
using System.Collections.Generic;
using ExPedidosA123.Entities.Enums;

namespace ExPedidosA123.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public Client Client { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(Client client, DateTime moment, OrderStatus status)
        {
            Client = client;
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            OrderItem.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            OrderItem.Remove(item);
        }
        public double Total()
        {
            double sum = 0;

            //Para cada item na minha lista OrderItem
            foreach (OrderItem item in OrderItem)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder ss = new StringBuilder();
            ss.AppendLine("Order Moment: " + Moment.ToString("yyyy / MM / dd HH: mm:ss"));
            ss.AppendLine("Order Status: " + Status);
            ss.AppendLine("Client: " + Client);
            ss.AppendLine("Order items: ");
            foreach (OrderItem item in OrderItem)
            {
                ss.AppendLine(item.ToString());
            }
            ss.AppendLine("Total price: $" + Total());
            return ss.ToString();
        }
    }
}
