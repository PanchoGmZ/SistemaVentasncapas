
using System.Data.SqlClient;
using System.Data;
using SistemasVentas.VISTA.UsuarioVistas;
using SistemasVentas.VISTA.MarcaVistas;
using SistemasVentas.VISTA.DetalleVentaVistas;
using SistemasVentas.VISTA.RolVistas;
using SistemasVentas.VISTA.ClienteVistas;
using SistemasVentas.VISTA.PersonaVistas;

namespace SistemasVentas.Vista
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
            Application.Run(new PersonaInsertarVista ());
        }
    }
}

