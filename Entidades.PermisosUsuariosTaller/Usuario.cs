using System;
namespace Entidades.PermisosUsuariosTaller
{
    public class Usuario
    {
        public Usuario(int idusuario, string nombreUsuario, string apellidoPUsuario, string apellidoMUsuario, string fechaNac, string rFC, string password)
        {
            this.idusuario = idusuario;
            NombreUsuario = nombreUsuario;
            ApellidoPUsuario = apellidoPUsuario;
            ApellidoMUsuario = apellidoMUsuario;
            FechaNac = fechaNac;
            RFC = rFC;
            Password = password;
        }
        public int idusuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoPUsuario { get; set; }
        public string ApellidoMUsuario { get; set; }
        public string FechaNac { get; set; }
        public string RFC { get; set; }
        public string Password { get; set; }
    }
}
