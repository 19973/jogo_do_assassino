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
    public partial class Form5 : Form
    {

       
        public menu_jogo mn5;

        public Form5()
        {
            InitializeComponent();
        }

        public void set_jogo(menu_jogo mn4)
        {
            mn5 = mn4;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            if (mn5.get_versao() == "terror")
            {
                Image myimage = new Bitmap(jogo_assassino.Properties.Resources.corredor_fancy);
                this.BackgroundImage = myimage;
            }

            if (mn5.get_versao() == "normal")
            {
                Image myimage = new Bitmap(jogo_assassino.Properties.Resources.corredor);
                this.BackgroundImage = myimage;
            }
        }
    }
}
