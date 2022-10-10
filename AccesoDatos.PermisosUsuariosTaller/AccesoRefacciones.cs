using System;
using System.Data;
using ConectarBd;
namespace AccesoDatos.PermisosUsuariosTaller
{
    public class AccesoRefacciones : IEntidades
    {
        Base b = new Base("localhost", "root", "", "PermisosTaller");
        public void Borrar(dynamic Entidad)
        {
            b.Comando(String.Format("call DeleteProductos('{0}')", Entidad.CodigoBarras));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(String.Format("call InsertOrUpdateProductos('{0}','{1}','{2}','{3}',{4})", Entidad.CodigoBarras,Entidad.Nombre,Entidad.Descripcion,Entidad.Marca,Entidad.Opcion));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call ShowProductos('%{0}%')", filtro), "productos");
        }
    }
}
