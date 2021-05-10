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
    public partial class compte : Form
    {
        public compte()
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

        private void compte_Load(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.CommandText = "select * from Administrateur where IdAdm=1";
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                txtNom.Text = reader.GetString(1);
                txtPrenom.Text = reader.GetString(2);
                txtEmail.Text = reader.GetString(3);
                txtMp.Text = reader.GetString(4);
                nomLbl.Text= reader.GetString(2)+" "+ reader.GetString(1);
                emailLbl.Text= reader.GetString(3);
            }
            cnx.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
           
            cmd.CommandText = "update Administrateur set nomAdm='"+txtNom.Text+"',prenomAdm='"+txtPrenom.Text+"',emailAdm='"+txtEmail.Text+"',mdpAdm='"+txtMp.Text+"' where IdAdm=1";
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
    }
}
