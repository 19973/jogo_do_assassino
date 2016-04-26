namespace jogo_assassino
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label1 = new System.Windows.Forms.Label();
            this.label_perder = new System.Windows.Forms.Label();
            this.label_ganhar = new System.Windows.Forms.Label();
            this.botao_back_fim = new System.Windows.Forms.PictureBox();
            this.botao_seguinte_fim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.botao_back_fim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_seguinte_fim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Player";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_perder
            // 
            this.label_perder.AutoSize = true;
            this.label_perder.BackColor = System.Drawing.Color.Transparent;
            this.label_perder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_perder.Location = new System.Drawing.Point(14, 141);
            this.label_perder.Name = "label_perder";
            this.label_perder.Size = new System.Drawing.Size(258, 50);
            this.label_perder.TabIndex = 3;
            this.label_perder.Text = "Não poderá jogar mais.\r\nEspere que o jogo acabe.";
            this.label_perder.Visible = false;
            this.label_perder.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_ganhar
            // 
            this.label_ganhar.AutoSize = true;
            this.label_ganhar.BackColor = System.Drawing.Color.Transparent;
            this.label_ganhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ganhar.ForeColor = System.Drawing.Color.Black;
            this.label_ganhar.Location = new System.Drawing.Point(12, 141);
            this.label_ganhar.Name = "label_ganhar";
            this.label_ganhar.Size = new System.Drawing.Size(243, 50);
            this.label_ganhar.TabIndex = 6;
            this.label_ganhar.Text = "Parabéns! Ganhaste\r\nClick no botão seguinte.";
            this.label_ganhar.Click += new System.EventHandler(this.label5_Click);
            // 
            // botao_back_fim
            // 
            this.botao_back_fim.Image = global::jogo_assassino.Properties.Resources.back_button;
            this.botao_back_fim.Location = new System.Drawing.Point(3, 205);
            this.botao_back_fim.Name = "botao_back_fim";
            this.botao_back_fim.Size = new System.Drawing.Size(100, 50);
            this.botao_back_fim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botao_back_fim.TabIndex = 5;
            this.botao_back_fim.TabStop = false;
            this.botao_back_fim.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // botao_seguinte_fim
            // 
            this.botao_seguinte_fim.BackColor = System.Drawing.Color.Transparent;
            this.botao_seguinte_fim.Image = global::jogo_assassino.Properties.Resources.Seguinte;
            this.botao_seguinte_fim.Location = new System.Drawing.Point(172, 205);
            this.botao_seguinte_fim.Name = "botao_seguinte_fim";
            this.botao_seguinte_fim.Size = new System.Drawing.Size(100, 50);
            this.botao_seguinte_fim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botao_seguinte_fim.TabIndex = 4;
            this.botao_seguinte_fim.TabStop = false;
            this.botao_seguinte_fim.Visible = false;
            this.botao_seguinte_fim.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::jogo_assassino.Properties.Resources.vitoria;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.label_ganhar);
            this.Controls.Add(this.botao_back_fim);
            this.Controls.Add(this.botao_seguinte_fim);
            this.Controls.Add(this.label_perder);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vitoria/Derrota";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.botao_back_fim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botao_seguinte_fim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_perder;
        private System.Windows.Forms.PictureBox botao_seguinte_fim;
        private System.Windows.Forms.PictureBox botao_back_fim;
        private System.Windows.Forms.Label label_ganhar;
    }
}