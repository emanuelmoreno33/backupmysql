namespace backup_mysql
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.respaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todasLasBasesDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unaSolaBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parcialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restauraciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.todasLasBasesDeDatosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.soloUnaBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parcialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.respaldoToolStripMenuItem,
            this.restauraciToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // respaldoToolStripMenuItem
            // 
            this.respaldoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalToolStripMenuItem,
            this.parcialToolStripMenuItem});
            this.respaldoToolStripMenuItem.Name = "respaldoToolStripMenuItem";
            this.respaldoToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.respaldoToolStripMenuItem.Text = "Respaldo";
            // 
            // totalToolStripMenuItem
            // 
            this.totalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todasLasBasesDeDatosToolStripMenuItem,
            this.unaSolaBaseDeDatosToolStripMenuItem});
            this.totalToolStripMenuItem.Name = "totalToolStripMenuItem";
            this.totalToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.totalToolStripMenuItem.Text = "Total";
            this.totalToolStripMenuItem.Click += new System.EventHandler(this.totalToolStripMenuItem_Click);
            // 
            // todasLasBasesDeDatosToolStripMenuItem
            // 
            this.todasLasBasesDeDatosToolStripMenuItem.Name = "todasLasBasesDeDatosToolStripMenuItem";
            this.todasLasBasesDeDatosToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.todasLasBasesDeDatosToolStripMenuItem.Text = "Todas las bases de datos";
            this.todasLasBasesDeDatosToolStripMenuItem.ToolTipText = "Respalda todas las bases de datos.";
            this.todasLasBasesDeDatosToolStripMenuItem.Click += new System.EventHandler(this.todasLasBasesDeDatosToolStripMenuItem_Click);
            // 
            // unaSolaBaseDeDatosToolStripMenuItem
            // 
            this.unaSolaBaseDeDatosToolStripMenuItem.Name = "unaSolaBaseDeDatosToolStripMenuItem";
            this.unaSolaBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.unaSolaBaseDeDatosToolStripMenuItem.Text = "Una sola base de datos";
            this.unaSolaBaseDeDatosToolStripMenuItem.ToolTipText = "Respalda una sola base de datos.\r\nNo agrega la sentencia \"CREATE DATABASE\".";
            this.unaSolaBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.unaSolaBaseDeDatosToolStripMenuItem_Click);
            // 
            // parcialToolStripMenuItem
            // 
            this.parcialToolStripMenuItem.Name = "parcialToolStripMenuItem";
            this.parcialToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.parcialToolStripMenuItem.Text = "Especifico.";
            this.parcialToolStripMenuItem.ToolTipText = "Hace un respaldo indicando que guardar.";
            this.parcialToolStripMenuItem.Click += new System.EventHandler(this.parcialToolStripMenuItem_Click);
            // 
            // restauraciToolStripMenuItem
            // 
            this.restauraciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalToolStripMenuItem1,
            this.parcialToolStripMenuItem1});
            this.restauraciToolStripMenuItem.Name = "restauraciToolStripMenuItem";
            this.restauraciToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.restauraciToolStripMenuItem.Text = "Restauración";
            // 
            // totalToolStripMenuItem1
            // 
            this.totalToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todasLasBasesDeDatosToolStripMenuItem1,
            this.soloUnaBaseDeDatosToolStripMenuItem});
            this.totalToolStripMenuItem1.Name = "totalToolStripMenuItem1";
            this.totalToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.totalToolStripMenuItem1.Text = "Total";
            this.totalToolStripMenuItem1.Click += new System.EventHandler(this.totalToolStripMenuItem1_Click);
            // 
            // todasLasBasesDeDatosToolStripMenuItem1
            // 
            this.todasLasBasesDeDatosToolStripMenuItem1.Name = "todasLasBasesDeDatosToolStripMenuItem1";
            this.todasLasBasesDeDatosToolStripMenuItem1.Size = new System.Drawing.Size(248, 26);
            this.todasLasBasesDeDatosToolStripMenuItem1.Text = "Todas las bases de datos";
            this.todasLasBasesDeDatosToolStripMenuItem1.ToolTipText = "Restaura cuando el archivo tiene todas\r\nlas bases de datos.";
            this.todasLasBasesDeDatosToolStripMenuItem1.Click += new System.EventHandler(this.todasLasBasesDeDatosToolStripMenuItem1_Click);
            // 
            // soloUnaBaseDeDatosToolStripMenuItem
            // 
            this.soloUnaBaseDeDatosToolStripMenuItem.Name = "soloUnaBaseDeDatosToolStripMenuItem";
            this.soloUnaBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.soloUnaBaseDeDatosToolStripMenuItem.Text = "Solo una base de datos";
            this.soloUnaBaseDeDatosToolStripMenuItem.ToolTipText = "Funciona cuando ya se tiene\r\nseleccionada la base de datos\r\ncon \"CREATE DATABASE\"" +
    "";
            this.soloUnaBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.soloUnaBaseDeDatosToolStripMenuItem_Click);
            // 
            // parcialToolStripMenuItem1
            // 
            this.parcialToolStripMenuItem1.Name = "parcialToolStripMenuItem1";
            this.parcialToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.parcialToolStripMenuItem1.Text = "Especifica";
            this.parcialToolStripMenuItem1.ToolTipText = "Restaura cuando no se tiene\r\nel \"CREATE DATABASE\"";
            this.parcialToolStripMenuItem1.Click += new System.EventHandler(this.parcialToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 853);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem respaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restauraciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parcialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem parcialToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todasLasBasesDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unaSolaBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todasLasBasesDeDatosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem soloUnaBaseDeDatosToolStripMenuItem;
    }
}

