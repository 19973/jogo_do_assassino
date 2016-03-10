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
    public partial class Form1 : System.Windows.Forms.Form
    {

        private menu_jogo mn;
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mn = new menu_jogo();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
           // form2.set_jogo(mn);
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void button_options_Click(object sender, EventArgs e)
        {
            mn.set_versao();
            if (mn.get_versao() == "normal")
            {
                Image myimage = new Bitmap(jogo_assassino.Properties.Resources.fancy);
                this.BackgroundImage = myimage;
            }

            if (mn.get_versao() == "terror")
            {
                Image myimage = new Bitmap(jogo_assassino.Properties.Resources.creepy);
                this.BackgroundImage = myimage;
            }
        }
    }
}