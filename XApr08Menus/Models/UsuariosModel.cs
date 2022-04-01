namespace XApr08Menus.Models
{
    public class UsuariosModel
    {

        public int ID { set; get; } = 0;
        public string Nombre { set; get; }
        public string Usuario { set; get; }
        public int Tipo { set; get; }

        public UsuariosModel(string nombre, string usuario, int tipo)
        {
            Nombre = nombre;
            Usuario = usuario;
            Tipo = tipo;
            UsuariosModelValidator validador = new UsuariosModelValidator(this);
        }

    }
}
