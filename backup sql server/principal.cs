using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backup_sql_server
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void totalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backuptotal ventana = new backuptotal();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void totalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            restaurartotal ventana = new restaurartotal();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listabd ventana = new listabd();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
