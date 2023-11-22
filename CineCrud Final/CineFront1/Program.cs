using CineFront;

namespace CineFront1
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
            Application.Run(new frmLogin());
            //Application.Run(new frmConsultarComprobantes());
            //Application.Run(new frmComprobanteAM(AccionComp.Act, 136));
        }
    }
}