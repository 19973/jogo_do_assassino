using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_assassino
{
    class menu_jogo
    {
        protected string versao = "normal";
        protected int opcao = 1;

        public menu_jogo()
        {
            opcao = 1;
        }

        public void set_versao(string versao)
        {
            if (versao == "normal")
            {
                versao = "terror";
                opcao = 2;
                MessageBox.Show("Versão |-Terror-| Ativada");
            }
            else if (versao == "terror")
            {
                versao = "normal";
                opcao = 1;
                MessageBox.Show("Versão |-Casual-| Ativada");
            }
        }

        //public int set_versao(string versao)
    }
}
