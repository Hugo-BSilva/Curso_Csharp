namespace ExPedidosA123.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        //Construtores
        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
