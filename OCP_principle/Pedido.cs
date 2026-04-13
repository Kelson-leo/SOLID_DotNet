using System;

namespace OCP_Violation
{
    public enum TipoCliente
    {
        Comum,
        Associado,
        Especial
    }

    class Pedido
    {
        public double DescontoPedido(double valor, TipoCliente tipoCliente)
        {
            double valorFinal;

            if (tipoCliente == TipoCliente.Especial)
            {
                valorFinal = valor - 50;
            }
            else if (tipoCliente == TipoCliente.Associado)
            {
                valorFinal = valor - 10;
            }
            else // Comum
            {
                valorFinal = valor;
            }

            return valorFinal;
        }
    }
}