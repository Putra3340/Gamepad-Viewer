using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Gamepad_Viewer
{
    public static class Pads
    {
        public static string ActiveButtons = "";


        //General Button
        public static string Triangle = "Y";
        public static string Square = "X";
        public static string Circle = "B";
        public static string Cross = "A";

        //Pads
        public static string PadUp = "DPadUp";
        public static string PadLeft = "DPadLeft";
        public static string PadRight = "DPadRight";
        public static string PadDown = "DPadDown";

        //Left
        public static string L1 = "LeftShoulder";
        public static string L2 = "";
        // Todo = L2 pressure

        //Right
        public static string R1 = "RightShoulder";
        public static string R2 = "A";

        //Other
        public static string R3 = "RightThumb";
        public static string L3 = "LeftThumb";
        public static string Start = "Start";
        public static string Select = "Back";

        // Todo = R2 pressure


        // Todo : Left Analog
        // Todo : Right Analog


        #region Cursor
        // Import the SetCursorPos function from user32.dll
        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int x, int y);

        // Import the GetCursorPos function from user32.dll
        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(out POINT lpPoint);

        // Define a POINT structure to hold the cursor position
        private struct POINT
        {
            public int X;
            public int Y;
        }
        #endregion
        public static async void move()
        {
            for (int i = 0; i < 600; i++)
            {

                // Get the current cursor position
                if (GetCursorPos(out POINT currentPos))
                {

                    // Move the cursor down by 100 pixels
                    int newX = currentPos.X;
                    int newY = currentPos.Y + 1;

                    // Apply the new position
                    SetCursorPos(newX, newY);
                    await Task.Delay(20);

                }
            }
        }
    }
}
