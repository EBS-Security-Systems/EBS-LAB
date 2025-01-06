namespace EBS_LAB
{
    public partial class frmPrincipal : Form
    {        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                string user = login.User;
                if (user == "")
                {
                    sLUser.Text = "Nenhum usu�rio conectado";
                }
                else
                {
                    sLUser.Text = $"Usu�rio conectado: @{user}";
                    btnLogin.Enabled = false;
                    btnLogin.Visible = false;
                    btnExitEbsWeb.Visible = true;
                }
            }                                          
        }
    }
}
