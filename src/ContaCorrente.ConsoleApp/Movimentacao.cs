

namespace ContaCorrente.ConsoleApp
{
    public class Movimentacao
    {
        public decimal valor;
        public string tipo;
        public string credito;
        public string debito;

        public Movimentacao(string tipo, decimal valor)
        {
            this.tipo = tipo;
            this.valor = valor;
        }
    }
}
