using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_assassino
{
    class vitoria_derrota
        
    {
        protected string versao = "normal";
        protected int opcao = 1;
        protected System.Media.SoundPlayer bkground_sound;



        public vitoria_derrota()
        {
            opcao = 1;
            bkground_sound = new System.Media.SoundPlayer();
            bkground_sound.SoundLocation = @"Z:\github_musicas\MudarVersaoNormal.wav";
            bkground_sound.Play();

        }

        public void set_versao()
        {
            if (versao == "normal")
            {
                bkground_sound.Stop();
                versao = "terror";
                opcao = 2;
                // MessageBox.Show("Versão |-Terror-| Ativada");
                bkground_sound.SoundLocation = @"Z:\github_musicas\MudarVersaoTerror.wav";
                bkground_sound.Play();
            }
            else if (versao == "terror")
            {
                bkground_sound.Stop();
                versao = "normal";
                opcao = 1;
                //   MessageBox.Show("Versão |-Casual-| Ativada");
                bkground_sound.SoundLocation = @"Z:\github_musicas\MudarVersaoNormal.wav";
                bkground_sound.Play();
            }
        }

        public string get_versao()
        {
            return versao;
        }
    }
}
