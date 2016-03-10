namespace jogo_assassino
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.voltar_para_menu = new System.Windows.Forms.PictureBox();
            this.sair_jogo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voltar_para_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sair_jogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.vScrollBar1);
            this.groupBox1.Location = new System.Drawing.Point(35, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estatísticas";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(298, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 237);
            this.vScrollBar1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(322, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estatísticas";
            // 
            // voltar_para_menu
            // 
            this.voltar_para_menu.BackColor = System.Drawing.Color.Transparent;
            this.voltar_para_menu.Image = global::jogo_assassino.Properties.Resources.back_button;
            this.voltar_para_menu.Location = new System.Drawing.Point(399, 289);
            this.voltar_para_menu.Name = "voltar_para_menu";
            this.voltar_para_menu.Size = new System.Drawing.Size(100, 50);
            this.voltar_para_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.voltar_para_menu.TabIndex = 3;
            this.voltar_para_menu.TabStop = false;
            this.voltar_para_menu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sair_jogo
            // 
            this.sair_jogo.Image = global::jogo_assassino.Properties.Resources.button_ext1;
            this.sair_jogo.Location = new System.Drawing.Point(399, 345);
            this.sair_jogo.Name = "sair_jogo";
            this.sair_jogo.Size = new System.Drawing.Size(100, 50);
            this.sair_jogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sair_jogo.TabIndex = 4;
            this.sair_jogo.TabStop = false;
            this.sair_jogo.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::jogo_assassino.Properties.Resources.graficos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(502, 398);
            this.ControlBox = false;
            this.Controls.Add(this.sair_jogo);
            this.Controls.Add(this.voltar_para_menu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.Text = "Estatísticas";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.voltar_para_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sair_jogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.PictureBox voltar_para_menu;
        private System.Windows.Forms.PictureBox sair_jogo;
    }
}