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
            Lab_Player1_Pronto.Hide();
            Lab_Player2_Pronto.Hide();
            Lab_Player3_Pronto.Hide();
            Lab_Player4_Pronto.Hide();
            Lab_Player5_Pronto.Hide();
            But_Nao.Hide();
            But_Sim.Hide();
            Imag_Classes.Hide();
        }

      
        private void But_Nao_Click(object sender, EventArgs e)
        {


            Lab_Classe.Show();
            Lab_Player1.Show();
            Lab_Player2.Show(); 
            Lab_Player3.Show();
            Lab_Player4.Show();
            Lab_Player5.Show();
            List_Classes.Show();
            tex_Player1.Show();
            tex_Player2.Show();
            tex_Player3.Show();
            tex_Player4.Show();
            tex_Player5.Show();
            Seguinte.Enabled = true;
            Voltar.Enabled = true;
            Lab_Player1_Pronto.Hide();
            Lab_Player2_Pronto.Hide();
            Lab_Player3_Pronto.Hide();
            Lab_Player4_Pronto.Hide();
            Lab_Player5_Pronto.Hide();
            But_Nao.Hide();
            But_Sim.Hide();
            Imag_Classes.Hide();
            
        }

        private void Seguinte_Click_1(object sender, EventArgs e)
        {
            Image image_Default = Image.FromFile(@"C:\Users\20247\Source\Repos\jogo_do_assassino2\jogo_assassino\jogo_assassino\bin\Debug\Imagens\Default.jpg");

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
            Voltar.Enabled = false;
            Lab_Player1_Pronto.Show();
            Lab_Player2_Pronto.Show();
            Lab_Player3_Pronto.Show();
            Lab_Player4_Pronto.Show();
            Lab_Player5_Pronto.Show();
            But_Nao.Show();
            But_Sim.Show();
            Imag_Classes.Show();
            Imag_Classes.Image = image_Default;
        }
    

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void But_Sim_Click(object sender, EventArgs e)
        {
            
            Image image1 = Image.FromFile(@"C:\Users\20247\Source\Repos\jogo_do_assassino2\jogo_assassino\jogo_assassino\bin\Debug\Imagens\Assassino.jpg");
            Image image2 = Image.FromFile(@"C:\Users\20247\Source\Repos\jogo_do_assassino2\jogo_assassino\jogo_assassino\bin\Debug\Imagens\Policia.jpg");
            Image image3 = Image.FromFile(@"C:\Users\20247\Source\Repos\jogo_do_assassino2\jogo_assassino\jogo_assassino\bin\Debug\Imagens\Inocente.jpg");
            Random rnd = new Random();
            int Gerar_Classes = rnd.Next(4);

            if (Gerar_Classes == 1){
                Imag_Classes.Image = image1;
                But_Sim.Enabled = false;
            }

            if (Gerar_Classes == 2)
            {
                Imag_Classes.Image = image2;
                But_Sim.Enabled = false;
            }

            if (Gerar_Classes == 3)
            {
                Imag_Classes.Image = image3;
                But_Sim.Enabled = false;
            }
        }
    }
}

