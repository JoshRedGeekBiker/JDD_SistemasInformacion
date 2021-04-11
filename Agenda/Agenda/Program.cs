using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    static class Program
    {
        //Vistas
        static frmPrincipal VistaPrincipal;
        static frmCargando VistaCargando;



        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            VistaPrincipal = new frmPrincipal();


            Cargando();
            Application.Run(new frmPrincipal());
            
        }

        

        /// <summary>
        /// Se encarga de mostrar un logo al inicio
        /// </summary>
        private static void Cargando()
        {
            VistaCargando = new frmCargando();
            VistaCargando.Show();
        } 

        private static List<>
    }
}
