using System;
namespace Entidades.PermisosUsuariosTaller
{
    public class Permisos
    {
        public Permisos(int idAsignacion, int fkidusuario, string modulo, bool permisoLectura, bool permisoEscritura, bool permisoEliminacion, bool permisoActualizacion)
        {
            IdAsignacion = idAsignacion;
            Fkidusuario = fkidusuario;
            Modulo = modulo;
            PermisoLectura = permisoLectura;
            PermisoEscritura = permisoEscritura;
            PermisoEliminacion = permisoEliminacion;
            PermisoActualizacion = permisoActualizacion;
        }

        public int IdAsignacion { get; set; }
        public int Fkidusuario { get; set; }
        public string Modulo { get; set; }
        public bool PermisoLectura { get; set; }
        public bool PermisoEscritura { get; set; }
        public bool PermisoEliminacion { get; set; }
        public bool PermisoActualizacion { get; set; }
    }
}
