namespace Teste_de_Heranças__Override_e_Etc.Herancas
{
    internal class Chute : Movimentos
    {
        public void Executar()
        {
            Console.WriteLine("Chutou");
        }

        public override void fazTudo()
        {
            Console.WriteLine("estou usando método fazTudo() da classe HERDEIRA Chute");
        }
    }
}
