﻿namespace ControlPanel
{
    partial class article
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnModifier = new Guna.UI.WinForms.GunaButton();
            this.btnAjouter = new Guna.UI.WinForms.GunaButton();
            this.btnSupprimer = new Guna.UI.WinForms.GunaButton();
            this.txtIdUtl = new Guna.UI.WinForms.GunaTextBox();
            this.articleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbOrticleDataSet1 = new ControlPanel.dbOrticleDataSet1();
            this.txtExtrait = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTitre = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSource = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdArt = new Guna.UI.WinForms.GunaTextBox();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.idArticleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUtlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceUtlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titreUtlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraitArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortSrcArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVider = new Guna.UI.WinForms.GunaButton();
            this.txtShortSrc = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.articleTableAdapter = new ControlPanel.dbOrticleDataSet1TableAdapters.ArticleTableAdapter();
            this.txtDate = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrticleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModifier
            // 
            this.btnModifier.AnimationHoverSpeed = 0.07F;
            this.btnModifier.AnimationSpeed = 0.03F;
            this.btnModifier.BackColor = System.Drawing.Color.Transparent;
            this.btnModifier.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(180)))));
            this.btnModifier.BorderColor = System.Drawing.Color.Black;
            this.btnModifier.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModifier.FocusedColor = System.Drawing.Color.Empty;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Image = null;
            this.btnModifier.ImageSize = new System.Drawing.Size(20, 20);
            this.btnModifier.Location = new System.Drawing.Point(1064, 25);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(180)))));
            this.btnModifier.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModifier.OnHoverForeColor = System.Drawing.Color.White;
            this.btnModifier.OnHoverImage = null;
            this.btnModifier.OnPressedColor = System.Drawing.Color.Black;
            this.btnModifier.Radius = 15;
            this.btnModifier.Size = new System.Drawing.Size(171, 39);
            this.btnModifier.TabIndex = 94;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.AnimationHoverSpeed = 0.07F;
            this.btnAjouter.AnimationSpeed = 0.03F;
            this.btnAjouter.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(180)))));
            this.btnAjouter.BorderColor = System.Drawing.Color.Black;
            this.btnAjouter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAjouter.FocusedColor = System.Drawing.Color.Empty;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Image = null;
            this.btnAjouter.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAjouter.Location = new System.Drawing.Point(853, 25);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(180)))));
            this.btnAjouter.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAjouter.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAjouter.OnHoverImage = null;
            this.btnAjouter.OnPressedColor = System.Drawing.Color.Black;
            this.btnAjouter.Radius = 15;
            this.btnAjouter.Size = new System.Drawing.Size(171, 39);
            this.btnAjouter.TabIndex = 93;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.AnimationHoverSpeed = 0.07F;
            this.btnSupprimer.AnimationSpeed = 0.03F;
            this.btnSupprimer.BackColor = System.Drawing.Color.Transparent;
            this.btnSupprimer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(180)))));
            this.btnSupprimer.BorderColor = System.Drawing.Color.Black;
            this.btnSupprimer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSupprimer.FocusedColor = System.Drawing.Color.Empty;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Image = null;
            this.btnSupprimer.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSupprimer.Location = new System.Drawing.Point(1273, 25);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(180)))));
            this.btnSupprimer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSupprimer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSupprimer.OnHoverImage = null;
            this.btnSupprimer.OnPressedColor = System.Drawing.Color.Black;
            this.btnSupprimer.Radius = 15;
            this.btnSupprimer.Size = new System.Drawing.Size(171, 39);
            this.btnSupprimer.TabIndex = 92;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // txtIdUtl
            // 
            this.txtIdUtl.BackColor = System.Drawing.Color.Transparent;
            this.txtIdUtl.BaseColor = System.Drawing.Color.White;
            this.txtIdUtl.BorderColor = System.Drawing.Color.Silver;
            this.txtIdUtl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdUtl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articleBindingSource, "IdUtl", true));
            this.txtIdUtl.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIdUtl.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIdUtl.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdUtl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdUtl.Location = new System.Drawing.Point(1085, 143);
            this.txtIdUtl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdUtl.Name = "txtIdUtl";
            this.txtIdUtl.PasswordChar = '\0';
            this.txtIdUtl.Radius = 6;
            this.txtIdUtl.SelectedText = "";
            this.txtIdUtl.Size = new System.Drawing.Size(345, 37);
            this.txtIdUtl.TabIndex = 91;
            // 
            // articleBindingSource
            // 
            this.articleBindingSource.DataMember = "Article";
            this.articleBindingSource.DataSource = this.dbOrticleDataSet1;
            // 
            // dbOrticleDataSet1
            // 
            this.dbOrticleDataSet1.DataSetName = "dbOrticleDataSet1";
            this.dbOrticleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtExtrait
            // 
            this.txtExtrait.BackColor = System.Drawing.Color.Transparent;
            this.txtExtrait.BaseColor = System.Drawing.Color.White;
            this.txtExtrait.BorderColor = System.Drawing.Color.Silver;
            this.txtExtrait.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExtrait.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articleBindingSource, "extraitArt", true));
            this.txtExtrait.FocusedBaseColor = System.Drawing.Color.White;
            this.txtExtrait.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtExtrait.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtExtrait.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtExtrait.Location = new System.Drawing.Point(985, 439);
            this.txtExtrait.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExtrait.Multiline = true;
            this.txtExtrait.Name = "txtExtrait";
            this.txtExtrait.PasswordChar = '\0';
            this.txtExtrait.Radius = 6;
            this.txtExtrait.SelectedText = "";
            this.txtExtrait.Size = new System.Drawing.Size(445, 192);
            this.txtExtrait.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(980, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 89;
            this.label7.Text = "extraitArt :";
            // 
            // txtTitre
            // 
            this.txtTitre.BackColor = System.Drawing.Color.Transparent;
            this.txtTitre.BaseColor = System.Drawing.Color.White;
            this.txtTitre.BorderColor = System.Drawing.Color.Silver;
            this.txtTitre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articleBindingSource, "titreUtl", true));
            this.txtTitre.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTitre.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTitre.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTitre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTitre.Location = new System.Drawing.Point(1085, 255);
            this.txtTitre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.PasswordChar = '\0';
            this.txtTitre.Radius = 6;
            this.txtTitre.SelectedText = "";
            this.txtTitre.Size = new System.Drawing.Size(345, 37);
            this.txtTitre.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(969, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 86;
            this.label6.Text = "DateArt :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(971, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 85;
            this.label5.Text = "TitreArt :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(972, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 82;
            this.label1.Text = "IdArticle :";
            // 
            // txtSource
            // 
            this.txtSource.BackColor = System.Drawing.Color.Transparent;
            this.txtSource.BaseColor = System.Drawing.Color.White;
            this.txtSource.BorderColor = System.Drawing.Color.Silver;
            this.txtSource.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSource.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articleBindingSource, "sourceUtl", true));
            this.txtSource.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSource.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSource.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSource.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSource.Location = new System.Drawing.Point(1085, 201);
            this.txtSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSource.Name = "txtSource";
            this.txtSource.PasswordChar = '\0';
            this.txtSource.Radius = 6;
            this.txtSource.SelectedText = "";
            this.txtSource.Size = new System.Drawing.Size(345, 37);
            this.txtSource.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(972, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 81;
            this.label4.Text = "Source :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(976, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 80;
            this.label2.Text = "IdUtl :";
            // 
            // txtIdArt
            // 
            this.txtIdArt.BackColor = System.Drawing.Color.Transparent;
            this.txtIdArt.BaseColor = System.Drawing.Color.White;
            this.txtIdArt.BorderColor = System.Drawing.Color.Silver;
            this.txtIdArt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdArt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articleBindingSource, "IdArticle", true));
            this.txtIdArt.Enabled = false;
            this.txtIdArt.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIdArt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIdArt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdArt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdArt.Location = new System.Drawing.Point(1085, 89);
            this.txtIdArt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdArt.Name = "txtIdArt";
            this.txtIdArt.PasswordChar = '\0';
            this.txtIdArt.Radius = 6;
            this.txtIdArt.SelectedText = "";
            this.txtIdArt.Size = new System.Drawing.Size(345, 37);
            this.txtIdArt.TabIndex = 84;
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.DataSource = this.articleBindingSource;
            this.gunaComboBox1.DisplayMember = "IdArticle";
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Location = new System.Drawing.Point(139, 33);
            this.gunaComboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Radius = 6;
            this.gunaComboBox1.Size = new System.Drawing.Size(321, 31);
            this.gunaComboBox1.TabIndex = 78;
            this.gunaComboBox1.ValueMember = "IdArticle";
            // 
            // gunaDataGridView1
            // 
            this.gunaDataGridView1.AllowUserToAddRows = false;
            this.gunaDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoGenerateColumns = false;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 27;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArticleDataGridViewTextBoxColumn,
            this.idUtlDataGridViewTextBoxColumn,
            this.sourceUtlDataGridViewTextBoxColumn,
            this.titreUtlDataGridViewTextBoxColumn,
            this.dateArtDataGridViewTextBoxColumn,
            this.extraitArtDataGridViewTextBoxColumn,
            this.shortSrcArtDataGridViewTextBoxColumn});
            this.gunaDataGridView1.DataSource = this.articleBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(17, 89);
            this.gunaDataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.ReadOnly = true;
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(928, 581);
            this.gunaDataGridView1.TabIndex = 77;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 27;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = true;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.LightGray;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idArticleDataGridViewTextBoxColumn
            // 
            this.idArticleDataGridViewTextBoxColumn.DataPropertyName = "IdArticle";
            this.idArticleDataGridViewTextBoxColumn.HeaderText = "IdArticle";
            this.idArticleDataGridViewTextBoxColumn.Name = "idArticleDataGridViewTextBoxColumn";
            this.idArticleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idUtlDataGridViewTextBoxColumn
            // 
            this.idUtlDataGridViewTextBoxColumn.DataPropertyName = "IdUtl";
            this.idUtlDataGridViewTextBoxColumn.HeaderText = "IdUtl";
            this.idUtlDataGridViewTextBoxColumn.Name = "idUtlDataGridViewTextBoxColumn";
            this.idUtlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sourceUtlDataGridViewTextBoxColumn
            // 
            this.sourceUtlDataGridViewTextBoxColumn.DataPropertyName = "sourceUtl";
            this.sourceUtlDataGridViewTextBoxColumn.HeaderText = "sourceUtl";
            this.sourceUtlDataGridViewTextBoxColumn.Name = "sourceUtlDataGridViewTextBoxColumn";
            this.sourceUtlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titreUtlDataGridViewTextBoxColumn
            // 
            this.titreUtlDataGridViewTextBoxColumn.DataPropertyName = "titreUtl";
            this.titreUtlDataGridViewTextBoxColumn.HeaderText = "titreUtl";
            this.titreUtlDataGridViewTextBoxColumn.Name = "titreUtlDataGridViewTextBoxColumn";
            this.titreUtlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateArtDataGridViewTextBoxColumn
            // 
            this.dateArtDataGridViewTextBoxColumn.DataPropertyName = "dateArt";
            this.dateArtDataGridViewTextBoxColumn.HeaderText = "dateArt";
            this.dateArtDataGridViewTextBoxColumn.Name = "dateArtDataGridViewTextBoxColumn";
            this.dateArtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // extraitArtDataGridViewTextBoxColumn
            // 
            this.extraitArtDataGridViewTextBoxColumn.DataPropertyName = "extraitArt";
            this.extraitArtDataGridViewTextBoxColumn.HeaderText = "extraitArt";
            this.extraitArtDataGridViewTextBoxColumn.Name = "extraitArtDataGridViewTextBoxColumn";
            this.extraitArtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shortSrcArtDataGridViewTextBoxColumn
            // 
            this.shortSrcArtDataGridViewTextBoxColumn.DataPropertyName = "shortSrcArt";
            this.shortSrcArtDataGridViewTextBoxColumn.HeaderText = "shortSrcArt";
            this.shortSrcArtDataGridViewTextBoxColumn.Name = "shortSrcArtDataGridViewTextBoxColumn";
            this.shortSrcArtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnVider
            // 
            this.btnVider.AnimationHoverSpeed = 0.07F;
            this.btnVider.AnimationSpeed = 0.03F;
            this.btnVider.BackColor = System.Drawing.Color.Transparent;
            this.btnVider.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(180)))));
            this.btnVider.BorderColor = System.Drawing.Color.Black;
            this.btnVider.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVider.FocusedColor = System.Drawing.Color.Empty;
            this.btnVider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVider.ForeColor = System.Drawing.Color.White;
            this.btnVider.Image = null;
            this.btnVider.ImageSize = new System.Drawing.Size(20, 20);
            this.btnVider.Location = new System.Drawing.Point(1106, 688);
            this.btnVider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVider.Name = "btnVider";
            this.btnVider.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(180)))));
            this.btnVider.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnVider.OnHoverForeColor = System.Drawing.Color.White;
            this.btnVider.OnHoverImage = null;
            this.btnVider.OnPressedColor = System.Drawing.Color.Black;
            this.btnVider.Radius = 15;
            this.btnVider.Size = new System.Drawing.Size(216, 39);
            this.btnVider.TabIndex = 97;
            this.btnVider.Text = "Vider les champs";
            this.btnVider.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // txtShortSrc
            // 
            this.txtShortSrc.BackColor = System.Drawing.Color.Transparent;
            this.txtShortSrc.BaseColor = System.Drawing.Color.White;
            this.txtShortSrc.BorderColor = System.Drawing.Color.Silver;
            this.txtShortSrc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtShortSrc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articleBindingSource, "shortSrcArt", true));
            this.txtShortSrc.FocusedBaseColor = System.Drawing.Color.White;
            this.txtShortSrc.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtShortSrc.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtShortSrc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtShortSrc.Location = new System.Drawing.Point(1085, 363);
            this.txtShortSrc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtShortSrc.Name = "txtShortSrc";
            this.txtShortSrc.PasswordChar = '\0';
            this.txtShortSrc.Radius = 6;
            this.txtShortSrc.SelectedText = "";
            this.txtShortSrc.Size = new System.Drawing.Size(345, 37);
            this.txtShortSrc.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(951, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 86;
            this.label3.Text = "Short source :";
            // 
            // articleTableAdapter
            // 
            this.articleTableAdapter.ClearBeforeFill = true;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.Transparent;
            this.txtDate.BaseColor = System.Drawing.Color.White;
            this.txtDate.BorderColor = System.Drawing.Color.Silver;
            this.txtDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articleBindingSource, "dateArt", true));
            this.txtDate.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDate.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDate.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDate.Location = new System.Drawing.Point(1085, 309);
            this.txtDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDate.Name = "txtDate";
            this.txtDate.PasswordChar = '\0';
            this.txtDate.Radius = 6;
            this.txtDate.SelectedText = "";
            this.txtDate.Size = new System.Drawing.Size(345, 37);
            this.txtDate.TabIndex = 98;
            // 
            // article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtShortSrc);
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.txtIdUtl);
            this.Controls.Add(this.txtExtrait);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdArt);
            this.Controls.Add(this.gunaComboBox1);
            this.Controls.Add(this.gunaDataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "article";
            this.Size = new System.Drawing.Size(1461, 738);
            this.Load += new System.EventHandler(this.article_Load);
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrticleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnModifier;
        private Guna.UI.WinForms.GunaButton btnAjouter;
        private Guna.UI.WinForms.GunaButton btnSupprimer;
        private Guna.UI.WinForms.GunaTextBox txtIdUtl;
        private Guna.UI.WinForms.GunaTextBox txtExtrait;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox txtTitre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtIdArt;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaButton btnVider;
        private Guna.UI.WinForms.GunaTextBox txtShortSrc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUtlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceUtlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreUtlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraitArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortSrcArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource articleBindingSource;
        private dbOrticleDataSet1 dbOrticleDataSet1;
        private dbOrticleDataSet1TableAdapters.ArticleTableAdapter articleTableAdapter;
        private Guna.UI.WinForms.GunaTextBox txtDate;
    }
}
