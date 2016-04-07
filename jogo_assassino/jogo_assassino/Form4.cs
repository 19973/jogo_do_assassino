using System;
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
    public partial class Form4 : Form
    {
        public menu_jogo mn4;

        public Form4()
        {
            InitializeComponent();
        }

        public void set_jogo(menu_jogo mn3)
        {
            mn4 = mn3;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (mn4.get_versao() == "normal")
            {
                Image myimage = new Bitmap(jogo_assassino.Properties.Resources.elect);
                this.BackgroundImage = myimage;

                pictureBox5.Image = Properties.Resources.aro;

                pictureBox4.Image = Properties.Resources.gifs_gifs_terror_41;

                pictureBox6.Image = Properties.Resources.tumblr_mk34zvLlli1s92578o1_500;


            }

            if (mn4.get_versao() == "terror")
            {
                Image myimage = new Bitmap(jogo_assassino.Properties.Resources.elect);
                this.BackgroundImage = myimage;

                pictureBox5.Image = Properties.Resources.gif_Normal_1;

                pictureBox4.Image = Properties.Resources.gif_Normal_2;

                pictureBox6.Image = Properties.Resources.gif_Normal_3;


            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            form1 = null;
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            this.Hide();
            Form5 form5 = new Form5();
            form5.set_jogo(mn4);
            form5.ShowDialog();
            form5 = null;
            this.Show();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}