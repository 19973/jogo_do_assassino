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
        private policia pol;
        private assassino ass;
        private inocente ino;
        public menu_jogo mn3;

        Image imagem_Default = new Bitmap(jogo_assassino.Properties.Resources.Default);
        Image imagem_Ladrao= new Bitmap(jogo_assassino.Properties.Resources.Assassino);
        Image imagem_Policia = new Bitmap(jogo_assassino.Properties.Resources.Policia);
        Image imagem_Inocente = new Bitmap(jogo_assassino.Properties.Resources.Inocente);

        Random rnd = new Random();
        List<int> jogadores = new List<int>();
        List<string> papeis = new List<string>();
        int count = (-1);
        string player1 = "";
        string player2 = "";
        string player3 = "";
        string player4 = "";
        string player5 = "";

        public void set_jogo(menu_jogo mn2)
        {
            mn3 = mn2;
        }

        public Form3()
        {
            InitializeComponent();

            

            Lab_Player1_Pronto.Hide();
            But_Nao.Hide();
            But_Sim1.Hide();
            Imag_Classes.Hide();
            tex_Player1.Enabled = false;
            tex_Player2.Enabled = false;
            tex_Player3.Enabled = false;
            tex_Player4.Enabled = false;
            tex_Player5.Enabled = false;

            papeis.Add("policia");
            papeis.Add("ladrao");
            papeis.Add("inocente1");

        }


        private void But_Nao_Click(object sender, EventArgs e)
        {

            Lab_Players.Show();
            Lab_Player1.Show();
            Lab_Player2.Show();
            Lab_Player3.Show();
            Lab_Player4.Show();
            Lab_Player5.Show();
            comboBox_Player.Show();
            tex_Player1.Show();
            tex_Player2.Show();
            tex_Player3.Show();
            tex_Player4.Show();
            tex_Player5.Show();
            Seguinte1.Enabled = true;
            Voltar1.Enabled = true;
            Lab_Player1_Pronto.Hide();
            But_Nao.Hide();
            But_Sim1.Hide();
            Imag_Classes.Hide();
            But_Sim1.Enabled = true;
            Seguinte1.Show();

        }

        private void Seguinte_Click_1(object sender, EventArgs e)
        {
            Image imagem_Default = new Bitmap(jogo_assassino.Properties.Resources.Default);

            Seguinte2.Hide();
            Seguinte1.Hide();
            Voltar1.Hide();
            Voltar2.Hide();
            Lab_Players.Hide();
            Lab_Player1.Hide();
            Lab_Player2.Hide();
            Lab_Player3.Hide();
            Lab_Player4.Hide();
            Lab_Player5.Hide();
            comboBox_Player.Hide();
            tex_Player1.Hide();
            tex_Player2.Hide();
            tex_Player3.Hide();
            tex_Player4.Hide();
            tex_Player5.Hide();
            Lab_Player1_Pronto.Show();
            But_Nao.Show();
            But_Sim1.Show();
            Imag_Classes.Show();
            Imag_Classes.Image = imagem_Default;
        }


        private void Voltar_Click(object sender, EventArgs e)
        {


            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            form2 = null;
            this.Show();


        }
        //Botao1
        private void But_Sim1_Click(object sender, EventArgs e)
        {
            if (comboBox_Player.Text == "4")
                papeis.Add("inocente2");

            if (comboBox_Player.Text == "5")
                papeis.Add("inocente3");



            count++;
            Lab_Player1_Pronto.Text = "Player" + (count+1) + ", Estás Pronto?";
            jogadores.Add(count - 1);

            if (count <= int.Parse(comboBox_Player.Text)-1)
                {

                    if (papeis[count] == "policia")
                    {
                    if (jogadores[0] == 0)
                        player1 = "policia";
                        pol.get_personagem();

                        Imag_Classes.Image = imagem_Policia;
                        MessageBox.Show("Carrega ok e vira as costas se ja sabes a classe");
                        Imag_Classes.Image = imagem_Default;  
                     }
                    else if (papeis[count] == "ladrao")
                    {
                        Imag_Classes.Image = imagem_Ladrao;
                        MessageBox.Show("Carrega ok e vira as costas se ja sabes a classe");
                        Imag_Classes.Image = imagem_Default;
                   }
                    else if (papeis[count] == "inocente1")
                    {
                        Imag_Classes.Image = imagem_Inocente;
                        MessageBox.Show("Carrega ok e vira as costas se ja sabes a classe");
                        Imag_Classes.Image = imagem_Default;
                    }
                    else if (papeis[count] == "inocente2")
                    {
                        Imag_Classes.Image = imagem_Inocente;
                        MessageBox.Show("Carrega ok e vira as costas se ja sabes a classe");
                        Imag_Classes.Image = imagem_Default;                  
                     }
                    else if (papeis[count] == "inocente3")
                    {
                        Imag_Classes.Image = imagem_Inocente;
                        MessageBox.Show("Carrega ok e vira as costas se ja sabes a classe");
                        Imag_Classes.Image = imagem_Default;                      
                    }
            }

            if(count == int.Parse(comboBox_Player.Text))
            {
                Seguinte2.Show();
                Lab_Player1_Pronto.Hide();
                Imag_Classes.Hide();
                But_Sim1.Hide();
                But_Nao.Hide();
                Lab_Pronto_Final.Show();
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
       
            Random rnd = new Random();


            for (int i = 0; i <= 10; i++)
            {
                int p1 = rnd.Next(papeis.Count);
                int p2 = rnd.Next(papeis.Count - 1);


                string troca = papeis[p1];
                papeis.RemoveAt(p1);
                papeis.Insert(p2, troca);

            }

           

            mn3.set_versao();
            if (mn3.get_versao() == "normal")
            {
                Image myimage = new Bitmap(jogo_assassino.Properties.Resources.terror_ponto_int);
                this.BackgroundImage = myimage;
            }

            if (mn3.get_versao() == "terror")
            {
                Image myimage = new Bitmap(jogo_assassino.Properties.Resources.Imagem_Fundo);
                this.BackgroundImage = myimage;
            }

        }

        private void Seguinte2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.set_jogo(mn3);
            form4.ShowDialog();
            form4 = null;
            this.Show();



        }

        private void Voltar2_Click(object sender, EventArgs e)
        {
            Lab_Players.Show();
            Lab_Player1.Show();
            Lab_Player2.Show();
            Lab_Player3.Show();
            Lab_Player4.Show();
            Lab_Player5.Show();
            comboBox_Player.Show();
            tex_Player1.Show();
            tex_Player2.Show();
            tex_Player3.Show();
            tex_Player4.Show();
            tex_Player5.Show();
            Seguinte1.Enabled = true;
            Voltar1.Enabled = true;
            Lab_Player1_Pronto.Hide();
            But_Nao.Hide();
            But_Sim1.Hide();
            But_Nao.Hide();
            Imag_Classes.Hide();
            Seguinte1.Show();
        }

      
    }
}











