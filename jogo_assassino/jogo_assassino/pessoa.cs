using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_assassino
{
    class pessoa
    {
        protected string personagem = "Pessoa";
        protected int vida = 100;
        protected int descanso = 100;
        protected int comida = 100;
        protected int rondas = 1;

        protected void aumentar_rondas()
        {
            rondas = rondas + 1;

        }

        protected void aumentar_sono()
        {
                descanso = descanso - 10;
        }

        protected void aumentar_fome()
        {
                comida = comida - 20;
        }

        protected void perder_vida()
        {
            if (comida >= 100)
                vida = vida + 15;

            if (descanso >= 100)
                vida = vida + 15;
        }

        public string get_personagem()
        {
            return personagem;
   
        }

        protected int get_descanso()
        {
            return descanso;

        }

        protected int get_comida()
        {
            return comida;

        }

        protected int get_vida()
        {
            return vida;

        }

        protected int get_rondas()
        {
            return rondas;

        }
    }
}
