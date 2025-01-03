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
            txtPassword = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            btnSingUp = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Dock = DockStyle.Right;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Consolas", 15.75F);
            btnLogin.ForeColor = Color.FromArgb(0, 192, 0);
            btnLogin.Location = new Point(263, 0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(255, 63);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
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
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Consolas", 15.75F);
            txtPassword.Location = new Point(114, 41);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(344, 32);
            txtPassword.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.29501F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.70499F));
            tableLayoutPanel1.Controls.Add(txtPassword, 1, 1);
            tableLayoutPanel1.Controls.Add(txtUser, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
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
            // btnSingUp
            // 
            btnSingUp.Cursor = Cursors.Hand;
            btnSingUp.Dock = DockStyle.Left;
            btnSingUp.FlatStyle = FlatStyle.Popup;
            btnSingUp.Font = new Font("Consolas", 15.75F);
            btnSingUp.ForeColor = Color.FromArgb(0, 192, 0);
            btnSingUp.Location = new Point(0, 0);
            btnSingUp.Name = "btnSingUp";
            btnSingUp.Size = new Size(255, 63);
            btnSingUp.TabIndex = 5;
            btnSingUp.Text = "REGISTRO";
            btnSingUp.UseVisualStyleBackColor = true;
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
            pictureBox1.Location = new Point(14, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(142, 16);
            label3.Name = "label3";
            label3.Size = new Size(301, 64);
            label3.TabIndex = 9;
            label3.Text = "EBS-LAB\r\nLog-in com EBS WEB";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(518, 247);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmLogin";
            Text = "EBS-LAB - Login (EBS-WEB)";
            Load += frmLogin_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUser;
        private TextBox txtPassword;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Button btnSingUp;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
    }
}