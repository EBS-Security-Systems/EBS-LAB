using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBS_LAB
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(0, 100, 0);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void btnSingUp_MouseEnter(object sender, EventArgs e)
        {
            btnSingUp.BackColor = Color.FromArgb(0, 100, 0);
        }

        private void btnSingUp_MouseLeave(object sender, EventArgs e)
        {
            btnSingUp.BackColor = Color.FromArgb(0, 0, 0);
        }
    }
}
