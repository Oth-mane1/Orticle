using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Control_Panel
{
    public partial class utilisateurs : Form
    {
        public utilisateurs()
        {
            InitializeComponent();
        }
        static SqlConnection cnx = new SqlConnection("Server=tcp:orticle.database.windows.net,1433;Initial Catalog=dbOrticle;Persist Security Info=False;User ID= publicloginUser; Password= pub1.lic2.lo3.gi4.n;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");
        SqlCommand cmd = new SqlCommand("", cnx);

        private void utilisateurs_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dbOrticleDataSet5.Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateurTableAdapter.Fill(this.dbOrticleDataSet5.Utilisateur);
            
        }

        private void gunaImageButton8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
       
        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtUsern.Text = "";
            txtEmail.Text = "";
            txtMp.Text = "";
            
        }
        
    private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "exec createUser '" + txtNom.Text + "','" + txtPrenom.Text + "','" + txtUsern.Text + "','" + txtEmail.Text + "','" + txtMp.Text + "'";
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                this.utilisateurTableAdapter.Fill(this.dbOrticleDataSet5.Utilisateur);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "update utilisateur set nomUtl='" + txtNom.Text + "',prenomUtl='" + txtPrenom.Text + "',usernUtl='" + txtUsern.Text + "',emailUtl='" + txtEmail.Text + "',mdpUtl='" + txtMp.Text + "' where IdUtl=" + txtId.Text;
                //cmd.CommandText = "exec updateUser "+txtId.Text+",'"+txtNom.Text+"','"+txtPrenom.Text+"','"+txtUsern.Text+"','"+txtEmail.Text+"','"+txtMp.Text+"'";
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                this.utilisateurTableAdapter.Fill(this.dbOrticleDataSet5.Utilisateur);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "exec deleteUser " + txtId.Text;
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                this.utilisateurTableAdapter.Fill(this.dbOrticleDataSet5.Utilisateur);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            
        }
    }
}
