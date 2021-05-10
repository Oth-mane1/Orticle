using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompte_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            compte newMDIChild = new compte();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
            sidePanel.Height = btnCompte.Height;
            sidePanel.Top = btnCompte.Top;
            newMDIChild.Location = new Point(0,0);
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            support newMDIChild = new support();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
            sidePanel.Height = btnSupport.Height;
            sidePanel.Top = btnSupport.Top;
            newMDIChild.Location = new Point(0, 0);
        }

        private void btnUtlisateurs_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            utilisateurs newMDIChild = new utilisateurs();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
            sidePanel.Height = btnUtlisateurs.Height;
            sidePanel.Top = btnUtlisateurs.Top;
            newMDIChild.Location = new Point(0, 0);
        }

        private void btnOrticle_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            orticle newMDIChild = new orticle();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
            sidePanel.Height = btnOrticle.Height;
            sidePanel.Top = btnOrticle.Top;
            newMDIChild.Location = new Point(0, 0);
        }

        private void btnArticle_Click(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            article newMDIChild = new article();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
            sidePanel.Height = btnArticle.Height;
            sidePanel.Top = btnArticle.Top;
            newMDIChild.Location = new Point(0, 0);
        }

        private void btnSignal_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            signal newMDIChild = new signal();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
            sidePanel.Height = btnSignal.Height;
            sidePanel.Top = btnSignal.Top;
            newMDIChild.Location = new Point(0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            accueil newMDIChild = new accueil();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
            sidePanel.Height = 0;
        }

        private void btnStatistiques_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            statistiques newMDIChild = new statistiques();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
            sidePanel.Height = btnStatistiques.Height;
            sidePanel.Top = btnStatistiques.Top;
            newMDIChild.Location = new Point(0, 0);
        }
    }
}
