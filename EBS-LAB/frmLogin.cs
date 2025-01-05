/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;*/
using System.Diagnostics;
/*using System.Net.Http;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
*/
namespace EBS_LAB
{
    public partial class frmLogin : Form
    {
        public string User { get; set; }

        public frmLogin()
        {
            InitializeComponent();            
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

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(@"https://web.ebs-systems.epizy.com/singup") { UseShellExecute = true });
        }       

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPassword.Text;

            User = "";

            this.DialogResult = DialogResult.OK;

            // URL do PHP com parâmetros GET
            string url = $"https://web.ebs-systems.epizy.com/login/login.php?user={Uri.EscapeDataString(user)}&pwd={Uri.EscapeDataString(pass)}";
        
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Envia a requisição GET para o PHP
                    HttpResponseMessage response = await client.GetAsync(url);
        
                    // Lê a resposta da API
                    string responseContent = await response.Content.ReadAsStringAsync();


                    // Verifica se a resposta contém "success"
                    if (responseContent.Contains("success"))
                    {
                        MessageBox.Show("Login bem-sucedido!");
                    }
                    else
                    {
                        MessageBox.Show("Erro: " + responseContent);
                    }

                    
                    /*// Se a resposta for de sucesso
                    if (response.IsSuccessStatusCode)
                    {                        
                    }
                    else
                    {
                        MessageBox.Show("Erro ao conectar com a API");
                    }*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }

            this.Close();
        }

    
    }
}
