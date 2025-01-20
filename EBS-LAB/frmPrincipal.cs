using System.Diagnostics;
using System.Text;

namespace EBS_LAB
{
    public partial class frmPrincipal : Form
    {
        public string user = "";
        public frmPrincipal()
        {
            InitializeComponent();

            toolTipPrincipal.SetToolTip(pbLogo, "Clique para acessar o repositório do projeto no GitHub");
            //toolTipPrincipal.SetToolTip(btnRepoEBS_Lab, "Clique para acessar o repositório do projeto no GitHub");
            toolTipPrincipal.SetToolTip(lblAssyncMulti, "O efeito de encriptação em cascata não é viável para alguns algoritmos!");
            toolTipPrincipal.SetToolTip(nUpMultiAssimetric, "O efeito de encriptação em cascata não é viável para alguns algoritmos!");
        }

        private void btnRepoEBS_Lab_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(@"https://github.com/EBS-Security-Systems/EBS-LAB") { UseShellExecute = true });
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(@"https://github.com/EBS-Security-Systems/EBS-LAB") { UseShellExecute = true });
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                user = login.User;
                if (user == "")
                {
                    sLUser.Text = "Nenhum usuário conectado";
                }
                else
                {
                    sLUser.Text = $"Usuário conectado: @{user}";
                    btnLogin.Enabled = false;
                    btnLogin.Visible = false;
                    btnExitEbsWeb.Visible = true;
                }
            }
        }

        private void btnExitEbsWeb_Click(object sender, EventArgs e)
        {
            user = "";
            sLUser.Text = "Nenhum usuário conectado";
            btnLogin.Enabled = true;
            btnLogin.Visible = true;
            btnExitEbsWeb.Visible = false;

            MessageBox.Show("Log-off efetuado com sucesso!", "EBS-WEB - EBS-LAB", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEbsCli_Click(object sender, EventArgs e)
        {

        }

        private void eBSCSPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtPrincipal_TextChanged(object sender, EventArgs e)
        {
            string text = txtPrincipal.Text;
            dtgPrincipal.Rows.Clear(); // Limpa as linhas existentes

            foreach (char c in text)
            {
                int decimalValue = c;
                string binaryValue = Convert.ToString(decimalValue, 2).PadLeft(8, '0'); // 8 bits
                string hexValue = decimalValue.ToString("X2");
                string octalValue = Convert.ToString(decimalValue, 8);

                dtgPrincipal.Rows.Add(c.ToString(), decimalValue, binaryValue, octalValue, hexValue);
            }

        }
    }
}
