using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gamepad_Viewer.Tools;
using SharpDX.XInput;
using Logging_Api;

#pragma warning disable CS4014 //fuck the warning man
#pragma warning disable CS1998

namespace Gamepad_Viewer
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();

            //debug
            Pad();
            Dev.Init();
            //Pointer.DoAction();
            //Todo =
            //Logging
            //Settings
            //Custom Skin
            //Remapping
            //Multiple Controller
            //Control Windows Cursor
            //Button Holding
            //WebPAD ps3 integration
            //Keyboard.Subscribe();
            
        }

        private async Task Pad()
        {
            // Create a new controller instance
            Controller controller = new Controller(UserIndex.One);
            //Pointer.DoAction();
            // Check if the controller is connected
            if (!controller.IsConnected)
            {
                label1.Text = "Controller not connected.";
                Dev.Log("Controller not connected.");
                return;
            }

            Dev.Log("Controller 1 is connected!");
            
            // Continuously poll for input
            while (true)
            {
                Pointer.DoAction();   
                // Get the current state of the controller
                var state = controller.GetState();

                // Access joystick, triggers, and buttons
                var leftStick = state.Gamepad.LeftThumbX;
                var rightStick = state.Gamepad.RightThumbX;
                var leftTrigger = state.Gamepad.LeftTrigger;
                var rightTrigger = state.Gamepad.RightTrigger;
                var buttons = state.Gamepad.Buttons;

                //update to global string
                Pads.ActiveButtons = buttons.ToString();
                Pads.LX = leftStick;
                Pads.LY = state.Gamepad.LeftThumbY;
                Pads.RX = rightStick;
                Pads.RY = state.Gamepad.RightThumbY;

                // Display the data (concatenate into one string to avoid overwriting issues)
                label1.Text = $"LeftStick: {leftStick}, RightStick: {rightStick}\n" +
                                $"LeftStick: {state.Gamepad.LeftThumbY}, RightStick: {state.Gamepad.RightThumbY}\n" +
                              $"LeftTrigger: {leftTrigger}, RightTrigger: {rightTrigger}\n" +
                              $"Buttons: {buttons}";



                // Action
                UpdateButtons(); // i added pointer action on this
                Pointer.Start();
                HoldState();
                // Use Task.Delay to allow the UI thread to remain responsive
                // Polling rate 1000Hz
                // Todo Custom Polling rate to run smoothly on slow cpu
                await Task.Delay(1);
            }
        }

        private async void UpdateButtons()
        {
            // i love ifs
            #region if
            //general
            if (Pads.ActiveButtons.Contains(Pads.Triangle)) { Pads.isHoldingTriangle = true; pad_triangle.Visible = true; } else { Pads.isHoldingTriangle = false; pad_triangle.Visible = false; }
            if (Pads.ActiveButtons.Contains(Pads.Square)) {pad_square.Visible = true; }
            else
            {
                pad_square.Visible = false;
            }
            if (Pads.ActiveButtons.Contains(Pads.Circle))
            {
                pad_circle.Visible = true;
            }
            else
            {
                pad_circle.Visible = false;
            }
            if (Pads.ActiveButtons.Contains(Pads.Cross))
            {
                Pads.isHoldingCross = true;
                pad_cross.Visible = true;
            }
            else
            {
                Pads.isHoldingCross = false;
                pad_cross.Visible = false;
            }

            // dpad
            if(Pads.ActiveButtons.Contains(Pads.PadUp)) { Pads.isHoldingPadUp = true; pad_padup.Visible = true; } else { Pads.isHoldingPadUp = false; pad_padup.Visible = false; }
            #endregion
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            Pad();
            Pointer.Start();
        }

        private void debug_check_CheckedChanged(object sender, EventArgs e)
        {
            if (debug_check.Checked)
            {
                Dev.Show();
                Dev.Log($"Gamepad Viewer v{Assembly.GetExecutingAssembly().GetName().Version}");
            }
            else { Dev.Hide(); }
        }

        private void Pointer_Check_CheckedChanged(object sender, EventArgs e)
        {
            if(Pointer_Check.Checked)
            {
                Dev.Log("Gamepad Controlling is Activated");
                Pointer.IsPointerActive = true;
            }
            else
            {
                Dev.Log("Gamepad Controlling is Disabled");
                Pointer.IsPointerActive = false;
            }
        }
        private int circle = 0;
        private void HoldState()
        {
            if (pad_circle.Visible) {
                circle++;
                if(circle == 100)
                {
                    return;
                }
                //if circle pressed for 200ms
                if(circle > 500) {
                    Dev.Log("Circle holded!!");
                }
            }
            else
            {
                //reset state
                circle = 0;
            }
        }
    }
}
