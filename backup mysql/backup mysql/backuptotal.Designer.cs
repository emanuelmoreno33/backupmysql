namespace backup_mysql
{
    partial class backuptotal
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
            this.btnconectar = new System.Windows.Forms.Button();
            this.numpuerto = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.combobd = new System.Windows.Forms.ComboBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtservidor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnrespaldo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numpuerto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnconectar
            // 
            this.btnconectar.Location = new System.Drawing.Point(109, 131);
            this.btnconectar.Name = "btnconectar";
            this.btnconectar.Size = new System.Drawing.Size(101, 45);
            this.btnconectar.TabIndex = 51;
            this.btnconectar.Text = "Conectar";
            this.btnconectar.UseVisualStyleBackColor = true;
            this.btnconectar.Click += new System.EventHandler(this.btnconectar_Click);
            // 
            // numpuerto
            // 
            this.numpuerto.Location = new System.Drawing.Point(151, 35);
            this.numpuerto.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numpuerto.Name = "numpuerto";
            this.numpuerto.Size = new System.Drawing.Size(184, 22);
            this.numpuerto.TabIndex = 50;
            this.numpuerto.Value = new decimal(new int[] {
            3306,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "Puerto:";
            // 
            // combobd
            // 
            this.combobd.Enabled = false;
            this.combobd.FormattingEnabled = true;
            this.combobd.Location = new System.Drawing.Point(151, 195);
            this.combobd.Name = "combobd";
            this.combobd.Size = new System.Drawing.Size(184, 24);
            this.combobd.TabIndex = 48;
            // 
            // txtcontra
            // 
            this.txtcontra.Location = new System.Drawing.Point(151, 91);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(184, 22);
            this.txtcontra.TabIndex = 46;
            this.txtcontra.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Contraseña";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(151, 63);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(184, 22);
            this.txtusuario.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Nombre de usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Base de datos:";
            // 
            // txtservidor
            // 
            this.txtservidor.Location = new System.Drawing.Point(151, 6);
            this.txtservidor.Name = "txtservidor";
            this.txtservidor.Size = new System.Drawing.Size(184, 22);
            this.txtservidor.TabIndex = 40;
            this.txtservidor.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Servidor:";
            // 
            // btnrespaldo
            // 
            this.btnrespaldo.Enabled = false;
            this.btnrespaldo.Location = new System.Drawing.Point(109, 243);
            this.btnrespaldo.Name = "btnrespaldo";
            this.btnrespaldo.Size = new System.Drawing.Size(101, 45);
            this.btnrespaldo.TabIndex = 38;
            this.btnrespaldo.Text = "Respaldar";
            this.btnrespaldo.UseVisualStyleBackColor = true;
            this.btnrespaldo.Click += new System.EventHandler(this.btnrespaldo_Click);
            // 
            // backuptotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 336);
            this.Controls.Add(this.btnconectar);
            this.Controls.Add(this.numpuerto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combobd);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtservidor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnrespaldo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "backuptotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "backuptotal";
            ((System.ComponentModel.ISupportInitialize)(this.numpuerto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconectar;
        private System.Windows.Forms.NumericUpDown numpuerto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combobd;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtservidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnrespaldo;
    }
}