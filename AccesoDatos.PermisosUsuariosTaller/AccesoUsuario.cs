using System;
using System.Data;
using ConectarBd;
namespace AccesoDatos.PermisosUsuariosTaller
{
    public class AccesoUsuario : InterfazUsuarios
    {
        Base b = new Base("localhost", "root", "", "PermisosTaller");

        public DataSet Comprobar(string usuario, string clave)
        {
            return b.Obtener(String.Format("SELECT COUNT(*) as EXISTE from usuarios where nombre='{0}' AND contrasena='{1}'", usuario, clave),"usuarios");
        }
        
    }
}
