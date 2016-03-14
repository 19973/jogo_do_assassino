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

    public partial class Form2 : Form
    {
        jogo jg;
        menu_jogo mn2;


        public Form2()
        {
            InitializeComponent();

        }


        /*public void set_jogo(menu_jogo mn)
        {
            mn2 = mn;
        }

    */


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "3")
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
            }

            if (comboBox1.Text == "4")
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = false;
            }

            if (comboBox1.Text == "5")
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
            }
        }

        private void back_botao_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }


        private void next_botao_Click(object sender, EventArgs e)
        {
            try {
            
                switch (int.Parse(comboBox1.SelectedItem.ToString()))
                {

                    
                    case 3:

                            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                    {
                            if (textBox1.Text != textBox2.Text && textBox1.Text != textBox3.Text && textBox2.Text != textBox3.Text)
                            {

                                this.Hide();
                                Form3 form3 = new Form3();
                                Control t = form3.Controls.Find("tex_Player1", true)[0];
                                t.Text = textBox1.Text;
                                t = form3.Controls.Find("tex_Player2", true)[0];
                                t.Text = textBox2.Text;
                                t = form3.Controls.Find("tex_Player3", true)[0];
                                t.Text = textBox3.Text;
                                t = form3.Controls.Find("comboBox_Player", true)[0];
                                t.Text = comboBox1.Text;


                                form3.Show();
                                jg = new jogo(int.Parse(comboBox1.Text));
                            }
                            else
                            {
                                MessageBox.Show("Tem nomes repetidos");
                            }
                    }
                        else
                        {
                            MessageBox.Show("Voce tem que preencher os 3 campos");
                        }

                    break;
                           
                    case 4:
                        if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                        {
                            if (textBox1.Text != textBox2.Text && textBox1.Text != textBox3.Text && textBox1.Text != textBox4.Text && textBox2.Text != textBox3.Text && textBox2.Text != textBox4.Text && textBox3.Text != textBox5.Text)
                            {
                                this.Hide();
                                Form3 form3 = new Form3();
                                Control t = form3.Controls.Find("tex_Player1", true)[0];
                                t.Text = textBox1.Text;
                                t = form3.Controls.Find("tex_Player2", true)[0];
                                t.Text = textBox2.Text;
                                t = form3.Controls.Find("tex_Player3", true)[0];
                                t.Text = textBox3.Text;
                                t = form3.Controls.Find("tex_Player4", true)[0];
                                t.Text = textBox4.Text;
                                t = form3.Controls.Find("comboBox_Player", true)[0];
                                t.Text = comboBox1.Text;
                                form3.Show();
                                jg = new jogo(int.Parse(comboBox1.Text));
                            }
                            else
                            {
                                MessageBox.Show("Tem nomes repetidos");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Voce tem que preencher os 4 campos");
                        }

                        break;

                    case 5:
                        if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                        {
                            if (textBox1.Text != textBox2.Text && textBox1.Text != textBox3.Text && textBox1.Text != textBox4.Text && textBox1.Text != textBox5.Text && textBox2.Text != textBox3.Text && textBox2.Text != textBox4.Text && textBox2.Text != textBox5.Text && textBox3.Text != textBox4.Text && textBox3.Text != textBox5.Text && textBox4.Text != textBox5.Text)
                            {
                                this.Hide();
                                Form3 form3 = new Form3();
                                Control t = form3.Controls.Find("tex_Player1", true)[0];
                                t.Text = textBox1.Text;
                                t = form3.Controls.Find("tex_Player2", true)[0];
                                t.Text = textBox2.Text;
                                t = form3.Controls.Find("tex_Player3", true)[0];
                                t.Text = textBox3.Text;
                                t = form3.Controls.Find("tex_Player4", true)[0];
                                t.Text = textBox4.Text;
                                t = form3.Controls.Find("tex_Player5", true)[0];
                                t.Text = textBox5.Text;
                                t = form3.Controls.Find("comboBox_Player", true)[0];
                                t.Text = comboBox1.Text;
                                form3.Show();
                                jg = new jogo(int.Parse(comboBox1.Text));
                            }
                            else
                            {
                                MessageBox.Show("Tem nomes repetidos");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Voce tem que preencher os 5 campos");
                        }


                        break;

                    default:
                        MessageBox.Show("Vôce não inseriu todo os dados necessario");
                        break;
                }
                }
            catch(Exception) {

                MessageBox.Show("Voce tem que selecionar os numeros de jogadores");
            }
            

            }
            
 


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            mn2.set_versao();
            if (mn2.get_versao() == "normal")
            {
                Image myimage = new Bitmap(jogo_assassino.Properties.Resources.mesa_terror);
                this.BackgroundImage = myimage;
            }

            if (mn2.get_versao() == "terror")
            {
                Image myimage = new Bitmap(jogo_assassino.Properties.Resources.mesa_casual);
                this.BackgroundImage = myimage;
            } 
        }

    }
}

