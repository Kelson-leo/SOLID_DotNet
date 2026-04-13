using System;

namespace SolidPrinciples.SRP_Compliant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE PEDIDOS (VERSÃO SRP) ===\n");

            // Injeção de dependência manual
            var logger = new ConsoleLogger();
            var emailService = new EmailService();
            var pedido = new Pedido(logger, emailService);

            pedido.IncluirPedido();

            Console.WriteLine("\nPressione Enter para deletar o pedido...");
            Console.ReadLine();

            pedido.DeletaPedido();

            Console.WriteLine("\nPressione Enter para sair...");
            Console.ReadLine();
        }
    }
}