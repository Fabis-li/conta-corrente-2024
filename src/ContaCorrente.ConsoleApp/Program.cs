namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta();
            Cliente fabiano = new Cliente();

            c1.titular.nome = "Fabiano";

            c1.saldo = 1000;

            c1.Saca(200);

            c1.Deposita(500);

            bool conseguiu = c1.VerificarSaque(2000);

            if(conseguiu)
            {
                Console.WriteLine("Conseguiu sacar");
            }
            else
            {
                Console.WriteLine("Não conseguiu sacar");
            }

            Console.WriteLine(conseguiu);
        }
    }
}
