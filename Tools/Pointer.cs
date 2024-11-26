using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS4014 //fuck the warning man
#pragma warning disable CS1998
namespace Gamepad_Viewer
{
    public static class Pointer
    {

        public static readonly string Up = "Up";
        public static readonly string Left = "Left";
        public static readonly string Right = "Right";
        public static readonly string Down = "Down";
        private static bool PointerActive = false;

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

        public static async Task Start()
        {
            while (PointerActive)
            {
                if (Pads.ActiveButtons.Contains(Pads.R3) && Pads.ActiveButtons.Contains(Pads.R3)) break; // if triggered next go to calculate
                await Task.Delay(20);
            }

            Calculate(); // Process the analog input
        }

        private static async Task Calculate() {
            int speed = 0;
            while (PointerActive)
            {
                // Handle LX - Left
                if (Pads.LX < 0)
                {
                    MoveCursor(Left, 10); // Assume Speed
                }
                else if (Pads.LX < -1200)
                {
                    MoveCursor(Left, 25);
                }
            }

        }

        public static async Task MoveCursor(string direction, int speed = 10)
        {

            // Idk if it gonna accurate but fuck it
            if(direction == Left) MoveLeft(speed);
        }

        public static async Task MoveLeft(int speed = 10)
        {
            // Maybe using loop if has high speed to make it smooth


            // Get the current cursor position
            if (GetCursorPos(out POINT currentPos))
            {

                // Move the cursor down by 100 pixels
                int newX = currentPos.X - 10;
                int newY = currentPos.Y;

                // Apply the new position
                SetCursorPos(newX, newY);

            }
        }
    }
}
