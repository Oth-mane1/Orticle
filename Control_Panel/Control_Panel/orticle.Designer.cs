namespace Control_Panel
{
    partial class orticle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orticle));
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.orticleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbOrticleDataSet5 = new Control_Panel.dbOrticleDataSet5();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.idOrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUtlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceOrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titreOrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbLikeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orticleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.btnClose = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.orticleTableAdapter = new Control_Panel.dbOrticleDataSet5TableAdapters.OrticleTableAdapter();
            this.btnModifier = new Guna.UI.WinForms.GunaButton();
            this.btnAjouter = new Guna.UI.WinForms.GunaButton();
            this.btnSupprimer = new Guna.UI.WinForms.GunaButton();
            this.btnVider = new Guna.UI.WinForms.GunaButton();
            this.txtDate = new Guna.UI.WinForms.GunaTextBox();
            this.txtTitre = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSource = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdOrt = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNbLikes = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdUtl = new Guna.UI.WinForms.GunaTextBox();
            this.txtIdCat = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.orticleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrticleDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orticleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.DataSource = this.orticleBindingSource1;
            this.gunaComboBox1.DisplayMember = "IdOrt";
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Location = new System.Drawing.Point(285, 102);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Radius = 6;
            this.gunaComboBox1.Size = new System.Drawing.Size(322, 31);
            this.gunaComboBox1.TabIndex = 17;
            this.gunaComboBox1.ValueMember = "IdOrt";
            // 
            // orticleBindingSource1
            // 
            this.orticleBindingSource1.DataMember = "Orticle";
            this.orticleBindingSource1.DataSource = this.dbOrticleDataSet5;
            // 
            // dbOrticleDataSet5
            // 
            this.dbOrticleDataSet5.DataSetName = "dbOrticleDataSet5";
            this.dbOrticleDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.idOrtDataGridViewTextBoxColumn,
            this.idCatDataGridViewTextBoxColumn,
            this.idUtlDataGridViewTextBoxColumn,
            this.sourceOrtDataGridViewTextBoxColumn,
            this.titreOrtDataGridViewTextBoxColumn,
            this.dateOrtDataGridViewTextBoxColumn,
            this.nbLikeDataGridViewTextBoxColumn});
            this.gunaDataGridView1.DataSource = this.orticleBindingSource1;
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
            this.gunaDataGridView1.Location = new System.Drawing.Point(126, 181);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.ReadOnly = true;
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(949, 601);
            this.gunaDataGridView1.TabIndex = 16;
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
            // idOrtDataGridViewTextBoxColumn
            // 
            this.idOrtDataGridViewTextBoxColumn.DataPropertyName = "IdOrt";
            this.idOrtDataGridViewTextBoxColumn.HeaderText = "IdOrt";
            this.idOrtDataGridViewTextBoxColumn.Name = "idOrtDataGridViewTextBoxColumn";
            this.idOrtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idCatDataGridViewTextBoxColumn
            // 
            this.idCatDataGridViewTextBoxColumn.DataPropertyName = "IdCat";
            this.idCatDataGridViewTextBoxColumn.HeaderText = "IdCat";
            this.idCatDataGridViewTextBoxColumn.Name = "idCatDataGridViewTextBoxColumn";
            this.idCatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idUtlDataGridViewTextBoxColumn
            // 
            this.idUtlDataGridViewTextBoxColumn.DataPropertyName = "IdUtl";
            this.idUtlDataGridViewTextBoxColumn.HeaderText = "IdUtl";
            this.idUtlDataGridViewTextBoxColumn.Name = "idUtlDataGridViewTextBoxColumn";
            this.idUtlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sourceOrtDataGridViewTextBoxColumn
            // 
            this.sourceOrtDataGridViewTextBoxColumn.DataPropertyName = "sourceOrt";
            this.sourceOrtDataGridViewTextBoxColumn.HeaderText = "sourceOrt";
            this.sourceOrtDataGridViewTextBoxColumn.Name = "sourceOrtDataGridViewTextBoxColumn";
            this.sourceOrtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titreOrtDataGridViewTextBoxColumn
            // 
            this.titreOrtDataGridViewTextBoxColumn.DataPropertyName = "titreOrt";
            this.titreOrtDataGridViewTextBoxColumn.HeaderText = "titreOrt";
            this.titreOrtDataGridViewTextBoxColumn.Name = "titreOrtDataGridViewTextBoxColumn";
            this.titreOrtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOrtDataGridViewTextBoxColumn
            // 
            this.dateOrtDataGridViewTextBoxColumn.DataPropertyName = "dateOrt";
            this.dateOrtDataGridViewTextBoxColumn.HeaderText = "dateOrt";
            this.dateOrtDataGridViewTextBoxColumn.Name = "dateOrtDataGridViewTextBoxColumn";
            this.dateOrtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nbLikeDataGridViewTextBoxColumn
            // 
            this.nbLikeDataGridViewTextBoxColumn.DataPropertyName = "nbLike";
            this.nbLikeDataGridViewTextBoxColumn.HeaderText = "nbLike";
            this.nbLikeDataGridViewTextBoxColumn.Name = "nbLikeDataGridViewTextBoxColumn";
            this.nbLikeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orticleBindingSource
            // 
            this.orticleBindingSource.DataMember = "Orticle";
            this.orticleBindingSource.DataSource = this.dbOrticleDataSet5;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.gunaLabel5.Location = new System.Drawing.Point(698, 9);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(223, 51);
            this.gunaLabel5.TabIndex = 21;
            this.gunaLabel5.Text = "ORTICLE•";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(1501, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 28;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.Image")));
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaImageButton1.Location = new System.Drawing.Point(1445, -2);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(50, 50);
            this.gunaImageButton1.TabIndex = 29;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // orticleTableAdapter
            // 
            this.orticleTableAdapter.ClearBeforeFill = true;
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
            this.btnModifier.Location = new System.Drawing.Point(1101, 102);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(180)))));
            this.btnModifier.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModifier.OnHoverForeColor = System.Drawing.Color.White;
            this.btnModifier.OnHoverImage = null;
            this.btnModifier.OnPressedColor = System.Drawing.Color.Black;
            this.btnModifier.Radius = 15;
            this.btnModifier.Size = new System.Drawing.Size(170, 39);
            this.btnModifier.TabIndex = 32;
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
            this.btnAjouter.Location = new System.Drawing.Point(857, 102);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(180)))));
            this.btnAjouter.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAjouter.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAjouter.OnHoverImage = null;
            this.btnAjouter.OnPressedColor = System.Drawing.Color.Black;
            this.btnAjouter.Radius = 15;
            this.btnAjouter.Size = new System.Drawing.Size(170, 39);
            this.btnAjouter.TabIndex = 31;
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
            this.btnSupprimer.Location = new System.Drawing.Point(1323, 102);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(180)))));
            this.btnSupprimer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSupprimer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSupprimer.OnHoverImage = null;
            this.btnSupprimer.OnPressedColor = System.Drawing.Color.Black;
            this.btnSupprimer.Radius = 15;
            this.btnSupprimer.Size = new System.Drawing.Size(170, 39);
            this.btnSupprimer.TabIndex = 30;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
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
            this.btnVider.Location = new System.Drawing.Point(1200, 711);
            this.btnVider.Name = "btnVider";
            this.btnVider.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(180)))));
            this.btnVider.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnVider.OnHoverForeColor = System.Drawing.Color.White;
            this.btnVider.OnHoverImage = null;
            this.btnVider.OnPressedColor = System.Drawing.Color.Black;
            this.btnVider.Radius = 15;
            this.btnVider.Size = new System.Drawing.Size(270, 39);
            this.btnVider.TabIndex = 55;
            this.btnVider.Text = "Vider les champs";
            this.btnVider.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.Transparent;
            this.txtDate.BaseColor = System.Drawing.Color.White;
            this.txtDate.BorderColor = System.Drawing.Color.Silver;
            this.txtDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orticleBindingSource1, "dateOrt", true));
            this.txtDate.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDate.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDate.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDate.Location = new System.Drawing.Point(1218, 568);
            this.txtDate.Name = "txtDate";
            this.txtDate.PasswordChar = '\0';
            this.txtDate.Radius = 6;
            this.txtDate.SelectedText = "";
            this.txtDate.Size = new System.Drawing.Size(275, 30);
            this.txtDate.TabIndex = 54;
            // 
            // txtTitre
            // 
            this.txtTitre.BackColor = System.Drawing.Color.Transparent;
            this.txtTitre.BaseColor = System.Drawing.Color.White;
            this.txtTitre.BorderColor = System.Drawing.Color.Silver;
            this.txtTitre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orticleBindingSource1, "titreOrt", true));
            this.txtTitre.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTitre.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTitre.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTitre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTitre.Location = new System.Drawing.Point(1218, 498);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.PasswordChar = '\0';
            this.txtTitre.Radius = 6;
            this.txtTitre.SelectedText = "";
            this.txtTitre.Size = new System.Drawing.Size(275, 30);
            this.txtTitre.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(1107, 573);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 52;
            this.label6.Text = "DateOrt :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(1113, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 51;
            this.label5.Text = "TitreOrt :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(1132, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "IdOrt :";
            // 
            // txtSource
            // 
            this.txtSource.BackColor = System.Drawing.Color.Transparent;
            this.txtSource.BaseColor = System.Drawing.Color.White;
            this.txtSource.BorderColor = System.Drawing.Color.Silver;
            this.txtSource.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSource.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orticleBindingSource1, "sourceOrt", true));
            this.txtSource.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSource.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSource.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSource.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSource.Location = new System.Drawing.Point(1218, 425);
            this.txtSource.Name = "txtSource";
            this.txtSource.PasswordChar = '\0';
            this.txtSource.Radius = 6;
            this.txtSource.SelectedText = "";
            this.txtSource.Size = new System.Drawing.Size(275, 30);
            this.txtSource.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(1089, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "SourceOrt :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(1128, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "IdCat :";
            // 
            // txtIdOrt
            // 
            this.txtIdOrt.BackColor = System.Drawing.Color.Transparent;
            this.txtIdOrt.BaseColor = System.Drawing.Color.White;
            this.txtIdOrt.BorderColor = System.Drawing.Color.Silver;
            this.txtIdOrt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdOrt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orticleBindingSource1, "IdOrt", true));
            this.txtIdOrt.Enabled = false;
            this.txtIdOrt.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIdOrt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIdOrt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdOrt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdOrt.Location = new System.Drawing.Point(1218, 215);
            this.txtIdOrt.Name = "txtIdOrt";
            this.txtIdOrt.PasswordChar = '\0';
            this.txtIdOrt.Radius = 6;
            this.txtIdOrt.SelectedText = "";
            this.txtIdOrt.Size = new System.Drawing.Size(275, 30);
            this.txtIdOrt.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(1136, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "IdUtl :";
            // 
            // txtNbLikes
            // 
            this.txtNbLikes.BackColor = System.Drawing.Color.Transparent;
            this.txtNbLikes.BaseColor = System.Drawing.Color.White;
            this.txtNbLikes.BorderColor = System.Drawing.Color.Silver;
            this.txtNbLikes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNbLikes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orticleBindingSource, "nbLike", true));
            this.txtNbLikes.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNbLikes.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNbLikes.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNbLikes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNbLikes.Location = new System.Drawing.Point(1218, 639);
            this.txtNbLikes.Name = "txtNbLikes";
            this.txtNbLikes.PasswordChar = '\0';
            this.txtNbLikes.Radius = 6;
            this.txtNbLikes.SelectedText = "";
            this.txtNbLikes.Size = new System.Drawing.Size(275, 30);
            this.txtNbLikes.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(1104, 644);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 56;
            this.label7.Text = "NbLikes :";
            // 
            // txtIdUtl
            // 
            this.txtIdUtl.BackColor = System.Drawing.Color.Transparent;
            this.txtIdUtl.BaseColor = System.Drawing.Color.White;
            this.txtIdUtl.BorderColor = System.Drawing.Color.Silver;
            this.txtIdUtl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdUtl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orticleBindingSource1, "IdUtl", true));
            this.txtIdUtl.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIdUtl.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIdUtl.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdUtl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdUtl.Location = new System.Drawing.Point(1218, 350);
            this.txtIdUtl.Name = "txtIdUtl";
            this.txtIdUtl.PasswordChar = '\0';
            this.txtIdUtl.Radius = 6;
            this.txtIdUtl.SelectedText = "";
            this.txtIdUtl.Size = new System.Drawing.Size(275, 30);
            this.txtIdUtl.TabIndex = 58;
            // 
            // txtIdCat
            // 
            this.txtIdCat.BackColor = System.Drawing.Color.Transparent;
            this.txtIdCat.BaseColor = System.Drawing.Color.White;
            this.txtIdCat.BorderColor = System.Drawing.Color.Silver;
            this.txtIdCat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdCat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orticleBindingSource1, "IdCat", true));
            this.txtIdCat.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIdCat.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIdCat.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdCat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdCat.Location = new System.Drawing.Point(1218, 283);
            this.txtIdCat.Name = "txtIdCat";
            this.txtIdCat.PasswordChar = '\0';
            this.txtIdCat.Radius = 6;
            this.txtIdCat.SelectedText = "";
            this.txtIdCat.Size = new System.Drawing.Size(275, 30);
            this.txtIdCat.TabIndex = 59;
            // 
            // orticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 830);
            this.Controls.Add(this.txtIdCat);
            this.Controls.Add(this.txtIdUtl);
            this.Controls.Add(this.txtNbLikes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdOrt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.gunaImageButton1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaComboBox1);
            this.Controls.Add(this.gunaDataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "orticle";
            this.Text = "orticle";
            this.Load += new System.EventHandler(this.orticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orticleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrticleDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orticleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaImageButton btnClose;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private dbOrticleDataSet5 dbOrticleDataSet5;
        private System.Windows.Forms.BindingSource orticleBindingSource;
        private dbOrticleDataSet5TableAdapters.OrticleTableAdapter orticleTableAdapter;
        private System.Windows.Forms.BindingSource orticleBindingSource1;
        private Guna.UI.WinForms.GunaButton btnModifier;
        private Guna.UI.WinForms.GunaButton btnAjouter;
        private Guna.UI.WinForms.GunaButton btnSupprimer;
        private Guna.UI.WinForms.GunaButton btnVider;
        private Guna.UI.WinForms.GunaTextBox txtDate;
        private Guna.UI.WinForms.GunaTextBox txtTitre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtIdOrt;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtNbLikes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUtlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceOrtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreOrtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOrtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbLikeDataGridViewTextBoxColumn;
        private Guna.UI.WinForms.GunaTextBox txtIdUtl;
        private Guna.UI.WinForms.GunaTextBox txtIdCat;
    }
}