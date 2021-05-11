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
    public partial class signal : UserControl
    {
        public signal()
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

        private void signal_Load(object sender, EventArgs e)
        {
            this.signalOrtTableAdapter.Fill(this.dbOrticleDataSet.signalOrt);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int idOrt = int.Parse(gunaDataGridView1.CurrentRow.Cells["idOrt"].Value.ToString());
            int idsig = int.Parse(gunaDataGridView1.CurrentRow.Cells["idSig"].Value.ToString());
            cnx.Open();
            cmd.CommandText = "delete signalOrt where IdSig=" + idsig;
            cmd.ExecuteNonQuery();

            cmd.CommandText = "delete orticle where IdOrt=" + idOrt;
            cmd.ExecuteNonQuery();
            gunaDataGridView1.Refresh();
            cnx.Close();
        }

        private void btnIgnorer_Click(object sender, EventArgs e)
        {
            int status = int.Parse(gunaDataGridView1.CurrentRow.Cells["statusSig"].Value.ToString());
            int idSig = int.Parse(gunaDataGridView1.CurrentRow.Cells["idSig"].Value.ToString());
            if (status == 0)
            {
                cnx.Open();
                cmd.CommandText = "update signalOrt set statusSig=1 where IdSig=" + idSig;
                cmd.ExecuteNonQuery();
                gunaDataGridView1.Refresh();
                cnx.Close();
            }
        }

        private void gunaDataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(gunaDataGridView1.CurrentRow.Cells["idOrt"].Value.ToString());
                cnx.Open();
                cmd.CommandText = "select corpsIde from idee where IdOrt=" + id;
                textOrticle.Text = cmd.ExecuteScalar().ToString();
                cmd.CommandText = "select sourceOrt from orticle where IdOrt=" + id;
                txtSource.Text = cmd.ExecuteScalar().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { cnx.Close(); }
        }
    }
}
