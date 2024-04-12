namespace ContaCorrente.ConsoleApp
{
    public class Cliente
    {
        public string nome;
        public string sobrenome;
        public string cpf;

        public Cliente(string nome, string sobrenome, string cpf)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.cpf = cpf;
        }
    }
}
