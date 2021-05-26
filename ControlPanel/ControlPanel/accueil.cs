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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ControlPanel
{
    public partial class accueil : UserControl
    {
        public accueil()
        {
            InitializeComponent();
        }
        private void accueil_Load(object sender, EventArgs e)
        {
            try
            {
                Stream fsr = File.OpenRead(@"C:\Orticle\admin.ort");
                BinaryFormatter bfr = new BinaryFormatter();
                Admin admin = (Admin)bfr.Deserialize(fsr);
                fsr.Close();

                lbWlc.Text =admin.Prenom + " " + admin.Nom;
                lbEmail.Text = admin.Email;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReduire_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
