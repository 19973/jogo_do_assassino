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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            List<pessoa> jogadores = new List<pessoa>();

            /*policia p = new policia();
            assassino a = new assassino();
            inocente i = new inocente();

            jogadores.Add(p); // se for policia
            jogadores.Add(a); // se for assasino
            jogadores.Add(i); // se for inocente */
        }

    }
}
