using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace backup_mysql
{
    public partial class restauraciontotal : Form
    {
        string conex;

        public restauraciontotal()
        {
            InitializeComponent();
        }

        private void restauraciontotal_Load(object sender, EventArgs e)
        {

        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            conex = "server="+txtservidor.Text+";port="+numpuerto.Value+";username="+txtusuario.Text+";password="+txtcontra.Text+";";
            MySqlConnection conexion = new MySqlConnection(conex);
            try
            {
                conexion.Open();
                btnrespaldo.Enabled = true;
                conexion.Close();
            }
            catch(MySqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void btnrespaldo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"D:\";
            openFileDialog1.Title = "Buscar el respaldo";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.DefaultExt = "sql";
            openFileDialog1.Filter = "Archivo de respaldo (*.sql)|*.sql";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                conex = "server=" + txtservidor.Text + ";port=" + numpuerto.Value + ";user=" + txtusuario.Text + ";pwd=" + txtcontra.Text + ";";
                using (MySqlConnection conn = new MySqlConnection(conex))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            try
                            {
                                cmd.Connection = conn;
                                conn.Open();
                                mb.ImportFromFile(openFileDialog1.FileName);
                                conn.Close();
                                MessageBox.Show("Restauracion completada", "Aviso",MessageBoxButtons.OK);
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }
}
