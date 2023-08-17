namespace Teste_de_Heranças__Override_e_Etc.Herancas
{
    internal class Soco : Movimentos
    {
        public void Executar()
        {
            Console.WriteLine("Socou");
        }

        public override void fazTudo()
        {
            Console.WriteLine("estou usando método fazTudo() da classe HERDEIRA Soco");
        }
    }
}
