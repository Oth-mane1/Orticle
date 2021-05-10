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
    public partial class article : Form
    {
        public article()
        {
            InitializeComponent();
        }
        static SqlConnection cnx = new SqlConnection("Server=tcp:orticle.database.windows.net,1433;Initial Catalog=dbOrticle;Persist Security Info=False;User ID= publicloginUser; Password= pub1.lic2.lo3.gi4.n;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");
        SqlCommand cmd = new SqlCommand("", cnx);
        private void article_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dbOrticleDataSet5.Article'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.articleTableAdapter.Fill(this.dbOrticleDataSet5.Article);
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReduire_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "exec createArticle " + txtIdUtl.Text + ",'" + txtSource.Text + "','" + txtTitre.Text + "','" + txtDate.Text + "','" + txtExtrait.Text + "'";
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                this.articleTableAdapter.Fill(this.dbOrticleDataSet5.Article);
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
                cmd.CommandText = "update Article set IdUtl=" + txtIdUtl.Text + ",sourceUtl='" + txtSource.Text + "',titreArt='" + txtTitre.Text + "',dateArt='" + txtDate.Text + "',extraitArt='" + txtExtrait.Text + "' where IdArticle=" + txtIdArt.Text;
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                this.articleTableAdapter.Fill(this.dbOrticleDataSet5.Article);
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
                cmd.CommandText = "exec deleteArticle " + txtIdArt.Text;
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                this.articleTableAdapter.Fill(this.dbOrticleDataSet5.Article);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            } 
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
    }
}
