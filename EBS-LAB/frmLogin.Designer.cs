namespace EBS_LAB
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnLogin = new Button();
            txtUser = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            txtPassword = new MaskedTextBox();
            btnSingUp = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Consolas", 15.75F);
            btnLogin.ForeColor = Color.FromArgb(0, 192, 0);
            btnLogin.Location = new Point(263, 0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(243, 51);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseEnter += btnLogin_MouseEnter;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            // 
            // txtUser
            // 
            txtUser.Dock = DockStyle.Fill;
            txtUser.Font = new Font("Consolas", 15.75F);
            txtUser.Location = new Point(114, 3);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(344, 32);
            txtUser.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.29501F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.70499F));
            tableLayoutPanel1.Controls.Add(txtUser, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txtPassword, 1, 1);
            tableLayoutPanel1.Location = new Point(29, 97);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(461, 81);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Calibri", 20.25F);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 38);
            label1.TabIndex = 3;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Calibri", 20.25F);
            label2.ForeColor = Color.FromArgb(0, 192, 0);
            label2.Location = new Point(3, 38);
            label2.Name = "label2";
            label2.Size = new Size(105, 43);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(114, 41);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '�';
            txtPassword.Size = new Size(344, 32);
            txtPassword.TabIndex = 5;
            // 
            // btnSingUp
            // 
            btnSingUp.Cursor = Cursors.Hand;
            btnSingUp.FlatStyle = FlatStyle.Popup;
            btnSingUp.Font = new Font("Consolas", 15.75F);
            btnSingUp.ForeColor = Color.FromArgb(0, 192, 0);
            btnSingUp.Location = new Point(12, 0);
            btnSingUp.Name = "btnSingUp";
            btnSingUp.Size = new Size(243, 51);
            btnSingUp.TabIndex = 5;
            btnSingUp.Text = "REGISTRO";
            btnSingUp.UseVisualStyleBackColor = true;
            btnSingUp.Click += btnSingUp_Click;
            btnSingUp.MouseEnter += btnSingUp_MouseEnter;
            btnSingUp.MouseLeave += btnSingUp_MouseLeave;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnSingUp);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 184);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 63);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_EBS_LAB;
            pictureBox1.Location = new Point(29, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(125, 12);
            label3.Name = "label3";
            label3.Size = new Size(264, 66);
            label3.TabIndex = 9;
            label3.Text = "EBS-LAB\r\nLog-in com EBS WEB";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Logo_EBS_WEB;
            pictureBox2.Location = new Point(397, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 82);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(518, 247);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EBS-LAB - Login (EBS-WEB)";
            Load += frmLogin_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUser;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Button btnSingUp;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private MaskedTextBox txtPassword;
        private PictureBox pictureBox2;
    }
}