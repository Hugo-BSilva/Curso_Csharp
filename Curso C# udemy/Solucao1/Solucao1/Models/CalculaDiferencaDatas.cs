using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucao1.Models
{
    public class CalculaDiferencaDatas
    {
        /// <summary>
        /// definindo os números de dias em um mês; index 0=> janeiro e 11=> Dezembro
        /// fevereiro contém ou 28 ou 29 dias, por isso temos o valor -1
        /// o que iremos usar para calcular
        /// </summary>
        private int[] diasDoMes = new int[12] { 31, -1, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        /// <summary>
        /// contém a data inicial
        /// </summary>
        private DateTime DataInicio;
        /// <summary>
        /// contém a data final
        /// </summary>
        private DateTime DataFim;

        public int Anos { get; set; }
        public int Meses { get; set; }
        public int Dias { get; set; }
        public string Vencimento { get; set; }

        public CalculaDiferencaDatas() { }

        public CalculaDiferencaDatas(DateTime d1, DateTime d2)
        {
            int incremento;

            //Se a primeira data for maior que a segunda(ou seja mais recente) ela será a data final.
            if (d1 > d2)
            {
                this.DataInicio = d2;
                this.DataFim = d1;
            }
            //Se a primeira data for menor que a segunda(ou seja mais antiga) ela será a data de início.
            else
            {
                this.DataInicio = d1;
                this.DataFim = d2;
            }

            /// 
            /// Calculando os dias de diferença entre uma data e outra.
            /// 
            incremento = 0;

            if (this.DataInicio.Day > this.DataFim.Day)
            {
                incremento = this.diasDoMes[this.DataInicio.Month - 1];
            }

            /// se for fevereiro
            /// se o dia for menor que o dia de  hoje
            if (incremento == -1)
            {
                if (DateTime.IsLeapYear(this.DataInicio.Year))
                {
                    // ano bissexto -> fevereiro contém 29 dias
                    incremento = 29;
                }
                else
                {
                    incremento = 28;
                }
            }
            if (incremento != 0)
            {
                Dias = (this.DataFim.Day + incremento) - this.DataInicio.Day;
                incremento = 1;
            }
            else
            {
                Dias = this.DataFim.Day - this.DataInicio.Day;
            }

            ///
            ///calculo do mês
            ///
            if ((this.DataInicio.Month + incremento) > this.DataFim.Month)
            {
                this.Meses = (this.DataFim.Month + 12) - (this.DataInicio.Month + incremento);
                incremento = 1;
            }
            else
            {
                this.Meses = (this.DataFim.Month) - (this.DataInicio.Month + incremento);
                incremento = 0;
            }
            ///
            /// calculo do ano
            ///
            this.Anos = this.DataFim.Year - (this.DataInicio.Year + incremento);

            //Calcular diferença real
            if (this.Anos >= 5)
            {
                if (this.Meses > 0)
                {
                    Vencimento = "Está vencido !";
                }
                if (this.Dias > 0)
                {
                    Vencimento = "Está vencido !";
                }
            }
            else
            {
                Vencimento = "Não está vencido !";
            }
        }

        public override string ToString()
        {
            return this.Anos + " Anos(s), " + this.Meses + " mes(es), " + this.Dias + " dia(s)" + " Status do Vencimento: " + this.Vencimento;
        }
    }
}
