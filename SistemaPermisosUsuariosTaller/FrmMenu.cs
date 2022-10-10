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
    public partial class FrmMenu : Form
    {
        ManejadorPermisos mp;
        public FrmMenu()
        {
            InitializeComponent();
            mp = new ManejadorPermisos();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios u = new FrmUsuarios();
            u.ShowDialog();
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            FrmPermisos p = new FrmPermisos();
            p.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MHerramientas) != "Administrador" && mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MTaller) != "Administrador")
            {
                btnUsuarios.Visible = false;
                btnPermisos.Visible = false;
            }
        }

        private void btnRefacciones_Click(object sender, EventArgs e)
        {
            FrmModuloRefacciones r = new FrmModuloRefacciones();
            r.ShowDialog();
        }

        private void btnTaller_Click(object sender, EventArgs e)
        {
            FrmModuloTaller t = new FrmModuloTaller();
            t.ShowDialog();
        }
    }
}
