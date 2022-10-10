using System;
using System.Windows.Forms;
using LogicaNegocio.PermisosUsuariosTaller;
using Entidades.PermisosUsuariosTaller;
namespace SistemaPermisosUsuariosTaller
{
    public partial class FrmModuloRefacciones : Form
    {
        ManejadorRefacciones mr;
        ManejadorPermisos mp;
        public static Refaccion refaccion = new Refaccion("","","","",0);
        int columna = 0, fila = 0;
        public FrmModuloRefacciones()
        {
            InitializeComponent();
            mp = new ManejadorPermisos();
            mr = new ManejadorRefacciones();    
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            refaccion.Opcion = -1;
            FrmModuloRefaccionesAdd u = new FrmModuloRefaccionesAdd();
            u.Show();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void FrmModuloRefacciones_Load(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("¿Quiere cargar los registros actualmente existentes en la base de datos?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Actualizar();
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MHerramientas) == "Lectura")
            {
                btnAgregar.Visible = false;
                dgvRefacciones.Columns[4].Visible = false;
                dgvRefacciones.Columns[5].Visible = false;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MHerramientas) == "Escritura")
            {
                btnAgregar.Visible = true;
                dgvRefacciones.Columns[4].Visible = false;
                dgvRefacciones.Columns[5].Visible = false;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MHerramientas) == "Eliminacion" || mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MHerramientas) == "LecturaEliminacion")
            {
                btnAgregar.Visible = false;
                dgvRefacciones.Columns[4].Visible = false;
                dgvRefacciones.Columns[5].Visible = true;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MHerramientas) == "Modificacion")
            {
                btnAgregar.Visible = false;
                dgvRefacciones.Columns[4].Visible = true;
                dgvRefacciones.Columns[5].Visible = false;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MHerramientas) == "LecturaEscritura")
            {
                btnAgregar.Visible = true;
                dgvRefacciones.Columns[4].Visible = false;
                dgvRefacciones.Columns[5].Visible = false;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MHerramientas) == "LecturaEscrituraEliminacion" || mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MHerramientas) == "EscrituraEliminacion")
            {
                btnAgregar.Visible = true;
                dgvRefacciones.Columns[4].Visible = false;
                dgvRefacciones.Columns[5].Visible = true;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MHerramientas) == "EscrituraModificacion")
            {
                btnAgregar.Visible = true;
                dgvRefacciones.Columns[4].Visible = true;
                dgvRefacciones.Columns[5].Visible = false;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MHerramientas) == "EliminacionModificacion")
            {
                btnAgregar.Visible = false;
                dgvRefacciones.Columns[4].Visible = true;
                dgvRefacciones.Columns[5].Visible = true;
            }
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MHerramientas) == "EscrituraEliminacionModificacion" || mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MHerramientas) == "LecturaModificacion")
            {
                btnAgregar.Visible = true;
                dgvRefacciones.Columns[4].Visible = true;
                dgvRefacciones.Columns[5].Visible = true;
            }
        }

        private void dgvRefacciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            refaccion.CodigoBarras = dgvRefacciones.Rows[fila].Cells[0].Value.ToString();
            refaccion.Nombre= dgvRefacciones.Rows[fila].Cells[1].Value.ToString();
            refaccion.Descripcion=dgvRefacciones.Rows[fila].Cells[2].Value.ToString();
            refaccion.Marca= dgvRefacciones.Rows[fila].Cells[3].Value.ToString();
            switch (columna)
            {
                case 4:
                    {
                        refaccion.Opcion = 1;
                        FrmModuloRefaccionesAdd ja = new FrmModuloRefaccionesAdd();
                        ja.Show();
                        txtBuscar.Text = "-1";
                        txtBuscar.Clear();
                        Actualizar();
                    }
                    break;
                case 5:
                    {
                        /*mr.Borrar(usuario);
                        txtBuscar.Text = "";
                        Actualizar();*/
                    }
                    break;
            }
        }

        private void dgvRefacciones_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        public void Actualizar()
        {
            mr.Mostrar(dgvRefacciones, txtBuscar.Text);
        }
    }
}
