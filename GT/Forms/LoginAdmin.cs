using GT.Forms;
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

namespace GT
{
    public partial class LoginAdmin : Form
    {
        private bool Logado = false;
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Close();
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            bool result = VerificaLogin();

            Logado = result;

            if (result)
            {
                MessageBox.Show("Usuário ou senha incorreto!");
               
            }
            else
            {
                MessageBox.Show("Seja bem vindo!");

                Opcoes op = new Opcoes();
                op.Show();
                Hide();
            }
        }
        bool VerificaLogin()
        {
            bool result = false;
            using (SqlConnection cn = new SqlConnection(@"Data Source=localhost;Initial Catalog=GTelefonia;Integrated Security=True"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select * from Administrador where username = '" + txtUsernameAdmin + "' and password = '" + txtPasswordAdmin + "';", cn);
                    cn.Open();
                    SqlDataReader dados = cmd.ExecuteReader();
                    result = dados.HasRows;
                }
                catch (SqlException m)
                {
                    throw new Exception(m.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
            return result;
        }
    }
}


