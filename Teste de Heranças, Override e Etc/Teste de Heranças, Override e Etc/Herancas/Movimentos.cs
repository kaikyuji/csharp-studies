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
            Console.WriteLine("usando método fazTudo() da classe ANCESTRAL Movimentos");
        }
    }
}
