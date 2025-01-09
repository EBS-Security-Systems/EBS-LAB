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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            splitContainerPrincipal = new SplitContainer();
            txtPrincipal = new TextBox();
            statusStripPrincipal.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            menuStripPrincipal.SuspendLayout();
            toolStripPrincipal.SuspendLayout();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerPrincipal).BeginInit();
            splitContainerPrincipal.Panel1.SuspendLayout();
            splitContainerPrincipal.SuspendLayout();
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
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Top;
            tabControl1.Location = new Point(74, 50);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(726, 100);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(718, 72);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Codificações";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Location = new Point(4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(718, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Criptografia Simétrica";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.Control;
            tabPage3.Location = new Point(4, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(718, 72);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Criptografia Assimétrica";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = SystemColors.Control;
            tabPage4.Location = new Point(4, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(718, 72);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Hashs";
            // 
            // splitContainerPrincipal
            // 
            splitContainerPrincipal.Dock = DockStyle.Fill;
            splitContainerPrincipal.Location = new Point(74, 150);
            splitContainerPrincipal.Name = "splitContainerPrincipal";
            splitContainerPrincipal.Orientation = Orientation.Horizontal;
            // 
            // splitContainerPrincipal.Panel1
            // 
            splitContainerPrincipal.Panel1.Controls.Add(txtPrincipal);
            splitContainerPrincipal.Size = new Size(726, 278);
            splitContainerPrincipal.SplitterDistance = 249;
            splitContainerPrincipal.TabIndex = 4;
            // 
            // txtPrincipal
            // 
            txtPrincipal.BackColor = Color.Black;
            txtPrincipal.BorderStyle = BorderStyle.None;
            txtPrincipal.Dock = DockStyle.Fill;
            txtPrincipal.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrincipal.ForeColor = Color.FromArgb(0, 192, 0);
            txtPrincipal.Location = new Point(0, 0);
            txtPrincipal.Name = "txtPrincipal";
            txtPrincipal.Size = new Size(726, 25);
            txtPrincipal.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainerPrincipal);
            Controls.Add(tabControl1);
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
            tabControl1.ResumeLayout(false);
            splitContainerPrincipal.Panel1.ResumeLayout(false);
            splitContainerPrincipal.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerPrincipal).EndInit();
            splitContainerPrincipal.ResumeLayout(false);
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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private SplitContainer splitContainerPrincipal;
        private TextBox txtPrincipal;
    }
}
