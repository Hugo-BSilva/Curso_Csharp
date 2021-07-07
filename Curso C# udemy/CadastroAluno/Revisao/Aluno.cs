namespace Revisao
{
    public struct Aluno
    {
        public string Nome { get; set; }
        public decimal Nota { get; set; }

        public decimal CalcularMedia(decimal nota)
        {
            nota = (nota + Nota) / 5;
            return 0;
        }
    }
}