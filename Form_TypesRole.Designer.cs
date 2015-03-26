namespace Cinephile
{
    partial class Form_typesRole
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
            this.toolStrip_typesRole = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_new = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_save = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_search = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_exit = new System.Windows.Forms.ToolStripButton();
            this.groupBox_searchCriteria = new System.Windows.Forms.GroupBox();
            this.label_type = new System.Windows.Forms.Label();
            this.textBox_type = new System.Windows.Forms.TextBox();
            this.groupBox_typesRole = new System.Windows.Forms.GroupBox();
            this.dataGridView_typesRole = new System.Windows.Forms.DataGridView();
            this.cinefilo_DataSet = new Cinephile.cinefiloDataSet();
            this.typesRole_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIPOS_PAPELTableAdapter = new Cinephile.cinefiloDataSetTableAdapters.TIPOS_PAPELTableAdapter();
            this.description_DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip_typesRole.SuspendLayout();
            this.groupBox_searchCriteria.SuspendLayout();
            this.groupBox_typesRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_typesRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinefilo_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesRole_BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip_typesRole
            // 
            this.toolStrip_typesRole.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_new,
            this.toolStripButton_search,
            this.toolStripButton_save,
            this.toolStripSeparator1,
            this.toolStripButton_exit});
            this.toolStrip_typesRole.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_typesRole.Name = "toolStrip_typesRole";
            this.toolStrip_typesRole.Size = new System.Drawing.Size(472, 25);
            this.toolStrip_typesRole.TabIndex = 0;
            // 
            // toolStripButton_new
            // 
            this.toolStripButton_new.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_new.Image = global::Cinephile.Properties.Resources.new_32;
            this.toolStripButton_new.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_new.Name = "toolStripButton_new";
            this.toolStripButton_new.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_new.Text = "New";
            this.toolStripButton_new.Click += new System.EventHandler(this.toolStripButton_new_Click);
            // 
            // toolStripButton_save
            // 
            this.toolStripButton_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_save.Image = global::Cinephile.Properties.Resources.document_save_32;
            this.toolStripButton_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_save.Name = "toolStripButton_save";
            this.toolStripButton_save.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_save.Text = "Save";
            // 
            // toolStripButton_search
            // 
            this.toolStripButton_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_search.Image = global::Cinephile.Properties.Resources.search_32;
            this.toolStripButton_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_search.Name = "toolStripButton_search";
            this.toolStripButton_search.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_search.Text = "Search";
            this.toolStripButton_search.Click += new System.EventHandler(this.toolStripButton_search_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_exit
            // 
            this.toolStripButton_exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_exit.Image = global::Cinephile.Properties.Resources.application_exit_32;
            this.toolStripButton_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_exit.Name = "toolStripButton_exit";
            this.toolStripButton_exit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_exit.Text = "Exit";
            this.toolStripButton_exit.Click += new System.EventHandler(this.toolStripButton_exit_Click);
            // 
            // groupBox_searchCriteria
            // 
            this.groupBox_searchCriteria.Controls.Add(this.textBox_type);
            this.groupBox_searchCriteria.Controls.Add(this.label_type);
            this.groupBox_searchCriteria.Location = new System.Drawing.Point(13, 41);
            this.groupBox_searchCriteria.Name = "groupBox_searchCriteria";
            this.groupBox_searchCriteria.Size = new System.Drawing.Size(447, 85);
            this.groupBox_searchCriteria.TabIndex = 1;
            this.groupBox_searchCriteria.TabStop = false;
            this.groupBox_searchCriteria.Text = "Search criteria";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(95, 34);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(31, 13);
            this.label_type.TabIndex = 0;
            this.label_type.Text = "Type";
            // 
            // textBox_type
            // 
            this.textBox_type.Location = new System.Drawing.Point(157, 31);
            this.textBox_type.Name = "textBox_type";
            this.textBox_type.Size = new System.Drawing.Size(222, 20);
            this.textBox_type.TabIndex = 1;
            // 
            // groupBox_typesRole
            // 
            this.groupBox_typesRole.Controls.Add(this.dataGridView_typesRole);
            this.groupBox_typesRole.Location = new System.Drawing.Point(13, 133);
            this.groupBox_typesRole.Name = "groupBox_typesRole";
            this.groupBox_typesRole.Size = new System.Drawing.Size(447, 297);
            this.groupBox_typesRole.TabIndex = 2;
            this.groupBox_typesRole.TabStop = false;
            this.groupBox_typesRole.Text = "Types of role";
            // 
            // dataGridView_typesRole
            // 
            this.dataGridView_typesRole.AllowUserToOrderColumns = true;
            this.dataGridView_typesRole.AutoGenerateColumns = false;
            this.dataGridView_typesRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_typesRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.description_DataGridViewTextBoxColumn});
            this.dataGridView_typesRole.DataSource = this.typesRole_BindingSource;
            this.dataGridView_typesRole.Location = new System.Drawing.Point(25, 34);
            this.dataGridView_typesRole.Name = "dataGridView_typesRole";
            this.dataGridView_typesRole.Size = new System.Drawing.Size(401, 237);
            this.dataGridView_typesRole.TabIndex = 0;
            // 
            // cinefilo_DataSet
            // 
            this.cinefilo_DataSet.DataSetName = "cinefilo_DataSet";
            this.cinefilo_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typesRole_BindingSource
            // 
            this.typesRole_BindingSource.DataMember = "TIPOS_PAPEL";
            this.typesRole_BindingSource.DataSource = this.cinefilo_DataSet;
            // 
            // tIPOS_PAPELTableAdapter
            // 
            this.tIPOS_PAPELTableAdapter.ClearBeforeFill = true;
            // 
            // description_DataGridViewTextBoxColumn
            // 
            this.description_DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description_DataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.description_DataGridViewTextBoxColumn.HeaderText = "Description";
            this.description_DataGridViewTextBoxColumn.Name = "description_DataGridViewTextBoxColumn";
            // 
            // Form_typesRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 442);
            this.Controls.Add(this.groupBox_typesRole);
            this.Controls.Add(this.groupBox_searchCriteria);
            this.Controls.Add(this.toolStrip_typesRole);
            this.Name = "Form_typesRole";
            this.Text = "Types of role";
            this.Load += new System.EventHandler(this.Form_typesRole_Load);
            this.toolStrip_typesRole.ResumeLayout(false);
            this.toolStrip_typesRole.PerformLayout();
            this.groupBox_searchCriteria.ResumeLayout(false);
            this.groupBox_searchCriteria.PerformLayout();
            this.groupBox_typesRole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_typesRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinefilo_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesRole_BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_typesRole;
        private System.Windows.Forms.ToolStripButton toolStripButton_new;
        private System.Windows.Forms.ToolStripButton toolStripButton_search;
        private System.Windows.Forms.ToolStripButton toolStripButton_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_exit;
        private System.Windows.Forms.GroupBox groupBox_searchCriteria;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.TextBox textBox_type;
        private System.Windows.Forms.GroupBox groupBox_typesRole;
        private System.Windows.Forms.DataGridView dataGridView_typesRole;
        private cinefiloDataSet cinefilo_DataSet;
        private System.Windows.Forms.BindingSource typesRole_BindingSource;
        private cinefiloDataSetTableAdapters.TIPOS_PAPELTableAdapter tIPOS_PAPELTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn description_DataGridViewTextBoxColumn;
    }
}