using System;
using System.Windows.Forms;
using LogicaNegocio.PermisosUsuariosTaller;
namespace SistemaPermisosUsuariosTaller
{
    public partial class FrmLogin : Form
    {
        ManejadorUsuarios mu;
        ManejadorPermisos mp;
        public static string MHerramientas = "Refacciones";
        public static string MTaller = "Taller";
        public static string usuario = "";
        public static string clave = "";
        public FrmLogin()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
            mp = new ManejadorPermisos();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            usuario = txtUsuario.Text;clave=txtContrasena.Text;
            if (mu.Comprobar(txtUsuario.Text, txtContrasena.Text) == true)
            {
                if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, MHerramientas) == "Ninguno" && mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, MTaller) == "Ninguno")
                {
                    MessageBox.Show("Lo sentimos, no puedes acceder al sistema por la asignación de tus permisos.", "¡FALTA DE PERMISOS!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    FrmMenu m = new FrmMenu();
                    m.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta, verifica tus datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
