using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gamepad_Viewer.Tools;
using SharpDX.XInput;

namespace Gamepad_Viewer
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            //debug
            Pad();
            Pad2();

            //Todo =
            //Logging
            //Settings
            //Custom Skin
            //Remapping
            //Multiple Controller
            //Control Windows Cursor
        }

        private async Task Pad2()
        {
            // Create a new controller instance
            Controller controller = new Controller(UserIndex.Two);

            // Check if the controller is connected
            if (!controller.IsConnected)
            {
                label2.Text = "Controller not connected.";
                return;
            }

            label2.Text = "Controller connected.";

            // Continuously poll for input
            while (true)
            {
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
                UpdateButtons();

                // Display the data (concatenate into one string to avoid overwriting issues)
                label2.Text = $"LeftStick: {leftStick}, RightStick: {rightStick}\n" +
                              $"LeftTrigger: {leftTrigger}, RightTrigger: {rightTrigger}\n" +
                              $"Buttons: {buttons}";




                // Use Task.Delay to allow the UI thread to remain responsive
                // 60 fps - Input Delay
                await Task.Delay(20);
            }
        }

        private async Task Pad()
        {
            // Create a new controller instance
            Controller controller = new Controller(UserIndex.One);

            // Check if the controller is connected
            if (!controller.IsConnected)
            {
                label1.Text = "Controller not connected.";
                return;
            }

            label1.Text = "Controller connected.";

            // Continuously poll for input
            while (true)
            {
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
                UpdateButtons();

                // Display the data (concatenate into one string to avoid overwriting issues)
                label1.Text = $"LeftStick: {leftStick}, RightStick: {rightStick}\n" +
                              $"LeftTrigger: {leftTrigger}, RightTrigger: {rightTrigger}\n" +
                              $"Buttons: {buttons}";


                

                // Use Task.Delay to allow the UI thread to remain responsive
                // 60 fps - Input Delay
                await Task.Delay(20);
            }
        }

        private async void UpdateButtons()
        {

            #region if
            //general
            //if (Pads.ActiveButtons.Contains(Pads.Triangle))
            //{
            //    pad_triangle.Visible = true;
            //}
            //else
            //{
            //    pad_triangle.Visible = false;
            //}
            //if (Pads.ActiveButtons.Contains(Pads.Square))
            //{
            //    pad_square.Visible = true;
            //}
            //else
            //{
            //    pad_square.Visible = false;
            //}
            //if (Pads.ActiveButtons.Contains(Pads.Circle))
            //{
            //    pad_circle.Visible = true;
            //}
            //else
            //{
            //    pad_circle.Visible = false;
            //}
            //if (Pads.ActiveButtons.Contains(Pads.Cross))
            //{
            //    pad_cross.Visible = true;
            //}
            //else
            //{
            //    pad_cross.Visible = false;
            //}
            #endregion

            //Damn dictionary condition
            var buttonMap = new Dictionary<string, Control>
{
    //general
    { Pads.Triangle, pad_triangle },
    { Pads.Square, pad_square },
    { Pads.Circle, pad_circle },
    { Pads.Cross, pad_cross },

    //dpad
    { Pads.PadUp, pad_padup },
    { Pads.PadDown, pad_paddown },
    { Pads.PadRight, pad_padright },
    { Pads.PadLeft, pad_padleft },
     
};

            foreach (var entry in buttonMap)
            {
                entry.Value.Visible = Pads.ActiveButtons.Contains(entry.Key);
            }


        }

        private async void button1_Click(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CreatePictureBoxWithChromaKey()
        {
            PictureBox pictureBox = new PictureBox
            {
                Location = new Point(3, 258), // Set position (X: 50, Y: 100)
                Size = new Size(794, 341),     // Set size (Width: 400, Height: 300)
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Lime, // Set BackColor to Lime
                TabIndex = 2, // Set TabIndex to 1
                TabStop = false // Optional: Disable tab navigation for PictureBox
            };
            this.Controls.Add(pictureBox);

            // Load the image with transparency
            Bitmap transparentImage = new Bitmap("raw\\triangle.png"); // Replace with your image path

            // Apply chroma key to remove Lime background
            Bitmap processedImage = ApplyChromaKeyOnBackColor(transparentImage, Color.Lime);
            pictureBox.Image = processedImage;
            
        }

        private Bitmap ApplyChromaKeyOnBackColor(Bitmap image, Color chromaKey)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);

                    // Replace chroma key color (lime) with transparency
                    if (pixelColor.ToArgb() == chromaKey.ToArgb())
                    {
                        result.SetPixel(x, y, Color.FromArgb(0, 0, 0, 0)); // Fully transparent
                    }
                    else
                    {
                        result.SetPixel(x, y, pixelColor);
                    }
                }
            }

            return result;
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            await Pad();
        }

        private void debug_check_CheckedChanged(object sender, EventArgs e)
        {
            if(debug_check.Checked)
            {
                Dev.Init();
            }else { Dev.Close(); }
        }
    }
}
