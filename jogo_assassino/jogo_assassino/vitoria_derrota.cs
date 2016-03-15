using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_assassino
{
    class vitoria_derrota
        
    {
        protected string ganhou_perdeu = "vitoria";
        protected int opcao = 1;



        public vitoria_derrota()
        {
            opcao = 1;

        }

        public void set_opcao()
        {
            if (ganhou_perdeu == "vitoria")
            {
                ganhou_perdeu = "derrota";
                opcao = 2;
            }
            else if (ganhou_perdeu == "derrota")
            {
                ganhou_perdeu = "vitoria";
                opcao = 1;
            }
        }

        public string get_opcao()
        {
            return ganhou_perdeu;
        }
    }
}
