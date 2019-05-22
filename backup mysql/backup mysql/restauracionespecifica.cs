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
    public partial class restauracionespecifica : Form
    {
        public restauracionespecifica()
        {
            InitializeComponent();
        }

        string conex;

        private void llenarbd(MySqlConnection conexion)
        {
            MySqlDataReader reader;
            try
            {
                conexion.Open();
                MySqlCommand query = new MySqlCommand("show databases", conexion);
                reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        combobd.Items.Add(reader.GetString(0));
                    }
                }

                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                conexion.Close();
            }
        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            conex = "server=" + txtservidor.Text + ";port=" + numpuerto.Value + ";username=" + txtusuario.Text + ";password=" + txtcontra.Text + ";";
            MySqlConnection conexion = new MySqlConnection(conex);
            try
            {
                conexion.Open();
                btnrespaldo.Enabled = true;
                groupBox1.Enabled = true;
                conexion.Close();
                llenarbd(conexion);
            }
            catch (MySqlException error)
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
                                if(checkBox2.Checked == true)
                                {
                                    mb.ImportInfo.TargetDatabase = combobd.Text;
                                }


                                cmd.Connection = conn;
                                conn.Open();
                                mb.ImportInfo.IgnoreSqlError = checkBox3.Checked;
                                mb.ImportFromFile(openFileDialog1.FileName);
                                conn.Close();
                                MessageBox.Show("Restauración completada", "Aviso", MessageBoxButtons.OK);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private string obtenerdireccion()
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowNewFolderButton = true;
            folderBrowserDialog1.Description = "Seleccione donde colocar el Archivo Log";

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                return folderBrowserDialog1.SelectedPath;
            }
            else
            {
                return null;
            }
        }

        

        
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                combobd.Enabled = true;
            }
            else
            {
                combobd.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
