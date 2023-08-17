using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_de_Heranças__Override_e_Etc.Herancas
{
    internal class Movimentos
    {
        public virtual void fazTudo()
        {
            /* virtual significa que esse método poderá ser substituido pelo método de mesmo nome
             de uma classe descendente/derivada, a classe do método que substituirá esse método
            depende unicamente da classe do objeto que utiliza o método .fazTudo.
             */ 
            Console.WriteLine("usando método fazTudo() da classe ANCESTRAL Movimentos");
        }
    }
}
