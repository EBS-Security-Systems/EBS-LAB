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
            pictureBox1 = new PictureBox();
            menuStripPrincipal = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            salvarComoToolStripMenuItem = new ToolStripMenuItem();
            toolStripPrincipal = new ToolStrip();
            btnLogin = new ToolStripButton();
            btnEbsCli = new ToolStripButton();
            btnExitEbsWeb = new ToolStripButton();
            statusStripPrincipal.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStripPrincipal.SuspendLayout();
            toolStripPrincipal.SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 49);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(74, 379);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.Logo_EBS_LAB;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            toolStripPrincipal.Items.AddRange(new ToolStripItem[] { btnLogin, btnEbsCli, btnExitEbsWeb });
            toolStripPrincipal.Location = new Point(0, 24);
            toolStripPrincipal.Name = "toolStripPrincipal";
            toolStripPrincipal.Size = new Size(800, 25);
            toolStripPrincipal.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Image = Properties.Resources.Logo_EBS_WEB;
            btnLogin.ImageTransparentColor = Color.Magenta;
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(136, 22);
            btnLogin.Text = "Entrar com EBS-WEB";
            btnLogin.Click += btnLogin_Click;
            // 
            // btnEbsCli
            // 
            btnEbsCli.Image = Properties.Resources.PowerShell_5_0_icon;
            btnEbsCli.ImageTransparentColor = Color.Magenta;
            btnEbsCli.Name = "btnEbsCli";
            btnEbsCli.Size = new Size(97, 22);
            btnEbsCli.Text = "Abrir EBS-CLI";
            // 
            // btnExitEbsWeb
            // 
            btnExitEbsWeb.Image = Properties.Resources.Logo_EBS_WEB;
            btnExitEbsWeb.ImageTransparentColor = Color.Magenta;
            btnExitEbsWeb.Name = "btnExitEbsWeb";
            btnExitEbsWeb.Size = new Size(114, 22);
            btnExitEbsWeb.Text = "Sair do EBS-WEB";
            btnExitEbsWeb.Visible = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStripPrincipal.ResumeLayout(false);
            menuStripPrincipal.PerformLayout();
            toolStripPrincipal.ResumeLayout(false);
            toolStripPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStripPrincipal;
        private ToolStripStatusLabel sLUser;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
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
    }
}
