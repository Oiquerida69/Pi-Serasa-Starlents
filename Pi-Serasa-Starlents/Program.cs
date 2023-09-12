namespace Pi_Serasa_Starlents
{
    internal static class Program
    {
         public static Perfil perfil = new Perfil();
        public static Usuario usuario = new Usuario();
        public static Cadastro CADAs = new Cadastro();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Notificacao());
        }
    }
}