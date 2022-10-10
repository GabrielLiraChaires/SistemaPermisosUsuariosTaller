namespace SistemaPermisosUsuariosTaller
{
    partial class FrmMenu
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnUsuarios = new System.Windows.Forms.ToolStripButton();
            this.btnPermisos = new System.Windows.Forms.ToolStripButton();
            this.btnRefacciones = new System.Windows.Forms.ToolStripButton();
            this.btnTaller = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUsuarios,
            this.btnPermisos,
            this.btnRefacciones,
            this.btnTaller,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(51, 450);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.AutoSize = false;
            this.btnUsuarios.BackgroundImage = global::SistemaPermisosUsuariosTaller.Properties.Resources.icons8_seleccionar_usuarios_50;
            this.btnUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(50, 50);
            this.btnUsuarios.Text = "AGREGAR USUARIOS";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnPermisos
            // 
            this.btnPermisos.AutoSize = false;
            this.btnPermisos.BackgroundImage = global::SistemaPermisosUsuariosTaller.Properties.Resources.PermisosP;
            this.btnPermisos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPermisos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPermisos.Name = "btnPermisos";
            this.btnPermisos.Size = new System.Drawing.Size(50, 50);
            this.btnPermisos.Text = "ASIGNACIÓN DE PERMISOS A LOS USUARIOS";
            this.btnPermisos.Click += new System.EventHandler(this.btnPermisos_Click);
            // 
            // btnRefacciones
            // 
            this.btnRefacciones.AutoSize = false;
            this.btnRefacciones.BackgroundImage = global::SistemaPermisosUsuariosTaller.Properties.Resources.PermisosRefacciones;
            this.btnRefacciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefacciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefacciones.Name = "btnRefacciones";
            this.btnRefacciones.Size = new System.Drawing.Size(50, 50);
            this.btnRefacciones.Text = "MÓDULO DE REFACCIONES";
            this.btnRefacciones.Click += new System.EventHandler(this.btnRefacciones_Click);
            // 
            // btnTaller
            // 
            this.btnTaller.AutoSize = false;
            this.btnTaller.BackgroundImage = global::SistemaPermisosUsuariosTaller.Properties.Resources.PermisosTaller;
            this.btnTaller.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTaller.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTaller.Name = "btnTaller";
            this.btnTaller.Size = new System.Drawing.Size(50, 50);
            this.btnTaller.Text = "MÓDULO DE TALLER";
            this.btnTaller.Click += new System.EventHandler(this.btnTaller_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = false;
            this.btnSalir.BackgroundImage = global::SistemaPermisosUsuariosTaller.Properties.Resources.PermisosSalir;
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 50);
            this.btnSalir.Text = "SALIR DEL SISTEMA";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENÚ PRINCIPAL";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnUsuarios;
        private System.Windows.Forms.ToolStripButton btnPermisos;
        private System.Windows.Forms.ToolStripButton btnRefacciones;
        private System.Windows.Forms.ToolStripButton btnTaller;
        private System.Windows.Forms.ToolStripButton btnSalir;
    }
}