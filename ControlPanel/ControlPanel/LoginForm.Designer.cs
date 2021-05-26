namespace ControlPanel
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.main = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.accountImg = new Guna.UI.WinForms.GunaImageButton();
            this.btnConnecter = new Guna.UI.WinForms.GunaButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.txtMp = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TopBar = new System.Windows.Forms.Panel();
            this.btnReduire = new Guna.UI.WinForms.GunaImageButton();
            this.btnClose = new Guna.UI.WinForms.GunaImageButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.main.SuspendLayout();
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.Controls.Add(this.label1);
            this.main.Controls.Add(this.label5);
            this.main.Controls.Add(this.accountImg);
            this.main.Controls.Add(this.btnConnecter);
            this.main.Controls.Add(this.label4);
            this.main.Controls.Add(this.txtEmail);
            this.main.Controls.Add(this.txtMp);
            this.main.Controls.Add(this.label3);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(0, 66);
            this.main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(1492, 672);
            this.main.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(438, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 34);
            this.label1.TabIndex = 22;
            this.label1.Text = "Veuillez entrer vos informations d\'authentification";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(565, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(354, 39);
            this.label5.TabIndex = 22;
            this.label5.Text = "Espace Administrative";
            // 
            // accountImg
            // 
            this.accountImg.DialogResult = System.Windows.Forms.DialogResult.None;
            this.accountImg.Image = ((System.Drawing.Image)(resources.GetObject("accountImg.Image")));
            this.accountImg.ImageSize = new System.Drawing.Size(54, 54);
            this.accountImg.Location = new System.Drawing.Point(701, 56);
            this.accountImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accountImg.Name = "accountImg";
            this.accountImg.OnHoverImage = null;
            this.accountImg.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.accountImg.Size = new System.Drawing.Size(84, 84);
            this.accountImg.TabIndex = 21;
            // 
            // btnConnecter
            // 
            this.btnConnecter.AnimationHoverSpeed = 0.07F;
            this.btnConnecter.AnimationSpeed = 0.03F;
            this.btnConnecter.BackColor = System.Drawing.Color.Transparent;
            this.btnConnecter.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(180)))));
            this.btnConnecter.BorderColor = System.Drawing.Color.Black;
            this.btnConnecter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConnecter.FocusedColor = System.Drawing.Color.Empty;
            this.btnConnecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnecter.ForeColor = System.Drawing.Color.White;
            this.btnConnecter.Image = null;
            this.btnConnecter.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConnecter.Location = new System.Drawing.Point(670, 525);
            this.btnConnecter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(180)))));
            this.btnConnecter.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConnecter.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConnecter.OnHoverImage = null;
            this.btnConnecter.OnPressedColor = System.Drawing.Color.Black;
            this.btnConnecter.Radius = 15;
            this.btnConnecter.Size = new System.Drawing.Size(180, 39);
            this.btnConnecter.TabIndex = 20;
            this.btnConnecter.Text = "Se Connecter";
            this.btnConnecter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mot de passe :";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BaseColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(629, 311);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.Radius = 6;
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(444, 46);
            this.txtEmail.TabIndex = 18;
            // 
            // txtMp
            // 
            this.txtMp.BackColor = System.Drawing.Color.Transparent;
            this.txtMp.BaseColor = System.Drawing.Color.White;
            this.txtMp.BorderColor = System.Drawing.Color.Silver;
            this.txtMp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMp.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMp.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMp.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMp.Location = new System.Drawing.Point(629, 407);
            this.txtMp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMp.Name = "txtMp";
            this.txtMp.PasswordChar = '*';
            this.txtMp.Radius = 6;
            this.txtMp.SelectedText = "";
            this.txtMp.Size = new System.Drawing.Size(444, 46);
            this.txtMp.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "E-mail :";
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(180)))));
            this.TopBar.Controls.Add(this.btnReduire);
            this.TopBar.Controls.Add(this.btnClose);
            this.TopBar.Controls.Add(this.gunaLabel1);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Margin = new System.Windows.Forms.Padding(4);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(1492, 66);
            this.TopBar.TabIndex = 0;
            // 
            // btnReduire
            // 
            this.btnReduire.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReduire.Image = ((System.Drawing.Image)(resources.GetObject("btnReduire.Image")));
            this.btnReduire.ImageSize = new System.Drawing.Size(25, 25);
            this.btnReduire.Location = new System.Drawing.Point(1371, 9);
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
            this.btnClose.Location = new System.Drawing.Point(1427, 9);
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
            this.gunaLabel1.Location = new System.Drawing.Point(627, 10);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(223, 51);
            this.gunaLabel1.TabIndex = 103;
            this.gunaLabel1.Text = "ORTICLE•";
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.TopBar;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 11;
            this.gunaElipse1.TargetControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 738);
            this.Controls.Add(this.main);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Panel TopBar;
        private Guna.UI.WinForms.GunaImageButton btnReduire;
        private Guna.UI.WinForms.GunaImageButton btnClose;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaImageButton accountImg;
        private Guna.UI.WinForms.GunaButton btnConnecter;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private Guna.UI.WinForms.GunaTextBox txtMp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}

