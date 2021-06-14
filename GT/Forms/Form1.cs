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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            LoginAdmin adm = new LoginAdmin();
            adm.Show();
            Hide();
        }

        private void btnAssis_Click(object sender, EventArgs e)
        {
            LoginAssistente assis = new LoginAssistente();
            assis.Show();
            Hide();
        }
    }
}
