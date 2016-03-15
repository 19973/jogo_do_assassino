﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_assassino
{
    public partial class Form6 : Form
    {
        private vitoria_derrota gp;

        public Form6()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            gp = new vitoria_derrota();

            gp.set_opcao();
            if (gp.get_opcao() == "vitoria")
            {
                Image myimage = new Bitmap(jogo_assassino.Properties.Resources.vitoria);
                this.BackgroundImage = myimage;
            }

            if (gp.get_opcao() == "derrota")
            {
                Image myimage = new Bitmap(jogo_assassino.Properties.Resources.derrota_sim);
                this.BackgroundImage = myimage;
            }
        }
    }
}
