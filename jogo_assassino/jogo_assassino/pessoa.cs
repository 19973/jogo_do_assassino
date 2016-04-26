using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_assassino
{
    class pessoa
    {
        protected string personagem = "Pessoa";
        protected int vida = 100;
        protected int descanso = 100;
        protected int comida = 100;
        protected int rondas = 1;
        protected bool tv = false;
        protected bool esconder = false;
        protected bool falar = false;
        protected bool investigar = false;
        protected string nome_player = "";
        protected List <string> mensagens = new List<string> ();

        protected void emviar_mensagem(pessoa p, string mensagem)
        {
            p.receber_mensagem(this, mensagem);
        }       

        protected void receber_mensagem(pessoa p, string mensagem)
        {
            mensagens.Add(mensagem);
            for (int i = 0; i <= mensagens.Count; i++)
            {
                MessageBox.Show(mensagens[i].ToString());
            }
        }

        protected void esconder_pessoa()
        {
            esconder = true;
        }

        protected void tv_true()
        {
            tv = true;
        }

        protected void ver_tv()
        {
            if (tv == true)
            {
                comida = comida + 25;
                descanso = descanso + 25;
            }
        }

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

        protected void comer()
        {
            comida = comida + 100;
        }

        protected void dormir()
        {
            descanso = descanso + 100;
        }

        protected void perder_vida_de_players()
        {

            if (esconder == true)
                vida = vida - 35;

            if (esconder == false)
                vida = vida - 100;
        }

        protected void perder_vida_de_atributos()
        { 

            if (comida >= 100)
                vida = vida - 15;

            if (descanso >= 100)
                vida = vida - 15;
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

        protected bool get_esconder()
        {
            return esconder;

        }

        protected bool get_falar()
        {
            return falar;

        }

        protected bool get_investigar()
        {
            return investigar;

        }

        protected bool get_tv()
        {
            return tv;

        }
    }
}
