namespace EBS_LAB
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            statusStripPrincipal = new StatusStrip();
            sLUser = new ToolStripStatusLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pbLogo = new PictureBox();
            menuStripPrincipal = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            salvarComoToolStripMenuItem = new ToolStripMenuItem();
            toolStripPrincipal = new ToolStrip();
            btnLogin = new ToolStripButton();
            btnExitEbsWeb = new ToolStripButton();
            btnEbsCli = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tabControlPrincipal = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            txtIV = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtKey = new TextBox();
            cboAlgorithm = new ComboBox();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            splitContainerPrincipal = new SplitContainer();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tableLayoutPanel3 = new TableLayoutPanel();
            btnEncrypt_S = new Button();
            btnDecrypt_S = new Button();
            statusStripPrincipal.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            menuStripPrincipal.SuspendLayout();
            toolStripPrincipal.SuspendLayout();
            tabControlPrincipal.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerPrincipal).BeginInit();
            splitContainerPrincipal.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // statusStripPrincipal
            // 
            statusStripPrincipal.Items.AddRange(new ToolStripItem[] { sLUser });
            statusStripPrincipal.Location = new Point(0, 428);
            statusStripPrincipal.Name = "statusStripPrincipal";
            statusStripPrincipal.Size = new Size(800, 22);
            statusStripPrincipal.TabIndex = 0;
            statusStripPrincipal.Text = "statusStrip1";
            // 
            // sLUser
            // 
            sLUser.BackColor = SystemColors.Control;
            sLUser.ForeColor = SystemColors.ActiveCaptionText;
            sLUser.Name = "sLUser";
            sLUser.Size = new Size(155, 17);
            sLUser.Text = "Nenhum usuário conectado";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pbLogo, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 50);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(74, 378);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // pbLogo
            // 
            pbLogo.Cursor = Cursors.Hand;
            pbLogo.Dock = DockStyle.Top;
            pbLogo.Image = Properties.Resources.Logo_EBS_LAB;
            pbLogo.Location = new Point(3, 3);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(68, 65);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            pbLogo.Click += pbLogo_Click;
            // 
            // menuStripPrincipal
            // 
            menuStripPrincipal.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem });
            menuStripPrincipal.Location = new Point(0, 0);
            menuStripPrincipal.Name = "menuStripPrincipal";
            menuStripPrincipal.Size = new Size(800, 24);
            menuStripPrincipal.TabIndex = 2;
            menuStripPrincipal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, abrirToolStripMenuItem, salvarToolStripMenuItem, salvarComoToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(139, 22);
            novoToolStripMenuItem.Text = "Novo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(139, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            // 
            // salvarToolStripMenuItem
            // 
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.Size = new Size(139, 22);
            salvarToolStripMenuItem.Text = "Salvar";
            // 
            // salvarComoToolStripMenuItem
            // 
            salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            salvarComoToolStripMenuItem.Size = new Size(139, 22);
            salvarComoToolStripMenuItem.Text = "Salvar como";
            // 
            // toolStripPrincipal
            // 
            toolStripPrincipal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripPrincipal.Items.AddRange(new ToolStripItem[] { btnLogin, btnExitEbsWeb, btnEbsCli, toolStripSeparator1 });
            toolStripPrincipal.Location = new Point(0, 24);
            toolStripPrincipal.Name = "toolStripPrincipal";
            toolStripPrincipal.Size = new Size(800, 26);
            toolStripPrincipal.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Image = Properties.Resources.Logo_EBS_WEB;
            btnLogin.ImageTransparentColor = Color.Magenta;
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(156, 23);
            btnLogin.Text = "Entrar com EBS-WEB";
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExitEbsWeb
            // 
            btnExitEbsWeb.Image = Properties.Resources.Logo_EBS_WEB;
            btnExitEbsWeb.ImageTransparentColor = Color.Magenta;
            btnExitEbsWeb.Name = "btnExitEbsWeb";
            btnExitEbsWeb.Size = new Size(131, 23);
            btnExitEbsWeb.Text = "Sair do EBS-WEB";
            btnExitEbsWeb.Visible = false;
            btnExitEbsWeb.Click += btnExitEbsWeb_Click;
            // 
            // btnEbsCli
            // 
            btnEbsCli.Image = Properties.Resources.PowerShell_5_0_icon;
            btnEbsCli.ImageTransparentColor = Color.Magenta;
            btnEbsCli.Name = "btnEbsCli";
            btnEbsCli.Size = new Size(111, 23);
            btnEbsCli.Text = "Abrir EBS-CLI";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 26);
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Alignment = TabAlignment.Bottom;
            tabControlPrincipal.Controls.Add(tabPage1);
            tabControlPrincipal.Controls.Add(tabPage2);
            tabControlPrincipal.Controls.Add(tabPage3);
            tabControlPrincipal.Controls.Add(tabPage4);
            tabControlPrincipal.Dock = DockStyle.Top;
            tabControlPrincipal.Location = new Point(74, 50);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new Size(726, 125);
            tabControlPrincipal.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(718, 97);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Codificações";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Controls.Add(tableLayoutPanel3);
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Location = new Point(4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(718, 97);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Criptografia Simétrica";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.2990646F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.7009354F));
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(txtIV, 1, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(txtKey, 1, 0);
            tableLayoutPanel2.Controls.Add(cboAlgorithm, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Left;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(373, 91);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 60);
            label3.Name = "label3";
            label3.Size = new Size(84, 31);
            label3.TabIndex = 4;
            label3.Text = "Algoritmo";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtIV
            // 
            txtIV.Dock = DockStyle.Fill;
            txtIV.Location = new Point(93, 33);
            txtIV.Name = "txtIV";
            txtIV.Size = new Size(277, 23);
            txtIV.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 30);
            label2.Name = "label2";
            label2.Size = new Size(84, 30);
            label2.TabIndex = 2;
            label2.Text = "Vetor (IV)";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 30);
            label1.TabIndex = 0;
            label1.Text = "Chave (Key)";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtKey
            // 
            txtKey.Dock = DockStyle.Fill;
            txtKey.Location = new Point(93, 3);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(277, 23);
            txtKey.TabIndex = 1;
            // 
            // cboAlgorithm
            // 
            cboAlgorithm.Dock = DockStyle.Fill;
            cboAlgorithm.FormattingEnabled = true;
            cboAlgorithm.Location = new Point(93, 63);
            cboAlgorithm.Name = "cboAlgorithm";
            cboAlgorithm.Size = new Size(277, 23);
            cboAlgorithm.TabIndex = 5;
            cboAlgorithm.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.Control;
            tabPage3.Location = new Point(4, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(718, 97);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Criptografia Assimétrica";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = SystemColors.Control;
            tabPage4.Location = new Point(4, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(718, 97);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Hashs";
            // 
            // splitContainerPrincipal
            // 
            splitContainerPrincipal.Dock = DockStyle.Fill;
            splitContainerPrincipal.Location = new Point(74, 175);
            splitContainerPrincipal.Name = "splitContainerPrincipal";
            splitContainerPrincipal.Orientation = Orientation.Horizontal;
            splitContainerPrincipal.Size = new Size(726, 253);
            splitContainerPrincipal.SplitterDistance = 223;
            splitContainerPrincipal.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoScroll = true;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(btnEncrypt_S, 0, 0);
            tableLayoutPanel3.Controls.Add(btnDecrypt_S, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Right;
            tableLayoutPanel3.Location = new Point(572, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(143, 91);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // btnEncrypt_S
            // 
            btnEncrypt_S.Dock = DockStyle.Fill;
            btnEncrypt_S.Location = new Point(3, 3);
            btnEncrypt_S.Name = "btnEncrypt_S";
            btnEncrypt_S.Size = new Size(137, 24);
            btnEncrypt_S.TabIndex = 0;
            btnEncrypt_S.Text = "Criptografar";
            btnEncrypt_S.UseVisualStyleBackColor = true;
            // 
            // btnDecrypt_S
            // 
            btnDecrypt_S.Dock = DockStyle.Fill;
            btnDecrypt_S.Location = new Point(3, 63);
            btnDecrypt_S.Name = "btnDecrypt_S";
            btnDecrypt_S.Size = new Size(137, 25);
            btnDecrypt_S.TabIndex = 1;
            btnDecrypt_S.Text = "Descriptografar";
            btnDecrypt_S.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainerPrincipal);
            Controls.Add(tabControlPrincipal);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(toolStripPrincipal);
            Controls.Add(menuStripPrincipal);
            Controls.Add(statusStripPrincipal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStripPrincipal;
            Name = "frmPrincipal";
            Text = "EBS-LAB";
            WindowState = FormWindowState.Maximized;
            statusStripPrincipal.ResumeLayout(false);
            statusStripPrincipal.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            menuStripPrincipal.ResumeLayout(false);
            menuStripPrincipal.PerformLayout();
            toolStripPrincipal.ResumeLayout(false);
            toolStripPrincipal.PerformLayout();
            tabControlPrincipal.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerPrincipal).EndInit();
            splitContainerPrincipal.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStripPrincipal;
        private ToolStripStatusLabel sLUser;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pbLogo;
        private MenuStrip menuStripPrincipal;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStrip toolStripPrincipal;
        private ToolStripButton btnLogin;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem salvarComoToolStripMenuItem;
        private ToolStripButton btnEbsCli;
        private ToolStripButton btnExitEbsWeb;
        private ToolStripSeparator toolStripSeparator1;
        private TabControl tabControlPrincipal;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private SplitContainer splitContainerPrincipal;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TextBox txtIV;
        private Label label2;
        private TextBox txtKey;
        private ContextMenuStrip contextMenuStrip1;
        private Label label3;
        private ComboBox cboAlgorithm;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnEncrypt_S;
        private Button btnDecrypt_S;
    }
}
