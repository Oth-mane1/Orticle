namespace ControlPanel
{
    partial class signal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signal));
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.idSigDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUtlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbSugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusSigDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signalOrtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbOrticleDataSet = new ControlPanel.dbOrticleDataSet();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtSource = new Guna.UI.WinForms.GunaTextBox();
            this.btnIgnorer = new Guna.UI.WinForms.GunaButton();
            this.btnSupprimer = new Guna.UI.WinForms.GunaButton();
            this.textOrticle = new Guna.UI.WinForms.GunaTextBox();
            this.btnReduire = new Guna.UI.WinForms.GunaImageButton();
            this.btnClose = new Guna.UI.WinForms.GunaImageButton();
            this.signalOrtTableAdapter = new ControlPanel.dbOrticleDataSetTableAdapters.signalOrtTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signalOrtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrticleDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaDataGridView1
            // 
            this.gunaDataGridView1.AllowUserToAddRows = false;
            this.gunaDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaDataGridView1.AutoGenerateColumns = false;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gunaDataGridView1.ColumnHeadersHeight = 27;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSigDataGridViewTextBoxColumn,
            this.idOrtDataGridViewTextBoxColumn,
            this.idUtlDataGridViewTextBoxColumn,
            this.nbSugDataGridViewTextBoxColumn,
            this.dateOrtDataGridViewTextBoxColumn,
            this.statusSigDataGridViewTextBoxColumn});
            this.gunaDataGridView1.DataSource = this.signalOrtBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(52, 105);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.ReadOnly = true;
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(753, 699);
            this.gunaDataGridView1.TabIndex = 37;
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
            this.gunaDataGridView1.CurrentCellChanged += new System.EventHandler(this.gunaDataGridView1_CurrentCellChanged);
            // 
            // idSigDataGridViewTextBoxColumn
            // 
            this.idSigDataGridViewTextBoxColumn.DataPropertyName = "IdSig";
            this.idSigDataGridViewTextBoxColumn.HeaderText = "IdSig";
            this.idSigDataGridViewTextBoxColumn.Name = "idSigDataGridViewTextBoxColumn";
            this.idSigDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idOrtDataGridViewTextBoxColumn
            // 
            this.idOrtDataGridViewTextBoxColumn.DataPropertyName = "IdOrt";
            this.idOrtDataGridViewTextBoxColumn.HeaderText = "IdOrt";
            this.idOrtDataGridViewTextBoxColumn.Name = "idOrtDataGridViewTextBoxColumn";
            this.idOrtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idUtlDataGridViewTextBoxColumn
            // 
            this.idUtlDataGridViewTextBoxColumn.DataPropertyName = "IdUtl";
            this.idUtlDataGridViewTextBoxColumn.HeaderText = "IdUtl";
            this.idUtlDataGridViewTextBoxColumn.Name = "idUtlDataGridViewTextBoxColumn";
            this.idUtlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nbSugDataGridViewTextBoxColumn
            // 
            this.nbSugDataGridViewTextBoxColumn.DataPropertyName = "nbSug";
            this.nbSugDataGridViewTextBoxColumn.HeaderText = "nbSug";
            this.nbSugDataGridViewTextBoxColumn.Name = "nbSugDataGridViewTextBoxColumn";
            this.nbSugDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOrtDataGridViewTextBoxColumn
            // 
            this.dateOrtDataGridViewTextBoxColumn.DataPropertyName = "dateOrt";
            this.dateOrtDataGridViewTextBoxColumn.HeaderText = "dateOrt";
            this.dateOrtDataGridViewTextBoxColumn.Name = "dateOrtDataGridViewTextBoxColumn";
            this.dateOrtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusSigDataGridViewTextBoxColumn
            // 
            this.statusSigDataGridViewTextBoxColumn.DataPropertyName = "statusSig";
            this.statusSigDataGridViewTextBoxColumn.HeaderText = "statusSig";
            this.statusSigDataGridViewTextBoxColumn.Name = "statusSigDataGridViewTextBoxColumn";
            this.statusSigDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // signalOrtBindingSource
            // 
            this.signalOrtBindingSource.DataMember = "signalOrt";
            this.signalOrtBindingSource.DataSource = this.dbOrticleDataSet;
            // 
            // dbOrticleDataSet
            // 
            this.dbOrticleDataSet.DataSetName = "dbOrticleDataSet";
            this.dbOrticleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.gunaLabel5.Location = new System.Drawing.Point(622, 10);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(223, 51);
            this.gunaLabel5.TabIndex = 36;
            this.gunaLabel5.Text = "ORTICLE•";
            // 
            // txtSource
            // 
            this.txtSource.BackColor = System.Drawing.Color.Transparent;
            this.txtSource.BaseColor = System.Drawing.Color.White;
            this.txtSource.BorderColor = System.Drawing.Color.Silver;
            this.txtSource.BorderSize = 0;
            this.txtSource.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSource.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSource.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSource.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSource.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSource.Location = new System.Drawing.Point(1002, 687);
            this.txtSource.Name = "txtSource";
            this.txtSource.PasswordChar = '\0';
            this.txtSource.Radius = 10;
            this.txtSource.SelectedText = "";
            this.txtSource.Size = new System.Drawing.Size(285, 32);
            this.txtSource.TabIndex = 35;
            // 
            // btnIgnorer
            // 
            this.btnIgnorer.AnimationHoverSpeed = 0.07F;
            this.btnIgnorer.AnimationSpeed = 0.03F;
            this.btnIgnorer.BackColor = System.Drawing.Color.Transparent;
            this.btnIgnorer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(180)))));
            this.btnIgnorer.BorderColor = System.Drawing.Color.Black;
            this.btnIgnorer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIgnorer.FocusedColor = System.Drawing.Color.Empty;
            this.btnIgnorer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgnorer.ForeColor = System.Drawing.Color.White;
            this.btnIgnorer.Image = null;
            this.btnIgnorer.ImageSize = new System.Drawing.Size(20, 20);
            this.btnIgnorer.Location = new System.Drawing.Point(1181, 747);
            this.btnIgnorer.Name = "btnIgnorer";
            this.btnIgnorer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(180)))));
            this.btnIgnorer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnIgnorer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnIgnorer.OnHoverImage = null;
            this.btnIgnorer.OnPressedColor = System.Drawing.Color.Black;
            this.btnIgnorer.Radius = 15;
            this.btnIgnorer.Size = new System.Drawing.Size(170, 39);
            this.btnIgnorer.TabIndex = 34;
            this.btnIgnorer.Text = "Ignorer";
            this.btnIgnorer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIgnorer.Click += new System.EventHandler(this.btnIgnorer_Click);
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
            this.btnSupprimer.Location = new System.Drawing.Point(938, 747);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(180)))));
            this.btnSupprimer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSupprimer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSupprimer.OnHoverImage = null;
            this.btnSupprimer.OnPressedColor = System.Drawing.Color.Black;
            this.btnSupprimer.Radius = 15;
            this.btnSupprimer.Size = new System.Drawing.Size(170, 39);
            this.btnSupprimer.TabIndex = 33;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // textOrticle
            // 
            this.textOrticle.BackColor = System.Drawing.Color.Transparent;
            this.textOrticle.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textOrticle.BorderColor = System.Drawing.Color.Silver;
            this.textOrticle.BorderSize = 0;
            this.textOrticle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textOrticle.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textOrticle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textOrticle.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textOrticle.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOrticle.Location = new System.Drawing.Point(881, 105);
            this.textOrticle.Multiline = true;
            this.textOrticle.Name = "textOrticle";
            this.textOrticle.PasswordChar = '\0';
            this.textOrticle.Radius = 15;
            this.textOrticle.SelectedText = "";
            this.textOrticle.Size = new System.Drawing.Size(532, 453);
            this.textOrticle.TabIndex = 32;
            // 
            // btnReduire
            // 
            this.btnReduire.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReduire.Image = ((System.Drawing.Image)(resources.GetObject("btnReduire.Image")));
            this.btnReduire.ImageSize = new System.Drawing.Size(25, 25);
            this.btnReduire.Location = new System.Drawing.Point(1353, 0);
            this.btnReduire.Name = "btnReduire";
            this.btnReduire.OnHoverImage = null;
            this.btnReduire.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnReduire.Size = new System.Drawing.Size(50, 50);
            this.btnReduire.TabIndex = 100;
            this.btnReduire.Click += new System.EventHandler(this.btnReduire_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(1409, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 99;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // signalOrtTableAdapter
            // 
            this.signalOrtTableAdapter.ClearBeforeFill = true;
            // 
            // signal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReduire);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.btnIgnorer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.textOrticle);
            this.Name = "signal";
            this.Size = new System.Drawing.Size(1462, 830);
            this.Load += new System.EventHandler(this.signal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signalOrtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrticleDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtSource;
        private Guna.UI.WinForms.GunaButton btnIgnorer;
        private Guna.UI.WinForms.GunaButton btnSupprimer;
        private Guna.UI.WinForms.GunaTextBox textOrticle;
        private Guna.UI.WinForms.GunaImageButton btnReduire;
        private Guna.UI.WinForms.GunaImageButton btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSigDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUtlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbSugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOrtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusSigDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource signalOrtBindingSource;
        private dbOrticleDataSet dbOrticleDataSet;
        private dbOrticleDataSetTableAdapters.signalOrtTableAdapter signalOrtTableAdapter;
    }
}
