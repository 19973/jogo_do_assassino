using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_assassino
{
    class policia : pessoa
    {
           
        policia()
        {
            personagem = "Policia";

        }

        protected void prender(pessoa p)
        {
            // fazer com que a pessoa não execute nenhuma ação
        }

        protected void disparar(pessoa p)
        {
            // matar a pessoa
        }

        protected void policia_investigar(pessoa p)
        {
            // investiga uma casa, ficando a saber dos status do outro player... 
        }

    }
}
