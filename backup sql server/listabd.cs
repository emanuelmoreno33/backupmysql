using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backup_sql_server
{
    public partial class listabd : Form
    {
        public listabd()
        {
            InitializeComponent();
        }

        private void listabd_Load(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("server=EMANUELMR-OMEN\\SQLEXPRESS;database=Creditos_Complementarios;integrated security = true");
            DataTable dt = new DataTable();

            conex.Open();
            string query = "select name from sysdatabases";
            SqlCommand comando = new SqlCommand(query, conex);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conex.Close();
        }
    }
}
