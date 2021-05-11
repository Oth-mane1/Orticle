using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            main.Controls.Clear();
            main.Controls.Add(new accueil());
            sidePanel.Height = 0;
        }

        private void btnCompte_Click(object sender, EventArgs e)
        {
            main.Controls.Clear();
            main.Controls.Add(new compte());
            sidePanel.Height = btnCompte.Height;
            sidePanel.Top = btnCompte.Top;
        }

        private void btnSignal_Click(object sender, EventArgs e)
        {
            main.Controls.Clear();
            main.Controls.Add(new signal());
            sidePanel.Height = btnSignal.Height;
            sidePanel.Top = btnSignal.Top;
        }

        private void btnArticles_Click(object sender, EventArgs e)
        {
            main.Controls.Clear();
            main.Controls.Add(new article());
            sidePanel.Height = btnArticles.Height;
            sidePanel.Top = btnArticles.Top;
        }

        private void btnOrticles_Click(object sender, EventArgs e)
        {
            main.Controls.Clear();
            main.Controls.Add(new orticle());
            sidePanel.Height = btnOrticles.Height;
            sidePanel.Top = btnOrticles.Top;
        }

        private void btnUtilisateurs_Click(object sender, EventArgs e)
        {
            main.Controls.Clear();
            main.Controls.Add(new utilisateurs());
            sidePanel.Height = btnUtilisateurs.Height;
            sidePanel.Top = btnUtilisateurs.Top;
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            main.Controls.Clear();
            main.Controls.Add(new support());
            sidePanel.Height = btnSupport.Height;
            sidePanel.Top = btnSupport.Top;
        }

        private void btnStatistiques_Click(object sender, EventArgs e)
        {
            main.Controls.Clear();
            main.Controls.Add(new statistiques());
            sidePanel.Height = btnStatistiques.Height;
            sidePanel.Top = btnStatistiques.Top;
        }
    }
}
