using Gamepad_Viewer.Tools;
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
        public static bool IsPointerActive = false;
        private static int speed = 10; // Todo : Dynamic speed on cursor
        public static bool condition = false; // The main condition
        public static bool hasExecuted = false; // Tracks if the action has been executed

        // Import the SetCursorPos function from user32.dll
        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int x, int y);

        // Import the GetCursorPos function from user32.dll
        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(out POINT lpPoint);

        // Declare the mouse_event function from user32.dll
        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, uint dwExtraInfo);

        // Constants for mouse events
        const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        const uint MOUSEEVENTF_LEFTUP = 0x0004;
        const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        const uint MOUSEEVENTF_MIDDLEUP = 0x0040;

        // Define a POINT structure to hold the cursor position
        private struct POINT
        {
            public int X;
            public int Y;
        }

        public static async Task Start()
        {
            if (!IsPointerActive) return;
            Calculate(); // Process the analog input
        }
        public static async Task<string> DoAction()
        {
            //while(true)
            //{
                if (Pads.isHoldingCross && !hasExecuted)
                {
                    // Execute the code only once when condition becomes true
                    Dev.Log("Condition is true. Executing action...");
                    if (Pads.ActiveButtons.Contains(Pads.Cross))
                    {
                        // Simulate a left mouse click
                        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);  // Mouse button down
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);    // Mouse button up


                    }
                    hasExecuted = true; // Mark as executed
                }
                else if (!Pads.isHoldingCross)
                {
                    // Reset the flag when condition becomes false
                    hasExecuted = false;
                }
                Pads.isHoldingCross = !Pads.isHoldingCross;
            //}
            return "";
        }
        private static async Task Calculate()
        {
            
            // Todo : Analog Speed
            // Todo : Add Custom Default Analog Deadzone

            // Left Analog X - Y
            if (Pads.LX < 128)
            {
                MoveCursor(Left);
            }
            else if (Pads.LX > 128)
            {
                MoveCursor(Right);
            }

            if (Pads.LY > -129)
            {
                MoveCursor(Down);
            }
            else if (Pads.LY < -129)
            {
                MoveCursor(Up);
            }

            //await Task.Delay(20); // Maybe
            // Damn Logic
            //}

        }

        public static async Task MoveCursor(string direction)
        {

            // Idk if it gonna accurate but fuck it
            if (direction == Left) MoveLeft(speed);
            if (direction == Right) MoveRight(speed);
            if (direction == Up) MoveUp(speed);
            if (direction == Down) MoveDown(speed);
        }

        #region Action
        // Todo
        #endregion

        #region Move

        public static async Task MoveLeft(int speed)
        {
            // Maybe using loop if has high speed to make it smooth


            // Get the current cursor position
            if (GetCursorPos(out POINT currentPos))
            {

                // Move the cursor down by 100 pixels
                int newX = currentPos.X - speed;
                int newY = currentPos.Y;

                // Apply the new position
                SetCursorPos(newX, newY);

            }
        }
        public static async Task MoveRight(int speed)
        {
            // Get the current cursor position
            if (GetCursorPos(out POINT currentPos))
            {

                // Move the cursor down by 100 pixels
                int newX = currentPos.X + speed;
                int newY = currentPos.Y;

                // Apply the new position
                SetCursorPos(newX, newY);

            }
        }
        public static async Task MoveUp(int speed)
        {
            // Get the current cursor position
            if (GetCursorPos(out POINT currentPos))
            {

                // Move the cursor down by 100 pixels
                int newX = currentPos.X;
                int newY = currentPos.Y + speed;

                // Apply the new position
                SetCursorPos(newX, newY);
            }
        }
        public static async Task MoveDown(int speed)
        {
            // Maybe using loop if has high speed to make it smooth


            // Get the current cursor position
            if (GetCursorPos(out POINT currentPos))
            {

                // Move the cursor down by 100 pixels
                int newX = currentPos.X;
                int newY = currentPos.Y - speed;

                // Apply the new position
                SetCursorPos(newX, newY);

            }
        }
        #endregion
    }
}
