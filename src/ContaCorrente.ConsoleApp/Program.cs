namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta(1, new Cliente("Fabiano","Lima","111.222.333-44"), 3000, false);
            Conta c2 = new Conta(2, new Cliente("Alice", "Lima","222.333.444-55"), 2000, false);

            c1.Depositar(1000);
            c1.Sacar(200);
            c1.Depositar(500);            
            c1.Transferir(c2, 300);

            c1.ExbirCliente();
            c1.ExibirSaldo();
            c1.ExibirExtrato();

            c2.ExbirCliente();
            c2.ExibirSaldo();
            
            Console.ReadLine();
        }
    }
}
