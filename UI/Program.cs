namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new Update_Phone1());
=======
            Application.Run(new UserOperation());
>>>>>>> 7ba7fef6ef548ee156ea183142e01b6b3e94dc55
        }
    }
}