using Teste_de_Heranças__Override_e_Etc.Herancas;

internal class JogoDaLuta
{
    public static void Main(string[] args)
    {
        Dictionary<int, Movimentos> opcoes = new();
        opcoes.Add(1, new Chute());
        opcoes.Add(2, new Pulo());
        opcoes.Add(3, new Soco());

        void jogoLuta()
        {
            Console.WriteLine("1 - chute, 2- pulo, 3- soco:");
            int usuarioEscolha = int.Parse(Console.ReadLine()!);
            if (opcoes.ContainsKey(usuarioEscolha))
            {
                opcoes[usuarioEscolha].fazTudo();
            }
            else
            {
                Console.WriteLine("Erro");
            }
            jogoLuta();
        }
        jogoLuta();
    }
}