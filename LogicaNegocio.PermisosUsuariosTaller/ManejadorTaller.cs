using Crud;
using AccesoDatos.PermisosUsuariosTaller;
using System.Windows.Forms;
using System.Drawing;
using System;
using Entidades.PermisosUsuariosTaller;
using System.IO;
namespace LogicaNegocio.PermisosUsuariosTaller
{
    public class ManejadorTaller
    {
        AccesoTaller at = new AccesoTaller();
        Grafico g = new Grafico();

        public void Guardar(dynamic Entidad)
        {
            at.Guardar(Entidad);
            g.Mensaje("Herramienta Guardada", "¡ATENCIÓN!", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = at.Mostrar(filtro).Tables["herramientas"];
            tabla.Columns.Insert(5, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(6, g.Boton("Borrar", Color.Red));
            tabla.AutoResizeColumns();
            tabla.Columns[0].Visible = false;
        }

        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(string.Format("¿Está seguro de borrar a la herramienta?"), "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                at.Borrar(Entidad);
            }
        }
    }
}
