#define TRAZA

using System;
using System.Windows.Forms;

namespace NavegadorWeb
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("Test");

#if PRUEBA
            Console.Write (“Esto es una prueba”);

#if TRAZA
            Console.Write(“ con traza”);
#elif !TRAZA

            Console.Write(“ sin traza”);
#endif
#endif

            Console.Write("Test");


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
