using System;
using System.Globalization;
using ExPedidosA123.Entities;
using ExPedidosA123.Entities.Enums;

namespace ExPedidosA123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("> Enter Cliente Data < "); //dados do cliente
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (yyyy/mm/dd): ");
            string birthDate = Console.ReadLine();
            DateTime dataB = DateTime.Parse(birthDate);
            

            Console.WriteLine();
            Console.WriteLine("> Enter Order Data < "); //dados do pedido
            Console.Write("Status: ");
            //OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());
            Console.WriteLine();

            Client client = new Client(name, email, dataB);
            Order order = new Order(client, DateTime.Now, status);

            //Quantos items vai querer incluir nesse pedido ?
            Console.Write("How many item to this order: ");
            int nOrder = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nOrder; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Productname: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(nameProduct, productPrice);
                OrderItem itemOrder = new OrderItem(product, productQuantity, productPrice);

                order.AddItem(itemOrder);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
            Console.ReadKey();
        }
    }
}
