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
    public partial class backuptodas : Form
    {
        public backuptodas()
        {
            InitializeComponent();
        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("¿Est seguro de respaldar todas las bases de datos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

                                cmd.CommandText = "show databases;";
                                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                                DataTable dtDbList = new DataTable();
                                da.Fill(dtDbList);



                                resultado = MessageBox.Show("Usar ubicación predeterminada", "Aviso", MessageBoxButtons.YesNo);
                                if (resultado == DialogResult.No)
                                {
                                    FolderBrowserDialog folder = new FolderBrowserDialog();
                                    if (folder.ShowDialog() == DialogResult.OK)
                                    {

                                        string defaultFolder = folder.SelectedPath;

                                        foreach (DataRow dr in dtDbList.Rows)
                                        {
                                            string dbname = dr[0] + "";

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

                                    foreach (DataRow dr in dtDbList.Rows)
                                    {
                                        string dbname = dr[0] + "";

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         }
    }
}
