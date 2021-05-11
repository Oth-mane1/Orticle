using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ControlPanel
{
    public partial class support : UserControl
    {
        public support()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReduire_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void support_Load(object sender, EventArgs e)
        {
            this.supportTableAdapter.Fill(this.dbOrticleDataSet.support);
        }
    }
}
