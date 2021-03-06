﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_assassino
{

    public partial class Form5 : Form
    {


        public menu_jogo mn5;
        private pessoa p;
        int rondas = 1;
        int jogadas = 0;
        /* private assassino ass;
        private policia pol;
        private inocente ino; */
        public Form5()
        {
            InitializeComponent();

        }



        public void set_jogo(menu_jogo mn4)
        {
            mn5 = mn4;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            p = new pessoa();
            if (mn5.get_versao() == "terror")
            {
                Image myimage = new Bitmap(jogo_assassino.Properties.Resources.corredor_fancy);
                this.BackgroundImage = myimage;
            }

            if (mn5.get_versao() == "normal")
            {
                Image myimage = new Bitmap(jogo_assassino.Properties.Resources.corredor);
                this.BackgroundImage = myimage;
            }

            progressBar_Descanso.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            progressBar_Comida.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            progressBar_Saude.Style = System.Windows.Forms.ProgressBarStyle.Continuous;

            progressBar_Descanso.ForeColor = Color.DeepSkyBlue;
            progressBar_Descanso.Minimum = 0;
            progressBar_Descanso.Maximum = 100;
            progressBar_Descanso.Step = 5;

            for (int x = 1; x <= 100; x++)
            {
                progressBar_Descanso.PerformStep();

            }
            progressBar_Saude.ForeColor = Color.Green;
            progressBar_Saude.Minimum = 0;
            progressBar_Saude.Maximum = 100;
            progressBar_Saude.Step = 5;

            for (int x = 1; x <= 100; x++)
            {
                progressBar_Saude.PerformStep();

            }
            progressBar_Comida.ForeColor = Color.Orange;
            progressBar_Comida.Minimum = 0;
            progressBar_Comida.Maximum = 100;
            progressBar_Comida.Step = 5;

            for (int x = 1; x <= 100; x++)
            {
                progressBar_Comida.PerformStep();

            }


            if (p.get_personagem() == "Inocente")
            {
                lab_Opcao6.Text = "";
                lab_Opcao7.Text = "";
                lab_Opcao8.Text = "Apanhar Arma";
                lab_Opcao9.Text = "Denunciar";
                lab_Opcao10.Text = "Suicidar";
            }

            if (p.get_personagem() == "Policia")
            {
                lab_Opcao6.Text = "Prender";
                lab_Opcao7.Text = "Disparar";
                lab_Opcao8.Text = "Investigar";
                lab_Opcao9.Text = "";
                lab_Opcao10.Text = "";
            }

            if (p.get_personagem() == "Assasino")
            {
                lab_Opcao6.Text = "Denunciar";
                lab_Opcao7.Text = "Raptar";
                lab_Opcao8.Text = "Esfaquear";
                lab_Opcao9.Text = "Investigar";
                lab_Opcao10.Text = "Esconder Arma";
            }

            num_rondas.Text = rondas.ToString();


        }

        private void Player_Enter(object sender, EventArgs e)
        {

        }

        private void progressBar_Saude_Click(object sender, EventArgs e)
        {

        }

        private void but_Opcao1_Click(object sender, EventArgs e)
        {

            progressBar_Comida.Step = 30;
            progressBar_Comida.PerformStep();
            jogadas++;
            if (jogadas == 4)
            {
                rondas++;
                num_rondas.Text = rondas.ToString();
                jogadas = 0;
            }

        }

        private void but_Opcao6_Click(object sender, EventArgs e)
        {
            if (p.get_personagem() == "Assasino")
            {

            }

            if (p.get_personagem() == "Policia")
            {

            }

            if (p.get_personagem() == "Inocente")
            {

            }
        }

        private void but_Opcao2_Click(object sender, EventArgs e)
        {

            progressBar_Descanso.Step = 40;
            progressBar_Descanso.PerformStep();
            jogadas++;
            if (jogadas == 4)
            {
                rondas++;
                num_rondas.Text = rondas.ToString();
                jogadas = 0;
            }

        }

        private void but_Opcao5_Click(object sender, EventArgs e)
        {
            progressBar_Descanso.Step = 10;
            progressBar_Descanso.PerformStep();
            progressBar_Comida.Step = (-10);
            progressBar_Comida.PerformStep();
            num_rondas.Text = rondas.ToString();
            jogadas++;
            if (jogadas == 4)
            {
                rondas++;
                num_rondas.Text = rondas.ToString();
                jogadas = 0;
            }
        }

        private void but_Opcao4_Click(object sender, EventArgs e)
        {
            progressBar_Descanso.Step = (-5);
            progressBar_Descanso.PerformStep();
            progressBar_Comida.Step = (-5);
            progressBar_Comida.PerformStep();
            if (jogadas == 4)
            {
                rondas++;
                num_rondas.Text = rondas.ToString();
                jogadas = 0;
            }
            comboBox_enviar_mensagem.Visible = true;
        }
    }
}
