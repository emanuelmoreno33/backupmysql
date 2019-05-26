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
    public partial class restauraciontodas : Form
    {
        public restauraciontodas()
        {
            InitializeComponent();
        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("¿Esta seguro de restaurar todas las bases de datos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                                        string[] files = System.IO.Directory.GetFiles(defaultFolder);

                                        foreach (string file in files)
                                        {
                                            if (file.ToLower().EndsWith(".sql"))
                                            {
                                                string dbName = System.IO.Path.GetFileNameWithoutExtension(file);

                                                cmd.CommandText = "create database if not exists `" + dbName + "`";
                                                cmd.ExecuteNonQuery();

                                                cmd.CommandText = "use `" + dbName + "`";
                                                cmd.ExecuteNonQuery();

                                                mb.ImportFromFile(file);
                                            }
                                        }

                                        conn.Close();

                                        MessageBox.Show("Restauración completada", "Aviso", MessageBoxButtons.OK);
                                    }
                                }
                                else
                                {
                                    string defaultFolder = "D:\\Usuarios\\backup";
                                    string[] files = System.IO.Directory.GetFiles(defaultFolder);

                                    foreach (string file in files)
                                    {
                                        if (file.ToLower().EndsWith(".sql"))
                                        {
                                            string dbName = System.IO.Path.GetFileNameWithoutExtension(file);

                                            cmd.CommandText = "create database if not exists `" + dbName + "`";
                                            cmd.ExecuteNonQuery();

                                            cmd.CommandText = "use `" + dbName + "`";
                                            cmd.ExecuteNonQuery();

                                            mb.ImportFromFile(file);
                                        }
                                    }

                                    conn.Close();
                                    MessageBox.Show("Restauración completada", "Aviso", MessageBoxButtons.OK);
                                }



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
