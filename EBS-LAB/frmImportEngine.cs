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
        string[] encryptions;
        public frmImportEngine(string engineName)
        {
            InitializeComponent();
            this.engineName = engineName;
        }

        private void frmImportEngine_Load(object sender, EventArgs e)
        {
            this.Text = "Importar Engine " + engineName + " - EBS-LAB";
            switch (engineName)
            {
                case "EBS-CSP":
                    // Consultar a API do EBS-CSP e listar os mecanismos disponíveis
                default:
                    break;
            }
        }

        private void frmImportEngine_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
