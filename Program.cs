using System;

namespace Aula20Ifood
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente Paulo = new Cliente("Paulo Brandão");
            Paulo.Endereco = "Guarulhos, SP";
            Restaurante mequi = new Restaurante("McDonalds", "Av Castelo Branco, 132");

            Pedido pedido1 = new Pedido();
            pedido1.Cliente = Paulo;
            pedido1.Restaurante = mequi;

            Console.WriteLine( pedido1.EntregarPedido() );
            

        }
    }
}

