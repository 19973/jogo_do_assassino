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
        protected int sono = 0;
        protected int fome = 0;


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

        public string get_personagem()
        {
            return personagem;
   
        }
    }
}
