using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBS_LAB
{
    public partial class frmImportEngine : Form
    {
        public string engineName { get; private set; } = "";
        public frmImportEngine(string engineName)
        {
            InitializeComponent();
            this.engineName = engineName;
        }

        private void frmImportEngine_Load(object sender, EventArgs e)
        {
            this.Text = "Importar Engine " + engineName + " - EBS-LAB";
        }

        private void frmImportEngine_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
