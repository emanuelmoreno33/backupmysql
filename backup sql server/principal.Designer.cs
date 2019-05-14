namespace backup_sql_server
{
    partial class principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.respaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parcialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restauracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.parcialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.respaldoToolStripMenuItem,
            this.restauracionToolStripMenuItem,
            this.listarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
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
            this.totalToolStripMenuItem.Name = "totalToolStripMenuItem";
            this.totalToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.totalToolStripMenuItem.Text = "Total";
            this.totalToolStripMenuItem.Click += new System.EventHandler(this.totalToolStripMenuItem_Click);
            // 
            // parcialToolStripMenuItem
            // 
            this.parcialToolStripMenuItem.Name = "parcialToolStripMenuItem";
            this.parcialToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.parcialToolStripMenuItem.Text = "Parcial";
            // 
            // restauracionToolStripMenuItem
            // 
            this.restauracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalToolStripMenuItem1,
            this.parcialToolStripMenuItem1});
            this.restauracionToolStripMenuItem.Name = "restauracionToolStripMenuItem";
            this.restauracionToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.restauracionToolStripMenuItem.Text = "Restauracion";
            // 
            // totalToolStripMenuItem1
            // 
            this.totalToolStripMenuItem1.Name = "totalToolStripMenuItem1";
            this.totalToolStripMenuItem1.Size = new System.Drawing.Size(127, 26);
            this.totalToolStripMenuItem1.Text = "Total";
            this.totalToolStripMenuItem1.Click += new System.EventHandler(this.totalToolStripMenuItem1_Click);
            // 
            // parcialToolStripMenuItem1
            // 
            this.parcialToolStripMenuItem1.Name = "parcialToolStripMenuItem1";
            this.parcialToolStripMenuItem1.Size = new System.Drawing.Size(127, 26);
            this.parcialToolStripMenuItem1.Text = "Parcial";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.listarToolStripMenuItem.Text = "listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "principal";
            this.Text = "principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem respaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parcialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restauracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem parcialToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
    }
}