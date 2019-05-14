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
    public partial class backuptotal : Form
    {
        public backuptotal()
        {
            InitializeComponent();
        }

        private void btnrespaldo_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = @"D:\";
                saveFileDialog1.Title = "Save text Files";
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Filter = "Archivo de respaldo (*.bak)|*.bak";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                progressBar1.Value = 0;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.SqlServer.Management.Common.ServerConnection conexion = new Microsoft.SqlServer.Management.Common.ServerConnection(txtservidor.Text, txtusuario.Text, txtcontra.Text);
                    Server dbserver = new Server(conexion);
                    Backup dbbackup = new Backup() { Action = BackupActionType.Database, Database = combobd.Text };
                    dbbackup.Devices.AddDevice(saveFileDialog1.FileName, DeviceType.File);
                    dbbackup.Initialize = true;
                    dbbackup.PercentComplete += Dbbackup_PercentComplete;
                    dbbackup.Complete += Dbbackup_Complete;
                    dbbackup.SqlBackupAsync(dbserver);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dbbackup_Complete(object sender, Microsoft.SqlServer.Management.Common.ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lblstatus.Text = e.Error.Message;
            }
        }

        private void Dbbackup_PercentComplete(object sender, PercentCompleteEventArgs e)
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

            while(lector.Read())
            {
                combobd.Items.Add(lector["name"]);
            }
            conex.Close();
        }

        private void backuptotal_Load(object sender, EventArgs e)
        {
            mostrarbd();
        }
    }
}
