using System;
using System.Windows.Forms;
using Entidades.PermisosUsuariosTaller;
using LogicaNegocio.PermisosUsuariosTaller;
namespace SistemaPermisosUsuariosTaller
{
    public partial class FrmUsuariosAdd : Form
    {
        ManejadorUsuarios mu;
        public static int idusuario=0;
        public static string modulo = "";
        public FrmUsuariosAdd()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
            if (FrmUsuarios.usuario.idusuario > 0)
            {
                txtNombres.Text = FrmUsuarios.usuario.NombreUsuario.ToString();
                txtApellidop.Text= FrmUsuarios.usuario.ApellidoPUsuario.ToString();
                txtApellidom.Text= FrmUsuarios.usuario.ApellidoMUsuario.ToString();
                dtpNacimiento.Text= FrmUsuarios.usuario.FechaNac.ToString();
                txtRFC.Text= FrmUsuarios.usuario.RFC.ToString();
                txtContrasena.Text= FrmUsuarios.usuario.Password.ToString();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmUsuarios.usuario.idusuario != -1)
            {
               mu.Guardar(new Usuario(FrmUsuarios.idmodificador,txtNombres.Text,txtApellidop.Text,txtApellidom.Text,dtpNacimiento.Text,txtRFC.Text,txtContrasena.Text));
               Close();
            }
            else if (FrmUsuarios.usuario.idusuario == -1)
            {
               mu.Guardar(new Usuario(FrmUsuarios.usuario.idusuario, txtNombres.Text, txtApellidop.Text, txtApellidom.Text, dtpNacimiento.Text, txtRFC.Text, txtContrasena.Text));
               Close();
            }
            DialogResult rs = MessageBox.Show("¿Decea asignar los permisos para este usuario en este momento?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                FrmPermisos p = new FrmPermisos();
                p.ShowDialog();
            }
        }
    }
}
