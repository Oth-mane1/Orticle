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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ControlPanel
{
    public partial class compte : UserControl
    {

        static SqlConnection cnx = new SqlConnection(Connection.ConnectionString);
        SqlCommand cmd = new SqlCommand("", cnx);

        public compte()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReduire_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void compte_Load(object sender, EventArgs e)
        {
            try
            {
                Stream fsr = File.OpenRead(@"C:\Orticle\admin.ort");
                BinaryFormatter bfr = new BinaryFormatter();
                Admin admin = (Admin)bfr.Deserialize(fsr);
                fsr.Close();

                txtId.Text = admin.Id.ToString();
                txtNom.Text = admin.Nom;
                txtPrenom.Text = admin.Prenom;
                txtEmail.Text = admin.Email;
                txtMp.Text = admin.Mdp;
                nomLbl.Text = admin.Prenom + " " + admin.Nom;
                emailLbl.Text = emailLbl.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "update Administrateur set nomAdm='" + txtNom.Text + "',prenomAdm='" + txtPrenom.Text + "',emailAdm='" + txtEmail.Text + "',mdpAdm='" + txtMp.Text + "' where IdAdm = '" + int.Parse(txtId.Text) + "'";
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
