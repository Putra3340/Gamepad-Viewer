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

        // For showing or hiding the console window
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        // Getting the process window handle (Console window)
        [DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();

        private const int SW_HIDE = 0;
        private const int SW_SHOW = 5;

        public async static void Init()
        {
            // Allocate console window only if not already allocated
            IntPtr hwnd = GetConsoleWindow();
            if (hwnd == IntPtr.Zero)
            {
                // If no console exists, allocate it
                if (!AllocConsole())
                {
                    MessageBox.Show("Console window could not be created.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Console.Title = "Gamepad Viewer";

            // Now try hiding the console window if possible
            hwnd = GetConsoleWindow();
            if (hwnd != IntPtr.Zero)
            {
                // Hide the console window
                ShowWindow(hwnd, SW_HIDE);
            }
        }

        public async static void Show()
        {
            IntPtr hwnd = GetConsoleWindow();
            if (hwnd != IntPtr.Zero)
            {
                // Show the console window
                ShowWindow(hwnd, SW_SHOW);
            }
        }

        public async static void Hide()
        {
            IntPtr hwnd = GetConsoleWindow();
            if (hwnd != IntPtr.Zero)
            {
                // Hide the console window
                ShowWindow(hwnd, SW_HIDE);
            }
        }

        public async static void Log(string log, ConsoleColor col = ConsoleColor.White)
        {
            // Log messages to the console
            Console.ForegroundColor = col;
            Console.WriteLine($"{DateTime.Now}: {log}");
        }

        public async static void Close()
        {
            // Close the console window
            FreeConsole();
        }
    }
}
