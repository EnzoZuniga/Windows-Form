using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TPFenetreMereFille
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            FMere fenetreDemarrage;
            fenetreDemarrage = new FMere();
            Application.Run(fenetreDemarrage);
        }
    }
}
