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
    public partial class Form3 : System.Windows.Forms.Form
    {


        public Form3()
        {
            InitializeComponent();
        }

        private void Seguinte_Click(object sender, EventArgs e)
        {
            Lab_Classe.Hide();
            Lab_Player1.Hide();
            Lab_Player2.Hide();
            Lab_Player3.Hide();
            Lab_Player4.Hide();
            Lab_Player5.Hide();
            List_Classes.Hide();
            tex_Player1.Hide();
            tex_Player2.Hide();
            tex_Player3.Hide();
            tex_Player4.Hide();
            tex_Player5.Hide();
            Seguinte.Enabled = false;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tex_Player1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

