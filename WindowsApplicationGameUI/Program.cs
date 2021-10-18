using System;
using System.Windows.Forms;

namespace WindowsApplicationGameUI
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
            GameManager ticTacToeGame = new GameManager();
            ticTacToeGame.Run();
        }
    }
}
