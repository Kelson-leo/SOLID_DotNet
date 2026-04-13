using System;

namespace SolidPrinciples.SRP_Compliant
{
    public class EmailService
    {
        public void EnviarEmailPedido(string emailTo)
        {
            Console.WriteLine("\n=== ENVIANDO EMAIL ===");
            Console.WriteLine($"De: sistema@loja.com");
            Console.WriteLine($"Para: {emailTo}");
            Console.WriteLine("Assunto: Seu pedido foi confirmado");
            Console.WriteLine("Corpo: Obrigado pela compra!");
            Console.WriteLine("📧 Email enviado com sucesso (simulado)");
        }
    }
}