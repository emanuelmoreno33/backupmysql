using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backup_mysql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listardb ventana = new listardb();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void totalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void totalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void parcialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backupparcial ventana = new backupparcial();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void parcialToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            restauracionespecifica ventana = new restauracionespecifica();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void todasLasBasesDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backuptodas ventana = new backuptodas();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void unaSolaBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backuptotal ventana = new backuptotal();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void todasLasBasesDeDatosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            restauraciontodas ventana = new restauraciontodas();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void soloUnaBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restauraciontotal ventana = new restauraciontotal();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void abrirUbicacionPredeterminadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\\Usuarios\\backup\\");
        }

        private void algunasBasesDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backupalgunas ventana = new backupalgunas();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void listarBasesDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listardb ventana = new listardb();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
