namespace ControlPanel
{
    partial class support
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(support));
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.idSupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomSupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomSupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailSupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msgSupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbOrticleDataSet = new ControlPanel.dbOrticleDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sendEmail = new Guna.UI.WinForms.GunaImageButton();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.ResponseTb = new Guna.UI.WinForms.GunaTextBox();
            this.supportTableAdapter = new ControlPanel.dbOrticleDataSetTableAdapters.supportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrticleDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaDataGridView1
            // 
            this.gunaDataGridView1.AllowUserToAddRows = false;
            this.gunaDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gunaDataGridView1.AutoGenerateColumns = false;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gunaDataGridView1.ColumnHeadersHeight = 27;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSupDataGridViewTextBoxColumn,
            this.nomSupDataGridViewTextBoxColumn,
            this.prenomSupDataGridViewTextBoxColumn,
            this.emailSupDataGridViewTextBoxColumn,
            this.msgSupDataGridViewTextBoxColumn});
            this.gunaDataGridView1.DataSource = this.supportBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(41, 16);
            this.gunaDataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.ReadOnly = true;
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(755, 706);
            this.gunaDataGridView1.TabIndex = 33;
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
            // idSupDataGridViewTextBoxColumn
            // 
            this.idSupDataGridViewTextBoxColumn.DataPropertyName = "IdSup";
            this.idSupDataGridViewTextBoxColumn.HeaderText = "IdSup";
            this.idSupDataGridViewTextBoxColumn.Name = "idSupDataGridViewTextBoxColumn";
            this.idSupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomSupDataGridViewTextBoxColumn
            // 
            this.nomSupDataGridViewTextBoxColumn.DataPropertyName = "nomSup";
            this.nomSupDataGridViewTextBoxColumn.HeaderText = "nomSup";
            this.nomSupDataGridViewTextBoxColumn.Name = "nomSupDataGridViewTextBoxColumn";
            this.nomSupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomSupDataGridViewTextBoxColumn
            // 
            this.prenomSupDataGridViewTextBoxColumn.DataPropertyName = "prenomSup";
            this.prenomSupDataGridViewTextBoxColumn.HeaderText = "prenomSup";
            this.prenomSupDataGridViewTextBoxColumn.Name = "prenomSupDataGridViewTextBoxColumn";
            this.prenomSupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailSupDataGridViewTextBoxColumn
            // 
            this.emailSupDataGridViewTextBoxColumn.DataPropertyName = "emailSup";
            this.emailSupDataGridViewTextBoxColumn.HeaderText = "emailSup";
            this.emailSupDataGridViewTextBoxColumn.Name = "emailSupDataGridViewTextBoxColumn";
            this.emailSupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // msgSupDataGridViewTextBoxColumn
            // 
            this.msgSupDataGridViewTextBoxColumn.DataPropertyName = "msgSup";
            this.msgSupDataGridViewTextBoxColumn.HeaderText = "msgSup";
            this.msgSupDataGridViewTextBoxColumn.Name = "msgSupDataGridViewTextBoxColumn";
            this.msgSupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supportBindingSource
            // 
            this.supportBindingSource.DataMember = "support";
            this.supportBindingSource.DataSource = this.dbOrticleDataSet;
            // 
            // dbOrticleDataSet
            // 
            this.dbOrticleDataSet.DataSetName = "dbOrticleDataSet";
            this.dbOrticleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.sendEmail);
            this.groupBox2.Controls.Add(this.gunaTextBox1);
            this.groupBox2.Controls.Add(this.ResponseTb);
            this.groupBox2.Location = new System.Drawing.Point(840, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(580, 720);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BaseColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supportBindingSource, "emailSup", true));
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(168, 683);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.Radius = 6;
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(352, 32);
            this.txtEmail.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 683);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-mail :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 411);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Reponse :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Message :";
            // 
            // sendEmail
            // 
            this.sendEmail.DialogResult = System.Windows.Forms.DialogResult.None;
            this.sendEmail.Image = ((System.Drawing.Image)(resources.GetObject("sendEmail.Image")));
            this.sendEmail.ImageSize = new System.Drawing.Size(40, 40);
            this.sendEmail.Location = new System.Drawing.Point(523, 438);
            this.sendEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendEmail.Name = "sendEmail";
            this.sendEmail.OnHoverImage = null;
            this.sendEmail.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.sendEmail.Size = new System.Drawing.Size(51, 50);
            this.sendEmail.TabIndex = 5;
            this.sendEmail.Click += new System.EventHandler(this.sendEmail_Click);
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.BorderSize = 0;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supportBindingSource, "msgSup", true));
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTextBox1.Location = new System.Drawing.Point(27, 40);
            this.gunaTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaTextBox1.Multiline = true;
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(532, 294);
            this.gunaTextBox1.TabIndex = 4;
            // 
            // ResponseTb
            // 
            this.ResponseTb.BackColor = System.Drawing.Color.Transparent;
            this.ResponseTb.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ResponseTb.BorderColor = System.Drawing.Color.Silver;
            this.ResponseTb.BorderSize = 0;
            this.ResponseTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ResponseTb.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ResponseTb.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ResponseTb.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.ResponseTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponseTb.Location = new System.Drawing.Point(27, 438);
            this.ResponseTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResponseTb.Multiline = true;
            this.ResponseTb.Name = "ResponseTb";
            this.ResponseTb.PasswordChar = '\0';
            this.ResponseTb.Radius = 10;
            this.ResponseTb.SelectedText = "";
            this.ResponseTb.Size = new System.Drawing.Size(476, 192);
            this.ResponseTb.TabIndex = 4;
            // 
            // supportTableAdapter
            // 
            this.supportTableAdapter.ClearBeforeFill = true;
            // 
            // support
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "support";
            this.Size = new System.Drawing.Size(1461, 738);
            this.Load += new System.EventHandler(this.support_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrticleDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaImageButton sendEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomSupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomSupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailSupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msgSupDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource supportBindingSource;
        private dbOrticleDataSet dbOrticleDataSet;
        private dbOrticleDataSetTableAdapters.supportTableAdapter supportTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaTextBox ResponseTb;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private System.Windows.Forms.Label label3;
    }
}
