namespace ConversaoEnumeracao.Entities.Enums
{   //O OrderStatus é uma derivação do tipo básico que é o int
    enum OrderStatus : int
    {
        PendingPayment = 0, //Pagamento pendente
        Processing = 1, //Processando
        Shipped = 2, //Enviado
        Delivered = 3 //Entregue
    }
}
