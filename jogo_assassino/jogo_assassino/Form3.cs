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
    public partial class Form3 : System.Windows.Forms.Form
    {
        Image imagem_Default = new Bitmap(jogo_assassino.Properties.Resources.Default);
        Image imagem1 = new Bitmap(jogo_assassino.Properties.Resources.Assassino);
        Image imagem2 = new Bitmap(jogo_assassino.Properties.Resources.Policia);
        Image imagem3 = new Bitmap(jogo_assassino.Properties.Resources.Inocente);
        Random rnd = new Random();
        List<string> classes = new List<string>();

        public Form3()
        {
            InitializeComponent();

            Lab_Player1_Pronto.Hide();
            Lab_Player2_Pronto.Hide();
            Lab_Player3_Pronto.Hide();
            Lab_Player4_Pronto.Hide();
            Lab_Player5_Pronto.Hide();
            But_Nao.Hide();
            But_Sim1.Hide();
            But_Sim2.Hide();
            But_Sim3.Hide();
            But_Sim4.Hide();
            But_Sim5.Hide();
            Imag_Classes.Hide();
            tex_Player1.Enabled = false;
            tex_Player2.Enabled = false;
            tex_Player3.Enabled = false;
            tex_Player4.Enabled = false;
            tex_Player5.Enabled = false;

            classes.Add("Policia");
            classes.Add("Ladrao");
            classes.Add("Inocente");
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
            Seguinte.Enabled = true;
            Voltar.Enabled = true;
            Lab_Player1_Pronto.Hide();
            Lab_Player2_Pronto.Hide();
            Lab_Player3_Pronto.Hide();
            Lab_Player4_Pronto.Hide();
            Lab_Player5_Pronto.Hide();
            But_Nao.Hide();
            But_Sim1.Hide();
            But_Sim2.Hide();
            But_Sim3.Hide();
            But_Sim4.Hide();
            But_Sim5.Hide();
            Imag_Classes.Hide();
            But_Sim1.Enabled = true;

        }

        private void Seguinte_Click_1(object sender, EventArgs e)
        {
            Image imagem_Default = new Bitmap(jogo_assassino.Properties.Resources.Default);

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
            Seguinte.Enabled = false;
            Voltar.Enabled = false;
            Lab_Player1_Pronto.Show();
            Lab_Player2_Pronto.Show();
            Lab_Player3_Pronto.Show();
            Lab_Player4_Pronto.Show();
            Lab_Player5_Pronto.Show();
            But_Nao.Show();
            But_Sim1.Show();
            But_Sim2.Show();
            But_Sim3.Show();
            But_Sim4.Show();
            But_Sim5.Show();
            Imag_Classes.Show();
            Imag_Classes.Image = imagem_Default;
        }


        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2(/*mn*/);
            form2.Show();

        }

        private void But_Sim1_Click(object sender, EventArgs e)
        {

            int Gerar_classes = rnd.Next(classes.Count);



            if (comboBox_Player.SelectedItem.ToString() == "3")
            {

                if (Gerar_classes == 0)
                {
                    Imag_Classes.Image = imagem2;
                    But_Nao.Enabled = false;
                    But_Sim1.Enabled = false;
                    classes.Remove("Policia");
                    imagem2.Dispose();
                    DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        But_Sim1.Hide();
                        Lab_Player1_Pronto.Hide();

                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }

                }


                if (Gerar_classes == 1)
                {
                    Imag_Classes.Image = imagem1;
                    But_Nao.Enabled = false;
                    But_Sim1.Enabled = false;
                    classes.Remove("Ladrao");
                    imagem1.Dispose();
                    DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        But_Sim1.Hide();
                        Lab_Player1_Pronto.Hide();

                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }

                }

                if (Gerar_classes == 2)
                {
                    Imag_Classes.Image = imagem3;
                    But_Nao.Enabled = false;
                    But_Sim1.Enabled = false;
                    classes.Remove("Inocente");
                    imagem3.Dispose();
                    DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        But_Sim1.Hide();
                        Lab_Player1_Pronto.Hide();
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
            }

            /*  if(comboBox_Player.SelectedItem.ToString() == "4")
              {

                  if (Gerar_classes == 0)
                  {
                      Imag_Classes.Image = imagem2;
                      But_Nao.Enabled = false;
                      But_Sim1.Enabled = false;
                      classes.Remove("Policia");
                      DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                      if (dialogResult == DialogResult.Yes)
                      {
                          But_Sim1.Hide();
                          Lab_Player1_Pronto.Hide();

                      }
                      else if (dialogResult == DialogResult.No)
                      {

                      }

                  }


                  if (Gerar_classes == 1)
                  {
                      Imag_Classes.Image = imagem1;
                      But_Nao.Enabled = false;
                      But_Sim1.Enabled = false;
                      classes.Remove("Ladrao");
                      DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                      if (dialogResult == DialogResult.Yes)
                      {
                          But_Sim1.Hide();
                          Lab_Player1_Pronto.Hide();

                      }
                      else if (dialogResult == DialogResult.No)
                      {

                      }

                  }

                  if (Gerar_classes == 2)
                  {
                      Imag_Classes.Image = imagem3;
                      But_Nao.Enabled = false;
                      But_Sim1.Enabled = false;
                      classes.Remove("Inocente");
                      DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                      if (dialogResult == DialogResult.Yes)
                      {
                          But_Sim1.Hide();
                          Lab_Player1_Pronto.Hide();
                      }
                      else if (dialogResult == DialogResult.No)
                      {

                      }
                  }
              }


               if(comboBox_Player.SelectedItem.ToString() == "5"){


                  if (Gerar_classes == 0)
                  {
                      Imag_Classes.Image = imagem2;
                      But_Nao.Enabled = false;
                      But_Sim1.Enabled = false;
                      classes.Remove("Policia");
                      DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                      if (dialogResult == DialogResult.Yes)
                      {
                          But_Sim1.Hide();
                          Lab_Player1_Pronto.Hide();

                      }
                      else if (dialogResult == DialogResult.No)
                      {

                      }

                  }


                  if (Gerar_classes == 1)
                  {
                      Imag_Classes.Image = imagem1;
                      But_Nao.Enabled = false;
                      But_Sim1.Enabled = false;
                      classes.Remove("Ladrao");
                      DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                      if (dialogResult == DialogResult.Yes)
                      {
                          But_Sim1.Hide();
                          Lab_Player1_Pronto.Hide();

                      }
                      else if (dialogResult == DialogResult.No)
                      {

                      }

                  }

                  if (Gerar_classes == 2)
                  {
                      Imag_Classes.Image = imagem3;
                      But_Nao.Enabled = false;
                      But_Sim1.Enabled = false;
                      classes.Remove("Inocente");
                      DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                      if (dialogResult == DialogResult.Yes)
                      {
                          But_Sim1.Hide();
                          Lab_Player1_Pronto.Hide();
                      }
                      else if (dialogResult == DialogResult.No)
                      {

                      }
                   } 
              }*/


        }

        private void But_Sim2_Click(object sender, EventArgs e)
        {
            int Gerar_classes = rnd.Next(classes.Count);

            if (comboBox_Player.SelectedItem.ToString() == "3")
            {
                if (Gerar_classes == 1)
                {
                    Imag_Classes.Image = imagem3;
                    But_Nao.Enabled = false;
                    But_Sim2.Enabled = false;
                    classes.Remove("Ladrao");
                    imagem1.Dispose();
                    DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        But_Sim2.Hide();
                        Lab_Player2_Pronto.Hide();
                    }
                }

                if (Gerar_classes == 2)
                {
                    Imag_Classes.Image = imagem3;
                    But_Nao.Enabled = false;
                    But_Sim2.Enabled = false;
                    classes.Remove("Policia");
                    imagem2.Dispose();
                    DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        But_Sim2.Hide();
                        Lab_Player2_Pronto.Hide();
                    }
                }

                if (Gerar_classes == 0)
                {
                    Imag_Classes.Image = imagem3;
                    But_Nao.Enabled = false;
                    But_Sim2.Enabled = false;
                    imagem3.Dispose();
                    DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        But_Sim2.Hide();
                        Lab_Player2_Pronto.Hide();
                    }
                }
            }
            
            //combo4
            if (comboBox_Player.SelectedItem.ToString() == "4")
            {
                if (Gerar_classes == 1)
                {
                    Imag_Classes.Image = imagem3;
                    But_Nao.Enabled = false;
                    But_Sim2.Enabled = false;
                    classes.Remove("Ladrao");
                    imagem1.Dispose();
                    DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        But_Sim2.Hide();
                        Lab_Player2_Pronto.Hide();
                    }
                }

                if (Gerar_classes == 2)
                {
                    Imag_Classes.Image = imagem3;
                    But_Nao.Enabled = false;
                    But_Sim2.Enabled = false;
                    classes.Remove("Policia");
                    imagem2.Dispose();
                    DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        But_Sim2.Hide();
                        Lab_Player2_Pronto.Hide();
                    }
                }

                if (Gerar_classes == 0)
                {
                    Imag_Classes.Image = imagem3;
                    But_Nao.Enabled = false;
                    But_Sim2.Enabled = false;
                    classes.Remove("inocente");
                    DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        But_Sim2.Hide();
                        Lab_Player2_Pronto.Hide();
                    }
                }
            }

            //combo 5
            if (comboBox_Player.SelectedItem.ToString() == "5")
            {
                if (Gerar_classes == 1)
                {
                    Imag_Classes.Image = imagem3;
                    But_Nao.Enabled = false;
                    But_Sim2.Enabled = false;
                    classes.Remove("Ladrao");
                    DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        But_Sim2.Hide();
                        Lab_Player2_Pronto.Hide();
                    }
                }

                if (Gerar_classes == 2)
                {
                    Imag_Classes.Image = imagem3;
                    But_Nao.Enabled = false;
                    But_Sim2.Enabled = false;
                    classes.Remove("Policia");
                    DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        But_Sim2.Hide();
                        Lab_Player2_Pronto.Hide();
                    }
                }

                if (Gerar_classes == 0)
                {
                    Imag_Classes.Image = imagem3;
                    But_Nao.Enabled = false;
                    But_Sim2.Enabled = false;
                    DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        But_Sim2.Hide();
                        Lab_Player2_Pronto.Hide();
                    }
                }
            }
        }

        private void But_Sim3_Click(object sender, EventArgs e)
        {
            int Gerar_classes = rnd.Next(classes.Count);

            if (comboBox_Player.SelectedItem.ToString() == "3")
            {
                if (Gerar_classes == 1)
                {
                    Imag_Classes.Image = imagem3;
                    But_Nao.Enabled = false;
                    But_Sim2.Enabled = false;
                    classes.Remove("Ladrao");
                    imagem1.Dispose();
                    DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        But_Sim3.Hide();
                        Lab_Player3_Pronto.Hide();
                    }
                }

                if (Gerar_classes == 2)
                {
                    Imag_Classes.Image = imagem3;
                    But_Nao.Enabled = false;
                    But_Sim3.Enabled = false;
                    classes.Remove("Policia");
                    imagem2.Dispose();
                    DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        But_Sim3.Hide();
                        Lab_Player3_Pronto.Hide();
                    }
                }

                if (Gerar_classes == 0)
                {
                    Imag_Classes.Image = imagem3;
                    But_Nao.Enabled = false;
                    But_Sim3.Enabled = false;
                    DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        But_Sim3.Hide();
                        Lab_Player3_Pronto.Hide();
                    }
                }

                if (comboBox_Player.SelectedItem.ToString() == "4")
                {
                    if (Gerar_classes == 1)
                    {
                        Imag_Classes.Image = imagem3;
                        But_Nao.Enabled = false;
                        But_Sim2.Enabled = false;
                        classes.Remove("Ladrao");
                        imagem1.Dispose();
                        DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            But_Sim3.Hide();
                            Lab_Player3_Pronto.Hide();
                        }
                    }

                    if (Gerar_classes == 2)
                    {
                        Imag_Classes.Image = imagem3;
                        But_Nao.Enabled = false;
                        But_Sim3.Enabled = false;
                        classes.Remove("Policia");
                        imagem2.Dispose();
                        DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            But_Sim3.Hide();
                            Lab_Player3_Pronto.Hide();
                        }
                    }

                    if (Gerar_classes == 0)
                    {
                        Imag_Classes.Image = imagem3;
                        But_Nao.Enabled = false;
                        But_Sim3.Enabled = false;
                        DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            But_Sim3.Hide();
                            Lab_Player3_Pronto.Hide();
                        }
                    }
                }

                if (comboBox_Player.SelectedItem.ToString() == "4")
                {
                    if (Gerar_classes == 1)
                    {
                        Imag_Classes.Image = imagem3;
                        But_Nao.Enabled = false;
                        But_Sim2.Enabled = false;
                        classes.Remove("Ladrao");
                        imagem1.Dispose();
                        DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            But_Sim3.Hide();
                            Lab_Player3_Pronto.Hide();
                        }
                    }

                    if (Gerar_classes == 2)
                    {
                        Imag_Classes.Image = imagem3;
                        But_Nao.Enabled = false;
                        But_Sim3.Enabled = false;
                        classes.Remove("Policia");
                        imagem2.Dispose();
                        DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            But_Sim3.Hide();
                            Lab_Player3_Pronto.Hide();
                        }
                    }

                    if (Gerar_classes == 0)
                    {
                        Imag_Classes.Image = imagem3;
                        But_Nao.Enabled = false;
                        But_Sim3.Enabled = false;
                        DialogResult dialogResult = MessageBox.Show("Se estiveres pronto Clica Sim e vira as costas", "Vez Do Adversário", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            But_Sim3.Hide();
                            Lab_Player3_Pronto.Hide();
                        }
                    }
                }
            }
        }
    }
}



