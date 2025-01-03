using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Net.Http;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

       /* private async void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPassword.Text;

            // URL da API
            string url = "https://ebs-web-auth.vercel.app/login";

            using (HttpClient client = new HttpClient())
            {
                var postData = new StringContent(
                    $"user={user}&pwd={pass}",
                    Encoding.UTF8,
                    "application/x-www-form-urlencoded"
                );

                try
                {
                    // Envia a requisição POST
                    HttpResponseMessage response = await client.PostAsync(url, postData);

                    // Lê a resposta da API
                    string responseContent = await response.Content.ReadAsStringAsync();

                    // Se a resposta for de sucesso, fazer algo (exibir a resposta ou redirecionar)
                    if (response.IsSuccessStatusCode)
                    {
                        // Aqui, você pode verificar o status da resposta JSON
                        if (responseContent.Contains("success"))
                        {
                            MessageBox.Show("Login bem-sucedido!");
                        }
                        else
                        {
                            MessageBox.Show("Erro: " + responseContent);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao conectar com a API");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }*/

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPassword.Text;
        
            // URL do PHP com parâmetros GET
            string url = $"https://ebs-web-auth.vercel.app/login?user={Uri.EscapeDataString(user)}&pwd={Uri.EscapeDataString(pass)}";
        
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
        }

    
    }
}
