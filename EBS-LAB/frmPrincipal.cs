using System.Diagnostics;

namespace EBS_LAB
{
    public partial class frmPrincipal : Form
    {
        public string user = "";
        public frmPrincipal()
        {
            InitializeComponent();

            toolTipPrincipal.SetToolTip(pbLogo, "Clique para acessar o repositório do projeto no GitHub");
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

    }
}
