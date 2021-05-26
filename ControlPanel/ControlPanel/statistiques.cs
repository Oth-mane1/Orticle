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
    public partial class statistiques : UserControl
    {
        public statistiques()
        {
            InitializeComponent();
        }
        static SqlConnection cnx = new SqlConnection(Connection.ConnectionString);
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

            chart1.Series["Utilisateurs"].Points.AddXY(DateTime.Now, nbUtl.Text);
            chart2.Series["Orticles"].Points.AddXY(DateTime.Now, nbOrticle.Text);
            chart2.Series["Articles"].Points.AddXY(DateTime.Now, nbArticle.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReduire_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
    }
}
