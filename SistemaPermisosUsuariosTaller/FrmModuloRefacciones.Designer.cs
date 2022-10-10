namespace SistemaPermisosUsuariosTaller
{
    partial class FrmModuloRefacciones
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
            this.dgvRefacciones = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefacciones)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRefacciones
            // 
            this.dgvRefacciones.AllowUserToAddRows = false;
            this.dgvRefacciones.AllowUserToDeleteRows = false;
            this.dgvRefacciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvRefacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefacciones.Location = new System.Drawing.Point(14, 103);
            this.dgvRefacciones.Name = "dgvRefacciones";
            this.dgvRefacciones.ReadOnly = true;
            this.dgvRefacciones.Size = new System.Drawing.Size(679, 297);
            this.dgvRefacciones.TabIndex = 23;
            this.dgvRefacciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRefacciones_CellClick);
            this.dgvRefacciones.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRefacciones_CellEnter);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::SistemaPermisosUsuariosTaller.Properties.Resources.icons8_añadir_etiqueta_491;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Location = new System.Drawing.Point(644, 50);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(49, 49);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(232, 57);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(402, 26);
            this.txtBuscar.TabIndex = 21;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "BUSQUEDA POR NOMBRE:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 44);
            this.panel1.TabIndex = 20;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackgroundImage = global::SistemaPermisosUsuariosTaller.Properties.Resources.Cerrar;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.Location = new System.Drawing.Point(657, 3);
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
            this.label1.Location = new System.Drawing.Point(211, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÓDULO DE REFACCIONES";
            // 
            // FrmModuloRefacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 414);
            this.Controls.Add(this.dgvRefacciones);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmModuloRefacciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModuloRefacciones";
            this.Load += new System.EventHandler(this.FrmModuloRefacciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefacciones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRefacciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label1;
    }
}