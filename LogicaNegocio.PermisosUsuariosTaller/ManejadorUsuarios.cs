using Crud;
using AccesoDatos.PermisosUsuariosTaller;
using System.Windows.Forms;
using System.Drawing;
using System;
using Entidades.PermisosUsuariosTaller;
using System.IO;
namespace LogicaNegocio.PermisosUsuariosTaller
{
    public class ManejadorUsuarios
    {
        AccesoUsuario au = new AccesoUsuario();
        Grafico g = new Grafico();

        public bool Comprobar(string usuario, string clave)
        {
            int c =  Convert.ToInt32( au.Comprobar(usuario, clave).Tables[0].Rows[0]["EXISTE"]);
            if (c==1)
            {
                return true;
            } 
            else
            {
                return false;
            }  
        }
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(string.Format("Está seguro de borrar al usuario con NOMBRE: '{0}'", Entidad.NombreUsuario), "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                au.Borrar(Entidad);
            }
        }

        public void Guardar(dynamic Entidad)
        {
            au.Guardar(Entidad);
            g.Mensaje("Usuario Guardado", "¡ATENCIÓN!", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = au.Mostrar(filtro).Tables["usuarios"];
            tabla.Columns.Insert(7, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(8, g.Boton("Borrar", Color.Red));
            tabla.AutoResizeColumns();
            tabla.Columns[0].Visible = false;
        }
    }
}
