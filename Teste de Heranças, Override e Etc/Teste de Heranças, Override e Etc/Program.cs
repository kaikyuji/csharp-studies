using Teste_de_Heranças__Override_e_Etc.Herancas;

internal class JogoDaLuta
{
    public static void Main(string[] args)
    {
        Dictionary<int, Movimentos> opcoes = new();
        opcoes.Add(1, new Chute()); // objeto de classe Chute, com tipo Movimentos
        opcoes.Add(2, new Pulo()); // objeto de classe Pulo, com tipo Movimentos
        opcoes.Add(3, new Soco()); // objeto de classe Soco, com tipo Movimentos

        void jogoLuta()
        {
            Console.WriteLine("1 - chute, 2- pulo, 3- soco:");
            int usuarioEscolha = int.Parse(Console.ReadLine()!);
            if (opcoes.ContainsKey(usuarioEscolha))
            {
                opcoes[usuarioEscolha].fazTudo();
                /* o objeto pode ser de classe Chute, porém, o tipo sempre será Movimento
                implicando que o que você terá de acesso, virá sempre da classe ancestral, Movimento

                como a classe Movimento possui um método fazTudo() que pode ser sobrescrito (virtual method)
                e todas as classes possuem um método fazTudo() para sobrescrever o ancestral, a escolha depende
                apenas de qual classe o objeto pertence, por exemplo:
                opcoes[usuarioEscolha] é um objeto de classe Pulo com tipo Movimentos, usando .fazTudo(), o método
                .fazTudo() de Movimentos será sobrescrito pelo método fazTudo() da classe que deriva o objeto, no caso
                a classe Pulo.
                */
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