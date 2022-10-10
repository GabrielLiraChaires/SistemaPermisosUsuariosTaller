using System;
using System.Data;
namespace AccesoDatos.PermisosUsuariosTaller
{
    internal interface InterfazPermisos
    {
        DataSet ValidacionPermisos(string usuario, string clave, string modulo);
        void Guardar(dynamic Entidad);
        void Borrar(dynamic Entidad);
        DataSet Mostrar(string filtro);
    }
}
