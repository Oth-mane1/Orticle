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
    public partial class statistiques : Form
    {
        public statistiques()
        {
            InitializeComponent();
        }
        static SqlConnection cnx = new SqlConnection("Server=tcp:orticle.database.windows.net,1433;Initial Catalog=dbOrticle;Persist Security Info=False;User ID= publicloginUser; Password= pub1.lic2.lo3.gi4.n;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");
        SqlCommand cmd = new SqlCommand("", cnx);
        private void statistiques_Load(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.CommandText = "select COUNT(*) from Utilisateur";
            nbUtl.Text = cmd.ExecuteScalar().ToString();
            cmd.CommandText = "select COUNT(*) from orticle";
            nbOrticle.Text = cmd.ExecuteScalar().ToString();
            cmd.CommandText = "select COUNT(*) from article";
            nbArticle.Text = cmd.ExecuteScalar().ToString();
            cnx.Close();

            chart1.Series["Utilisateurs"].Points.AddXY(DateTime.Now,nbUtl.Text);
            chart1.Series["Orticles"].Points.AddXY(DateTime.Now,nbOrticle.Text);
            chart1.Series["Articles"].Points.AddXY(DateTime.Now,nbArticle.Text);
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReduire_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
    }
}
