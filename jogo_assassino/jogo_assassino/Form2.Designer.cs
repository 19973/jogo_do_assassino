namespace jogo_assassino
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Nome_jogador_1 = new System.Windows.Forms.TextBox();
            this.Nome_jogador_2 = new System.Windows.Forms.TextBox();
            this.Nome_jogador_3 = new System.Windows.Forms.TextBox();
            this.Nome_jogador_4 = new System.Windows.Forms.TextBox();
            this.Nome_jogador_5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.PictureBox();
            this.button_seguinte = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.button_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_seguinte)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(12, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Nome_jogador_1
            // 
            this.Nome_jogador_1.Enabled = false;
            this.Nome_jogador_1.Location = new System.Drawing.Point(252, 49);
            this.Nome_jogador_1.Name = "Nome_jogador_1";
            this.Nome_jogador_1.Size = new System.Drawing.Size(293, 20);
            this.Nome_jogador_1.TabIndex = 1;
            // 
            // Nome_jogador_2
            // 
            this.Nome_jogador_2.Enabled = false;
            this.Nome_jogador_2.Location = new System.Drawing.Point(252, 97);
            this.Nome_jogador_2.Name = "Nome_jogador_2";
            this.Nome_jogador_2.Size = new System.Drawing.Size(293, 20);
            this.Nome_jogador_2.TabIndex = 2;
            // 
            // Nome_jogador_3
            // 
            this.Nome_jogador_3.Enabled = false;
            this.Nome_jogador_3.Location = new System.Drawing.Point(252, 142);
            this.Nome_jogador_3.Name = "Nome_jogador_3";
            this.Nome_jogador_3.Size = new System.Drawing.Size(293, 20);
            this.Nome_jogador_3.TabIndex = 3;
            // 
            // Nome_jogador_4
            // 
            this.Nome_jogador_4.Enabled = false;
            this.Nome_jogador_4.Location = new System.Drawing.Point(252, 191);
            this.Nome_jogador_4.Name = "Nome_jogador_4";
            this.Nome_jogador_4.Size = new System.Drawing.Size(293, 20);
            this.Nome_jogador_4.TabIndex = 4;
            // 
            // Nome_jogador_5
            // 
            this.Nome_jogador_5.Enabled = false;
            this.Nome_jogador_5.Location = new System.Drawing.Point(252, 242);
            this.Nome_jogador_5.Name = "Nome_jogador_5";
            this.Nome_jogador_5.Size = new System.Drawing.Size(293, 20);
            this.Nome_jogador_5.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numero de Jogadores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome dos Jogadores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Player 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Player 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Player 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Player 4:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Player 5:";
            // 
            // button_back
            // 
            this.button_back.BackgroundImage = global::jogo_assassino.Properties.Resources.party;
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_back.Image = global::jogo_assassino.Properties.Resources.back_button;
            this.button_back.Location = new System.Drawing.Point(5, 256);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(100, 50);
            this.button_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_back.TabIndex = 13;
            this.button_back.TabStop = false;
            this.button_back.WaitOnLoad = true;
            this.button_back.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_seguinte
            // 
            this.button_seguinte.BackgroundImage = global::jogo_assassino.Properties.Resources.party;
            this.button_seguinte.Image = global::jogo_assassino.Properties.Resources.Seguinte;
            this.button_seguinte.Location = new System.Drawing.Point(566, 256);
            this.button_seguinte.Name = "button_seguinte";
            this.button_seguinte.Size = new System.Drawing.Size(100, 50);
            this.button_seguinte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_seguinte.TabIndex = 14;
            this.button_seguinte.TabStop = false;
            this.button_seguinte.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::jogo_assassino.Properties.Resources.party;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(666, 309);
            this.ControlBox = false;
            this.Controls.Add(this.button_seguinte);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nome_jogador_5);
            this.Controls.Add(this.Nome_jogador_4);
            this.Controls.Add(this.Nome_jogador_3);
            this.Controls.Add(this.Nome_jogador_2);
            this.Controls.Add(this.Nome_jogador_1);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Número de Jogadores";
            ((System.ComponentModel.ISupportInitialize)(this.button_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_seguinte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Nome_jogador_1;
        private System.Windows.Forms.TextBox Nome_jogador_2;
        private System.Windows.Forms.TextBox Nome_jogador_3;
        private System.Windows.Forms.TextBox Nome_jogador_4;
        private System.Windows.Forms.TextBox Nome_jogador_5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox button_back;
        private System.Windows.Forms.PictureBox button_seguinte;
    }
}