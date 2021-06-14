using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GT.Forms
{
    public partial class Opcoes : Form
    {
        public Opcoes()
        {
            InitializeComponent();
        }

        private void btnCadPos_Click(object sender, EventArgs e)
        {
            CadCliPreP pre = new CadCliPreP();
            pre.Show();
            Hide();
        }

        private void btnCadPre_Click(object sender, EventArgs e)
        {
            CadCliPosP pos = new CadCliPosP();
            pos.Show();
            Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Hide();
        }

        private void btnNrCli_Click(object sender, EventArgs e)
        {
            QntCli qc = new QntCli();
            qc.Show();
            Hide();
        }

        private void btnElimCli_Click(object sender, EventArgs e)
        {
            EliminarCliente ec = new EliminarCliente();
            ec.Show();
            Hide();
        }
    }
}
