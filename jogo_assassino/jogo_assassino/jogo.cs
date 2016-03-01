using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Timers;


namespace jogo_assassino
{
    class jogo
    {
        protected int num_joagadores;

        public jogo(int novo_num_joagadores)
        {
            num_joagadores = novo_num_joagadores;


        }


        public void Esfaquear()
        {
            System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();
            player1.SoundLocation = @"Z:\Sons_para_o_jogo\Esfaquear.wav";
            player1.Play();

        }

        public void Sangue()
        {
            System.Media.SoundPlayer player2 = new System.Media.SoundPlayer();
            player2.SoundLocation = "Sangue.wav";
            player2.Play();

        }















    }
}
