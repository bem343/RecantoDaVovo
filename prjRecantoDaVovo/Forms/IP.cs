using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjRecantoDaVovo.classes;

namespace prjRecantoDaVovo.Forms
{
    public partial class IP : Form
    {
        public IP()
        {
            InitializeComponent();
        }

        private void btnIP_Click(object sender, EventArgs e)
        {
            execucao.IPServer(txtIP.Text,"");
            this.Close();
        }

        private void IP_Load(object sender, EventArgs e)
        {
            txtIP.Text = "";
            txtIP.Focus();
        }
    }
}
