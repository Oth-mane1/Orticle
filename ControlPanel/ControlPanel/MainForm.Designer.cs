namespace ControlPanel
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sideBar = new System.Windows.Forms.Panel();
            this.gunaImageButton8 = new Guna.UI.WinForms.GunaImageButton();
            this.btnSignal = new Guna.UI.WinForms.GunaImageButton();
            this.btnArticles = new Guna.UI.WinForms.GunaImageButton();
            this.btnOrticles = new Guna.UI.WinForms.GunaImageButton();
            this.btnUtilisateurs = new Guna.UI.WinForms.GunaImageButton();
            this.btnSupport = new Guna.UI.WinForms.GunaImageButton();
            this.btnStatistiques = new Guna.UI.WinForms.GunaImageButton();
            this.btnCompte = new Guna.UI.WinForms.GunaImageButton();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.main = new System.Windows.Forms.Panel();
            this.TopBar = new System.Windows.Forms.Panel();
            this.btnReduire = new Guna.UI.WinForms.GunaImageButton();
            this.btnClose = new Guna.UI.WinForms.GunaImageButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.sideBar.SuspendLayout();
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(180)))));
            this.sideBar.Controls.Add(this.gunaImageButton8);
            this.sideBar.Controls.Add(this.btnSignal);
            this.sideBar.Controls.Add(this.btnArticles);
            this.sideBar.Controls.Add(this.btnOrticles);
            this.sideBar.Controls.Add(this.btnUtilisateurs);
            this.sideBar.Controls.Add(this.btnSupport);
            this.sideBar.Controls.Add(this.btnStatistiques);
            this.sideBar.Controls.Add(this.btnCompte);
            this.sideBar.Controls.Add(this.sidePanel);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(93, 836);
            this.sideBar.TabIndex = 2;
            // 
            // gunaImageButton8
            // 
            this.gunaImageButton8.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton8.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton8.Image")));
            this.gunaImageButton8.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaImageButton8.Location = new System.Drawing.Point(8, 775);
            this.gunaImageButton8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaImageButton8.Name = "gunaImageButton8";
            this.gunaImageButton8.OnHoverImage = null;
            this.gunaImageButton8.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton8.Size = new System.Drawing.Size(77, 58);
            this.gunaImageButton8.TabIndex = 4;
            this.gunaImageButton8.Click += new System.EventHandler(this.gunaImageButton8_Click);
            // 
            // btnSignal
            // 
            this.btnSignal.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignal.Image = ((System.Drawing.Image)(resources.GetObject("btnSignal.Image")));
            this.btnSignal.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSignal.Location = new System.Drawing.Point(8, 539);
            this.btnSignal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignal.Name = "btnSignal";
            this.btnSignal.OnHoverImage = null;
            this.btnSignal.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnSignal.Size = new System.Drawing.Size(77, 58);
            this.btnSignal.TabIndex = 4;
            this.btnSignal.Click += new System.EventHandler(this.btnSignal_Click);
            // 
            // btnArticles
            // 
            this.btnArticles.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnArticles.Image = ((System.Drawing.Image)(resources.GetObject("btnArticles.Image")));
            this.btnArticles.ImageSize = new System.Drawing.Size(40, 40);
            this.btnArticles.Location = new System.Drawing.Point(8, 475);
            this.btnArticles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnArticles.Name = "btnArticles";
            this.btnArticles.OnHoverImage = null;
            this.btnArticles.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnArticles.Size = new System.Drawing.Size(77, 58);
            this.btnArticles.TabIndex = 4;
            this.btnArticles.Click += new System.EventHandler(this.btnArticles_Click);
            // 
            // btnOrticles
            // 
            this.btnOrticles.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOrticles.Image = ((System.Drawing.Image)(resources.GetObject("btnOrticles.Image")));
            this.btnOrticles.ImageSize = new System.Drawing.Size(50, 50);
            this.btnOrticles.Location = new System.Drawing.Point(8, 411);
            this.btnOrticles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrticles.Name = "btnOrticles";
            this.btnOrticles.OnHoverImage = null;
            this.btnOrticles.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnOrticles.Size = new System.Drawing.Size(77, 58);
            this.btnOrticles.TabIndex = 7;
            this.btnOrticles.Click += new System.EventHandler(this.btnOrticles_Click);
            // 
            // btnUtilisateurs
            // 
            this.btnUtilisateurs.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUtilisateurs.Image = ((System.Drawing.Image)(resources.GetObject("btnUtilisateurs.Image")));
            this.btnUtilisateurs.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUtilisateurs.Location = new System.Drawing.Point(9, 347);
            this.btnUtilisateurs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUtilisateurs.Name = "btnUtilisateurs";
            this.btnUtilisateurs.OnHoverImage = null;
            this.btnUtilisateurs.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnUtilisateurs.Size = new System.Drawing.Size(77, 58);
            this.btnUtilisateurs.TabIndex = 6;
            this.btnUtilisateurs.Click += new System.EventHandler(this.btnUtilisateurs_Click);
            // 
            // btnSupport
            // 
            this.btnSupport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSupport.Image = ((System.Drawing.Image)(resources.GetObject("btnSupport.Image")));
            this.btnSupport.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSupport.Location = new System.Drawing.Point(8, 283);
            this.btnSupport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.OnHoverImage = null;
            this.btnSupport.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnSupport.Size = new System.Drawing.Size(77, 58);
            this.btnSupport.TabIndex = 5;
            this.btnSupport.Click += new System.EventHandler(this.btnSupport_Click);
            // 
            // btnStatistiques
            // 
            this.btnStatistiques.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStatistiques.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistiques.Image")));
            this.btnStatistiques.ImageSize = new System.Drawing.Size(40, 40);
            this.btnStatistiques.Location = new System.Drawing.Point(8, 219);
            this.btnStatistiques.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStatistiques.Name = "btnStatistiques";
            this.btnStatistiques.OnHoverImage = null;
            this.btnStatistiques.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnStatistiques.Size = new System.Drawing.Size(77, 58);
            this.btnStatistiques.TabIndex = 4;
            this.btnStatistiques.Click += new System.EventHandler(this.btnStatistiques_Click);
            // 
            // btnCompte
            // 
            this.btnCompte.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCompte.Image = ((System.Drawing.Image)(resources.GetObject("btnCompte.Image")));
            this.btnCompte.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCompte.Location = new System.Drawing.Point(8, 23);
            this.btnCompte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompte.Name = "btnCompte";
            this.btnCompte.OnHoverImage = null;
            this.btnCompte.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnCompte.Size = new System.Drawing.Size(77, 58);
            this.btnCompte.TabIndex = 3;
            this.btnCompte.Click += new System.EventHandler(this.btnCompte_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.White;
            this.sidePanel.Location = new System.Drawing.Point(0, 23);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(5, 58);
            this.sidePanel.TabIndex = 1;
            // 
            // main
            // 
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(93, 81);
            this.main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(1454, 755);
            this.main.TabIndex = 3;
            // 
            // TopBar
            // 
            this.TopBar.Controls.Add(this.btnReduire);
            this.TopBar.Controls.Add(this.btnClose);
            this.TopBar.Controls.Add(this.gunaLabel1);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(93, 0);
            this.TopBar.Margin = new System.Windows.Forms.Padding(4);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(1454, 81);
            this.TopBar.TabIndex = 0;
            // 
            // btnReduire
            // 
            this.btnReduire.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReduire.Image = ((System.Drawing.Image)(resources.GetObject("btnReduire.Image")));
            this.btnReduire.ImageSize = new System.Drawing.Size(25, 25);
            this.btnReduire.Location = new System.Drawing.Point(1332, 14);
            this.btnReduire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReduire.Name = "btnReduire";
            this.btnReduire.OnHoverImage = null;
            this.btnReduire.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnReduire.Size = new System.Drawing.Size(51, 50);
            this.btnReduire.TabIndex = 105;
            this.btnReduire.Click += new System.EventHandler(this.btnReduire_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(35, 35);
            this.btnClose.Location = new System.Drawing.Point(1388, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.Size = new System.Drawing.Size(51, 50);
            this.btnClose.TabIndex = 104;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.gunaLabel1.Location = new System.Drawing.Point(612, 13);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(223, 51);
            this.gunaLabel1.TabIndex = 103;
            this.gunaLabel1.Text = "ORTICLE•";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 11;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.TopBar;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1547, 836);
            this.Controls.Add(this.main);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.sideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sideBar.ResumeLayout(false);
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Panel sidePanel;
        private Guna.UI.WinForms.GunaImageButton btnCompte;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton8;
        private Guna.UI.WinForms.GunaImageButton btnSignal;
        private Guna.UI.WinForms.GunaImageButton btnArticles;
        private Guna.UI.WinForms.GunaImageButton btnOrticles;
        private Guna.UI.WinForms.GunaImageButton btnUtilisateurs;
        private Guna.UI.WinForms.GunaImageButton btnSupport;
        private Guna.UI.WinForms.GunaImageButton btnStatistiques;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Panel TopBar;
        private Guna.UI.WinForms.GunaImageButton btnReduire;
        private Guna.UI.WinForms.GunaImageButton btnClose;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}

