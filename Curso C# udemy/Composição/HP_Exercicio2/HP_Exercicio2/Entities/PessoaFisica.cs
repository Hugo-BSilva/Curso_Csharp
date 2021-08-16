using System;
using System.Collections.Generic;
using System.Text;
using HP_Exercicio2.Entities;

namespace HP_Exercicio2.Entities
{
    internal class PessoaFisica : Pessoa
    {
        public double GastoSaude { get; set; }
        public PessoaFisica(double gastoSaude, string nome, double rendaAnual) :base (nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double CalcularImposto()
        {
            double saude = 0;
            double renda = 0;

            if (RendaAnual < 20000)
            {
                renda = (RendaAnual * 15) / 100;

                if (GastoSaude > 0)
                {
                    saude = (GastoSaude * 50) / 100;
                }
                else
                {
                    saude = 0;
                }
               
            }
            else if (RendaAnual >= 20000)
            {
                renda = (RendaAnual * 25.0) / 100;

                if (GastoSaude > 0)
                {
                    saude = (GastoSaude * 50) / 100;                    
                }
                else
                {
                    saude = 0;
                }
            }

            return renda - saude;
        }
    }
}
