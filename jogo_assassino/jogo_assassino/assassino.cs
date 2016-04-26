using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_assassino
{
    class assassino : pessoa
    {
        assassino()
        {
            personagem = "Assasino";

        }

        protected void raptar(pessoa p)
        {   
            // fazer com que a pessoa não execute nenhuma ação
        }

        protected void esfaquear(pessoa p)
        {
            // fazer outra pessoa perder vida
        }

        protected void denunciar(pessoa p)
        {
            // denunciar uma pessoa, escrever um texto ao policia do sucedido
        }

        protected void assasino_investigar(pessoa p)
        {
            // investiga a casa de uma pessoa, ficando a saber os seus status...
        }

        protected void esconder_arma(pessoa p)
        {
            // esconder a arma para que ninguem possa ver ou ouvir 
        }


    }
}
