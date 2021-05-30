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
                mail.Subject = "Suite à votre message de support";
                mail.Body = "Merci pour contacter notre support!<br><br>"+ ResponseTb.Text +
                    "<br><br>Si vous avez d'autres questions veuillez <a href=\"https://orticle.herokuapp.com/support\">contacter notre support</a><br><br>Cordialement.";
                mail.IsBodyHtml = true;
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
