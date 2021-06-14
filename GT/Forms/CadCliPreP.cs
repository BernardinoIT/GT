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
    public partial class CadCliPreP : Form
    {
        public CadCliPreP()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=localhost;Initial Catalog=GTelefonia;Integrated Security=True";

        private void btnCadCliPre_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO ClientePrePago "
                      + "VALUES ('"+""+"','" + txtNomePre.Text + "', '" + dataNiver.Text + "', '"
                      + txtNbiPre.Text + "', '" + txtEndPre.Text
                      + "', '" + txtNrTelPre.Text + "', '" + txtNacionPre.Text + "')";

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
    }
}
