using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ex05.GameLogic;
using Ex05.GameUI;

namespace B21_Ex05_Eithan_204311757_Maor_204709950
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GameSettings());
            //Application.Run(new GameBoard());

            Tournament m_Tournament = new Tournament();
        }

    }
}
