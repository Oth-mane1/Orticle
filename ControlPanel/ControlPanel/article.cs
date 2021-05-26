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
        static SqlConnection cnx = new SqlConnection(Connection.ConnectionString);
        SqlCommand cmd = new SqlCommand("", cnx);
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReduire_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void article_Load(object sender, EventArgs e)
        {
            articleTableAdapter.Fill(dbOrticleDataSet1.Article);
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            txtIdArt.Text = "";
            txtIdUtl.Text = "";
            txtSource.Text = "";
            txtTitre.Text = "";
            txtDate.Text = "";
            txtExtrait.Text = "";
            txtShortSrc.Text = "";
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "exec deleteArticle " + txtIdArt.Text;
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                articleTableAdapter.Fill(dbOrticleDataSet1.Article);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "insert into article values(" + txtIdUtl.Text + ",'" + txtSource.Text + "','" + txtTitre.Text + "',@date,'" + txtExtrait.Text + "'"+",'"+txtShortSrc.Text+"')";
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value =txtDate.Text;
                cnx.Open();
                cmd.ExecuteNonQuery();

                articleTableAdapter.Fill(dbOrticleDataSet1.Article);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnx.Close();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "update Article set IdUtl=" + txtIdUtl.Text + ",sourceUtl='" + txtSource.Text + "',titreUtl='" + txtTitre.Text + "',dateArt=@date,extraitArt='" + txtExtrait.Text + "',shortSrcArt='"+txtShortSrc.Text+"' where IdArticle=" + txtIdArt.Text;
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = txtDate.Text;
                cnx.Open();
                cmd.ExecuteNonQuery();
                articleTableAdapter.Fill(dbOrticleDataSet1.Article);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnx.Close();
            }
        }
    }
}
