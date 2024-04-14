

namespace ContaCorrente.ConsoleApp
{
    public class Movimentacao
    {
        public decimal valor;
        public string tipo;
        public decimal saldoConta;
        public string credito;
        public string debito;

        public Movimentacao(string tipo, decimal valor, decimal saldoConta)
        {
            this.tipo = tipo;
            this.valor = valor;
            this.saldoConta = saldoConta;
        }
    }
}
