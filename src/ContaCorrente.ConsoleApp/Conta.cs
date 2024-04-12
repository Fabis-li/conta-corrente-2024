namespace ContaCorrente.ConsoleApp
{
    public class Conta
    {
        public int numero;
        public string nome;
        public decimal saldo;
        public decimal limite;

        public void Saca(decimal quantidade)
        {
            this.saldo -= quantidade;
        }

        public void Deposita(decimal quantidade)
        {
            this.saldo += quantidade;
        }
    }
}
