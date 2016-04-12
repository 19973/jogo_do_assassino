using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace jogo_assassino
{
    public partial class Preenchimento : Form
    {
        
        public Preenchimento()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Properties.Resources.Database5; Persist Security Info=False;");

            OleDbCommand cmd = new OleDbCommand();


            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into nome_tabela ([parametro1],[parametro1],[parametro2]) values (?,?,?)";
            // cmd.Parameters.AddWithValue("@parametro1", parametro1);
            // cmd.Parameters.AddWithValue("@parametro2", parametro2);
            // cmd.Parameters.AddWithValue("@parametro3", parametro3);

            cmd.Connection = connection;

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();

            }
            catch (OleDbException exa)
            {
                MessageBox.Show("{0}: OleDbException: Unable to connect or retrieve data from data source: {1}.",
                     exa.ToString());
            }
            catch (Exception exa)
            {
                MessageBox.Show("{0}: Exception: Unable to connect or retrieve data from data source: .",
                     exa.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
