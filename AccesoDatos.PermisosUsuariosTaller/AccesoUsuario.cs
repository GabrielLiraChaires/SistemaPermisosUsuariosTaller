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
        public void Borrar(dynamic Entidad)
        {
            b.Comando(String.Format("call DeleteUsuario({0})", Entidad.idusuario));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(String.Format("call InsertOrUpdateUsuario('{0}','{1}','{2}','{3}','{4}','{5}',{6})", Entidad.NombreUsuario, Entidad.ApellidoPUsuario, Entidad.ApellidoMUsuario, Entidad.FechaNac, Entidad.RFC, Entidad.Password, Entidad.idusuario));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call ShowUsuario('%{0}%')", filtro), "usuarios");
        }

    }
}
