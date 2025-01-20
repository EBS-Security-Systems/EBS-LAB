using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace EBS_LAB
{
    public partial class frmPrincipal : Form
    {
        public string user = "";
        bool historico = true;
        int h_index = 0;
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

            if (historico)
            {
                dtgHistórico.Rows.Add(h_index, text);
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
            // Obtém o valor da coluna editada
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
                    case 2: // Binário
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
        }

        private void AtualizarColunas(int rowIndex, int decimalValue)
        {
            // Atualiza as colunas Binário, Hexadecimal e Octal
            dtgPrincipal.Rows[rowIndex].Cells[2].Value = Convert.ToString(decimalValue, 2).PadLeft(8, '0'); // Binário
            dtgPrincipal.Rows[rowIndex].Cells[3].Value = decimalValue.ToString("X2"); // Hexadecimal
            dtgPrincipal.Rows[rowIndex].Cells[4].Value = Convert.ToString(decimalValue, 8); // Octal
        }

        private void dtgPrincipal_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            // Confirma a edição da célula
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
                    // Tenta converter o valor da célula Decimal para um byte
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
            dtgHistórico.Rows.Clear();
            h_index = 0;
            MessageBox.Show("Histórico de texto limpo com sucesso!", "EBS-LAB", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtgHistórico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                txtPrincipal.Text = dtgHistórico.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
