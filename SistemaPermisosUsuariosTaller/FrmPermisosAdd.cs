using System;
using System.Windows.Forms;
using Entidades.PermisosUsuariosTaller;
using LogicaNegocio.PermisosUsuariosTaller;
namespace SistemaPermisosUsuariosTaller
{
    public partial class FrmPermisosAdd : Form
    {
        ManejadorPermisos mp;
        public FrmPermisosAdd()
        {
            InitializeComponent();
            mp = new ManejadorPermisos();
            mp.ExtraerUsuarioAPermisos(cmbUsuarios);
            if (FrmPermisos.permiso.IdAsignacion > 0)
            {
                cmbUsuarios.Text=FrmPermisos.nombreu.ToString();
                cmbModulo.Text = FrmPermisos.permiso.Modulo.ToString();
                cmbModulo.Enabled = false;
                cmbLectura.Text = FrmPermisos.permiso.PermisoLectura.ToString();
                cmbEscritura.Text = FrmPermisos.permiso.PermisoEscritura.ToString();
                cmbEliminacion.Text = FrmPermisos.permiso.PermisoEliminacion.ToString();
                cmbModificacion.Text= FrmPermisos.permiso.PermisoActualizacion.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmPermisos.permiso.IdAsignacion != -1)
            {
                mp.Guardar(new Permisos(FrmPermisos.idmodificador, int.Parse(cmbUsuarios.SelectedValue.ToString()), cmbModulo.Text, bool.Parse(cmbLectura.Text), bool.Parse(cmbEscritura.Text), bool.Parse(cmbEliminacion.Text), bool.Parse(cmbModificacion.Text)));
                Close();
            }
            else if (FrmPermisos.permiso.IdAsignacion == -1)
            {
                mp.Guardar(new Permisos(FrmPermisos.permiso.IdAsignacion, int.Parse(cmbUsuarios.SelectedValue.ToString()),cmbModulo.Text,bool.Parse(cmbLectura.Text), bool.Parse(cmbEscritura.Text), bool.Parse(cmbEliminacion.Text), bool.Parse(cmbModificacion.Text)));
                Close();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
