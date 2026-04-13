using System;
using System.IO;

namespace SRP_Violation
{
    class Pedido
    {
        public long Quantidade { get; set; }
        public DateTime Data { get; set; }

        public void IncluirPedido()
        {
            try
            {
                // Simular inclusão do pedido
                this.Quantidade = 10;
                this.Data = DateTime.Now;

                Console.WriteLine("=== INCLUINDO PEDIDO ===");
                Console.WriteLine($"Pedido criado em: {this.Data}");
                Console.WriteLine($"Quantidade: {this.Quantidade}");
                Console.WriteLine("Status: Pedido salvo no banco de dados");

                // Simular envio de email (sem MailMessage real)
                this.EnviaEmailPedido();

                Console.WriteLine("\n✅ Pedido incluído com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ ERRO: {ex.Message}");
                File.WriteAllText("ErrorLog.txt", ex.ToString());
                Console.WriteLine("Erro registrado em ErrorLog.txt");
            }
        }

        public void DeletaPedido()
        {
            try
            {
                Console.WriteLine("\n=== DELETANDO PEDIDO ===");
                Console.WriteLine($"Pedido de {this.Data} foi deletado");
                Console.WriteLine("✅ Pedido deletado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ ERRO: {ex.Message}");
                File.WriteAllText("ErrorLog.txt", ex.ToString());
            }
        }

        public void EnviaEmailPedido()
        {
            try
            {
                Console.WriteLine("\n=== ENVIANDO EMAIL ===");
                Console.WriteLine("De: sistema@loja.com");
                Console.WriteLine("Para: cliente@email.com");
                Console.WriteLine("Assunto: Seu pedido foi confirmado");
                Console.WriteLine("Corpo: Obrigado pela compra!");
                Console.WriteLine("📧 Email enviado com sucesso (simulado)");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ ERRO ao enviar email: {ex.Message}");
                throw;
            }
        }
    }
}