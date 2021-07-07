using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {                 
            Aluno[] alunos = new Aluno[5]; 
            var indiceAluno = 0;                
            string opcao = Menu();  

            while (opcao.ToUpper() != "X")
            {
                switch (opcao)
                {
                    case "1":
                    //Cadastrar Aluno
                        var aluno = new Aluno();
                        System.Console.Write("Informe o nome do aluno: ");
                        aluno.Nome = Console.ReadLine();

                        System.Console.Write($"Informe a nota do(a) {aluno.Nome}: ");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno ++;

                        break;
                    case "2":
                    //Listar alunos
                        foreach (var cadastro in alunos)
                        {
                            if (!string.IsNullOrEmpty(cadastro.Nome))
                            {
                                System.Console.WriteLine($"Aluno: {cadastro.Nome} - Nota: {cadastro.Nota}");
                            }                            
                        }
                        break;
                    case "3":
                    //Calcular média geral
                        decimal notaTotal = 0;
                        var nrAlunos = 0;

                        for (int i=0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal / nrAlunos;
                        Conceito conceitoGeral;

                        if (mediaGeral < 2)
                        {
                            conceitoGeral = Conceito.E;
                        }
                        else if (mediaGeral < 4)
                        {
                            conceitoGeral = Conceito.D;
                        }
                        else if (mediaGeral < 6)
                        {
                            conceitoGeral = Conceito.C;
                        }
                        else if (mediaGeral < 8)
                        {
                            conceitoGeral = Conceito.B;
                        }
                        else
                        { 
                            conceitoGeral = Conceito.A;
                        }

                        Console.WriteLine($"MÉDIA GERAL: {mediaGeral} - CONCEITO: {conceitoGeral}");

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcao = Menu();
            } 
        }
        private static string Menu()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Informe a opção desejada:");
            System.Console.WriteLine("1- Cadastrar novo aluno");
            System.Console.WriteLine("2- Listar alunos");
            System.Console.WriteLine("3- Calcular média geral");
            System.Console.WriteLine("X- Sair");
            System.Console.WriteLine();
            string op = Console.ReadLine();
            return op;
        }
    }
}
