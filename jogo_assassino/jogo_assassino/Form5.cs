using System;
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
        }

        private void Player_Enter(object sender, EventArgs e)
        {

        }

        private void progressBar_Saude_Click(object sender, EventArgs e)
        {

        }

        private void but_Opcao1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
