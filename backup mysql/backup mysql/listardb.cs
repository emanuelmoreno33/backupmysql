using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace backup_mysql
{
    public partial class listardb : Form
    {
        public listardb()
        {
            InitializeComponent();
        }

        private void listardb_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server="+txtservidor.Text+";port="+numpuerto.Value+";username="+txtusuario.Text+";password="+txtcontra.Text+";");
            MySqlDataReader reader;
            try
            {
                comboBox1.Items.Clear();
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
                        comboBox1.Items.Add(reader.GetString(0));
                    }
                }

                conexion.Close();
                comboBox1.Enabled = true;
                listBox1.Enabled = true;
                MessageBox.Show("Conexión con exito", "Aviso");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                conexion.Close();
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server=" + txtservidor.Text + ";port=" + numpuerto.Value + ";username=" + txtusuario.Text + ";password=" + txtcontra.Text + ";database="+comboBox1.Text+";");
            MySqlDataReader reader;
            try
            {
                listBox1.Items.Clear();
                conexion.Open();
                MySqlCommand query = new MySqlCommand("show tables", conexion);
                reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listBox1.Items.Add(reader.GetString(0));
                    }
                }

                conexion.Close();
                comboBox1.Enabled = true;
                listBox1.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                conexion.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server=" + txtservidor.Text + ";port=" + numpuerto.Value + ";username=" + txtusuario.Text + ";password=" + txtcontra.Text + ";database=" + comboBox1.Text + ";");
            try
            {
                conexion.Open();
                if (listBox1.Text != "")
                {
                    MySqlCommand query = new MySqlCommand("select * from " + listBox1.Text, conexion);

                    MySqlDataAdapter da = new MySqlDataAdapter(query);
                    DataSet dtDbList = new DataSet();
                    da.Fill(dtDbList);
                    dataGridView1.DataSource = dtDbList.Tables[0];

                    conexion.Close();
                    comboBox1.Enabled = true;
                    listBox1.Enabled = true;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                conexion.Close();
            }
        }
    }
}
