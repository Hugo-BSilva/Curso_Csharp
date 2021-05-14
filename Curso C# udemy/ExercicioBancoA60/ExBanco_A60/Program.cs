using System;

namespace ExBanco_A60
{
    class ContaBancaria
    {
        private string _nomeTitular;        
        public int NumConta { get; private set; } //AutoProperties
        public double Saldo { get; private set; } //AutoProperties

        //CONSTRUTORES
        public ContaBancaria()
        {
        }

        public ContaBancaria(int numConta, string nomeTitular)
        {
            this.NumConta = numConta;
            this._nomeTitular = nomeTitular;
        }

        public ContaBancaria(int numConta, string nomeTitular, double depositoInicial):this(numConta, nomeTitular)
        {
            Depositar(depositoInicial);
        }

        #region Propriedade Customizada
        //Propriedade customizada
        public string NomeTitular
        {
            get { return _nomeTitular; }
            set {
                if (value != null && value.Length > 1)
                {
                    _nomeTitular = value;
                }
                else
                {
                    Console.Write("Digite novamente: ");
                }
            }
        }
        #endregion

        //Outros métodos
        public void NumeroDaConta(int numeroConta)
        {
            NumConta = numeroConta;
        }
        public void Depositar(double deposito)
        {
            Saldo += deposito;
        }
        public void Saque(double saque)
        {
            Saldo -= - (saque + 5);
        }

        //Sobrecarga
        public override string ToString()
        {
            return "Dados da conta: \n" +
                "Conta: " + NumConta +
                ", Titular: " + NomeTitular +
                ", Saldo: $ " + Saldo;
        }
    }

    //PROGRAMA PRINCIPAL 
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c = new ContaBancaria();
            double valor;

            //ABRINDO CONTA BANCÁRIA
            Console.WriteLine(">>> ABERTURA DE CONTA BANCÁRIA <<< ");
            Console.Write("Número da conta: ");
            int numConta = Convert.ToInt32(Console.ReadLine());
            c.NumeroDaConta(numConta);

            Console.Write("Nome do titular: ");
            c.NomeTitular = Console.ReadLine();

            Console.WriteLine("Deseja depositar ? S/N");
            char respost = Console.ReadLine();
            
            //ESCOLHA SE VAI FAZER O PRIMEIRO DEPÓSITO OU NÃO
            if (respost == 's' || respost == 'S')
            {
                Console.WriteLine();
                Console.Write("Digite o valor que deseja depositar: ");
                valor = double.Parse(Console.ReadLine());
                c.Depositar(valor);
            }
            else
            {
                System.Console.WriteLine();
                Console.WriteLine("OK !");                
                //valor = 0; #NÃO É NECESSÁRIO, MAS DE QUALQUER FORMA ESTAREI FORÇANDO RECEBER ZERO
                //c.Depositar(valor);
            }

            //MOSTRANDO OS DADOS
            Console.WriteLine(c);            

            //DEPOSITANDO UM NOVO VALOR
            Console.WriteLine();
            Console.Write("Digite um valor para depósito: ");
            valor = double.Parse(Console.ReadLine());
            c.Depositar(valor);
            Console.WriteLine(c);
            Console.WriteLine();

            //SACANDO UM VALOR
            Console.WriteLine();
            Console.Write("Digite um valor para saque: ");
            valor = double.Parse(Console.ReadLine());
            c.Saque(valor);
            Console.WriteLine(c);
            Console.WriteLine();

        }
    }
}
