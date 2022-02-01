using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestricoesGenericsA206.Entities
{
    class Products : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Products(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name +
                ", " +
                Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Products))
            {
                throw new ArgumentException("Comparing error: argument is not an Product");
            }

            Products other = obj as Products;

            return Price.CompareTo(other.Price);
        }
    }
}
