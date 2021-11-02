using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioManipulacaoArquivosA192.Entities
{
    class Product
    {
        public string Nome_Produto { get; set; }
        public double Valor_Total { get; set; }

        public Product()
        {
        }

        public Product(string nome_Produto, double valor_Total)
        {
            Nome_Produto = nome_Produto;
            Valor_Total = valor_Total;
        }
    }
}
