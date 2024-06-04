using Aplikacja_finansowa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AplikacjaFinansowa
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Aplikacja_finansowa.MainMenu mainMenu = new Aplikacja_finansowa.MainMenu();
            Finanse finanse = new Finanse();
            Application.Run(mainMenu);




        }
    }
}
