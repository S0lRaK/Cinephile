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
    public partial class Form_typesRole : Form
    {
        Form_newTypeRole formNewTypeRole = new Form_newTypeRole();
        
        public Form_typesRole()
        {
            InitializeComponent();
        }

        private void Form_typesRole_Load(object sender, EventArgs e)
        {
            this.tIPOS_PAPELTableAdapter.Fill(this.cinefilo_DataSet.TIPOS_PAPEL);
        }

        private void toolStripButton_new_Click(object sender, EventArgs e)
        {
            formNewTypeRole.ShowDialog();
        }

        private void toolStripButton_search_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
