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
using EBS_RN;

namespace EBS_LAB
{
    public partial class frmCrypts : Form
    {
        Crypts crypts = new Crypts();

        // Instância do formulário principal
        private frmPrincipal mainForm = null;

        string Text = "", Algorithm = "", Key = "", IV = "";
        int multiple = 1;
        bool enc = true;

        public frmCrypts(Form callingForm, string text, string Algorithm, string Key, string IV, int multi, bool enc)
        {
            mainForm = callingForm as frmPrincipal;
            InitializeComponent();
            //this.frmPrincipal = frmPrincipal; A forma com Calling form é um jeito bem melhor de fazer isso
            this.Text = text;
            this.Algorithm = Algorithm;
            this.Key = Key;
            this.IV = IV;
            this.multiple = multi;
            this.enc = enc;
        }        
        
        private async void frmCrypts_Load(object sender, EventArgs e)
        {
            pbPrincipal.Maximum = multiple;
            if (enc)
            {
                switch (Algorithm)
                {
                    case "AES":
                        mainForm.TextPrincipal = crypts.EncryptAES(Text, Key, IV, "UTF-8", "UTF-8", "UTF-8");
                        for (int i = 1; i < multiple; i++)
                        {
                            mainForm.TextPrincipal = crypts.EncryptAES(mainForm.TextPrincipal, Key, IV, "UTF-8", "UTF-8", "UTF-8");
                            pbPrincipal.Value = i+1;
                        }
                        
                        this.Close();

                        break;
                    case "DES":
                    break;
                default:
                        break;
                }
            }
            else // dec
            {
                switch (Algorithm)
                {
                    case "AES":
                        mainForm.TextPrincipal = crypts.DecryptAES(Text, Key, IV, "UTF-8", "UTF-8", "UTF-8");
                        for (int i = 1; i < multiple; i++)
                        {
                            mainForm.TextPrincipal = crypts.DecryptAES(mainForm.TextPrincipal, Key, IV, "UTF-8", "UTF-8", "UTF-8");
                            pbPrincipal.Value = i + 1;
                        }

                        this.Close();

                        break;
                    case "DES":
                        break;
                    default:
                        break;
                }
            }
        }

        private void frmCrypts_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
