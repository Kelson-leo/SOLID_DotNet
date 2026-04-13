namespace OCP_Compliant
{
    class DescontoClienteVIP : Pedido
    {
        public override double DescontoPedido(double valorFinal)
        {
            return valorFinal - 100;
        }
    }
}
