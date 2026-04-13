using System;

namespace SolidPrinciples.SRP_Compliant
{
    public class Pedido
    {
        public long Quantidade { get; set; }
        public DateTime Data { get; set; }
        public string? ClienteEmail { get; set; }

        private readonly ILogger _logger;
        private readonly EmailService _emailService;

        public Pedido(ILogger logger, EmailService emailService)
        {
            _logger = logger;
            _emailService = emailService;
        }

        public void IncluirPedido()
        {
            try
            {
                // Regras de negócio do pedido
                this.Quantidade = 10;
                this.Data = DateTime.Now;
                this.ClienteEmail = "cliente@email.com";

                _logger.Info("=== INCLUINDO PEDIDO ===");
                _logger.Info($"Pedido criado em: {this.Data}");
                _logger.Info($"Quantidade: {this.Quantidade}");
                _logger.Info("Status: Pedido salvo no banco de dados");

                // Enviar email (delega responsabilidade)
                _emailService.EnviarEmailPedido(this.ClienteEmail);

                _logger.Info("\n✅ Pedido incluído com sucesso!");
            }
            catch (Exception ex)
            {
                _logger.Error(ex.Message);
            }
        }

        public void DeletaPedido()
        {
            try
            {
                _logger.Info("\n=== DELETANDO PEDIDO ===");
                _logger.Info($"Pedido de {this.Data} foi deletado");
                _logger.Info("✅ Pedido deletado com sucesso!");
            }
            catch (Exception ex)
            {
                _logger.Error(ex.Message);
            }
        }
    }
}