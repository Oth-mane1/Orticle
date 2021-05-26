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
        static SqlConnection cnx = new SqlConnection(Connection.ConnectionString);
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
            MainForm.ActiveForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;
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
            txtShortSrc.Text = "";
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "delete orticle where IdOrt=" + txtIdOrt.Text;
                cnx.Open();
                cmd.ExecuteNonQuery();
                
                this.orticleTableAdapter.Fill(this.dbOrticleDataSet.Orticle);
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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "insert into orticle values(" + txtIdCat.Text + "," + txtIdUtl.Text + ",'" + txtSource.Text + "','" + txtTitre.Text + "',@date," + txtNbLikes.Text +",'"+txtShortSrc.Text+"')";
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = txtDate.Text;
                cnx.Open();
                cmd.ExecuteNonQuery();
                this.orticleTableAdapter.Fill(this.dbOrticleDataSet.Orticle);
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
                cmd.CommandText = "update orticle set IdCat=" + txtIdCat.Text + ",IdUtl=" + txtIdUtl.Text + ",sourceOrt='" + txtSource.Text + "',titreOrt='" + txtTitre.Text + "',dateOrt=@date,nbLike=" + txtNbLikes.Text + ",shortSrcOrt='"+txtShortSrc.Text+"' where IdOrt=" + txtIdOrt.Text;
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = txtDate.Text;
                cnx.Open();
                cmd.ExecuteNonQuery();
                this.orticleTableAdapter.Fill(this.dbOrticleDataSet.Orticle);
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
