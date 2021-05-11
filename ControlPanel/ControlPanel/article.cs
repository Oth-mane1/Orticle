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
    public partial class article : UserControl
    {
        public article()
        {
            InitializeComponent();
        }
        static SqlConnection cnx = new SqlConnection("Server=tcp:orticle.database.windows.net,1433;Initial Catalog=dbOrticle;Persist Security Info=False;User ID= publicloginUser; Password= pub1.lic2.lo3.gi4.n;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");
        SqlCommand cmd = new SqlCommand("", cnx);
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReduire_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void article_Load(object sender, EventArgs e)
        {
            this.articleTableAdapter.Fill(this.dbOrticleDataSet.Article);
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            txtIdArt.Text = "";
            txtIdUtl.Text = "";
            txtSource.Text = "";
            txtTitre.Text = "";
            txtDate.Text = "";
            txtExtrait.Text = "";
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "exec deleteArticle " + txtIdArt.Text;
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                this.articleTableAdapter.Fill(this.dbOrticleDataSet.Article);
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
                cmd.CommandText = "exec createArticle " + txtIdUtl.Text + ",'" + txtSource.Text + "','" + txtTitre.Text + "','" + txtDate.Text + "','" + txtExtrait.Text + "'";
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                this.articleTableAdapter.Fill(this.dbOrticleDataSet.Article);
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
            cmd.CommandText = "update Article set IdUtl=" + txtIdUtl.Text + ",sourceUtl='" + txtSource.Text + "',titreUtl='" + txtTitre.Text + "',dateArt='" + txtDate.Text + "',extraitArt='" + txtExtrait.Text + "' where IdArticle=" + txtIdArt.Text;
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
            this.articleTableAdapter.Fill(this.dbOrticleDataSet.Article);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erreur : " + ex.Message);
        }

    }
}
}
