namespace Cinephile
{
    partial class Form_themes
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
            this.toolStrip_Themes = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_New = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Search = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Exit = new System.Windows.Forms.ToolStripButton();
            this.groupBox_SearchCriteria = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip_Themes.SuspendLayout();
            this.groupBox_SearchCriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_Themes
            // 
            this.toolStrip_Themes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_New,
            this.toolStripButton_Search,
            this.toolStripButton_Save,
            this.toolStripSeparator1,
            this.toolStripButton_Exit});
            this.toolStrip_Themes.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_Themes.Name = "toolStrip_Themes";
            this.toolStrip_Themes.Size = new System.Drawing.Size(470, 25);
            this.toolStrip_Themes.TabIndex = 0;
            // 
            // toolStripButton_New
            // 
            this.toolStripButton_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_New.Image = global::Cinephile.Properties.Resources.new_32;
            this.toolStripButton_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_New.Name = "toolStripButton_New";
            this.toolStripButton_New.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_New.Text = "New";
            // 
            // toolStripButton_Search
            // 
            this.toolStripButton_Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Search.Image = global::Cinephile.Properties.Resources.search_32;
            this.toolStripButton_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Search.Name = "toolStripButton_Search";
            this.toolStripButton_Search.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Search.Text = "Search";
            // 
            // toolStripButton_Save
            // 
            this.toolStripButton_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Save.Image = global::Cinephile.Properties.Resources.document_save_32;
            this.toolStripButton_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Save.Name = "toolStripButton_Save";
            this.toolStripButton_Save.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Save.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_Exit
            // 
            this.toolStripButton_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Exit.Image = global::Cinephile.Properties.Resources.application_exit_32;
            this.toolStripButton_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Exit.Name = "toolStripButton_Exit";
            this.toolStripButton_Exit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Exit.Text = "Exit";
            // 
            // groupBox_SearchCriteria
            // 
            this.groupBox_SearchCriteria.Controls.Add(this.label1);
            this.groupBox_SearchCriteria.Location = new System.Drawing.Point(13, 39);
            this.groupBox_SearchCriteria.Name = "groupBox_SearchCriteria";
            this.groupBox_SearchCriteria.Size = new System.Drawing.Size(445, 72);
            this.groupBox_SearchCriteria.TabIndex = 1;
            this.groupBox_SearchCriteria.TabStop = false;
            this.groupBox_SearchCriteria.Text = "Search criteria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Form_Themes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 261);
            this.Controls.Add(this.groupBox_SearchCriteria);
            this.Controls.Add(this.toolStrip_Themes);
            this.Name = "Form_Themes";
            this.Text = "Themes";
            this.toolStrip_Themes.ResumeLayout(false);
            this.toolStrip_Themes.PerformLayout();
            this.groupBox_SearchCriteria.ResumeLayout(false);
            this.groupBox_SearchCriteria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_Themes;
        private System.Windows.Forms.ToolStripButton toolStripButton_New;
        private System.Windows.Forms.ToolStripButton toolStripButton_Search;
        private System.Windows.Forms.ToolStripButton toolStripButton_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Exit;
        private System.Windows.Forms.GroupBox groupBox_SearchCriteria;
        private System.Windows.Forms.Label label1;
    }
}