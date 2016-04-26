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
    public partial class Form6 : Form
    {
        private vitoria_derrota gp;
        public menu_jogo mn6;


        public Form6()
        {
            InitializeComponent();
        }
        public void set_jogo(menu_jogo mn)
        {
            mn6 = mn;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form7 = new Form7();           
            form7.ShowDialog();
            form7 = null;
            this.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label_ganhar.Visible = false;
            label_perder.Visible = false;
            botao_seguinte_fim.Visible = false;
            botao_back_fim.Visible = false;

            gp = new vitoria_derrota();

            gp.set_opcao();
            if (gp.get_opcao() != "vitoria")
            {
                Image myimage = new Bitmap(jogo_assassino.Properties.Resources.vitoria);
                this.BackgroundImage = myimage;

                label_ganhar.Visible = true;
                botao_seguinte_fim.Visible = true;
                botao_seguinte_fim.Enabled = true;
                label_ganhar.Enabled = true;


            }

            if (gp.get_opcao() != "derrota")
            {
                Image myimage = new Bitmap(jogo_assassino.Properties.Resources.derrota_sim);
                this.BackgroundImage = myimage;

                label_perder.Visible = true;
                botao_back_fim.Visible = true;
                botao_back_fim.Enabled = true;
                label_perder.Enabled = true;

            }

            if (mn6.get_versao() == "terror")
            {
                Image myimage = new Bitmap(jogo_assassino.Properties.Resources.derrota_sim);
                this.BackgroundImage = myimage;

                label_perder.Visible = true;
                botao_back_fim.Visible = true;
                botao_back_fim.Enabled = true;
                label_perder.Enabled = true;
            }

            if (mn6.get_versao() == "normal")
            {
               
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.ShowDialog();
            form5 = null;
            this.Show();
        }
    }
}
