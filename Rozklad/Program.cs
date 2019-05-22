using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozklad
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Aktualizacja a = new Aktualizacja();
            Application.Run(a);
            if(a.wyjscie==false)
            {
                Application.Run(new Form1(a.jakieMiasta));
            }
            
        }
    }
}
