namespace ContaCorrente.ConsoleApp
{
    public class Conta
    {
        public int numero;
        public Cliente titular;
        public decimal saldo;
        public decimal limite;
        public Movimentacao[] historico;
        public int qtdeMovimentacao = 0;
        public bool status;
        int tamanhoHistorico = 10;

        public Conta()
        {
        }

        public Conta(int numero, Cliente titular, decimal limite, bool status)
        {
            this.numero = numero;
            this.titular = titular;
            this.limite = limite;
            this.status = status;
            historico = new Movimentacao[tamanhoHistorico];
          
        }
        public void AdicionarMovimentacao(string tipo, decimal valor)
        {
            if(qtdeMovimentacao < historico.Length)
            {
                historico[qtdeMovimentacao] = new Movimentacao(tipo, valor);
                qtdeMovimentacao++;
            }
        }
        public void Sacar(decimal quantidade)
        {
            if (this.saldo < quantidade)            
                Console.WriteLine("Saldo insuficiente na conta");
            else
            this.saldo -= quantidade;
            
            AdicionarMovimentacao("Debito", quantidade);
        }
        public void Depositar(decimal quantidade)
        {
            this.saldo += quantidade;
            AdicionarMovimentacao("Credio", quantidade);
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
            AdicionarMovimentacao("Debito", valor);
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
                destino.Depositar(valor);
                return true;
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Nome:{titular.nome} {titular.sobrenome}\n");
            Console.WriteLine($"Saldo atual R$: {saldo}");
        }
        public void ExibirExtrato()
        {
            Console.WriteLine("\nExtrato da Conta\n");            
            for (int i = 0; i < qtdeMovimentacao; i++)
            {                
                Console.WriteLine($"Tipo:{historico[i].tipo}, R$:{historico[i].valor}");
            }           
            Console.WriteLine("\n");
        }
        public void SaldoAnterior()
        {
            
        }
        
    }
}
