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
        MySqlConnection conexion = new MySqlConnection("server=127.0.0.1;port=3306;username=emanuel;password=2133;");
            MySqlDataReader reader;
            try
            {
                conexion.Open();
                MySqlCommand query = new MySqlCommand("show databases", conexion);
                reader = query.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        comboBox1.Items.Add(reader.GetString(0));
                    }
                }

                conexion.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
                conexion.Close();
            }


        }
    }
}
