using Microsoft.SqlServer.Management.Smo;
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
    public partial class restaurartotal : Form
    {
        
        public restaurartotal()
        {
            InitializeComponent();
        }

        private void btnrespaldo_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.InitialDirectory = @"D:\";
                openFileDialog1.Title = "Buscar el respaldo";
                openFileDialog1.CheckFileExists = true;
                openFileDialog1.DefaultExt = "bak";
                openFileDialog1.Filter = "Archivo de respaldo (*.bak)|*.bak";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.SqlServer.Management.Common.ServerConnection conexion = new Microsoft.SqlServer.Management.Common.ServerConnection(txtservidor.Text, txtusuario.Text, txtcontra.Text);
                    Server dbserver = new Server(conexion);
                    Restore dbrestaurar = new Restore() { Database = combobd.Text, Action = RestoreActionType.Database, ReplaceDatabase = true, NoRecovery = false };
                    dbrestaurar.Devices.AddDevice(openFileDialog1.FileName,DeviceType.File);
                    dbrestaurar.PercentComplete += Dbrestaurar_PercentComplete;
                    dbrestaurar.Complete += Dbrestaurar_Complete;
                    dbrestaurar.SqlRestoreAsync(dbserver);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dbrestaurar_Complete(object sender, Microsoft.SqlServer.Management.Common.ServerMessageEventArgs e)
        {
            if(e.Error != null)
            {
                lblstatus.Text = e.Error.Message;
            }
        }

        private void Dbrestaurar_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = e.Percent;
                progressBar1.Update();
            });
            lblporcentaje.Invoke((MethodInvoker)delegate
            {
                lblporcentaje.Text = $"{e.Percent} %";
            });
        }

        private void mostrarbd()
        {
            SqlConnection conex = new SqlConnection("server=EMANUELMR-OMEN\\SQLEXPRESS;database=Creditos_Complementarios;integrated security = true");
            conex.Open();
            string query = "select name from sysdatabases";
            SqlCommand comando = new SqlCommand(query, conex);
            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                combobd.Items.Add(lector["name"]);
            }
            conex.Close();
        }

        private void restaurartotal_Load(object sender, EventArgs e)
        {
            mostrarbd();
        }
    }
}
