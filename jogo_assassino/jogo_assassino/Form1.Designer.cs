namespace jogo_assassino
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_play = new System.Windows.Forms.PictureBox();
            this.button_exit = new System.Windows.Forms.PictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_creators = new System.Windows.Forms.Label();
            this.button_options = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.button_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_options)).BeginInit();
            this.SuspendLayout();
            // 
            // button_play
            // 
            this.button_play.BackColor = System.Drawing.Color.Transparent;
            this.button_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_play.Image = global::jogo_assassino.Properties.Resources.button_play;
            this.button_play.Location = new System.Drawing.Point(53, 60);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(189, 83);
            this.button_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_play.TabIndex = 5;
            this.button_play.TabStop = false;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.Transparent;
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.Image = global::jogo_assassino.Properties.Resources.button_ext1;
            this.button_exit.Location = new System.Drawing.Point(53, 269);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(189, 83);
            this.button_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_exit.TabIndex = 7;
            this.button_exit.TabStop = false;
            this.button_exit.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_title.Location = new System.Drawing.Point(29, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(235, 36);
            this.label_title.TabIndex = 8;
            this.label_title.Text = "Jogo do Assasino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 9;
            // 
            // label_creators
            // 
            this.label_creators.AutoSize = true;
            this.label_creators.BackColor = System.Drawing.Color.Transparent;
            this.label_creators.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_creators.ForeColor = System.Drawing.Color.White;
            this.label_creators.Location = new System.Drawing.Point(3, 364);
            this.label_creators.Name = "label_creators";
            this.label_creators.Size = new System.Drawing.Size(393, 19);
            this.label_creators.TabIndex = 10;
            this.label_creators.Text = "Criado Por: Nelson Silva, Michael Luis e Miguel Canhola";
            // 
            // button_options
            // 
            this.button_options.BackColor = System.Drawing.Color.Transparent;
            this.button_options.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_options.Image = global::jogo_assassino.Properties.Resources.button_options1;
            this.button_options.Location = new System.Drawing.Point(53, 166);
            this.button_options.Name = "button_options";
            this.button_options.Size = new System.Drawing.Size(189, 83);
            this.button_options.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_options.TabIndex = 11;
            this.button_options.TabStop = false;
            this.button_options.Click += new System.EventHandler(this.button_options_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::jogo_assassino.Properties.Resources.fancy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 386);
            this.ControlBox = false;
            this.Controls.Add(this.button_options);
            this.Controls.Add(this.label_creators);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_play);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo do assasino";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.button_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_options)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox button_play;
        private System.Windows.Forms.PictureBox button_exit;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_creators;
        private System.Windows.Forms.PictureBox button_options;
    }
}

