using System;
using System.Data;
namespace AccesoDatos.PermisosUsuariosTaller
{
    internal interface InterfazUsuarios
    {
        DataSet Comprobar(string usuario, string clave);
    }
}
