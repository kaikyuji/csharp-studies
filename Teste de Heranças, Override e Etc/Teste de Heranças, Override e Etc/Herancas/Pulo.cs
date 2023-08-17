using Teste_de_Heranças__Override_e_Etc.Herancas;

namespace Teste_de_Heranças__Override_e_Etc.Herancas
{
    internal class Pulo : Movimentos
    {
        public void Executar()
        {
            Console.WriteLine("Pulou");
        }

        public override void fazTudo()
        {
            Console.WriteLine("estou usando método fazTudo() da classe HERDEIRA Pulo");
        }
    }
}
