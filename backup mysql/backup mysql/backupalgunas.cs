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
    public partial class backupalgunas : Form
    {
        public backupalgunas()
        {
            InitializeComponent();
        }

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
                        checkedListBox1.Items.Add(reader.GetString(0));
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

        private List<String> hacerlista()
        {
            List<String> lista = new List<string>();
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                lista.Add(checkedListBox1.CheckedItems[i].ToString());
            }
            return lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
              string conex = "server=" + txtservidor.Text + ";port=" + numpuerto.Value + ";username=" + txtusuario.Text + ";password=" + txtcontra.Text + ";";
                MySqlConnection conexion = new MySqlConnection(conex);
                try
                {
                    conexion.Open();
                    checkedListBox1.Enabled = true;
                    btnrespaldo.Enabled = true;
                    conexion.Close();
                    llenarbd(conexion);
                    MessageBox.Show("Conexión con éxito", "Aviso");
                }
                catch (MySqlException error)
                {
                    MessageBox.Show(error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void btnrespaldo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de respaldar todas las bases de datos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    string conex = "server=" + txtservidor.Text + ";port=" + numpuerto.Value + ";username=" + txtusuario.Text + ";password=" + txtcontra.Text + ";";

                    using (MySqlConnection conn = new MySqlConnection(conex))
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup mb = new MySqlBackup(cmd))
                            {
                                conn.Open();
                                cmd.Connection = conn;

                                resultado = MessageBox.Show("¿Usar ubicación predeterminada?", "Aviso", MessageBoxButtons.YesNo);
                                if (resultado == DialogResult.No)
                                {
                                    FolderBrowserDialog folder = new FolderBrowserDialog();
                                    if (folder.ShowDialog() == DialogResult.OK)
                                    {

                                        string defaultFolder = folder.SelectedPath;

                                        List<String> lista = hacerlista();

                                        foreach (String dr in lista)
                                        {
                                            string dbname = dr + "";

                                            // skip mysql default system tables
                                            switch (dbname)
                                            {
                                                case "sys":
                                                case "performance_schema":
                                                case "mysql":
                                                case "information_schema":
                                                case "sakila":
                                                case "world":
                                                    continue;
                                            }

                                            string dumpFile = System.IO.Path.Combine(defaultFolder, dbname) + ".sql";

                                            cmd.CommandText = "use `" + dbname + "`;";
                                            cmd.ExecuteNonQuery();

                                            mb.ExportToFile(dumpFile);
                                        }
                                        MessageBox.Show("Respaldo creado satisfactoriamente", "Aviso", MessageBoxButtons.OK);
                                    }
                                }
                                else
                                {
                                    string defaultFolder = "D:\\Usuarios\\backup";

                                    List<String> lista = hacerlista();

                                    foreach (String dr in lista)
                                    {
                                        string dbname = dr + "";

                                        // skip mysql default system tables
                                        switch (dbname)
                                        {
                                            case "sys":
                                            case "performance_schema":
                                            case "mysql":
                                            case "information_schema":
                                            case "sakila":
                                            case "world":
                                                continue;
                                        }

                                        string dumpFile = System.IO.Path.Combine(defaultFolder, dbname) + ".sql";

                                        cmd.CommandText = "use `" + dbname + "`;";
                                        cmd.ExecuteNonQuery();

                                        mb.ExportToFile(dumpFile);

                                    }
                                    MessageBox.Show("Respaldo creado satisfactoriamente", "Aviso", MessageBoxButtons.OK);
                                }
                                conn.Close();

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
    }
