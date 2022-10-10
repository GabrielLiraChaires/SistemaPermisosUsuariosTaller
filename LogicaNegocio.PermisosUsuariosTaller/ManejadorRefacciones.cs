using Crud;
using AccesoDatos.PermisosUsuariosTaller;
using System.Windows.Forms;
using System.Drawing;
using System;
using Entidades.PermisosUsuariosTaller;
using System.IO;
namespace LogicaNegocio.PermisosUsuariosTaller
{
    public class ManejadorRefacciones
    {
        AccesoRefacciones ar = new AccesoRefacciones();
        Grafico g = new Grafico();

        public void Guardar(dynamic Entidad)
        {
            ar.Guardar(Entidad);
            g.Mensaje("Refacción Guardada", "¡ATENCIÓN!", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = ar.Mostrar(filtro).Tables["productos"];
            tabla.Columns.Insert(4, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(5, g.Boton("Borrar", Color.Red));
            tabla.AutoResizeColumns();
            tabla.Columns[0].Visible = false;
        }
    }
}
