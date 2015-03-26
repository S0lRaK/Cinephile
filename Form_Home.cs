using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinephile
{
    public partial class Form_home : Form
    {
        Form_typesRole formTypesRole = new Form_typesRole();
        Form_themes formThemes = new Form_themes();
        
        public Form_home()
        {
            InitializeComponent();
        }

        private void typesRole_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTypesRole.Show();
        }

        private void themes_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formThemes.Show();
        }
    }
}
