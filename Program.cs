using System;

namespace Aula20Ifood
{
    class Program
    {
        static void Main(string[] args)
        {

            // string[] Itens = {"Big Mac, Cheddar mc melt"};
            Cliente Paulo = new Cliente("Paulo Brandão", "Penha, São Paulo");
            System.Console.WriteLine( MostrarDados() );
            
            System.Console.WriteLine("");
            Restaurante mequi = new Restaurante("Mc Donald's", "Guarulhos, São Paulo");
            System.Console.WriteLine(mequi.MostrarDados());

        
            System.Console.WriteLine("");
            Pedido pedido1 = new Pedido();
            pedido1.Cliente = Paulo.NomeCliente;
            pedido1.Restaurante = mequi.NomeRestaurante;
            
        
        }
    }
}

