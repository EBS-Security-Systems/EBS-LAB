namespace EBS_LAB
{
    partial class frmImportEngine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportEngine));
            tableLayoutPanel1 = new TableLayoutPanel();
            pbPrincipal = new ProgressBar();
            txtLogs = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(pbPrincipal, 1, 2);
            tableLayoutPanel1.Controls.Add(txtLogs, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 78.26087F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.73913F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(518, 175);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pbPrincipal
            // 
            pbPrincipal.Dock = DockStyle.Fill;
            pbPrincipal.Location = new Point(23, 128);
            pbPrincipal.Name = "pbPrincipal";
            pbPrincipal.Size = new Size(472, 23);
            pbPrincipal.TabIndex = 1;
            pbPrincipal.Value = 50;
            // 
            // txtLogs
            // 
            txtLogs.BackColor = Color.Black;
            txtLogs.BorderStyle = BorderStyle.None;
            txtLogs.Dock = DockStyle.Fill;
            txtLogs.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogs.ForeColor = Color.FromArgb(0, 192, 0);
            txtLogs.Location = new Point(23, 23);
            txtLogs.Multiline = true;
            txtLogs.Name = "txtLogs";
            txtLogs.ReadOnly = true;
            txtLogs.Size = new Size(472, 99);
            txtLogs.TabIndex = 3;
            txtLogs.TabStop = false;
            txtLogs.Text = "Carregando logs de importação_";
            txtLogs.WordWrap = false;
            // 
            // frmImportEngine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(518, 175);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmImportEngine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Importar Engine - EBS-LAB";
            FormClosing += frmImportEngine_FormClosing;
            Load += frmImportEngine_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ProgressBar pbPrincipal;
        private TextBox txtLogs;
    }
}