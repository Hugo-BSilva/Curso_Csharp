using System;
using System.Collections.Generic;
using System.Text;

namespace AluguelQuarto
{
    class AluguelDeQuarto
    {
        //Declarando variáveis encapsuladas
        public string Nome { get; set; }
        public string Email { get; set; }

        //CONSTRUTORES
        public AluguelDeQuarto()
        {
        }

        public AluguelDeQuarto(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }

        //MÉTODO DE SOBRECARGA
        public override string ToString()
        {
            return "Nome: " + Nome + ", Email: " + Email;
        }
    }
}
