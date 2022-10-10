using System;
using System.Data;
namespace AccesoDatos.PermisosUsuariosTaller
{
    internal interface InterfazUsuarios
    {
        DataSet Comprobar(string usuario, string clave);
        void Guardar(dynamic Entidad);
        void Borrar(dynamic Entidad);
        DataSet Mostrar(string filtro);
    }
}
