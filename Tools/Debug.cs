using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamepad_Viewer.Tools
{
    public static class Dev
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool FreeConsole();

        public static async void Init()
        {
            if (!AllocConsole())
            {
                MessageBox.Show("Console window is already open.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Console.Title = "Gamepad Viewer";
        }
        
        public static void Log(string log, ConsoleColor col = ConsoleColor.White)
        {
            // Log messages to the console
            Console.ForegroundColor = col;
            Console.WriteLine($"{DateTime.Now}: {log}");
        }

        public static void Close()
        {
            // Close the console window
            FreeConsole();
        }
    }
}
