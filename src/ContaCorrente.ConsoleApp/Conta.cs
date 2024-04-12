namespace ContaCorrente.ConsoleApp
{
    public class Conta
    {
        public int numero;
        public Cliente titular;
        public decimal saldo;
        public decimal limite;
        public Movimentacao[] movimentacao;

        public void Saca(decimal quantidade)
        {
            this.saldo -= quantidade;
        }

        public void Deposita(decimal quantidade)
        {
            this.saldo += quantidade;
        }

        public bool VerificarSaque(decimal valor)
        {
            if(this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        public void Transferir(Conta destino, decimal valor)
        {
            this.saldo -= valor;
            destino.saldo += valor; 
        }

        public bool VerificarTransferencia(Conta destino, decimal valor)
        {
            bool retirou = this.VerificarSaque(valor);
            if(retirou == false)
            {
                return false;
            }
            else
            {
                destino.Deposita(valor);
                return true;
            }
        }
    }
}
