using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

#region Refer�ncia de Projeto EBS-RN
// A refer�ncia de projeto adicionado EBS-RN (Regra de Neg�cio) � um projeto essencial a ser utilizado
// Seu significado � importante pois ele � uma reciclagem do Encryption's Builder Studio (EBS) 
// Apenas 2 classes do EBS-RN s�o utilizadas aqui, com algumas altera��es
// + Crypts.cs
// + Hashs.cs
// As classes restantes do EBS-RN ainda n�o s�o utilizadas aqui
// - Bools.cs  --> Est� incompleta, est� reservada para uso futuro
// - CodesB64.cs --> � incompat�vel, ser� removida se n�o tiver uso
// O EBS-RN inteiro original ainda n�o foi disponibilizado por completo no Git-Hub
#endregion
// using EBS_RN;

namespace EBS_LAB
{

    public partial class frmPrincipal : Form
    {
        public string user = "", engine = "";
        bool historico = true;
        int h_index = 0;
        public frmPrincipal()
        {
            InitializeComponent();

            toolTipPrincipal.SetToolTip(pbLogo, "Clique para acessar o reposit�rio do projeto no GitHub");
            //toolTipPrincipal.SetToolTip(btnRepoEBS_Lab, "Clique para acessar o reposit�rio do projeto no GitHub");
            toolTipPrincipal.SetToolTip(lblAssyncMulti, "O efeito de encripta��o em cascata n�o � vi�vel para alguns algoritmos!");
            toolTipPrincipal.SetToolTip(nUpMultiAssimetric, "O efeito de encripta��o em cascata n�o � vi�vel para alguns algoritmos!");
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

        private void btnExitEbsWeb_Click(object sender, EventArgs e)
        {
            user = "";
            sLUser.Text = "Nenhum usu�rio conectado";
            btnLogin.Enabled = true;
            btnLogin.Visible = true;
            btnExitEbsWeb.Visible = false;

            MessageBox.Show("Log-off efetuado com sucesso!", "EBS-WEB - EBS-LAB", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEbsCli_Click(object sender, EventArgs e)
        {

        }

        private void eBSRNclassicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImportEngine Engine = new frmImportEngine("EBS-RN");
            Engine.ShowDialog();
            engine = Engine.engineName;
            lblEngine.Text = "Motor de Encripta��o: " + engine;
        }

        private void eBSCSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImportEngine Engine = new frmImportEngine("EBS-CSP");
            Engine.ShowDialog();
            engine = Engine.engineName;
            lblEngine.Text = "Motor de Encripta��o: " + engine;
        }

        private void eBSCLIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImportEngine Engine = new frmImportEngine("EBS-CLI");
            Engine.ShowDialog();
            engine = Engine.engineName;
            lblEngine.Text = "Motor de Encripta��o: " + engine;
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

            if (historico)
            {
                dtgHist�rico.Rows.Add(h_index, text);
                h_index++;
            }
        }

        private void dtgPrincipal_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 1) // Ignora a coluna de caracteres
            {
                AtualizarValores(e.RowIndex);
            }
        }

        private void AtualizarValores(int rowIndex)
        {
            // Obt�m o valor da coluna editada
            var cell = dtgPrincipal.Rows[rowIndex].Cells[dtgPrincipal.CurrentCell.ColumnIndex];
            if (cell.Value != null)
            {
                string value = cell.Value.ToString();
                int decimalValue;

                switch (dtgPrincipal.CurrentCell.ColumnIndex)
                {
                    case 1: // Decimal
                        if (int.TryParse(value, out decimalValue))
                        {
                            AtualizarColunas(rowIndex, decimalValue);
                        }
                        break;
                    case 2: // Bin�rio
                        if (Convert.ToInt32(value, 2) is int binaryValue)
                        {
                            AtualizarColunas(rowIndex, binaryValue);
                        }
                        break;
                    case 3: // Octal
                        if (Convert.ToInt32(value, 8) is int octalValue)
                        {
                            AtualizarColunas(rowIndex, octalValue);
                        }
                        break;
                    case 4: // Hexadecimal
                        if (int.TryParse(value, System.Globalization.NumberStyles.HexNumber, null, out decimalValue))
                        {
                            AtualizarColunas(rowIndex, decimalValue);
                        }
                        break;
                }
            }
            else
            {
                // Tratar o caso em que cell.Value � nulo
                MessageBox.Show("O valor da c�lula � nulo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AtualizarColunas(int rowIndex, int decimalValue)
        {
            // Atualiza as colunas Bin�rio, Hexadecimal e Octal
            dtgPrincipal.Rows[rowIndex].Cells[2].Value = Convert.ToString(decimalValue, 2).PadLeft(8, '0'); // Bin�rio
            dtgPrincipal.Rows[rowIndex].Cells[3].Value = decimalValue.ToString("X2"); // Hexadecimal
            dtgPrincipal.Rows[rowIndex].Cells[4].Value = Convert.ToString(decimalValue, 8); // Octal
        }

        private void dtgPrincipal_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            // Confirma a edi��o da c�lula
            if (dtgPrincipal.IsCurrentCellDirty)
            {
                dtgPrincipal.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dtgPrincipal_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string updatedText = string.Empty;
            byte[] byteArray = new byte[dtgPrincipal.Rows.Count];
            int index = 0;

            foreach (DataGridViewRow row in dtgPrincipal.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    // Tenta converter o valor da c�lula Decimal para um byte
                    if (byte.TryParse(row.Cells[1].Value.ToString(), out byte byteValue))
                    {
                        byteArray[index++] = byteValue; // Armazena o byte no array
                    }
                }
            }

            updatedText = Encoding.UTF8.GetString(byteArray, 0, index);
            txtPrincipal.Text = updatedText;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtgHist�rico.Rows.Clear();
            h_index = 0;
            MessageBox.Show("Hist�rico de texto limpo com sucesso!", "EBS-LAB", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtgHist�rico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                txtPrincipal.Text = dtgHist�rico.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void hist�ricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!splitContainerDTGs.Panel1Collapsed)
            {
                if (splitContainerDTGs.Panel2Collapsed)
                {
                    splitContainerPrincipal.Panel2Collapsed = true;
                }
                else
                {
                    splitContainerDTGs.Panel1Collapsed = true;
                }
                hist�ricoToolStripMenuItem.Text = "Exibir Hist�rico";
            }
            else
            {
                if (splitContainerPrincipal.Panel2Collapsed)
                {
                    splitContainerPrincipal.Panel2Collapsed = false;
                    editorDeBytesToolStripMenuItem.Text = "Ocultar Editor de Bytes";
                }


                splitContainerDTGs.Panel1Collapsed = false;
                hist�ricoToolStripMenuItem.Text = "Ocultar Hist�rico";
            }
        }

        private void editorDeBytesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!splitContainerDTGs.Panel2Collapsed)
            {
                if (splitContainerDTGs.Panel1Collapsed)
                {
                    splitContainerPrincipal.Panel2Collapsed = true;
                }
                else
                {
                    splitContainerDTGs.Panel2Collapsed = true;
                }
                editorDeBytesToolStripMenuItem.Text = "Exibir Editor de Bytes";
            }
            else
            {
                if (splitContainerPrincipal.Panel2Collapsed)
                    splitContainerPrincipal.Panel2Collapsed = false;
                else
                    splitContainerDTGs.Panel2Collapsed = false;

                editorDeBytesToolStripMenuItem.Text = "Ocultar Editor de Bytes";
            }
        }
    }
}
