namespace PassworldGenerator
{
    internal static class PassworldGeneratorMain
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            MainForm view = new MainForm();
            Presenter presenter = new Presenter(view);

            Application.Run(view);
        }
    }
}