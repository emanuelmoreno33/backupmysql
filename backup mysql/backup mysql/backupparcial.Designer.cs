namespace backup_mysql
{
    partial class backupparcial
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
            this.components = new System.ComponentModel.Container();
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.encriptararchivo = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.exportarrenglon = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.exportarevento = new System.Windows.Forms.CheckBox();
            this.exportartrigger = new System.Windows.Forms.CheckBox();
            this.exportarvista = new System.Windows.Forms.CheckBox();
            this.exportarprocedimiento = new System.Windows.Forms.CheckBox();
            this.exportarfuncion = new System.Windows.Forms.CheckBox();
            this.exportarextructura = new System.Windows.Forms.CheckBox();
            this.checkagregarbd = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numpuerto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnconectar
            // 
            this.btnconectar.Location = new System.Drawing.Point(109, 119);
            this.btnconectar.Name = "btnconectar";
            this.btnconectar.Size = new System.Drawing.Size(101, 45);
            this.btnconectar.TabIndex = 63;
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
            this.numpuerto.TabIndex = 62;
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
            this.label5.TabIndex = 61;
            this.label5.Text = "Puerto:";
            // 
            // combobd
            // 
            this.combobd.Enabled = false;
            this.combobd.FormattingEnabled = true;
            this.combobd.Location = new System.Drawing.Point(151, 170);
            this.combobd.Name = "combobd";
            this.combobd.Size = new System.Drawing.Size(184, 24);
            this.combobd.TabIndex = 60;
            // 
            // txtcontra
            // 
            this.txtcontra.Location = new System.Drawing.Point(151, 91);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(184, 22);
            this.txtcontra.TabIndex = 59;
            this.txtcontra.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 58;
            this.label3.Text = "Contraseña";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(151, 63);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(184, 22);
            this.txtusuario.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Nombre de usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Base de datos:";
            // 
            // txtservidor
            // 
            this.txtservidor.Location = new System.Drawing.Point(151, 6);
            this.txtservidor.Name = "txtservidor";
            this.txtservidor.Size = new System.Drawing.Size(184, 22);
            this.txtservidor.TabIndex = 54;
            this.txtservidor.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Servidor:";
            // 
            // btnrespaldo
            // 
            this.btnrespaldo.Enabled = false;
            this.btnrespaldo.Location = new System.Drawing.Point(109, 374);
            this.btnrespaldo.Name = "btnrespaldo";
            this.btnrespaldo.Size = new System.Drawing.Size(101, 45);
            this.btnrespaldo.TabIndex = 52;
            this.btnrespaldo.Text = "Respaldar";
            this.btnrespaldo.UseVisualStyleBackColor = true;
            this.btnrespaldo.Click += new System.EventHandler(this.btnrespaldo_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(109, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 61);
            this.button1.TabIndex = 64;
            this.button1.Text = "Conectar con Base de datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.encriptararchivo);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.exportarrenglon);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.exportarevento);
            this.groupBox1.Controls.Add(this.exportartrigger);
            this.groupBox1.Controls.Add(this.exportarvista);
            this.groupBox1.Controls.Add(this.exportarprocedimiento);
            this.groupBox1.Controls.Add(this.exportarfuncion);
            this.groupBox1.Controls.Add(this.exportarextructura);
            this.groupBox1.Controls.Add(this.checkagregarbd);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(361, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 653);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de exportar";
            // 
            // encriptararchivo
            // 
            this.encriptararchivo.AutoSize = true;
            this.encriptararchivo.Location = new System.Drawing.Point(6, 236);
            this.encriptararchivo.Name = "encriptararchivo";
            this.encriptararchivo.Size = new System.Drawing.Size(137, 21);
            this.encriptararchivo.TabIndex = 22;
            this.encriptararchivo.Text = "Encriptar archivo";
            this.encriptararchivo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton8);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton7);
            this.panel1.Controls.Add(this.radioButton6);
            this.panel1.Location = new System.Drawing.Point(6, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 169);
            this.panel1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(355, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Seleccione el tipo de exportación de renglón a realizar.";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(3, 34);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(77, 21);
            this.radioButton4.TabIndex = 14;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Insertar";
            this.toolTip1.SetToolTip(this.radioButton4, "Recomendado para exportar a\r\nuna base de datos nueva o vacia.\r\nSi encuentra llave" +
        " primaria duplicada\r\nse detiene.");
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(3, 142);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(91, 21);
            this.radioButton8.TabIndex = 18;
            this.radioButton8.Text = "Actualizar";
            this.toolTip1.SetToolTip(this.radioButton8, "Si la llave primaria no existe, se\r\nomite, de lo contrario se actualiza.");
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(3, 61);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(145, 21);
            this.radioButton5.TabIndex = 15;
            this.radioButton5.Text = "Insertar ignorando";
            this.toolTip1.SetToolTip(this.radioButton5, "Si la llave primaria existe, la omite");
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(3, 115);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(163, 21);
            this.radioButton7.TabIndex = 17;
            this.radioButton7.Text = "Actualizar duplicados";
            this.toolTip1.SetToolTip(this.radioButton7, "Si la llave primaria existe, actualiza la fila.");
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(3, 88);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(92, 21);
            this.radioButton6.TabIndex = 16;
            this.radioButton6.Text = "Remplazo";
            this.toolTip1.SetToolTip(this.radioButton6, "Si la llave primaria existe, elimina la fila\r\ne inserta nuevos datos.");
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // exportarrenglon
            // 
            this.exportarrenglon.AutoSize = true;
            this.exportarrenglon.Checked = true;
            this.exportarrenglon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exportarrenglon.Location = new System.Drawing.Point(6, 209);
            this.exportarrenglon.Name = "exportarrenglon";
            this.exportarrenglon.Size = new System.Drawing.Size(155, 21);
            this.exportarrenglon.TabIndex = 13;
            this.exportarrenglon.Text = "Exportar Renglones";
            this.exportarrenglon.UseVisualStyleBackColor = true;
            this.exportarrenglon.CheckedChanged += new System.EventHandler(this.exportarrenglon_CheckedChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Enabled = false;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(7, 482);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ScrollAlwaysVisible = true;
            this.checkedListBox1.Size = new System.Drawing.Size(489, 157);
            this.checkedListBox1.TabIndex = 12;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(313, 455);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(183, 21);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.Text = "No exportar estas tablas";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(145, 455);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(162, 21);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.Text = "Exportar estas tablas";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 455);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(133, 21);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Todas las tablas";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Seleccione si desea exportar algunas tablas";
            // 
            // exportarevento
            // 
            this.exportarevento.AutoSize = true;
            this.exportarevento.Checked = true;
            this.exportarevento.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exportarevento.Location = new System.Drawing.Point(6, 182);
            this.exportarevento.Name = "exportarevento";
            this.exportarevento.Size = new System.Drawing.Size(138, 21);
            this.exportarevento.TabIndex = 7;
            this.exportarevento.Text = "Exportar Eventos";
            this.exportarevento.UseVisualStyleBackColor = true;
            // 
            // exportartrigger
            // 
            this.exportartrigger.AutoSize = true;
            this.exportartrigger.Checked = true;
            this.exportartrigger.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exportartrigger.Location = new System.Drawing.Point(6, 128);
            this.exportartrigger.Name = "exportartrigger";
            this.exportartrigger.Size = new System.Drawing.Size(135, 21);
            this.exportartrigger.TabIndex = 5;
            this.exportartrigger.Text = "Exportar triggers";
            this.exportartrigger.UseVisualStyleBackColor = true;
            // 
            // exportarvista
            // 
            this.exportarvista.AutoSize = true;
            this.exportarvista.Checked = true;
            this.exportarvista.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exportarvista.Location = new System.Drawing.Point(6, 155);
            this.exportarvista.Name = "exportarvista";
            this.exportarvista.Size = new System.Drawing.Size(123, 21);
            this.exportarvista.TabIndex = 4;
            this.exportarvista.Text = "Exportar vistas";
            this.exportarvista.UseVisualStyleBackColor = true;
            // 
            // exportarprocedimiento
            // 
            this.exportarprocedimiento.AutoSize = true;
            this.exportarprocedimiento.Checked = true;
            this.exportarprocedimiento.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exportarprocedimiento.Location = new System.Drawing.Point(6, 74);
            this.exportarprocedimiento.Name = "exportarprocedimiento";
            this.exportarprocedimiento.Size = new System.Drawing.Size(183, 21);
            this.exportarprocedimiento.TabIndex = 3;
            this.exportarprocedimiento.Text = "Exportar procedimientos";
            this.exportarprocedimiento.UseVisualStyleBackColor = true;
            // 
            // exportarfuncion
            // 
            this.exportarfuncion.AutoSize = true;
            this.exportarfuncion.Checked = true;
            this.exportarfuncion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exportarfuncion.Location = new System.Drawing.Point(6, 101);
            this.exportarfuncion.Name = "exportarfuncion";
            this.exportarfuncion.Size = new System.Drawing.Size(148, 21);
            this.exportarfuncion.TabIndex = 2;
            this.exportarfuncion.Text = "Exportar funciones";
            this.exportarfuncion.UseVisualStyleBackColor = true;
            // 
            // exportarextructura
            // 
            this.exportarextructura.AutoSize = true;
            this.exportarextructura.Checked = true;
            this.exportarextructura.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exportarextructura.Location = new System.Drawing.Point(6, 47);
            this.exportarextructura.Name = "exportarextructura";
            this.exportarextructura.Size = new System.Drawing.Size(206, 21);
            this.exportarextructura.TabIndex = 1;
            this.exportarextructura.Text = "Exportar estructura de tabla";
            this.exportarextructura.UseVisualStyleBackColor = true;
            // 
            // checkagregarbd
            // 
            this.checkagregarbd.AutoSize = true;
            this.checkagregarbd.Location = new System.Drawing.Point(6, 20);
            this.checkagregarbd.Name = "checkagregarbd";
            this.checkagregarbd.Size = new System.Drawing.Size(212, 21);
            this.checkagregarbd.TabIndex = 0;
            this.checkagregarbd.Text = "Agregar crear base de datos";
            this.checkagregarbd.UseVisualStyleBackColor = true;
            // 
            // backupparcial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 674);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
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
            this.Name = "backupparcial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup Parciales/Especificos";
            ((System.ComponentModel.ISupportInitialize)(this.numpuerto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox exportarevento;
        private System.Windows.Forms.CheckBox exportartrigger;
        private System.Windows.Forms.CheckBox exportarvista;
        private System.Windows.Forms.CheckBox exportarprocedimiento;
        private System.Windows.Forms.CheckBox exportarfuncion;
        private System.Windows.Forms.CheckBox exportarextructura;
        private System.Windows.Forms.CheckBox checkagregarbd;
        private System.Windows.Forms.CheckBox exportarrenglon;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox encriptararchivo;
    }
}