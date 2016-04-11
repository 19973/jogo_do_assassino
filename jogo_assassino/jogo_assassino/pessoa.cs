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
        protected bool morte = false;
        protected bool escondida = false;
        protected bool sono = false;
        protected bool fome = false;
        protected int rondas = 1;

        protected void perde_vida() {
            if (escondida == false)
                vida = vida - 75;
            else
                vida = vida - 30;
            if (vida <= 0)
                morte = true;
        }

        protected void aumenta_ronda()
        {
            rondas++;
        }

        protected void ganha_sono()
        {
            if (rondas % 10 == 10)
                sono = true;

            if (sono == true)
                vida = vida - 25;
        }

        protected void ganha_fome()
        {
            
            if (rondas % 10 == 5)
                fome = true;

            if (fome == true)
                vida = vida - 25;
        }

        protected int get_vida()
        {
            return vida;
        }

        protected bool get_sono()
        {
            return sono;
        }

        protected bool get_fome()
        {
            return fome;
        }

        protected bool get_escondida()
        {
            return escondida;
        }

        protected bool get_morte()
        {
            return morte;
        }

        public int get_rondas()
        {
            return rondas;

        }

        public string get_personagem()
        {
            return personagem;

        }

        /*protected string versao = "normal";
        protected int opcao = 1;
        protected System.Media.SoundPlayer bkground_sound;

        public void dormir()
        {
            bkground_sound.SoundLocation = @"D:\github\musicas\Dormir2Versoes.wav";
            bkground_sound.Play();
        }

      
        public void bater_porta()
        {
            if (versao == "normal")
            {
                bkground_sound.Stop();
                versao = "terror";
                opcao = 2;
                // MessageBox.Show("Versão |-Terror-| Ativada");
                bkground_sound.SoundLocation = @"D:\github\musicas\Dormir2Versoes.wav";
                bkground_sound.Play();
            }
            else if (versao == "terror")
            {
                bkground_sound.Stop();
                versao = "normal";
                opcao = 1;
                //   MessageBox.Show("Versão |-Casual-| Ativada");
                bkground_sound.SoundLocation = @"D:\github\musicas\Dormir2Versoes.wav";
                bkground_sound.Play();
            }        
        }

        public void andar()
        {
            bkground_sound.SoundLocation = @"D:\github\musicas\Dormir2Versoes.wav";
            bkground_sound.Play();
        }
        public void ver_TV()
        {
            bkground_sound.SoundLocation = @"D:\github\musicas\Dormir2Versoes.wav";
            bkground_sound.Play();
        }
        public void telefonar()
        {
            bkground_sound.SoundLocation = @"D:\github\musicas\Dormir2Versoes.wav";
            bkground_sound.Play();
        }
        public void abrir_gaveta()
        {
            bkground_sound.SoundLocation = @"D:\github\musicas\Dormir2Versoes.wav";
            bkground_sound.Play();
        }

        public void abrir_cortinas()
        {
            bkground_sound.SoundLocation = @"D:\github\musicas\Dormir2Versoes.wav";
            bkground_sound.Play();
        }

        public void abrir_janela()
        {
            bkground_sound.SoundLocation = @"D:\github\musicas\Dormir2Versoes.wav";
            bkground_sound.Play();
        }

        public void gritos()
        {
            bkground_sound.SoundLocation = @"D:\github\musicas\Dormir2Versoes.wav";
            bkground_sound.Play();
        }

        public void gritar_morrer()
        {
            bkground_sound.SoundLocation = @"D:\github\musicas\Dormir2Versoes.wav";
            bkground_sound.Play();
        }

        public string get_versao()
        {
            return versao;
        }



    
    }
    */
    }
}
