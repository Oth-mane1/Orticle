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
using System.Net.Mail;
using System.Net;

namespace ControlPanel
{
    public partial class support : UserControl
    {
        public support()
        {
            InitializeComponent();
        }

        private void support_Load(object sender, EventArgs e)
        {
            supportTableAdapter.Fill(dbOrticleDataSet.support);
        }

        private void sendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("contact.orticle@gmail.com");
                mail.To.Add(txtEmail.Text);
                mail.Subject = "Réponse à votre message";
                mail.Body = ResponseTb.Text;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("contact.orticle@gmail.com", "orticl19.orticla20");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                MessageBox.Show("Mail envoyé","Envoie Effectué",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
