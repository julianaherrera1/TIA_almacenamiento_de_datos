using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIA_almacenamiento_de_datos
{
    /// <summary>
    /// Creada por : Juliana Herrera
    /// Fecha: 04/ mayo / 2023
    /// Implementar el acceso a datos con (TXT/CSV/XML/RTF). 
    /// Se debe permitir crear, editar, borrar cada uno de ellos
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_elegir());
        }
    }
}
