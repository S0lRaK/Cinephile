namespace Cinephile
{
    partial class Form_home
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip_home = new System.Windows.Forms.MenuStrip();
            this.generalData_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typesRole_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themes_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_home.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_home
            // 
            this.menuStrip_home.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalData_ToolStripMenuItem});
            this.menuStrip_home.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_home.Name = "menuStrip_home";
            this.menuStrip_home.Size = new System.Drawing.Size(469, 24);
            this.menuStrip_home.TabIndex = 0;
            // 
            // generalData_ToolStripMenuItem
            // 
            this.generalData_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typesRole_ToolStripMenuItem,
            this.themes_ToolStripMenuItem,
            this.toolStripSeparator1,
            this.exit_ToolStripMenuItem});
            this.generalData_ToolStripMenuItem.Name = "generalData_ToolStripMenuItem";
            this.generalData_ToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.generalData_ToolStripMenuItem.Text = "General Data";
            // 
            // typesRole_ToolStripMenuItem
            // 
            this.typesRole_ToolStripMenuItem.Name = "typesRole_ToolStripMenuItem";
            this.typesRole_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.typesRole_ToolStripMenuItem.Text = "Types of role";
            this.typesRole_ToolStripMenuItem.Click += new System.EventHandler(this.typesRole_ToolStripMenuItem_Click);
            // 
            // themes_ToolStripMenuItem
            // 
            this.themes_ToolStripMenuItem.Name = "themes_ToolStripMenuItem";
            this.themes_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.themes_ToolStripMenuItem.Text = "Themes";
            this.themes_ToolStripMenuItem.Click += new System.EventHandler(this.themes_ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exit_ToolStripMenuItem
            // 
            this.exit_ToolStripMenuItem.Name = "exit_ToolStripMenuItem";
            this.exit_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exit_ToolStripMenuItem.Text = "Exit";
            // 
            // Form_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 140);
            this.Controls.Add(this.menuStrip_home);
            this.MainMenuStrip = this.menuStrip_home;
            this.Name = "Form_home";
            this.Text = "Cinephile";
            this.menuStrip_home.ResumeLayout(false);
            this.menuStrip_home.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_home;
        private System.Windows.Forms.ToolStripMenuItem generalData_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typesRole_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themes_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exit_ToolStripMenuItem;
    }
}

