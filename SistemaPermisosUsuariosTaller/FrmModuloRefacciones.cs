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
    public partial class FrmModuloRefacciones : Form
    {
        ManejadorPermisos mp;
        public FrmModuloRefacciones()
        {
            InitializeComponent();
            mp = new ManejadorPermisos();
        }

        private void FrmModuloRefacciones_Load(object sender, EventArgs e)
        {
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MHerramientas) == "Lectura")
            {
                btnAgregar.Enabled = false;
                dgvRefacciones.Columns[4].Visible = false;
                dgvRefacciones.Columns[5].Visible = false;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MHerramientas) == "Escritura")
            {
                btnAgregar.Enabled = true;
                dgvRefacciones.Columns[4].Visible = false;
                dgvRefacciones.Columns[5].Visible = false;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MHerramientas) == "Eliminacion" || mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MHerramientas) == "LecturaEliminacion")
            {
                btnAgregar.Enabled = false;
                dgvRefacciones.Columns[4].Visible = false;
                dgvRefacciones.Columns[5].Visible = true;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MHerramientas) == "Modificacion")
            {
                btnAgregar.Enabled = false;
                dgvRefacciones.Columns[4].Visible = true;
                dgvRefacciones.Columns[5].Visible = false;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MHerramientas) == "LecturaEscritura")
            {
                btnAgregar.Enabled = true;
                dgvRefacciones.Columns[4].Visible = false;
                dgvRefacciones.Columns[5].Visible = false;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MHerramientas) == "LecturaEscrituraEliminacion" || mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MHerramientas) == "EscrituraEliminacion")
            {
                btnAgregar.Enabled = true;
                dgvRefacciones.Columns[4].Visible = false;
                dgvRefacciones.Columns[5].Visible = true;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MHerramientas) == "EscrituraModificacion")
            {
                btnAgregar.Enabled = true;
                dgvRefacciones.Columns[4].Visible = true;
                dgvRefacciones.Columns[5].Visible = false;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MHerramientas) == "EliminacionModificacion")
            {
                btnAgregar.Enabled = false;
                dgvRefacciones.Columns[4].Visible = true;
                dgvRefacciones.Columns[5].Visible = true;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MHerramientas) == "EscrituraEliminacionModificacion" || mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MHerramientas) == "LecturaModificacion")
            {
                btnAgregar.Enabled = true;
                dgvRefacciones.Columns[4].Visible = true;
                dgvRefacciones.Columns[5].Visible = true;
            }
        }
    }
}
