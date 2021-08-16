using System;
using System.Collections.Generic;
using System.Text;

namespace HP_Exercicio2.Entities
{
    class PessoaJuridica : Pessoa
    {   
        public int NumFuncionario { get; set; }
        public PessoaJuridica(int numFuncionario, string nome, double rendaAnual) :base (nome, rendaAnual)
        {
            NumFuncionario = numFuncionario;
        }

        public override double CalcularImposto()
        {
            double renda = 0;

            if (NumFuncionario > 10)
            {
                renda = (RendaAnual * 14.0) / 100;
            }
            else
            {
                renda = (RendaAnual * 16.0) / 100;
            }

            return renda;
        }
    }
}
