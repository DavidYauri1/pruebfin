namespace Lab14.Models
{
    public class Usuario
    {
        public string idUsuario { get; set; }
        public string usuario { get; set; }

        public string password { get; set; }

        public string rol {  get; set; }

        public static List<Usuario> DB()
        {
            var list = new List<Usuario>()

            {
                new Usuario
                {
                    idUsuario = "1",
                    usuario = "David",
                    password = "password",
                    rol = "empleado"

                },
                new Usuario
                {
                    idUsuario = "2",
                    usuario = "David2",
                    password = "password",
                    rol = "empleado"

                },
                new Usuario
                {
                    idUsuario = "3",
                    usuario = "David3",
                    password = "password",
                    rol = "assesor"

                },
                new Usuario
                {
                    idUsuario = "4",
                    usuario = "David4",
                    password = "password",
                    rol = "administrador"

                }
            };

            return list;
        }

    }
}
