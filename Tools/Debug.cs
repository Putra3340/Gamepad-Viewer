using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Gamepad_Viewer.Tools
{
    public static class Dev
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool FreeConsole();

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();

        private const int SW_HIDE = 0;
        private const int SW_SHOW = 5;

        public static void Init()
        {
            IntPtr hwnd = GetConsoleWindow();
            if (hwnd == IntPtr.Zero)
            {
                // Allocate a new console
                if (!AllocConsole())
                {
                    MessageBox.Show("Failed to create console.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Console.Title = "Gamepad Viewer";
            }
            Hide();
            Console.Clear();
        }

        public static void Show()
        {
            IntPtr hwnd = GetConsoleWindow();
            if (hwnd != IntPtr.Zero)
            {
                ShowWindow(hwnd, SW_SHOW);
            }
            
        }

        public static void Hide()
        {
            IntPtr hwnd = GetConsoleWindow();
            if (hwnd != IntPtr.Zero)
            {
                ShowWindow(hwnd, SW_HIDE);
            }
            Console.Clear();
        }

        public static void Log(string message, ConsoleColor color = ConsoleColor.White)
        {
            if (GetConsoleWindow() == IntPtr.Zero)
            {
                Init();
            }

            Console.ForegroundColor = color;
            Console.WriteLine($"{DateTime.Now}: {message}");
            Console.ResetColor();
        }

        public static void Close()
        {
            IntPtr hwnd = GetConsoleWindow();
            if (hwnd != IntPtr.Zero)
            {
                FreeConsole();
            }
        }
    }
}
