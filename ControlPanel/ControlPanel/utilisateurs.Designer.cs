namespace ControlPanel
{
    partial class utilisateurs
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
            this.btnVider = new Guna.UI.WinForms.GunaButton();
            this.txtMp = new Guna.UI.WinForms.GunaTextBox();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbOrticleDataSet = new ControlPanel.dbOrticleDataSet();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsern = new Guna.UI.WinForms.GunaTextBox();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.idUtlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomUtlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomUtlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernUtlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailUtlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdpUtlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModifier = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.CbId = new Guna.UI.WinForms.GunaComboBox();
            this.txtPrenom = new Guna.UI.WinForms.GunaTextBox();
            this.btnAjouter = new Guna.UI.WinForms.GunaButton();
            this.txtId = new Guna.UI.WinForms.GunaTextBox();
            this.btnSupprimer = new Guna.UI.WinForms.GunaButton();
            this.txtNom = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.utilisateurTableAdapter = new ControlPanel.dbOrticleDataSetTableAdapters.UtilisateurTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrticleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.btnVider.Location = new System.Drawing.Point(818, 518);
            this.btnVider.Margin = new System.Windows.Forms.Padding(2);
            this.btnVider.Name = "btnVider";
            this.btnVider.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(180)))));
            this.btnVider.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnVider.OnHoverForeColor = System.Drawing.Color.White;
            this.btnVider.OnHoverImage = null;
            this.btnVider.OnPressedColor = System.Drawing.Color.Black;
            this.btnVider.Radius = 15;
            this.btnVider.Size = new System.Drawing.Size(189, 32);
            this.btnVider.TabIndex = 61;
            this.btnVider.Text = "Vider les champs";
            this.btnVider.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // txtMp
            // 
            this.txtMp.BackColor = System.Drawing.Color.Transparent;
            this.txtMp.BaseColor = System.Drawing.Color.White;
            this.txtMp.BorderColor = System.Drawing.Color.Silver;
            this.txtMp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilisateurBindingSource, "mdpUtl", true));
            this.txtMp.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMp.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMp.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMp.Location = new System.Drawing.Point(840, 439);
            this.txtMp.Margin = new System.Windows.Forms.Padding(2);
            this.txtMp.Name = "txtMp";
            this.txtMp.PasswordChar = '\0';
            this.txtMp.Radius = 6;
            this.txtMp.SelectedText = "";
            this.txtMp.Size = new System.Drawing.Size(215, 26);
            this.txtMp.TabIndex = 60;
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataMember = "Utilisateur";
            this.utilisateurBindingSource.DataSource = this.dbOrticleDataSet;
            // 
            // dbOrticleDataSet
            // 
            this.dbOrticleDataSet.DataSetName = "dbOrticleDataSet";
            this.dbOrticleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BaseColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilisateurBindingSource, "emailUtl", true));
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(840, 383);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.Radius = 6;
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(215, 26);
            this.txtEmail.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(756, 444);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 58;
            this.label6.Text = "mdpUtl :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(750, 387);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "emailUtl :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(775, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "IdUtl :";
            // 
            // txtUsern
            // 
            this.txtUsern.BackColor = System.Drawing.Color.Transparent;
            this.txtUsern.BaseColor = System.Drawing.Color.White;
            this.txtUsern.BorderColor = System.Drawing.Color.Silver;
            this.txtUsern.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsern.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilisateurBindingSource, "usernUtl", true));
            this.txtUsern.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUsern.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUsern.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsern.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsern.Location = new System.Drawing.Point(840, 323);
            this.txtUsern.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsern.Name = "txtUsern";
            this.txtUsern.PasswordChar = '\0';
            this.txtUsern.Radius = 6;
            this.txtUsern.SelectedText = "";
            this.txtUsern.Size = new System.Drawing.Size(215, 26);
            this.txtUsern.TabIndex = 54;
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
            this.idUtlDataGridViewTextBoxColumn,
            this.nomUtlDataGridViewTextBoxColumn,
            this.prenomUtlDataGridViewTextBoxColumn,
            this.usernUtlDataGridViewTextBoxColumn,
            this.emailUtlDataGridViewTextBoxColumn,
            this.mdpUtlDataGridViewTextBoxColumn});
            this.gunaDataGridView1.DataSource = this.utilisateurBindingSource;
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
            this.gunaDataGridView1.Location = new System.Drawing.Point(40, 96);
            this.gunaDataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.ReadOnly = true;
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(666, 469);
            this.gunaDataGridView1.TabIndex = 47;
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
            // idUtlDataGridViewTextBoxColumn
            // 
            this.idUtlDataGridViewTextBoxColumn.DataPropertyName = "IdUtl";
            this.idUtlDataGridViewTextBoxColumn.HeaderText = "IdUtl";
            this.idUtlDataGridViewTextBoxColumn.Name = "idUtlDataGridViewTextBoxColumn";
            this.idUtlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomUtlDataGridViewTextBoxColumn
            // 
            this.nomUtlDataGridViewTextBoxColumn.DataPropertyName = "nomUtl";
            this.nomUtlDataGridViewTextBoxColumn.HeaderText = "nomUtl";
            this.nomUtlDataGridViewTextBoxColumn.Name = "nomUtlDataGridViewTextBoxColumn";
            this.nomUtlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomUtlDataGridViewTextBoxColumn
            // 
            this.prenomUtlDataGridViewTextBoxColumn.DataPropertyName = "prenomUtl";
            this.prenomUtlDataGridViewTextBoxColumn.HeaderText = "prenomUtl";
            this.prenomUtlDataGridViewTextBoxColumn.Name = "prenomUtlDataGridViewTextBoxColumn";
            this.prenomUtlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernUtlDataGridViewTextBoxColumn
            // 
            this.usernUtlDataGridViewTextBoxColumn.DataPropertyName = "usernUtl";
            this.usernUtlDataGridViewTextBoxColumn.HeaderText = "usernUtl";
            this.usernUtlDataGridViewTextBoxColumn.Name = "usernUtlDataGridViewTextBoxColumn";
            this.usernUtlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailUtlDataGridViewTextBoxColumn
            // 
            this.emailUtlDataGridViewTextBoxColumn.DataPropertyName = "emailUtl";
            this.emailUtlDataGridViewTextBoxColumn.HeaderText = "emailUtl";
            this.emailUtlDataGridViewTextBoxColumn.Name = "emailUtlDataGridViewTextBoxColumn";
            this.emailUtlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mdpUtlDataGridViewTextBoxColumn
            // 
            this.mdpUtlDataGridViewTextBoxColumn.DataPropertyName = "mdpUtl";
            this.mdpUtlDataGridViewTextBoxColumn.HeaderText = "mdpUtl";
            this.mdpUtlDataGridViewTextBoxColumn.Name = "mdpUtlDataGridViewTextBoxColumn";
            this.mdpUtlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(750, 323);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "usernUtl :";
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
            this.btnModifier.Location = new System.Drawing.Point(761, 36);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(180)))));
            this.btnModifier.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModifier.OnHoverForeColor = System.Drawing.Color.White;
            this.btnModifier.OnHoverImage = null;
            this.btnModifier.OnPressedColor = System.Drawing.Color.Black;
            this.btnModifier.Radius = 15;
            this.btnModifier.Size = new System.Drawing.Size(128, 32);
            this.btnModifier.TabIndex = 46;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(759, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "nomUtl :";
            // 
            // CbId
            // 
            this.CbId.BackColor = System.Drawing.Color.Transparent;
            this.CbId.BaseColor = System.Drawing.Color.White;
            this.CbId.BorderColor = System.Drawing.Color.Silver;
            this.CbId.DataSource = this.utilisateurBindingSource;
            this.CbId.DisplayMember = "IdUtl";
            this.CbId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbId.FocusedColor = System.Drawing.Color.Empty;
            this.CbId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CbId.ForeColor = System.Drawing.Color.Black;
            this.CbId.FormattingEnabled = true;
            this.CbId.Location = new System.Drawing.Point(102, 36);
            this.CbId.Margin = new System.Windows.Forms.Padding(2);
            this.CbId.Name = "CbId";
            this.CbId.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CbId.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CbId.Radius = 6;
            this.CbId.Size = new System.Drawing.Size(242, 26);
            this.CbId.TabIndex = 43;
            this.CbId.ValueMember = "IdUtl";
            // 
            // txtPrenom
            // 
            this.txtPrenom.BackColor = System.Drawing.Color.Transparent;
            this.txtPrenom.BaseColor = System.Drawing.Color.White;
            this.txtPrenom.BorderColor = System.Drawing.Color.Silver;
            this.txtPrenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilisateurBindingSource, "prenomUtl", true));
            this.txtPrenom.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPrenom.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPrenom.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrenom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrenom.Location = new System.Drawing.Point(840, 258);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.PasswordChar = '\0';
            this.txtPrenom.Radius = 6;
            this.txtPrenom.SelectedText = "";
            this.txtPrenom.Size = new System.Drawing.Size(215, 26);
            this.txtPrenom.TabIndex = 53;
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
            this.btnAjouter.Location = new System.Drawing.Point(578, 36);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(180)))));
            this.btnAjouter.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAjouter.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAjouter.OnHoverImage = null;
            this.btnAjouter.OnPressedColor = System.Drawing.Color.Black;
            this.btnAjouter.Radius = 15;
            this.btnAjouter.Size = new System.Drawing.Size(128, 32);
            this.btnAjouter.TabIndex = 45;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Transparent;
            this.txtId.BaseColor = System.Drawing.Color.White;
            this.txtId.BorderColor = System.Drawing.Color.Silver;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilisateurBindingSource, "IdUtl", true));
            this.txtId.Enabled = false;
            this.txtId.FocusedBaseColor = System.Drawing.Color.White;
            this.txtId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtId.Location = new System.Drawing.Point(840, 132);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.Radius = 6;
            this.txtId.SelectedText = "";
            this.txtId.Size = new System.Drawing.Size(215, 26);
            this.txtId.TabIndex = 55;
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
            this.btnSupprimer.Location = new System.Drawing.Point(928, 36);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(180)))));
            this.btnSupprimer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSupprimer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSupprimer.OnHoverImage = null;
            this.btnSupprimer.OnPressedColor = System.Drawing.Color.Black;
            this.btnSupprimer.Radius = 15;
            this.btnSupprimer.Size = new System.Drawing.Size(128, 32);
            this.btnSupprimer.TabIndex = 44;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.Transparent;
            this.txtNom.BaseColor = System.Drawing.Color.White;
            this.txtNom.BorderColor = System.Drawing.Color.Silver;
            this.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilisateurBindingSource, "nomUtl", true));
            this.txtNom.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNom.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNom.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNom.Location = new System.Drawing.Point(840, 193);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.Radius = 6;
            this.txtNom.SelectedText = "";
            this.txtNom.Size = new System.Drawing.Size(215, 26);
            this.txtNom.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(742, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "prenomUtl:";
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // utilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.txtMp);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsern);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbId);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "utilisateurs";
            this.Size = new System.Drawing.Size(1096, 600);
            this.Load += new System.EventHandler(this.utilisateurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrticleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnVider;
        private Guna.UI.WinForms.GunaTextBox txtMp;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtUsern;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaButton btnModifier;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaComboBox CbId;
        private Guna.UI.WinForms.GunaTextBox txtPrenom;
        private Guna.UI.WinForms.GunaButton btnAjouter;
        private Guna.UI.WinForms.GunaTextBox txtId;
        private Guna.UI.WinForms.GunaButton btnSupprimer;
        private Guna.UI.WinForms.GunaTextBox txtNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private dbOrticleDataSet dbOrticleDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUtlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomUtlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomUtlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernUtlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailUtlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdpUtlDataGridViewTextBoxColumn;
        private dbOrticleDataSetTableAdapters.UtilisateurTableAdapter utilisateurTableAdapter;
    }
}
