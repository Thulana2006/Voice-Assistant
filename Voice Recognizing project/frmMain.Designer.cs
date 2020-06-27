namespace Voice_Recognizing_project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timerTrueFalse = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.crclbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSettings = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Enblbtn = new System.Windows.Forms.Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timerTrueFalse
            // 
            this.timerTrueFalse.Enabled = true;
            this.timerTrueFalse.Interval = 1;
            this.timerTrueFalse.Tick += new System.EventHandler(this.timerTrueFalse_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // crclbar
            // 
            this.crclbar.animated = true;
            this.crclbar.animationIterval = 6;
            this.crclbar.animationSpeed = 1;
            this.crclbar.BackColor = System.Drawing.Color.Transparent;
            this.crclbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("crclbar.BackgroundImage")));
            this.crclbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.crclbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.crclbar.LabelVisible = false;
            this.crclbar.LineProgressThickness = 2;
            this.crclbar.LineThickness = 1;
            this.crclbar.Location = new System.Drawing.Point(89, 31);
            this.crclbar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.crclbar.MaxValue = 100;
            this.crclbar.Name = "crclbar";
            this.crclbar.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.crclbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.crclbar.Size = new System.Drawing.Size(186, 186);
            this.crclbar.TabIndex = 17;
            this.crclbar.Value = 30;
            this.crclbar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(7, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Say \'Hey assistant\', to activate";
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 10);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Made by ThulOnUpWork";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(343, -4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 31);
            this.button1.TabIndex = 25;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(316, -6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 33);
            this.button2.TabIndex = 24;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.ActiveImage = null;
            this.btnSettings.AllowAnimations = true;
            this.btnSettings.AllowBuffering = false;
            this.btnSettings.AllowZooming = true;
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnSettings.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.ErrorImage")));
            this.btnSettings.FadeWhenInactive = false;
            this.btnSettings.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageActive = null;
            this.btnSettings.ImageLocation = null;
            this.btnSettings.ImageMargin = 3;
            this.btnSettings.ImageSize = new System.Drawing.Size(27, 28);
            this.btnSettings.ImageZoomSize = new System.Drawing.Size(30, 31);
            this.btnSettings.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.InitialImage")));
            this.btnSettings.Location = new System.Drawing.Point(283, -2);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Rotation = 0;
            this.btnSettings.ShowActiveImage = true;
            this.btnSettings.ShowCursorChanges = true;
            this.btnSettings.ShowImageBorders = true;
            this.btnSettings.ShowSizeMarkers = false;
            this.btnSettings.Size = new System.Drawing.Size(30, 31);
            this.btnSettings.TabIndex = 23;
            this.btnSettings.ToolTipText = "Settings";
            this.btnSettings.WaitOnLoad = false;
            this.btnSettings.Zoom = 3;
            this.btnSettings.ZoomSpeed = 10;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.btnSettings);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(-4, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 25);
            this.panel2.TabIndex = 26;
            // 
            // Enblbtn
            // 
            this.Enblbtn.AccessibleName = "Enblbtn";
            this.Enblbtn.BackColor = System.Drawing.Color.Transparent;
            this.Enblbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Enblbtn.BackgroundImage")));
            this.Enblbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Enblbtn.FlatAppearance.BorderSize = 0;
            this.Enblbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Enblbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Enblbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enblbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enblbtn.ForeColor = System.Drawing.Color.Tan;
            this.Enblbtn.Location = new System.Drawing.Point(148, 92);
            this.Enblbtn.Name = "Enblbtn";
            this.Enblbtn.Size = new System.Drawing.Size(65, 66);
            this.Enblbtn.TabIndex = 0;
            this.Enblbtn.UseVisualStyleBackColor = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel2;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.label2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(366, 267);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Enblbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crclbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voice Assistant";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timerTrueFalse;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuImageButton btnSettings;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar crclbar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Enblbtn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
    }
}

