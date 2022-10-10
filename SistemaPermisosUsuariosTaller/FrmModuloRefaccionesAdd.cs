using System;
using System.Windows.Forms;
using Entidades.PermisosUsuariosTaller;
using LogicaNegocio.PermisosUsuariosTaller;
namespace SistemaPermisosUsuariosTaller
{
    public partial class FrmModuloRefaccionesAdd : Form
    {
        ManejadorRefacciones mr;
        public FrmModuloRefaccionesAdd()
        {
            InitializeComponent();
            mr = new ManejadorRefacciones();
            if (FrmModuloRefacciones.refaccion.Opcion > 0)
            {
                txtCodigoBarras.Text = FrmModuloRefacciones.refaccion.CodigoBarras.ToString();
                txtNombre.Text = FrmModuloRefacciones.refaccion.Nombre.ToString();
                txtDescripcion.Text = FrmModuloRefacciones.refaccion.Descripcion;
                txtMarca.Text = FrmModuloRefacciones.refaccion.Marca.ToString();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmModuloRefacciones.refaccion.Opcion != -1)
            {
                mr.Guardar(new Refaccion(txtCodigoBarras.Text,txtNombre.Text,txtDescripcion.Text,txtMarca.Text, FrmModuloRefacciones.refaccion.Opcion));
                Close();
            }
            else if (FrmModuloRefacciones.refaccion.Opcion == -1)
            {
                mr.Guardar(new Refaccion(txtCodigoBarras.Text, txtNombre.Text, txtDescripcion.Text, txtMarca.Text, FrmModuloRefacciones.refaccion.Opcion));
                Close();
            }
        }
    }
}
