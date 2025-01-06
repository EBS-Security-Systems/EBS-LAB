/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;*/
using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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
        public string User { get; private set; } = "";

        public frmLogin()
        {
            InitializeComponent();
        }

        #region Design dos componentes
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
        #endregion

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(@"https://web.ebs-systems.epizy.com/singup") { UseShellExecute = true });
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPassword.Text;

            // Verificar se os campos de usuário e senha não estão vazios
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Por favor, preencha o usuário e a senha.", "EBS-WEB - EBS-LAB", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


            // URL da API Flask (substitua pela URL correta da sua API Flask)
            string url = "http://ebs-web-auth.vercel.app/login"; // Ou o endpoint correto de login da API Flask

            // Criar um objeto com os dados para enviar
            var loginData = new
            {
                user = user,
                pwd = pass
            };

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Serializar os dados para JSON
                    string jsonContent = JsonSerializer.Serialize(loginData);
                    StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                    // Enviar a requisição POST para a API Flask
                    HttpResponseMessage response = await client.PostAsync(url, content);

                    // Lê a resposta da API
                    string responseContent = await response.Content.ReadAsStringAsync();

                    // Verifica se a resposta contém "success"
                    if (responseContent.Contains("success"))
                    {
                        // Desserializar a resposta JSON para o objeto LoginResponse
                        var loginResponse = JsonSerializer.Deserialize<LoginResponse>(responseContent);

                        // Agora podemos acessar o nickname retornado pela API
                        string nickname = Encoding.UTF8.GetString(Convert.FromBase64String(loginResponse.Nickname));

                        MessageBox.Show($"Seja bem vindo @{nickname}", "EBS-WEB - EBS-LAB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.User = nickname;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        var error_Response = JsonSerializer.Deserialize<ErrorResponse>(responseContent);
                        int error_code = int.Parse(error_Response.Error);
                        string error_Message = "";
                        switch (error_code)
                        {
                            case 1:
                                error_Message = "Senha incorreta!";
                                break;
                            case 2:
                                error_Message = "Usuário inativo!";
                                break;
                            case 3:
                                error_Message = "Usuário não encontrado!";
                                break;
                            default:
                                error_Message = responseContent;
                                break;
                        }
                        MessageBox.Show(error_Message, "EBS-WEB - EBS-LAB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    // Exibe a mensagem de erro caso haja falha na requisição
                    MessageBox.Show("Erro: " + ex.Message, "EBS-WEB - EBS-LAB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close(); // Fecha o formulário após sucesso
        }

        #region Classes de resposta da API
        // Classe para mapear a resposta JSON da API Flask
        public class LoginResponse
        {
            [JsonPropertyName("message")]
            public required string Message { get; set; }

            [JsonPropertyName("nickname")]
            public required string Nickname { get; set; }
        }

        public class ErrorResponse
        {
            [JsonPropertyName("error")]
            public required string Error { get; set; }
        }
        #endregion
    }
}
