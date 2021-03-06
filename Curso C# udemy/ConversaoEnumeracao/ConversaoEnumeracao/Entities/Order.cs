using System;
using ConversaoEnumeracao.Entities.Enums; /*Para criar o atributo do tipo OrderStatus
é preciso fazer essa declaração, porque o enum OrderStatus está em outra pasta, logo
possui um outro namespace que só pode ser acessado declarando aqui em cima*/
using System.Collections.Generic;
using System.Text;

namespace ConversaoEnumeracao.Entities
{
    class Order //Classe Pedido
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id +
                ", " + Moment + ", " +
                Status;
        }
    }
}
