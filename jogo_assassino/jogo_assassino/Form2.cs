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
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "3")
            {
                Nome_jogador_1.Enabled = true;
                Nome_jogador_2.Enabled = true;
                Nome_jogador_3.Enabled = true;
                Nome_jogador_4.Enabled = false;
                Nome_jogador_5.Enabled = false;
            }

            if (comboBox1.Text == "4")
            {
                Nome_jogador_1.Enabled = true;
                Nome_jogador_2.Enabled = true;
                Nome_jogador_3.Enabled = true;
                Nome_jogador_4.Enabled = true;
                Nome_jogador_5.Enabled = false;
            }

            if (comboBox1.Text == "5")
            {
                Nome_jogador_1.Enabled = true;
                Nome_jogador_2.Enabled = true;
                Nome_jogador_3.Enabled = true;
                Nome_jogador_4.Enabled = true;
                Nome_jogador_5.Enabled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
      

            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
