namespace SistemaPermisosUsuariosTaller
{
    partial class FrmPermisosAdd
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLectura = new System.Windows.Forms.ComboBox();
            this.cmbEscritura = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEliminacion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbModificacion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbModulo = new System.Windows.Forms.ComboBox();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Permiso de lectura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Modulo:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::SistemaPermisosUsuariosTaller.Properties.Resources.PermisosGuardar;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(406, 142);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(64, 65);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Usuario:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 44);
            this.panel1.TabIndex = 39;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackgroundImage = global::SistemaPermisosUsuariosTaller.Properties.Resources.Cerrar;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.Location = new System.Drawing.Point(452, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(36, 38);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "VARIACIONES DE PERMISOS";
            // 
            // cmbLectura
            // 
            this.cmbLectura.FormattingEnabled = true;
            this.cmbLectura.Items.AddRange(new object[] {
            "TRUE",
            "FALSE"});
            this.cmbLectura.Location = new System.Drawing.Point(12, 201);
            this.cmbLectura.Name = "cmbLectura";
            this.cmbLectura.Size = new System.Drawing.Size(140, 28);
            this.cmbLectura.TabIndex = 2;
            // 
            // cmbEscritura
            // 
            this.cmbEscritura.FormattingEnabled = true;
            this.cmbEscritura.Items.AddRange(new object[] {
            "TRUE",
            "FALSE"});
            this.cmbEscritura.Location = new System.Drawing.Point(216, 201);
            this.cmbEscritura.Name = "cmbEscritura";
            this.cmbEscritura.Size = new System.Drawing.Size(140, 28);
            this.cmbEscritura.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Permiso de escritura:";
            // 
            // cmbEliminacion
            // 
            this.cmbEliminacion.FormattingEnabled = true;
            this.cmbEliminacion.Items.AddRange(new object[] {
            "TRUE",
            "FALSE"});
            this.cmbEliminacion.Location = new System.Drawing.Point(12, 262);
            this.cmbEliminacion.Name = "cmbEliminacion";
            this.cmbEliminacion.Size = new System.Drawing.Size(140, 28);
            this.cmbEliminacion.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Permiso de eliminación:";
            // 
            // cmbModificacion
            // 
            this.cmbModificacion.FormattingEnabled = true;
            this.cmbModificacion.Items.AddRange(new object[] {
            "TRUE",
            "FALSE"});
            this.cmbModificacion.Location = new System.Drawing.Point(216, 262);
            this.cmbModificacion.Name = "cmbModificacion";
            this.cmbModificacion.Size = new System.Drawing.Size(140, 28);
            this.cmbModificacion.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Permiso de modificación:";
            // 
            // cmbModulo
            // 
            this.cmbModulo.FormattingEnabled = true;
            this.cmbModulo.Items.AddRange(new object[] {
            "Refacciones",
            "Taller"});
            this.cmbModulo.Location = new System.Drawing.Point(12, 142);
            this.cmbModulo.Name = "cmbModulo";
            this.cmbModulo.Size = new System.Drawing.Size(344, 28);
            this.cmbModulo.TabIndex = 1;
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(12, 88);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(344, 28);
            this.cmbUsuarios.TabIndex = 0;
            // 
            // FrmPermisosAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 309);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.cmbModulo);
            this.Controls.Add(this.cmbModificacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbEliminacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbEscritura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbLectura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPermisosAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPermisosAdd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLectura;
        private System.Windows.Forms.ComboBox cmbEscritura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEliminacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbModificacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbModulo;
        private System.Windows.Forms.ComboBox cmbUsuarios;
    }
}