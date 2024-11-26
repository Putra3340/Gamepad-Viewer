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
        // Pads State
        public static string ActiveButtons = ""; // All Buttons
        public static int LX = 0; // Left Analog X
        public static int LY = 0; // Left Analog Y
        public static int RX = 0; // Right Analog X
        public static int RY = 0; // Rigth Analog Y
        public static int LTrigger = 0; // L2 Pressure
        public static int RTrigger = 0; // R2 Pressure

        // Define
        public static int Trigger_Max = 255; // For R2/L2
        public static int Axis_Max = 32767; // Analog
        public static int Axis_Min = -32767;

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

    }
}
