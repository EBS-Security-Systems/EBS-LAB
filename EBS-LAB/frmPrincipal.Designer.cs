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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            statusStripPrincipal = new StatusStrip();
            sLUser = new ToolStripStatusLabel();
            lblEngine = new ToolStripStatusLabel();
            pbLogo = new PictureBox();
            menuStripPrincipal = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            salvarComoToolStripMenuItem = new ToolStripMenuItem();
            opçõesToolStripMenuItem = new ToolStripMenuItem();
            motoresDeEncriptaçãoToolStripMenuItem = new ToolStripMenuItem();
            eBSRNclassicToolStripMenuItem = new ToolStripMenuItem();
            eBSCSPToolStripMenuItem = new ToolStripMenuItem();
            eBSCLIToolStripMenuItem = new ToolStripMenuItem();
            históricoToolStripMenuItem = new ToolStripMenuItem();
            editorDeBytesToolStripMenuItem = new ToolStripMenuItem();
            toolStripPrincipal = new ToolStrip();
            btnLogin = new ToolStripButton();
            btnExitEbsWeb = new ToolStripButton();
            btnEbsCli = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnRepoEBS_Lab = new ToolStripButton();
            tabControlPrincipal = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnEncrypt_S = new Button();
            btnDecrypt_S = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            label6 = new Label();
            label3 = new Label();
            txtIV = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtKey = new TextBox();
            cboAlgorithm = new ComboBox();
            nUpSimetric = new NumericUpDown();
            tabPage3 = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            txtPrivateKey = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtPublicKey = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnDecryptAssymetric = new Button();
            btnEncryptAssimetric = new Button();
            btnGenerateKeyPair = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnExportKeyPair = new Button();
            btnImportKeyPair = new Button();
            nUpKeyLen = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            lblAssyncMulti = new Label();
            nUpMultiAssimetric = new NumericUpDown();
            cboAlgorithmAssymetric = new ComboBox();
            tabPage4 = new TabPage();
            tableLayoutPanel7 = new TableLayoutPanel();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            nUpShakeBits = new NumericUpDown();
            cboHashExit = new ComboBox();
            nUpMultiHash = new NumericUpDown();
            cboHashAlgorithm = new ComboBox();
            label15 = new Label();
            label13 = new Label();
            label11 = new Label();
            label9 = new Label();
            splitContainerPrincipal = new SplitContainer();
            txtPrincipal = new TextBox();
            splitContainerDTGs = new SplitContainer();
            dtgHistórico = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Texto = new DataGridViewTextBoxColumn();
            btnClear = new Button();
            dtgPrincipal = new DataGridView();
            id_Ordem = new DataGridViewTextBoxColumn();
            DEC = new DataGridViewTextBoxColumn();
            BIN = new DataGridViewTextBoxColumn();
            OCT = new DataGridViewTextBoxColumn();
            HEX = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolTipPrincipal = new ToolTip(components);
            statusStripPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            menuStripPrincipal.SuspendLayout();
            toolStripPrincipal.SuspendLayout();
            tabControlPrincipal.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUpSimetric).BeginInit();
            tabPage3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUpKeyLen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUpMultiAssimetric).BeginInit();
            tabPage4.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUpShakeBits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUpMultiHash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerPrincipal).BeginInit();
            splitContainerPrincipal.Panel1.SuspendLayout();
            splitContainerPrincipal.Panel2.SuspendLayout();
            splitContainerPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerDTGs).BeginInit();
            splitContainerDTGs.Panel1.SuspendLayout();
            splitContainerDTGs.Panel2.SuspendLayout();
            splitContainerDTGs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgHistórico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgPrincipal).BeginInit();
            SuspendLayout();
            // 
            // statusStripPrincipal
            // 
            statusStripPrincipal.Items.AddRange(new ToolStripItem[] { sLUser, lblEngine });
            statusStripPrincipal.Location = new Point(0, 707);
            statusStripPrincipal.Name = "statusStripPrincipal";
            statusStripPrincipal.Size = new Size(1350, 22);
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
            // lblEngine
            // 
            lblEngine.BackColor = SystemColors.Control;
            lblEngine.Name = "lblEngine";
            lblEngine.Size = new Size(239, 17);
            lblEngine.Text = "Motor de Encriptação: (nenhum conectado)";
            // 
            // pbLogo
            // 
            pbLogo.Cursor = Cursors.Hand;
            pbLogo.Image = Properties.Resources.Logo_EBS_LAB;
            pbLogo.Location = new Point(0, 0);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(75, 75);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            pbLogo.Click += pbLogo_Click;
            // 
            // menuStripPrincipal
            // 
            menuStripPrincipal.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, opçõesToolStripMenuItem });
            menuStripPrincipal.Location = new Point(0, 0);
            menuStripPrincipal.Name = "menuStripPrincipal";
            menuStripPrincipal.Size = new Size(1350, 24);
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
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { motoresDeEncriptaçãoToolStripMenuItem, históricoToolStripMenuItem, editorDeBytesToolStripMenuItem });
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new Size(59, 20);
            opçõesToolStripMenuItem.Text = "Opções";
            // 
            // motoresDeEncriptaçãoToolStripMenuItem
            // 
            motoresDeEncriptaçãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eBSRNclassicToolStripMenuItem, eBSCSPToolStripMenuItem, eBSCLIToolStripMenuItem });
            motoresDeEncriptaçãoToolStripMenuItem.Name = "motoresDeEncriptaçãoToolStripMenuItem";
            motoresDeEncriptaçãoToolStripMenuItem.Size = new Size(199, 22);
            motoresDeEncriptaçãoToolStripMenuItem.Text = "Motores de Encriptação";
            // 
            // eBSRNclassicToolStripMenuItem
            // 
            eBSRNclassicToolStripMenuItem.Name = "eBSRNclassicToolStripMenuItem";
            eBSRNclassicToolStripMenuItem.Size = new Size(176, 22);
            eBSRNclassicToolStripMenuItem.Text = "EBS-RN (classic)";
            // 
            // eBSCSPToolStripMenuItem
            // 
            eBSCSPToolStripMenuItem.Name = "eBSCSPToolStripMenuItem";
            eBSCSPToolStripMenuItem.Size = new Size(176, 22);
            eBSCSPToolStripMenuItem.Text = "EBS-CSP (standard)";
            eBSCSPToolStripMenuItem.Click += eBSCSPToolStripMenuItem_Click;
            // 
            // eBSCLIToolStripMenuItem
            // 
            eBSCLIToolStripMenuItem.Name = "eBSCLIToolStripMenuItem";
            eBSCLIToolStripMenuItem.Size = new Size(176, 22);
            eBSCLIToolStripMenuItem.Text = "EBS-CLI (beta)";
            // 
            // históricoToolStripMenuItem
            // 
            históricoToolStripMenuItem.Name = "históricoToolStripMenuItem";
            históricoToolStripMenuItem.Size = new Size(199, 22);
            históricoToolStripMenuItem.Text = "Ocultar Histórico";
            históricoToolStripMenuItem.Click += históricoToolStripMenuItem_Click;
            // 
            // editorDeBytesToolStripMenuItem
            // 
            editorDeBytesToolStripMenuItem.Name = "editorDeBytesToolStripMenuItem";
            editorDeBytesToolStripMenuItem.Size = new Size(199, 22);
            editorDeBytesToolStripMenuItem.Text = "Ocultar Editor de Bytes";
            editorDeBytesToolStripMenuItem.Click += editorDeBytesToolStripMenuItem_Click;
            // 
            // toolStripPrincipal
            // 
            toolStripPrincipal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripPrincipal.Items.AddRange(new ToolStripItem[] { btnLogin, btnExitEbsWeb, btnEbsCli, toolStripSeparator1, btnRepoEBS_Lab });
            toolStripPrincipal.Location = new Point(0, 24);
            toolStripPrincipal.Name = "toolStripPrincipal";
            toolStripPrincipal.Size = new Size(1350, 26);
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
            btnEbsCli.Click += btnEbsCli_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 26);
            // 
            // btnRepoEBS_Lab
            // 
            btnRepoEBS_Lab.Image = Properties.Resources.Logo_EBS_LAB;
            btnRepoEBS_Lab.ImageTransparentColor = Color.Magenta;
            btnRepoEBS_Lab.Name = "btnRepoEBS_Lab";
            btnRepoEBS_Lab.Size = new Size(174, 23);
            btnRepoEBS_Lab.Text = "Repositório do EBS-LAB";
            btnRepoEBS_Lab.Click += btnRepoEBS_Lab_Click;
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Alignment = TabAlignment.Bottom;
            tabControlPrincipal.Controls.Add(tabPage1);
            tabControlPrincipal.Controls.Add(tabPage2);
            tabControlPrincipal.Controls.Add(tabPage3);
            tabControlPrincipal.Controls.Add(tabPage4);
            tabControlPrincipal.Dock = DockStyle.Top;
            tabControlPrincipal.Location = new Point(0, 50);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new Size(1350, 144);
            tabControlPrincipal.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(pbLogo);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1342, 116);
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
            tabPage2.Size = new Size(1342, 116);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Criptografia Simétrica";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoScroll = true;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(btnEncrypt_S, 0, 0);
            tableLayoutPanel3.Controls.Add(btnDecrypt_S, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Right;
            tableLayoutPanel3.Location = new Point(1196, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(143, 110);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // btnEncrypt_S
            // 
            btnEncrypt_S.Dock = DockStyle.Fill;
            btnEncrypt_S.Location = new Point(3, 3);
            btnEncrypt_S.Name = "btnEncrypt_S";
            btnEncrypt_S.Size = new Size(137, 49);
            btnEncrypt_S.TabIndex = 0;
            btnEncrypt_S.Text = "Criptografar";
            btnEncrypt_S.UseVisualStyleBackColor = true;
            // 
            // btnDecrypt_S
            // 
            btnDecrypt_S.Dock = DockStyle.Fill;
            btnDecrypt_S.Location = new Point(3, 58);
            btnDecrypt_S.Name = "btnDecrypt_S";
            btnDecrypt_S.Size = new Size(137, 49);
            btnDecrypt_S.TabIndex = 1;
            btnDecrypt_S.Text = "Descriptografar";
            btnDecrypt_S.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.64343F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.35657F));
            tableLayoutPanel2.Controls.Add(label6, 0, 3);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(txtIV, 1, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(txtKey, 1, 0);
            tableLayoutPanel2.Controls.Add(cboAlgorithm, 1, 2);
            tableLayoutPanel2.Controls.Add(nUpSimetric, 1, 3);
            tableLayoutPanel2.Dock = DockStyle.Left;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(373, 110);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 81);
            label6.Name = "label6";
            label6.Size = new Size(70, 29);
            label6.TabIndex = 6;
            label6.Text = "Múltiplo";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 54);
            label3.Name = "label3";
            label3.Size = new Size(70, 27);
            label3.TabIndex = 4;
            label3.Text = "Algoritmo";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtIV
            // 
            txtIV.Dock = DockStyle.Fill;
            txtIV.Location = new Point(79, 30);
            txtIV.Name = "txtIV";
            txtIV.Size = new Size(291, 23);
            txtIV.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 27);
            label2.Name = "label2";
            label2.Size = new Size(70, 27);
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
            label1.Size = new Size(70, 27);
            label1.TabIndex = 0;
            label1.Text = "Chave (Key)";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtKey
            // 
            txtKey.Dock = DockStyle.Fill;
            txtKey.Location = new Point(79, 3);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(291, 23);
            txtKey.TabIndex = 1;
            // 
            // cboAlgorithm
            // 
            cboAlgorithm.Dock = DockStyle.Fill;
            cboAlgorithm.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAlgorithm.FormattingEnabled = true;
            cboAlgorithm.Location = new Point(79, 57);
            cboAlgorithm.Name = "cboAlgorithm";
            cboAlgorithm.Size = new Size(291, 23);
            cboAlgorithm.TabIndex = 5;
            // 
            // nUpSimetric
            // 
            nUpSimetric.Dock = DockStyle.Left;
            nUpSimetric.Location = new Point(79, 84);
            nUpSimetric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nUpSimetric.Name = "nUpSimetric";
            nUpSimetric.Size = new Size(128, 23);
            nUpSimetric.TabIndex = 7;
            nUpSimetric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.Control;
            tabPage3.Controls.Add(tableLayoutPanel4);
            tabPage3.Controls.Add(tableLayoutPanel6);
            tabPage3.Controls.Add(tableLayoutPanel5);
            tabPage3.Location = new Point(4, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1342, 116);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Criptografia Assimétrica";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(txtPrivateKey, 1, 1);
            tableLayoutPanel4.Controls.Add(label5, 1, 0);
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Controls.Add(txtPublicKey, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Left;
            tableLayoutPanel4.Location = new Point(383, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(760, 116);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // txtPrivateKey
            // 
            txtPrivateKey.Dock = DockStyle.Fill;
            txtPrivateKey.Font = new Font("Cascadia Mono", 9F);
            txtPrivateKey.Location = new Point(383, 18);
            txtPrivateKey.Multiline = true;
            txtPrivateKey.Name = "txtPrivateKey";
            txtPrivateKey.ScrollBars = ScrollBars.Both;
            txtPrivateKey.Size = new Size(374, 95);
            txtPrivateKey.TabIndex = 7;
            txtPrivateKey.WordWrap = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(383, 0);
            label5.Name = "label5";
            label5.Size = new Size(374, 15);
            label5.TabIndex = 5;
            label5.Text = "Chave Privada";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(374, 15);
            label4.TabIndex = 0;
            label4.Text = "Chave Pública";
            // 
            // txtPublicKey
            // 
            txtPublicKey.Dock = DockStyle.Fill;
            txtPublicKey.Font = new Font("Cascadia Mono", 9F);
            txtPublicKey.Location = new Point(3, 18);
            txtPublicKey.Multiline = true;
            txtPublicKey.Name = "txtPublicKey";
            txtPublicKey.ScrollBars = ScrollBars.Both;
            txtPublicKey.Size = new Size(374, 95);
            txtPublicKey.TabIndex = 6;
            txtPublicKey.WordWrap = false;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.Controls.Add(btnDecryptAssymetric, 0, 2);
            tableLayoutPanel6.Controls.Add(btnEncryptAssimetric, 0, 1);
            tableLayoutPanel6.Controls.Add(btnGenerateKeyPair, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Right;
            tableLayoutPanel6.Location = new Point(1178, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.Size = new Size(164, 116);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // btnDecryptAssymetric
            // 
            btnDecryptAssymetric.Dock = DockStyle.Fill;
            btnDecryptAssymetric.Location = new Point(3, 79);
            btnDecryptAssymetric.Name = "btnDecryptAssymetric";
            btnDecryptAssymetric.Size = new Size(158, 34);
            btnDecryptAssymetric.TabIndex = 2;
            btnDecryptAssymetric.Text = "Descriptografar";
            btnDecryptAssymetric.UseVisualStyleBackColor = true;
            // 
            // btnEncryptAssimetric
            // 
            btnEncryptAssimetric.Dock = DockStyle.Fill;
            btnEncryptAssimetric.Location = new Point(3, 41);
            btnEncryptAssimetric.Name = "btnEncryptAssimetric";
            btnEncryptAssimetric.Size = new Size(158, 32);
            btnEncryptAssimetric.TabIndex = 1;
            btnEncryptAssimetric.Text = "Criptografar";
            btnEncryptAssimetric.UseVisualStyleBackColor = true;
            // 
            // btnGenerateKeyPair
            // 
            btnGenerateKeyPair.Dock = DockStyle.Fill;
            btnGenerateKeyPair.Location = new Point(3, 3);
            btnGenerateKeyPair.Name = "btnGenerateKeyPair";
            btnGenerateKeyPair.Size = new Size(158, 32);
            btnGenerateKeyPair.TabIndex = 0;
            btnGenerateKeyPair.Text = "Gerar par de chaves";
            btnGenerateKeyPair.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.7964611F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.0757179F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.29765F));
            tableLayoutPanel5.Controls.Add(btnExportKeyPair, 2, 0);
            tableLayoutPanel5.Controls.Add(btnImportKeyPair, 2, 2);
            tableLayoutPanel5.Controls.Add(nUpKeyLen, 1, 1);
            tableLayoutPanel5.Controls.Add(label8, 0, 1);
            tableLayoutPanel5.Controls.Add(label7, 0, 0);
            tableLayoutPanel5.Controls.Add(lblAssyncMulti, 0, 2);
            tableLayoutPanel5.Controls.Add(nUpMultiAssimetric, 1, 2);
            tableLayoutPanel5.Controls.Add(cboAlgorithmAssymetric, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Left;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 4;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(383, 116);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // btnExportKeyPair
            // 
            btnExportKeyPair.Dock = DockStyle.Fill;
            btnExportKeyPair.Location = new Point(223, 3);
            btnExportKeyPair.Name = "btnExportKeyPair";
            btnExportKeyPair.Size = new Size(157, 25);
            btnExportKeyPair.TabIndex = 0;
            btnExportKeyPair.Text = "Exportar Par-de-Chaves";
            btnExportKeyPair.UseVisualStyleBackColor = true;
            // 
            // btnImportKeyPair
            // 
            btnImportKeyPair.Dock = DockStyle.Fill;
            btnImportKeyPair.Location = new Point(223, 66);
            btnImportKeyPair.Name = "btnImportKeyPair";
            btnImportKeyPair.Size = new Size(157, 26);
            btnImportKeyPair.TabIndex = 1;
            btnImportKeyPair.Text = "Importar Par-de-Chaves";
            btnImportKeyPair.UseVisualStyleBackColor = true;
            // 
            // nUpKeyLen
            // 
            nUpKeyLen.Dock = DockStyle.Fill;
            nUpKeyLen.Location = new Point(82, 34);
            nUpKeyLen.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nUpKeyLen.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nUpKeyLen.Name = "nUpKeyLen";
            nUpKeyLen.Size = new Size(135, 23);
            nUpKeyLen.TabIndex = 9;
            nUpKeyLen.Value = new decimal(new int[] { 1024, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(3, 31);
            label8.Name = "label8";
            label8.Size = new Size(73, 32);
            label8.TabIndex = 8;
            label8.Text = "Tamanho da Chave (bits)";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(73, 31);
            label7.TabIndex = 0;
            label7.Text = "Algoritmo";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAssyncMulti
            // 
            lblAssyncMulti.AutoSize = true;
            lblAssyncMulti.Dock = DockStyle.Fill;
            lblAssyncMulti.Location = new Point(3, 63);
            lblAssyncMulti.Name = "lblAssyncMulti";
            lblAssyncMulti.Size = new Size(73, 32);
            lblAssyncMulti.TabIndex = 7;
            lblAssyncMulti.Text = "Múltiplo";
            lblAssyncMulti.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nUpMultiAssimetric
            // 
            nUpMultiAssimetric.Dock = DockStyle.Fill;
            nUpMultiAssimetric.Location = new Point(82, 66);
            nUpMultiAssimetric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nUpMultiAssimetric.Name = "nUpMultiAssimetric";
            nUpMultiAssimetric.Size = new Size(135, 23);
            nUpMultiAssimetric.TabIndex = 1;
            nUpMultiAssimetric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboAlgorithmAssymetric
            // 
            cboAlgorithmAssymetric.Dock = DockStyle.Fill;
            cboAlgorithmAssymetric.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAlgorithmAssymetric.FormattingEnabled = true;
            cboAlgorithmAssymetric.Location = new Point(82, 3);
            cboAlgorithmAssymetric.Name = "cboAlgorithmAssymetric";
            cboAlgorithmAssymetric.Size = new Size(135, 23);
            cboAlgorithmAssymetric.TabIndex = 6;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = SystemColors.Control;
            tabPage4.Controls.Add(tableLayoutPanel7);
            tabPage4.Controls.Add(tableLayoutPanel1);
            tabPage4.Location = new Point(4, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1342, 116);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Hashs";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(button1, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Right;
            tableLayoutPanel7.Location = new Point(1199, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(143, 116);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(137, 52);
            button1.TabIndex = 0;
            button1.Text = "Iniciar Hasheamento";
            button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(nUpShakeBits, 1, 3);
            tableLayoutPanel1.Controls.Add(cboHashExit, 1, 2);
            tableLayoutPanel1.Controls.Add(nUpMultiHash, 1, 1);
            tableLayoutPanel1.Controls.Add(cboHashAlgorithm, 1, 0);
            tableLayoutPanel1.Controls.Add(label15, 0, 3);
            tableLayoutPanel1.Controls.Add(label13, 0, 2);
            tableLayoutPanel1.Controls.Add(label11, 0, 1);
            tableLayoutPanel1.Controls.Add(label9, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(247, 116);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // nUpShakeBits
            // 
            nUpShakeBits.Dock = DockStyle.Fill;
            nUpShakeBits.Enabled = false;
            nUpShakeBits.Location = new Point(85, 90);
            nUpShakeBits.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            nUpShakeBits.Minimum = new decimal(new int[] { 32, 0, 0, 0 });
            nUpShakeBits.Name = "nUpShakeBits";
            nUpShakeBits.Size = new Size(159, 23);
            nUpShakeBits.TabIndex = 13;
            nUpShakeBits.Value = new decimal(new int[] { 32, 0, 0, 0 });
            nUpShakeBits.Visible = false;
            // 
            // cboHashExit
            // 
            cboHashExit.AutoCompleteCustomSource.AddRange(new string[] { "Hexadecimal (HEX)", "Base64" });
            cboHashExit.Dock = DockStyle.Fill;
            cboHashExit.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHashExit.FormattingEnabled = true;
            cboHashExit.Items.AddRange(new object[] { "Hexadecimal (HEX)", "Base64" });
            cboHashExit.Location = new Point(85, 61);
            cboHashExit.Name = "cboHashExit";
            cboHashExit.Size = new Size(159, 23);
            cboHashExit.TabIndex = 12;
            // 
            // nUpMultiHash
            // 
            nUpMultiHash.Dock = DockStyle.Fill;
            nUpMultiHash.Location = new Point(85, 32);
            nUpMultiHash.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            nUpMultiHash.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nUpMultiHash.Name = "nUpMultiHash";
            nUpMultiHash.Size = new Size(159, 23);
            nUpMultiHash.TabIndex = 11;
            nUpMultiHash.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboHashAlgorithm
            // 
            cboHashAlgorithm.Dock = DockStyle.Fill;
            cboHashAlgorithm.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHashAlgorithm.FormattingEnabled = true;
            cboHashAlgorithm.Location = new Point(85, 3);
            cboHashAlgorithm.Name = "cboHashAlgorithm";
            cboHashAlgorithm.Size = new Size(159, 23);
            cboHashAlgorithm.TabIndex = 10;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Fill;
            label15.Location = new Point(3, 87);
            label15.Name = "label15";
            label15.Size = new Size(76, 29);
            label15.TabIndex = 9;
            label15.Text = "SHAKE (bits)";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            label15.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Fill;
            label13.Location = new Point(3, 58);
            label13.Name = "label13";
            label13.Size = new Size(76, 29);
            label13.TabIndex = 5;
            label13.Text = "Tipo de saída";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(3, 29);
            label11.Name = "label11";
            label11.Size = new Size(76, 29);
            label11.TabIndex = 2;
            label11.Text = "Múltiplo";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(76, 29);
            label9.TabIndex = 0;
            label9.Text = "Algoritmo";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // splitContainerPrincipal
            // 
            splitContainerPrincipal.Dock = DockStyle.Fill;
            splitContainerPrincipal.Location = new Point(0, 194);
            splitContainerPrincipal.Name = "splitContainerPrincipal";
            // 
            // splitContainerPrincipal.Panel1
            // 
            splitContainerPrincipal.Panel1.Controls.Add(txtPrincipal);
            // 
            // splitContainerPrincipal.Panel2
            // 
            splitContainerPrincipal.Panel2.Controls.Add(splitContainerDTGs);
            splitContainerPrincipal.Size = new Size(1350, 513);
            splitContainerPrincipal.SplitterDistance = 946;
            splitContainerPrincipal.TabIndex = 4;
            // 
            // txtPrincipal
            // 
            txtPrincipal.BackColor = Color.Black;
            txtPrincipal.BorderStyle = BorderStyle.FixedSingle;
            txtPrincipal.Dock = DockStyle.Fill;
            txtPrincipal.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrincipal.ForeColor = Color.FromArgb(0, 192, 0);
            txtPrincipal.Location = new Point(0, 0);
            txtPrincipal.Multiline = true;
            txtPrincipal.Name = "txtPrincipal";
            txtPrincipal.ScrollBars = ScrollBars.Both;
            txtPrincipal.Size = new Size(946, 513);
            txtPrincipal.TabIndex = 0;
            txtPrincipal.WordWrap = false;
            txtPrincipal.TextChanged += txtPrincipal_TextChanged;
            // 
            // splitContainerDTGs
            // 
            splitContainerDTGs.Dock = DockStyle.Fill;
            splitContainerDTGs.Location = new Point(0, 0);
            splitContainerDTGs.Name = "splitContainerDTGs";
            splitContainerDTGs.Orientation = Orientation.Horizontal;
            // 
            // splitContainerDTGs.Panel1
            // 
            splitContainerDTGs.Panel1.Controls.Add(dtgHistórico);
            splitContainerDTGs.Panel1.Controls.Add(btnClear);
            // 
            // splitContainerDTGs.Panel2
            // 
            splitContainerDTGs.Panel2.Controls.Add(dtgPrincipal);
            splitContainerDTGs.Size = new Size(400, 513);
            splitContainerDTGs.SplitterDistance = 138;
            splitContainerDTGs.TabIndex = 2;
            // 
            // dtgHistórico
            // 
            dtgHistórico.AllowUserToAddRows = false;
            dtgHistórico.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dtgHistórico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgHistórico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgHistórico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHistórico.Columns.AddRange(new DataGridViewColumn[] { ID, Texto });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgHistórico.DefaultCellStyle = dataGridViewCellStyle2;
            dtgHistórico.Dock = DockStyle.Fill;
            dtgHistórico.Location = new Point(0, 33);
            dtgHistórico.Name = "dtgHistórico";
            dtgHistórico.ReadOnly = true;
            dtgHistórico.RowHeadersVisible = false;
            dtgHistórico.Size = new Size(400, 105);
            dtgHistórico.TabIndex = 0;
            dtgHistórico.CellContentClick += dtgHistórico_CellContentClick;
            // 
            // ID
            // 
            ID.FillWeight = 30.456852F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Texto
            // 
            Texto.FillWeight = 169.543152F;
            Texto.HeaderText = "Texto";
            Texto.Name = "Texto";
            Texto.ReadOnly = true;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Top;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(0, 0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(400, 33);
            btnClear.TabIndex = 1;
            btnClear.Text = "🚮 Limpar Histórico";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dtgPrincipal
            // 
            dtgPrincipal.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dtgPrincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dtgPrincipal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPrincipal.Columns.AddRange(new DataGridViewColumn[] { id_Ordem, DEC, BIN, OCT, HEX });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dtgPrincipal.DefaultCellStyle = dataGridViewCellStyle4;
            dtgPrincipal.Dock = DockStyle.Fill;
            dtgPrincipal.Location = new Point(0, 0);
            dtgPrincipal.Name = "dtgPrincipal";
            dtgPrincipal.RowHeadersVisible = false;
            dtgPrincipal.Size = new Size(400, 371);
            dtgPrincipal.TabIndex = 1;
            dtgPrincipal.CellEndEdit += dtgPrincipal_CellEndEdit;
            dtgPrincipal.CellValueChanged += dtgPrincipal_CellValueChanged;
            dtgPrincipal.CurrentCellDirtyStateChanged += dtgPrincipal_CurrentCellDirtyStateChanged;
            // 
            // id_Ordem
            // 
            id_Ordem.HeaderText = "Caractere";
            id_Ordem.Name = "id_Ordem";
            // 
            // DEC
            // 
            DEC.HeaderText = "Decimal";
            DEC.Name = "DEC";
            // 
            // BIN
            // 
            BIN.HeaderText = "Binário";
            BIN.Name = "BIN";
            // 
            // OCT
            // 
            OCT.HeaderText = "Octal";
            OCT.Name = "OCT";
            // 
            // HEX
            // 
            HEX.HeaderText = "Hexadecimal";
            HEX.Name = "HEX";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1350, 729);
            Controls.Add(splitContainerPrincipal);
            Controls.Add(tabControlPrincipal);
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
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            menuStripPrincipal.ResumeLayout(false);
            menuStripPrincipal.PerformLayout();
            toolStripPrincipal.ResumeLayout(false);
            toolStripPrincipal.PerformLayout();
            tabControlPrincipal.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUpSimetric).EndInit();
            tabPage3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUpKeyLen).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUpMultiAssimetric).EndInit();
            tabPage4.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUpShakeBits).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUpMultiHash).EndInit();
            splitContainerPrincipal.Panel1.ResumeLayout(false);
            splitContainerPrincipal.Panel1.PerformLayout();
            splitContainerPrincipal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerPrincipal).EndInit();
            splitContainerPrincipal.ResumeLayout(false);
            splitContainerDTGs.Panel1.ResumeLayout(false);
            splitContainerDTGs.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerDTGs).EndInit();
            splitContainerDTGs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgHistórico).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgPrincipal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStripPrincipal;
        private ToolStripStatusLabel sLUser;
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
        private ToolStripStatusLabel lblEngine;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem motoresDeEncriptaçãoToolStripMenuItem;
        private ToolStripMenuItem eBSCSPToolStripMenuItem;
        private ToolStripMenuItem eBSCLIToolStripMenuItem;
        private ToolStripMenuItem eBSRNclassicToolStripMenuItem;
        private TextBox txtPrincipal;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label5;
        private Label label4;
        private TextBox txtPrivateKey;
        private TextBox txtPublicKey;
        private Label label6;
        private NumericUpDown nUpSimetric;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label8;
        private ComboBox cboAlgorithmAssymetric;
        private Label label7;
        private Label lblAssyncMulti;
        private NumericUpDown nUpMultiAssimetric;
        private NumericUpDown nUpKeyLen;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btnDecryptAssymetric;
        private Button btnEncryptAssimetric;
        private Button btnGenerateKeyPair;
        private ToolTip toolTipPrincipal;
        private Button btnExportKeyPair;
        private Button btnImportKeyPair;
        private ToolStripButton btnRepoEBS_Lab;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label13;
        private Label label11;
        private Label label9;
        private NumericUpDown nUpShakeBits;
        private ComboBox cboHashExit;
        private NumericUpDown nUpMultiHash;
        private ComboBox cboHashAlgorithm;
        private Label label15;
        private TableLayoutPanel tableLayoutPanel7;
        private Button button1;
        private DataGridView dtgPrincipal;
        private DataGridViewTextBoxColumn id_Ordem;
        private DataGridViewTextBoxColumn DEC;
        private DataGridViewTextBoxColumn BIN;
        private DataGridViewTextBoxColumn OCT;
        private DataGridViewTextBoxColumn HEX;
        private SplitContainer splitContainerDTGs;
        private DataGridView dtgHistórico;
        private Button btnClear;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Texto;
        private ToolStripMenuItem históricoToolStripMenuItem;
        private ToolStripMenuItem editorDeBytesToolStripMenuItem;
    }
}
