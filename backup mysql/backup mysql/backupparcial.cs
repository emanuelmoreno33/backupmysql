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
    public partial class backupparcial : Form
    {
        public backupparcial()
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

        private void llenartablas(MySqlConnection conexion)
        {
            MySqlDataReader reader;
            try
            {
                checkedListBox1.Items.Clear();
                conexion.Open();
                MySqlCommand query = new MySqlCommand("show tables", conexion);
                reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        checkedListBox1.Items.Add(reader.GetString(0));
                    }
                }

                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                conexion.Close();
            }
        }

        private void activarlistatablas(bool tablas)
        {
            if (tablas == true)
            {
                checkedListBox1.Enabled = true;
            }
            else if (tablas == false)
            {
                checkedListBox1.Enabled = false;
            }
        }

        private List<String> hacerlista()
        {
            List<String> lista = new List<string>();
            for (int i =0;i<checkedListBox1.CheckedItems.Count;i++)
            {
                lista.Add(checkedListBox1.CheckedItems[i].ToString());
            }
            return lista;
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
                button1.Enabled = true;
                conexion.Close();
                llenarbd(conexion);
                MessageBox.Show("Conexión con exito", "Aviso");
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //busca la base de datos para mostrar tablas
        private void button1_Click(object sender, EventArgs e)
        {
            conex = "server=" + txtservidor.Text + ";port=" + numpuerto.Value + ";username=" + txtusuario.Text + ";password=" + txtcontra.Text + ";database="+combobd.Text+";";
            MySqlConnection conexion = new MySqlConnection(conex);
            try
            {
                conexion.Open();
                combobd.Enabled = true;
                btnrespaldo.Enabled = true;
                groupBox1.Enabled = true;
                btnrespaldo.Enabled = true;
                conexion.Close();
                llenartablas(conexion);
                MessageBox.Show("Conexión con exito", "Aviso");
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Enabled == true)
            {
                activarlistatablas(false);
            }
        }

        private void btnrespaldo_Click(object sender, EventArgs e)
        {
            try
            {
                conex = "server=" + txtservidor.Text + ";port=" + numpuerto.Value + ";username=" + txtusuario.Text + ";password=" + txtcontra.Text + ";database=" + combobd.Text + ";";
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = @"D:\";
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
                                bool crearbd = checkagregarbd.Checked;
                                bool tablaestructura = exportarextructura.Checked;
                                bool procedimientos = exportarprocedimiento.Checked;
                                bool funciones = exportarfuncion.Checked;
                                bool triggers = exportartrigger.Checked;
                                bool vistas = exportarvista.Checked;
                                bool eventos = exportarevento.Checked;
                                bool renglones = exportarrenglon.Checked;
                                bool encriptarar = encriptararchivo.Checked;
                                

                                List<String> lista = new List<string>();
                                cmd.Connection = conn;
                                conn.Open();
                                mb.ExportInfo.AddCreateDatabase = crearbd;
                                mb.ExportInfo.ExportTableStructure = tablaestructura;
                                mb.ExportInfo.ExportProcedures = procedimientos;
                                mb.ExportInfo.ExportFunctions = funciones;
                                mb.ExportInfo.ExportTriggers = triggers;
                                mb.ExportInfo.ExportViews = vistas;
                                mb.ExportInfo.ExportEvents = eventos;
                                mb.ExportInfo.ExportRows = renglones;
                                if (radioButton2.Checked == true)
                                {
                                    lista = hacerlista();
                                    mb.ExportInfo.TablesToBeExportedList = lista;
                                }
                                else if (radioButton3.Checked == true)
                                {
                                    lista = hacerlista();
                                    mb.ExportInfo.ExcludeTables = lista;
                                }
                                
                                mb.ExportToFile(saveFileDialog1.FileName);
                                conn.Close();
                                MessageBox.Show("Base de datos respaldada con exito", "Aviso", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Enabled == true)
            {
                activarlistatablas(true);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Enabled == true)
            {
                activarlistatablas(true);
            }
        }

        private void exportarrenglon_CheckedChanged(object sender, EventArgs e)
        {
            if (exportarrenglon.Checked == true)
            {
                panel1.Enabled = true;
            }
            else
            {
                panel1.Enabled = false;
            }
        }
    }
}
