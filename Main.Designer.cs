namespace Gamepad_Viewer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.debug_check = new System.Windows.Forms.CheckBox();
            this.Preview1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pad_padright = new System.Windows.Forms.PictureBox();
            this.pad_padleft = new System.Windows.Forms.PictureBox();
            this.pad_paddown = new System.Windows.Forms.PictureBox();
            this.pad_padup = new System.Windows.Forms.PictureBox();
            this.pad_cross = new System.Windows.Forms.PictureBox();
            this.pad_circle = new System.Windows.Forms.PictureBox();
            this.pad_square = new System.Windows.Forms.PictureBox();
            this.pad_triangle = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Pointer_Check = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Preview1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pad_padright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pad_padleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pad_paddown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pad_padup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pad_cross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pad_circle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pad_square)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pad_triangle)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Preview1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.55556F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(741, 633);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(735, 262);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(727, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Pointer_Check);
            this.tabPage2.Controls.Add(this.debug_check);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(727, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // debug_check
            // 
            this.debug_check.AutoSize = true;
            this.debug_check.Location = new System.Drawing.Point(86, 24);
            this.debug_check.Name = "debug_check";
            this.debug_check.Size = new System.Drawing.Size(99, 17);
            this.debug_check.TabIndex = 0;
            this.debug_check.Text = "Debug Console";
            this.debug_check.UseVisualStyleBackColor = true;
            this.debug_check.CheckedChanged += new System.EventHandler(this.debug_check_CheckedChanged);
            // 
            // Preview1
            // 
            this.Preview1.Controls.Add(this.tabPage4);
            this.Preview1.Controls.Add(this.tabPage3);
            this.Preview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Preview1.Location = new System.Drawing.Point(3, 271);
            this.Preview1.Name = "Preview1";
            this.Preview1.SelectedIndex = 0;
            this.Preview1.Size = new System.Drawing.Size(735, 359);
            this.Preview1.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Lime;
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage4.Controls.Add(this.pad_padright);
            this.tabPage4.Controls.Add(this.pad_padleft);
            this.tabPage4.Controls.Add(this.pad_paddown);
            this.tabPage4.Controls.Add(this.pad_padup);
            this.tabPage4.Controls.Add(this.pad_cross);
            this.tabPage4.Controls.Add(this.pad_circle);
            this.tabPage4.Controls.Add(this.pad_square);
            this.tabPage4.Controls.Add(this.pad_triangle);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(727, 333);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            // 
            // pad_padright
            // 
            this.pad_padright.BackColor = System.Drawing.Color.Transparent;
            this.pad_padright.Image = ((System.Drawing.Image)(resources.GetObject("pad_padright.Image")));
            this.pad_padright.Location = new System.Drawing.Point(230, 122);
            this.pad_padright.Name = "pad_padright";
            this.pad_padright.Size = new System.Drawing.Size(28, 28);
            this.pad_padright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pad_padright.TabIndex = 6;
            this.pad_padright.TabStop = false;
            this.pad_padright.Visible = false;
            // 
            // pad_padleft
            // 
            this.pad_padleft.BackColor = System.Drawing.Color.Transparent;
            this.pad_padleft.Image = ((System.Drawing.Image)(resources.GetObject("pad_padleft.Image")));
            this.pad_padleft.Location = new System.Drawing.Point(189, 123);
            this.pad_padleft.Name = "pad_padleft";
            this.pad_padleft.Size = new System.Drawing.Size(28, 28);
            this.pad_padleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pad_padleft.TabIndex = 7;
            this.pad_padleft.TabStop = false;
            this.pad_padleft.Visible = false;
            // 
            // pad_paddown
            // 
            this.pad_paddown.BackColor = System.Drawing.Color.Transparent;
            this.pad_paddown.Image = ((System.Drawing.Image)(resources.GetObject("pad_paddown.Image")));
            this.pad_paddown.Location = new System.Drawing.Point(215, 142);
            this.pad_paddown.Name = "pad_paddown";
            this.pad_paddown.Size = new System.Drawing.Size(28, 28);
            this.pad_paddown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pad_paddown.TabIndex = 5;
            this.pad_paddown.TabStop = false;
            this.pad_paddown.Visible = false;
            // 
            // pad_padup
            // 
            this.pad_padup.BackColor = System.Drawing.Color.Transparent;
            this.pad_padup.Image = ((System.Drawing.Image)(resources.GetObject("pad_padup.Image")));
            this.pad_padup.Location = new System.Drawing.Point(209, 101);
            this.pad_padup.Name = "pad_padup";
            this.pad_padup.Size = new System.Drawing.Size(28, 28);
            this.pad_padup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pad_padup.TabIndex = 4;
            this.pad_padup.TabStop = false;
            this.pad_padup.Visible = false;
            // 
            // pad_cross
            // 
            this.pad_cross.BackColor = System.Drawing.Color.Transparent;
            this.pad_cross.Image = ((System.Drawing.Image)(resources.GetObject("pad_cross.Image")));
            this.pad_cross.Location = new System.Drawing.Point(488, 154);
            this.pad_cross.Name = "pad_cross";
            this.pad_cross.Size = new System.Drawing.Size(28, 28);
            this.pad_cross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pad_cross.TabIndex = 3;
            this.pad_cross.TabStop = false;
            this.pad_cross.Visible = false;
            // 
            // pad_circle
            // 
            this.pad_circle.BackColor = System.Drawing.Color.Transparent;
            this.pad_circle.Image = ((System.Drawing.Image)(resources.GetObject("pad_circle.Image")));
            this.pad_circle.Location = new System.Drawing.Point(518, 121);
            this.pad_circle.Name = "pad_circle";
            this.pad_circle.Size = new System.Drawing.Size(28, 28);
            this.pad_circle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pad_circle.TabIndex = 2;
            this.pad_circle.TabStop = false;
            this.pad_circle.Visible = false;
            // 
            // pad_square
            // 
            this.pad_square.BackColor = System.Drawing.Color.Transparent;
            this.pad_square.Image = ((System.Drawing.Image)(resources.GetObject("pad_square.Image")));
            this.pad_square.Location = new System.Drawing.Point(455, 121);
            this.pad_square.Name = "pad_square";
            this.pad_square.Size = new System.Drawing.Size(28, 28);
            this.pad_square.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pad_square.TabIndex = 1;
            this.pad_square.TabStop = false;
            this.pad_square.Visible = false;
            // 
            // pad_triangle
            // 
            this.pad_triangle.BackColor = System.Drawing.Color.Transparent;
            this.pad_triangle.Image = ((System.Drawing.Image)(resources.GetObject("pad_triangle.Image")));
            this.pad_triangle.Location = new System.Drawing.Point(489, 90);
            this.pad_triangle.Name = "pad_triangle";
            this.pad_triangle.Size = new System.Drawing.Size(28, 28);
            this.pad_triangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pad_triangle.TabIndex = 0;
            this.pad_triangle.TabStop = false;
            this.pad_triangle.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(727, 333);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Pointer_Check
            // 
            this.Pointer_Check.AutoSize = true;
            this.Pointer_Check.Location = new System.Drawing.Point(86, 68);
            this.Pointer_Check.Name = "Pointer_Check";
            this.Pointer_Check.Size = new System.Drawing.Size(113, 17);
            this.Pointer_Check.TabIndex = 1;
            this.Pointer_Check.Text = "Gamepad Controls";
            this.Pointer_Check.UseVisualStyleBackColor = true;
            this.Pointer_Check.CheckedChanged += new System.EventHandler(this.Pointer_Check_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 633);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Preview1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pad_padright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pad_padleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pad_paddown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pad_padup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pad_cross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pad_circle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pad_square)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pad_triangle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl Preview1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox pad_triangle;
        private System.Windows.Forms.PictureBox pad_square;
        private System.Windows.Forms.PictureBox pad_circle;
        private System.Windows.Forms.PictureBox pad_cross;
        private System.Windows.Forms.PictureBox pad_padup;
        private System.Windows.Forms.PictureBox pad_paddown;
        private System.Windows.Forms.PictureBox pad_padright;
        private System.Windows.Forms.PictureBox pad_padleft;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox debug_check;
        private System.Windows.Forms.CheckBox Pointer_Check;
    }
}

