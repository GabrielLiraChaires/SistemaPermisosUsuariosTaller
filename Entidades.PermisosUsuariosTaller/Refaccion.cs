namespace Entidades.PermisosUsuariosTaller
{
    public class Refaccion
    {
        public Refaccion(string codigoBarras, string nombre, string descripcion, string marca, int opcion)
        {
            CodigoBarras = codigoBarras;
            Nombre = nombre;
            Descripcion = descripcion;
            Marca = marca;
            Opcion = opcion;
        }

        public string CodigoBarras { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public int Opcion { get; set; }
    }
}
