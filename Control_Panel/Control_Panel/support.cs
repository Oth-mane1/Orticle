using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Panel
{
    public partial class support : Form
    {
        public support()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
            
        }

        private void support_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dbOrticleDataSet5.support'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.supportTableAdapter.Fill(this.dbOrticleDataSet5.support);
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
    }
}
