using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gma.System.MouseKeyHook;
using Gamepad_Viewer;
using System.Windows.Forms;

namespace Gamepad_Viewer.Tools
{
    public static class Keyboard
    {
        private static IKeyboardMouseEvents _globalHook;

        public static void Subscribe()
        {
            _globalHook = Hook.GlobalEvents();
            _globalHook.KeyDown += GlobalHookKeyDown;
            _globalHook.KeyUp += GlobalHookKeyUp;
        }

        public static void Unsubscribe()
        {
            _globalHook.KeyDown -= GlobalHookKeyDown;
            _globalHook.KeyUp -= GlobalHookKeyUp;
            _globalHook.Dispose();
        }
        private static void GlobalHookKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            MessageBox.Show($"Key Down: {e.KeyCode}");
            
            
        }

        private static void GlobalHookKeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            Console.WriteLine($"Key Up: {e.KeyCode}");
        }
    }
}
