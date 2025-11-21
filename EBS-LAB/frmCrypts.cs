using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBS_LAB
{
    public partial class frmCrypts : Form
    {
        public string engineName { get; private set; } = "";
        string[] encryptions;
        
        public frmCrypts(string engineName)
        {
            InitializeComponent();
            this.engineName = engineName;               
        }

        // Retorna da API os algoritmos de criptografia simétrica disponíveis
        static async Task<string> GetAlgorithmsFromCSP(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Realizando a requisição GET
                    HttpResponseMessage response = await client.GetAsync(url);

                    // Verificando se a resposta foi bem-sucedida
                    response.EnsureSuccessStatusCode();

                    // Lendo o conteúdo da resposta
                    string responseBody = await response.Content.ReadAsStringAsync();

                    return responseBody; // Retorna o conteúdo JSON
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show($"Erro na requisição: {e.Message}", "EBS-LAB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null; // Retorna null em caso de erro
                }
            }
        }

        
        private async void frmCrypts_Load(object sender, EventArgs e)
        {
            
        }

        private void frmCrypts_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
