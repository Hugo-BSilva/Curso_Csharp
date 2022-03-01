using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetSortedSetA210.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        /// <summary>
        /// O método deve ser implementado para que a comparação do HashSet aconteça da forma correta
        /// (fazendo a verificação pelo código do objeto, não pelo endereço do mesmo)
        /// Se o tipo do objeto for struct como no caso do point, não precisa fazer a implementação dos métodos abaixo
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            //Se o obj não for um produto
            if (!(obj is Product))
            {
                return false;
            }
            Product other = obj as Product;

            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}
