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
    public partial class backuptotal : Form
    {
        public backuptotal()
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
                        switch (reader.GetString(0))
                        {
                            case "sys":
                            case "performance_schema":
                            case "mysql":
                            case "information_schema":
                            case "sakila":
                            case "world":
                                continue;
                        }
                        combobd.Items.Add(reader.GetString(0));
                    }
                }

                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                combobd.Enabled = true;
                btnrespaldo.Enabled = true;
                conexion.Close();
                llenarbd(conexion);
                MessageBox.Show("Conexión con éxito", "Aviso");
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnrespaldo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado;
                resultado = MessageBox.Show("Usar ubicación predeterminada", "Aviso", MessageBoxButtons.YesNo);
                conex = "server=" + txtservidor.Text + ";port=" + numpuerto.Value + ";username=" + txtusuario.Text + ";password=" + txtcontra.Text + ";database=" + combobd.Text + ";";
                if (resultado == DialogResult.No)
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.InitialDirectory = @"D:\\Usuarios\\backup\\";
                    saveFileDialog1.Title = "Save text Files";
                    saveFileDialog1.DefaultExt = "sql";
                    saveFileDialog1.Filter = "Archivo de respaldo (*.sql)|*.sql";
                    saveFileDialog1.FilterIndex = 2;
                    saveFileDialog1.RestoreDirectory = true;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        using (MySqlConnection conn = new MySqlConnection(conex))
                        {
                            using (MySqlCommand cmd = new MySqlCommand())
                            {
                                using (MySqlBackup mb = new MySqlBackup(cmd))
                                {
                                    cmd.Connection = conn;
                                    conn.Open();
                                    mb.ExportInfo.AddCreateDatabase = true;
                                    mb.ExportToFile(saveFileDialog1.FileName);
                                    conn.Close();
                                    MessageBox.Show("Base de datos respaldada con éxito", "Aviso", MessageBoxButtons.OK);
                                }
                            }
                        }
                    }
                }
                else
                {
                    string nombre = Microsoft.VisualBasic.Interaction.InputBox("Nombre del archivo", "Aviso",combobd.Text+".sql");
                    using (MySqlConnection conn = new MySqlConnection(conex))
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup mb = new MySqlBackup(cmd))
                            {
                                cmd.Connection = conn;
                                conn.Open();
                                if (nombre != "")
                                {
                                    mb.ExportInfo.AddCreateDatabase = true;
                                    mb.ExportToFile("D:\\Usuarios\\backup\\"+nombre);
                                }
                                else
                                {
                                    mb.ExportInfo.AddCreateDatabase = true;
                                    mb.ExportToFile("D:\\Usuarios\\backup\\"+combobd.Text+".sql");
                                }
                                conn.Close();
                                MessageBox.Show("Base de datos respaldada con éxito", "Aviso", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void backuptotal_Load(object sender, EventArgs e)
        {

        }
    }
}
