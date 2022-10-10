using System;
using System.Windows.Forms;
using LogicaNegocio.PermisosUsuariosTaller;
using Entidades.PermisosUsuariosTaller;
namespace SistemaPermisosUsuariosTaller
{
    public partial class FrmPermisos : Form
    {
        ManejadorPermisos mp;
        public static Permisos permiso = new Permisos(0,0,"",true,true,true,true);
        int columna = 0, fila = 0;
        public static int idmodificador = 0;
        public static string nombreu="";
        public FrmPermisos()
        {
            InitializeComponent();
            mp = new ManejadorPermisos();
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dgvPermisos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            permiso.IdAsignacion = int.Parse(dgvPermisos.Rows[fila].Cells[0].Value.ToString());
            nombreu = dgvPermisos.Rows[fila].Cells[1].Value.ToString();
            permiso.Modulo = dgvPermisos.Rows[fila].Cells[2].Value.ToString();
            permiso.PermisoLectura = bool.Parse(dgvPermisos.Rows[fila].Cells[3].Value.ToString());
            permiso.PermisoEscritura = bool.Parse(dgvPermisos.Rows[fila].Cells[4].Value.ToString());
            permiso.PermisoEliminacion = bool.Parse(dgvPermisos.Rows[fila].Cells[5].Value.ToString());
            permiso.PermisoActualizacion = bool.Parse(dgvPermisos.Rows[fila].Cells[6].Value.ToString());
            switch (columna)
            {
                case 7:
                    {
                        permiso.IdAsignacion = 1;
                        idmodificador = int.Parse(dgvPermisos.Rows[fila].Cells[0].Value.ToString());
                        FrmPermisosAdd ja = new FrmPermisosAdd();
                        ja.Show();
                        txtBuscar.Text = "-1";
                        txtBuscar.Clear();
                        Actualizar();
                    }
                    break;
                case 8:
                    {
                        mp.Borrar(permiso);
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
            }
        }

        private void dgvPermisos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void FrmPermisos_Load(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("¿Quiere cargar los registros actualmente existentes en la base de datos?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Actualizar();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            permiso.IdAsignacion = -1;
            FrmPermisosAdd u = new FrmPermisosAdd();
            u.Show();
        }

        public void Actualizar()
        {
            mp.Mostrar(dgvPermisos, txtBuscar.Text);
        }
    }
}
