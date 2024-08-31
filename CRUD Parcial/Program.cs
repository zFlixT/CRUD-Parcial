using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Parcial
{
    //Se define una clase estática interna llamada Program.
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
            //Ejecuta la aplicación y muestra el formulario de inicio.
            //'Inicio' es el formulario principal que se abre cuando se inicia la aplicación.
            Application.Run(new Inicio());

        }
    }
}
