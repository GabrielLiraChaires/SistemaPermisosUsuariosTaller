using System;
using System.Windows.Forms;
using LogicaNegocio.PermisosUsuariosTaller;
using Entidades.PermisosUsuariosTaller;
namespace SistemaPermisosUsuariosTaller
{
    public partial class FrmUsuarios : Form
    {
        ManejadorUsuarios mu;
        public static Usuario usuario = new Usuario(0,"","","","","","");
        int columna = 0, fila = 0;
        public static int idmodificador = 0;
        public FrmUsuarios()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            usuario.idusuario = -1;
            FrmUsuariosAdd u = new FrmUsuariosAdd();
            u.Show();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usuario.idusuario=Convert.ToInt32( dgvUsuarios.Rows[fila].Cells[0].Value);
            usuario.NombreUsuario = dgvUsuarios.Rows[fila].Cells[1].Value.ToString();
            usuario.ApellidoPUsuario = dgvUsuarios.Rows[fila].Cells[2].Value.ToString();
            usuario.ApellidoMUsuario = dgvUsuarios.Rows[fila].Cells[3].Value.ToString();
            usuario.FechaNac= dgvUsuarios.Rows[fila].Cells[4].Value.ToString();
            usuario.RFC= dgvUsuarios.Rows[fila].Cells[5].Value.ToString();
            usuario.Password= dgvUsuarios.Rows[fila].Cells[6].Value.ToString();
            switch (columna)
            {
                case 7:
                    {
                        usuario.idusuario = 1;
                        idmodificador= Convert.ToInt32(dgvUsuarios.Rows[fila].Cells[0].Value);
                        FrmUsuariosAdd ja = new FrmUsuariosAdd();
                        ja.Show();
                        txtBuscar.Text = "-1";
                        txtBuscar.Clear();
                        Actualizar();
                    }
                    break;
                case 8:
                    {
                        mu.Borrar(usuario);
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
            }
        }

        private void dgvUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("¿Quiere cargar los registros actualmente existentes en la base de datos?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Actualizar();
            }
        }

        public void Actualizar()
        {
            mu.Mostrar(dgvUsuarios, txtBuscar.Text);
        }
        
    }
}
