using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GT.Forms
{
    public partial class QntCli : Form
    {
        public QntCli()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Opcoes op = new Opcoes();
            op.Show();
            Hide();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            //define a string de conexao com provedor caminho e nome do banco de dados
            string strProvider = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = localhost; Initial Catalog = GTelefonia; Integrated Security = True";
            //define a instrução SQL
            string strSql = "SELECT * FROM ClientesPrePago";

            //cria a conexão com o banco de dados
            OleDbConnection con = new OleDbConnection(strProvider);
            //cria o objeto command para executar a instruçao sql
            OleDbCommand cmd = new OleDbCommand(strSql, con);

            //abre a conexao
            con.Open();

            //define o tipo do comando 
            cmd.CommandType = CommandType.Text;
            //cria um dataadapter
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);

            //cria um objeto datatable
            DataTable clientespre = new DataTable();

            //preenche o datatable via dataadapter
            da.Fill(clientespre);

            //atribui o datatable ao datagridview para exibir o resultado
            dataGridView1.DataSource = clientespre;
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            //define a string de conexao com provedor caminho e nome do banco de dados
            string strProvider = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=localhost;Initial Catalog=GTelefonia;Integrated Security=True";
            //define a instrução SQL
            string strSql = "SELECT * FROM ClientesPosPago";

            //cria a conexão com o banco de dados
            OleDbConnection con = new OleDbConnection(strProvider);
            //cria o objeto command para executar a instruçao sql
            OleDbCommand cmd = new OleDbCommand(strSql, con);

            //abre a conexao
            con.Open();

            //define o tipo do comando 
            cmd.CommandType = CommandType.Text;
            //cria um dataadapter
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);

            //cria um objeto datatable
            DataTable clientespos = new DataTable();

            //preenche o datatable via dataadapter
            da.Fill(clientespos);

            //atribui o datatable ao datagridview para exibir o resultado
            dataGridView1.DataSource = clientespos;
        }
    }
    
}
