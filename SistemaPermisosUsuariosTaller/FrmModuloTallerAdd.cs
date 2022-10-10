using System;
using System.Windows.Forms;
using Entidades.PermisosUsuariosTaller;
using LogicaNegocio.PermisosUsuariosTaller;
namespace SistemaPermisosUsuariosTaller
{
    public partial class FrmModuloTallerAdd : Form
    {
        ManejadorTaller mt;
        public FrmModuloTallerAdd()
        {
            InitializeComponent();
            mt = new ManejadorTaller();
            if (FrmModuloTaller.taller.CodigoHerramienta > 0)
            {
                txtNombre.Text = FrmModuloTaller.taller.Nombre.ToString();
                txtMedida.Text = FrmModuloTaller.taller.Medida.ToString();
                txtMarca.Text = FrmModuloTaller.taller.Marca.ToString();
                txtDescripcion.Text = FrmModuloTaller.taller.Descripcion.ToString();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmModuloTaller.taller.CodigoHerramienta != -1)
            {
                mt.Guardar(new Taller(FrmModuloTaller.idmodificador, txtNombre.Text, Convert.ToDouble(txtMedida.Text), txtMarca.Text, txtDescripcion.Text));
                Close();
            }
            else if (FrmModuloTaller.taller.CodigoHerramienta == -1)
            {
                mt.Guardar(new Taller(FrmModuloTaller.taller.CodigoHerramienta,txtNombre.Text,Convert.ToDouble(txtMedida.Text),txtMarca.Text,txtDescripcion.Text));
                Close();
            }
        }
    }
}
