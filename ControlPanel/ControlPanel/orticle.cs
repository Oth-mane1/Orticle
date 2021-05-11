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
    public partial class orticle : UserControl
    {
        public orticle()
        {
            InitializeComponent();
        }
        static SqlConnection cnx = new SqlConnection("Server=tcp:orticle.database.windows.net,1433;Initial Catalog=dbOrticle;Persist Security Info=False;User ID= publicloginUser; Password= pub1.lic2.lo3.gi4.n;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");
        SqlCommand cmd = new SqlCommand("", cnx);
        private void orticle_Load(object sender, EventArgs e)
        {
            this.orticleTableAdapter.Fill(this.dbOrticleDataSet.Orticle);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReduire_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            txtIdOrt.Text = "";
            txtIdCat.Text = "";
            txtIdUtl.Text = "";
            txtSource.Text = "";
            txtTitre.Text = "";
            txtDate.Text = "";
            txtNbLikes.Text = "";
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "delete orticle where  IdOrt=" + txtIdOrt.Text;
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                this.orticleTableAdapter.Fill(this.dbOrticleDataSet.Orticle);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "insert into orticle values('" + txtIdCat.Text + "','" + txtIdUtl.Text + "','" + txtSource.Text + "','" + txtTitre.Text + "','" + txtDate.Text + "'," + txtNbLikes.Text + ")";
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                this.orticleTableAdapter.Fill(this.dbOrticleDataSet.Orticle);
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
                cmd.CommandText = "update orticle set IdCat=" + txtIdCat.Text + ",IdUtl=" + txtIdUtl.Text + ",sourceOrt='" + txtSource.Text + "',titreOrt='" + txtTitre.Text + "',dateOrt='" + txtDate.Text + "',nbLike=" + txtNbLikes.Text + " where IdOrt=" + txtIdOrt.Text;
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                this.orticleTableAdapter.Fill(this.dbOrticleDataSet.Orticle);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
    }
}
