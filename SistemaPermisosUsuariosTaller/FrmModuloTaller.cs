using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio.PermisosUsuariosTaller;
namespace SistemaPermisosUsuariosTaller
{
    public partial class FrmModuloTaller : Form
    {
        ManejadorPermisos mp;
        public FrmModuloTaller()
        {
            InitializeComponent();
            mp = new ManejadorPermisos();
        }

        private void FrmModuloTaller_Load(object sender, EventArgs e)
        {
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MTaller) == "Lectura")
            {
                btnAgregar.Enabled = false;
                dgvTaller.Columns[5].Visible = false;
                dgvTaller.Columns[6].Visible = false;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MTaller) == "Escritura")
            {
                btnAgregar.Enabled = true;
                dgvTaller.Columns[5].Visible = false;
                dgvTaller.Columns[6].Visible = false;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MTaller) == "Eliminacion" || mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MTaller) == "LecturaEliminacion")
            {
                btnAgregar.Enabled = false;
                dgvTaller.Columns[5].Visible = false;
                dgvTaller.Columns[6].Visible = true;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MTaller) == "Modificacion")
            {
                btnAgregar.Enabled = false;
                dgvTaller.Columns[5].Visible = true;
                dgvTaller.Columns[6].Visible = false;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MTaller) == "LecturaEscritura")
            {
                btnAgregar.Enabled = true;
                dgvTaller.Columns[5].Visible = false;
                dgvTaller.Columns[6].Visible = false;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MTaller) == "LecturaEscrituraEliminacion" || mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MTaller) == "EscrituraEliminacion")
            {
                btnAgregar.Enabled = true;
                dgvTaller.Columns[5].Visible = false;
                dgvTaller.Columns[6].Visible = true;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MTaller) == "EscrituraModificacion")
            {
                btnAgregar.Enabled = true;
                dgvTaller.Columns[5].Visible = true;
                dgvTaller.Columns[6].Visible = false;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MTaller) == "EliminacionModificacion")
            {
                btnAgregar.Enabled = false;
                dgvTaller.Columns[5].Visible = true;
                dgvTaller.Columns[6].Visible = true;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MTaller) == "EscrituraEliminacionModificacion" || mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MTaller) == "LecturaModificacion")
            {
                btnAgregar.Enabled = true;
                dgvTaller.Columns[5].Visible = true;
                dgvTaller.Columns[6].Visible = true;
            }
        }
    }
}
