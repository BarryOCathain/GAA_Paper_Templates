using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GAA_Paper_Templates;

namespace Client_Layer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Competition comp;

            using (GAA_Templates_ModelContainer context = new GAA_Templates_ModelContainer())
            {
                comp = context.Competitions
                    .Include("County")
                    .Where(c => c.Name == "Senior Championship")
                    .FirstOrDefault();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CompetitionWindow(comp));
        }
    }
}
