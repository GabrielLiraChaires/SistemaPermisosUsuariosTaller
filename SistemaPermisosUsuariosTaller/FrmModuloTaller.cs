using System;
using System.Windows.Forms;
using LogicaNegocio.PermisosUsuariosTaller;
using Entidades.PermisosUsuariosTaller;
namespace SistemaPermisosUsuariosTaller
{
    public partial class FrmModuloTaller : Form
    {
        ManejadorPermisos mp;
        ManejadorTaller mt;
        public static Taller taller = new Taller(0,"",3.2,"","");
        int columna = 0, fila = 0;
        public static int idmodificador;
        public FrmModuloTaller()
        {
            InitializeComponent();
            mt = new ManejadorTaller();
            mp = new ManejadorPermisos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
             taller.CodigoHerramienta= -1;
            FrmModuloTallerAdd u = new FrmModuloTallerAdd();
            u.Show();
        }

        private void FrmModuloTaller_Load(object sender, EventArgs e)
        {
            if (mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MTaller) == "Lectura" || mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MTaller) == "LecturaEliminacion" || mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MTaller) == "LecturaEscritura" || mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MTaller) == "LecturaEscrituraEliminacion" || mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MTaller) == "LecturaModificacion" || mp.AsignacionPermisos(FrmLogin.usuario, FrmLogin.clave, FrmLogin.MTaller) == "Administrador")
            {
                DialogResult rs = MessageBox.Show("¿Quiere cargar los registros actualmente existentes en la base de datos?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    Actualizar();
                    Condicionantes();
                }
            }
            else
            {
                MessageBox.Show("No cuentas con los permisos adecuados para acceder al formulario.", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dgvTaller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            taller.CodigoHerramienta= int.Parse(dgvTaller.Rows[fila].Cells[0].Value.ToString());
            taller.Nombre = dgvTaller.Rows[fila].Cells[1].Value.ToString();
            taller.Medida = Convert.ToDouble(dgvTaller.Rows[fila].Cells[2].Value.ToString());
            taller.Marca= dgvTaller.Rows[fila].Cells[3].Value.ToString();
            taller.Descripcion = dgvTaller.Rows[fila].Cells[4].Value.ToString();
            switch (columna)
            {
                case 5:
                    {
                        idmodificador= int.Parse(dgvTaller.Rows[fila].Cells[0].Value.ToString());
                        taller.CodigoHerramienta = 1;
                        FrmModuloTallerAdd ja = new FrmModuloTallerAdd();
                        ja.Show();
                        txtBuscar.Text = "-1";
                        txtBuscar.Clear();
                        Actualizar();
                    }
                    break;
                case 6:
                    {
                        mt.Borrar(taller);
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
            }
        }

        private void dgvTaller_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        public void Actualizar()
        {
            mt.Mostrar(dgvTaller, txtBuscar.Text);
            Condicionantes();   
        }

        public void Condicionantes()
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
