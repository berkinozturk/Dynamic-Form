namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.siticoneCircleButton1 = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.siticoneShadowForm1 = new Siticone.Desktop.UI.WinForms.SiticoneShadowForm(this.components);
            this.siticoneGradientButton1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.siticoneGradientButton2 = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(42, 113);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(607, 362);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(682, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show Name";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(92, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(257, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Address";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.Location = new System.Drawing.Point(772, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 30);
            this.button3.TabIndex = 0;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // siticoneCircleButton1
            // 
            this.siticoneCircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneCircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneCircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneCircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneCircleButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneCircleButton1.Location = new System.Drawing.Point(655, 96);
            this.siticoneCircleButton1.Name = "siticoneCircleButton1";
            this.siticoneCircleButton1.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCircleButton1.Size = new System.Drawing.Size(145, 49);
            this.siticoneCircleButton1.TabIndex = 10;
            this.siticoneCircleButton1.Text = "Delete";
            // 
            // siticoneGradientButton1
            // 
            this.siticoneGradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneGradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneGradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneGradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneGradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneGradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.siticoneGradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneGradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGradientButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton1.Location = new System.Drawing.Point(666, 340);
            this.siticoneGradientButton1.Name = "siticoneGradientButton1";
            this.siticoneGradientButton1.Size = new System.Drawing.Size(118, 28);
            this.siticoneGradientButton1.TabIndex = 11;
            this.siticoneGradientButton1.Text = "Delete";
            this.siticoneGradientButton1.Click += new System.EventHandler(this.button1_Click);
            this.siticoneGradientButton1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.siticoneGradientButton1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // siticoneGradientButton2
            // 
            this.siticoneGradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneGradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneGradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneGradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneGradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneGradientButton2.Enabled = false;
            this.siticoneGradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.siticoneGradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneGradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGradientButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton2.Location = new System.Drawing.Point(666, 261);
            this.siticoneGradientButton2.Name = "siticoneGradientButton2";
            this.siticoneGradientButton2.Size = new System.Drawing.Size(118, 28);
            this.siticoneGradientButton2.TabIndex = 14;
            this.siticoneGradientButton2.Text = "Show Name";
            this.siticoneGradientButton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.siticoneGradientButton2);
            this.Controls.Add(this.siticoneGradientButton1);
            this.Controls.Add(this.siticoneCircleButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton siticoneCircleButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneShadowForm siticoneShadowForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton2;
    }
}

