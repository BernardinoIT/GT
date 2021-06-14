using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GT.Forms
{
    public partial class CadCliPosP : Form
    {
        public CadCliPosP()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=localhost;Initial Catalog=GTelefonia;Integrated Security=True";
        

        private void btnCadPos_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO ClientePosPago "
                      + "VALUES ('" + "" + "','" + txtNomePos.Text + "', '" + dataNiver.Text + "', '"
                      + txtNbi.Text + "', '" + txtEnd.Text
                      + "', '" + txtNrTel.Text + "', '" + txtNacion.Text + "')";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Cadastro realizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

            

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Opcoes op = new Opcoes();
            op.Show();
            Hide();
        }
    } 
}
