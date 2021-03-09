using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Admin : Form
    {
        public Admin()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            welMsg.Text = "Welcome "+Login.curUser+".";
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login.curUser = "";
            Login.curUType = "";
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            MngDoc mngDoc = new MngDoc();
            mngDoc.Show();
        }
    }
}
