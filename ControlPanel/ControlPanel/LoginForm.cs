using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPanel
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReduire_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            if (!txtEmail.Text.Equals("") || !txtMp.Text.Equals(""))
            {
                using (SqlConnection cn = new SqlConnection(Connection.ConnectionString))
                {
                    try
                    {
                        SqlCommand cmdtest = new SqlCommand($"SELECT IdAdm, nomAdm, prenomAdm, emailAdm, mdpAdm FROM Administrateur WHERE emailAdm = '{txtEmail.Text}' AND mdpAdm = '{txtMp.Text}'", cn);
                        cn.Open();
                        SqlDataReader dr = cmdtest.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Read();
                            Admin admin = new Admin()
                            {
                                Id = Convert.ToInt32(dr[0]),
                                Nom = dr[1].ToString(),
                                Prenom = dr[2].ToString(),
                                Email = dr[3].ToString(),
                                Mdp = dr[4].ToString()
                            };
                            Stream fs = File.Create(@"C:\Orticle\admin.ort");
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Serialize(fs, admin);
                            fs.Close();

                            this.Hide();
                            MainForm form = new MainForm();
                            form.Show();
                        }
                        else
                        {
                            MessageBox.Show("Le membre n'existe pas ou les informations de connexion sont incorrecte!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
