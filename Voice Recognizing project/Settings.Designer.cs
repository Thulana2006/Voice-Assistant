namespace Voice_Recognizing_project
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.sliderTrans = new Bunifu.UI.WinForms.BunifuHSlider();
            this.lblVal = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cmbovoice = new MetroFramework.Controls.MetroComboBox();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBrowse = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxCmd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtBoxPath = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.tooltipError = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.sliderSound = new Bunifu.UI.WinForms.BunifuHSlider();
            this.picBoxSound = new System.Windows.Forms.PictureBox();
            this.lblSound = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tooltippath = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSound)).BeginInit();
            this.SuspendLayout();
            // 
            // sliderTrans
            // 
            this.sliderTrans.AllowCursorChanges = true;
            this.sliderTrans.AllowHomeEndKeysDetection = false;
            this.sliderTrans.AllowIncrementalClickMoves = true;
            this.sliderTrans.AllowMouseDownEffects = false;
            this.sliderTrans.AllowMouseHoverEffects = false;
            this.sliderTrans.AllowScrollingAnimations = true;
            this.sliderTrans.AllowScrollKeysDetection = true;
            this.sliderTrans.AllowScrollOptionsMenu = true;
            this.sliderTrans.AllowShrinkingOnFocusLost = false;
            this.sliderTrans.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sliderTrans.BackgroundImage")));
            this.sliderTrans.BindingContainer = null;
            this.sliderTrans.BorderRadius = 2;
            this.sliderTrans.BorderThickness = 1;
            this.sliderTrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderTrans.DrawThickBorder = false;
            this.sliderTrans.DurationBeforeShrink = 2000;
            this.sliderTrans.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.sliderTrans.LargeChange = 10;
            this.sliderTrans.Location = new System.Drawing.Point(20, 175);
            this.sliderTrans.Maximum = 100;
            this.sliderTrans.Minimum = 5;
            this.sliderTrans.MinimumSize = new System.Drawing.Size(0, 31);
            this.sliderTrans.MinimumThumbLength = 18;
            this.sliderTrans.Name = "sliderTrans";
            this.sliderTrans.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.sliderTrans.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.sliderTrans.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.sliderTrans.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.sliderTrans.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.sliderTrans.ShrinkSizeLimit = 3;
            this.sliderTrans.Size = new System.Drawing.Size(358, 31);
            this.sliderTrans.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.sliderTrans.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.sliderTrans.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.sliderTrans.SmallChange = 1;
            this.sliderTrans.TabIndex = 1;
            this.sliderTrans.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.sliderTrans.ThumbFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.sliderTrans.ThumbLength = 37;
            this.sliderTrans.ThumbMargin = 1;
            this.sliderTrans.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.tooltippath.SetToolTip(this.sliderTrans, "");
            this.tooltipError.SetToolTip(this.sliderTrans, "");
            this.tooltippath.SetToolTipIcon(this.sliderTrans, null);
            this.tooltipError.SetToolTipIcon(this.sliderTrans, null);
            this.tooltipError.SetToolTipTitle(this.sliderTrans, "");
            this.tooltippath.SetToolTipTitle(this.sliderTrans, "");
            this.sliderTrans.Value = 100;
            this.sliderTrans.ValueChanged += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs>(this.sliderTrans_ValueChanged);
            // 
            // lblVal
            // 
            this.lblVal.AutoSize = true;
            this.lblVal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblVal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblVal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVal.Location = new System.Drawing.Point(142, 159);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(43, 17);
            this.lblVal.TabIndex = 2;
            this.lblVal.Text = "100 %";
            this.tooltipError.SetToolTip(this.lblVal, "");
            this.tooltippath.SetToolTip(this.lblVal, "");
            this.tooltipError.SetToolTipIcon(this.lblVal, null);
            this.tooltippath.SetToolTipIcon(this.lblVal, null);
            this.tooltippath.SetToolTipTitle(this.lblVal, "");
            this.tooltipError.SetToolTipTitle(this.lblVal, "");
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(362, -12);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(43, 43);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.TextOffset = new System.Drawing.Point(-1, 3);
            this.tooltipError.SetToolTip(this.btnClose, "");
            this.tooltippath.SetToolTip(this.btnClose, "");
            this.tooltipError.SetToolTipIcon(this.btnClose, null);
            this.tooltippath.SetToolTipIcon(this.btnClose, null);
            this.tooltippath.SetToolTipTitle(this.btnClose, "");
            this.tooltipError.SetToolTipTitle(this.btnClose, "");
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(16, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select voice   :";
            this.tooltipError.SetToolTip(this.label2, "");
            this.tooltippath.SetToolTip(this.label2, "");
            this.tooltipError.SetToolTipIcon(this.label2, null);
            this.tooltippath.SetToolTipIcon(this.label2, null);
            this.tooltippath.SetToolTipTitle(this.label2, "");
            this.tooltipError.SetToolTipTitle(this.label2, "");
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // cmbovoice
            // 
            this.cmbovoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cmbovoice.DisplayFocus = true;
            this.cmbovoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbovoice.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cmbovoice.ForeColor = System.Drawing.Color.Yellow;
            this.cmbovoice.FormattingEnabled = true;
            this.cmbovoice.ItemHeight = 23;
            this.cmbovoice.Location = new System.Drawing.Point(145, 214);
            this.cmbovoice.Name = "cmbovoice";
            this.cmbovoice.Size = new System.Drawing.Size(233, 29);
            this.cmbovoice.Style = MetroFramework.MetroColorStyle.Silver;
            this.cmbovoice.TabIndex = 6;
            this.cmbovoice.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tooltippath.SetToolTip(this.cmbovoice, "");
            this.tooltipError.SetToolTip(this.cmbovoice, "");
            this.tooltipError.SetToolTipIcon(this.cmbovoice, null);
            this.tooltippath.SetToolTipIcon(this.cmbovoice, null);
            this.tooltipError.SetToolTipTitle(this.cmbovoice, "");
            this.tooltippath.SetToolTipTitle(this.cmbovoice, "");
            this.cmbovoice.UseCustomBackColor = true;
            this.cmbovoice.UseCustomForeColor = true;
            this.cmbovoice.UseSelectable = true;
            this.cmbovoice.UseStyleColors = true;
            this.cmbovoice.SelectedIndexChanged += new System.EventHandler(this.cmbovoice_SelectedIndexChanged);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Location = new System.Drawing.Point(353, -20);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.guna2CircleButton1.PressedDepth = 0;
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(59, 59);
            this.guna2CircleButton1.TabIndex = 7;
            this.tooltipError.SetToolTip(this.guna2CircleButton1, "");
            this.tooltippath.SetToolTip(this.guna2CircleButton1, "");
            this.tooltipError.SetToolTipIcon(this.guna2CircleButton1, null);
            this.tooltippath.SetToolTipIcon(this.guna2CircleButton1, null);
            this.tooltippath.SetToolTipTitle(this.guna2CircleButton1, "");
            this.tooltipError.SetToolTipTitle(this.guna2CircleButton1, "");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBoxCmd);
            this.panel1.Controls.Add(this.txtBoxPath);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 141);
            this.panel1.TabIndex = 8;
            this.tooltipError.SetToolTip(this.panel1, "");
            this.tooltippath.SetToolTip(this.panel1, "");
            this.tooltipError.SetToolTipIcon(this.panel1, null);
            this.tooltippath.SetToolTipIcon(this.panel1, null);
            this.tooltippath.SetToolTipTitle(this.panel1, "");
            this.tooltipError.SetToolTipTitle(this.panel1, "");
            // 
            // btnBrowse
            // 
            this.btnBrowse.ActiveBorderThickness = 1;
            this.btnBrowse.ActiveCornerRadius = 20;
            this.btnBrowse.ActiveFillColor = System.Drawing.Color.Gray;
            this.btnBrowse.ActiveForecolor = System.Drawing.Color.White;
            this.btnBrowse.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.BackgroundImage")));
            this.btnBrowse.ButtonText = "Browse the application";
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnBrowse.IdleBorderThickness = 1;
            this.btnBrowse.IdleCornerRadius = 20;
            this.btnBrowse.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnBrowse.IdleForecolor = System.Drawing.Color.Gray;
            this.btnBrowse.IdleLineColor = System.Drawing.Color.Gray;
            this.btnBrowse.Location = new System.Drawing.Point(15, 95);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(257, 41);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tooltippath.SetToolTip(this.btnBrowse, "");
            this.tooltipError.SetToolTip(this.btnBrowse, "");
            this.tooltippath.SetToolTipIcon(this.btnBrowse, null);
            this.tooltipError.SetToolTipIcon(this.btnBrowse, null);
            this.tooltippath.SetToolTipTitle(this.btnBrowse, "");
            this.tooltipError.SetToolTipTitle(this.btnBrowse, "");
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(16, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Application Path :";
            this.tooltipError.SetToolTip(this.label4, "");
            this.tooltippath.SetToolTip(this.label4, "");
            this.tooltipError.SetToolTipIcon(this.label4, null);
            this.tooltippath.SetToolTipIcon(this.label4, null);
            this.tooltippath.SetToolTipTitle(this.label4, "");
            this.tooltipError.SetToolTipTitle(this.label4, "");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(16, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Command String :";
            this.tooltipError.SetToolTip(this.label3, "");
            this.tooltippath.SetToolTip(this.label3, "");
            this.tooltipError.SetToolTipIcon(this.label3, null);
            this.tooltippath.SetToolTipIcon(this.label3, null);
            this.tooltippath.SetToolTipTitle(this.label3, "");
            this.tooltipError.SetToolTipTitle(this.label3, "");
            // 
            // txtBoxCmd
            // 
            this.txtBoxCmd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBoxCmd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBoxCmd.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxCmd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxCmd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBoxCmd.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxCmd.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtBoxCmd.HintText = "Command";
            this.txtBoxCmd.isPassword = false;
            this.txtBoxCmd.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxCmd.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBoxCmd.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtBoxCmd.LineThickness = 2;
            this.txtBoxCmd.Location = new System.Drawing.Point(148, 17);
            this.txtBoxCmd.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxCmd.MaxLength = 32767;
            this.txtBoxCmd.Name = "txtBoxCmd";
            this.txtBoxCmd.Size = new System.Drawing.Size(231, 33);
            this.txtBoxCmd.TabIndex = 3;
            this.txtBoxCmd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tooltipError.SetToolTip(this.txtBoxCmd, "");
            this.tooltippath.SetToolTip(this.txtBoxCmd, "");
            this.tooltipError.SetToolTipIcon(this.txtBoxCmd, null);
            this.tooltippath.SetToolTipIcon(this.txtBoxCmd, null);
            this.tooltippath.SetToolTipTitle(this.txtBoxCmd, "");
            this.tooltipError.SetToolTipTitle(this.txtBoxCmd, "");
            this.txtBoxCmd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxCmd_KeyPress);
            // 
            // txtBoxPath
            // 
            this.txtBoxPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBoxPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBoxPath.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxPath.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBoxPath.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxPath.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.txtBoxPath.HintText = "App path";
            this.txtBoxPath.isPassword = false;
            this.txtBoxPath.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxPath.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBoxPath.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtBoxPath.LineThickness = 2;
            this.txtBoxPath.Location = new System.Drawing.Point(146, 53);
            this.txtBoxPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPath.MaxLength = 32767;
            this.txtBoxPath.Name = "txtBoxPath";
            this.txtBoxPath.Size = new System.Drawing.Size(233, 33);
            this.txtBoxPath.TabIndex = 2;
            this.txtBoxPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tooltipError.SetToolTip(this.txtBoxPath, "");
            this.tooltippath.SetToolTip(this.txtBoxPath, "");
            this.tooltipError.SetToolTipIcon(this.txtBoxPath, null);
            this.tooltippath.SetToolTipIcon(this.txtBoxPath, null);
            this.tooltippath.SetToolTipTitle(this.txtBoxPath, "");
            this.tooltipError.SetToolTipTitle(this.txtBoxPath, "");
            this.txtBoxPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPath_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 20;
            this.btnSave.ActiveFillColor = System.Drawing.Color.Gray;
            this.btnSave.ActiveForecolor = System.Drawing.Color.White;
            this.btnSave.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 20;
            this.btnSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnSave.IdleForecolor = System.Drawing.Color.Gray;
            this.btnSave.IdleLineColor = System.Drawing.Color.Gray;
            this.btnSave.Location = new System.Drawing.Point(282, 95);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 41);
            this.btnSave.TabIndex = 0;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tooltippath.SetToolTip(this.btnSave, "");
            this.tooltipError.SetToolTip(this.btnSave, "");
            this.tooltippath.SetToolTipIcon(this.btnSave, null);
            this.tooltipError.SetToolTipIcon(this.btnSave, null);
            this.tooltippath.SetToolTipTitle(this.btnSave, "");
            this.tooltipError.SetToolTipTitle(this.btnSave, "");
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(18, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transparency :";
            this.tooltipError.SetToolTip(this.label1, "");
            this.tooltippath.SetToolTip(this.label1, "");
            this.tooltipError.SetToolTipIcon(this.label1, null);
            this.tooltippath.SetToolTipIcon(this.label1, null);
            this.tooltippath.SetToolTipTitle(this.label1, "");
            this.tooltipError.SetToolTipTitle(this.label1, "");
            // 
            // tooltipError
            // 
            this.tooltipError.Active = true;
            this.tooltipError.AlignTextWithTitle = false;
            this.tooltipError.AllowAutoClose = true;
            this.tooltipError.AllowFading = true;
            this.tooltipError.AutoCloseDuration = 800;
            this.tooltipError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.tooltipError.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(60)))), ((int)(((byte)(30)))));
            this.tooltipError.ClickToShowDisplayControl = false;
            this.tooltipError.ConvertNewlinesToBreakTags = true;
            this.tooltipError.DisplayControl = null;
            this.tooltipError.EntryAnimationSpeed = 350;
            this.tooltipError.ExitAnimationSpeed = 200;
            this.tooltipError.GenerateAutoCloseDuration = false;
            this.tooltipError.IconMargin = 6;
            this.tooltipError.InitialDelay = 0;
            this.tooltipError.Name = "tooltipError";
            this.tooltipError.Opacity = 1D;
            this.tooltipError.OverrideToolTipTitles = false;
            this.tooltipError.Padding = new System.Windows.Forms.Padding(10);
            this.tooltipError.ReshowDelay = 0;
            this.tooltipError.ShowAlways = true;
            this.tooltipError.ShowBorders = true;
            this.tooltipError.ShowIcons = true;
            this.tooltipError.ShowShadows = true;
            this.tooltipError.Tag = null;
            this.tooltipError.TextFont = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tooltipError.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(60)))), ((int)(((byte)(30)))));
            this.tooltipError.TextMargin = 2;
            this.tooltipError.TitleFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tooltipError.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(60)))), ((int)(((byte)(30)))));
            this.tooltipError.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.tooltipError.ToolTipTitle = "Error";
            this.tooltipError.Popup += new System.EventHandler<Bunifu.UI.WinForms.BunifuToolTip.PopupEventArgs>(this.tooltipError_Popup);
            // 
            // sliderSound
            // 
            this.sliderSound.AllowCursorChanges = true;
            this.sliderSound.AllowHomeEndKeysDetection = false;
            this.sliderSound.AllowIncrementalClickMoves = true;
            this.sliderSound.AllowMouseDownEffects = false;
            this.sliderSound.AllowMouseHoverEffects = false;
            this.sliderSound.AllowScrollingAnimations = true;
            this.sliderSound.AllowScrollKeysDetection = true;
            this.sliderSound.AllowScrollOptionsMenu = true;
            this.sliderSound.AllowShrinkingOnFocusLost = false;
            this.sliderSound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sliderSound.BackgroundImage")));
            this.sliderSound.BindingContainer = null;
            this.sliderSound.BorderRadius = 2;
            this.sliderSound.BorderThickness = 1;
            this.sliderSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderSound.DrawThickBorder = false;
            this.sliderSound.DurationBeforeShrink = 2000;
            this.sliderSound.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.sliderSound.LargeChange = 10;
            this.sliderSound.Location = new System.Drawing.Point(80, 274);
            this.sliderSound.Maximum = 100;
            this.sliderSound.Minimum = 0;
            this.sliderSound.MinimumSize = new System.Drawing.Size(0, 31);
            this.sliderSound.MinimumThumbLength = 18;
            this.sliderSound.Name = "sliderSound";
            this.sliderSound.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.sliderSound.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.sliderSound.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.sliderSound.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.sliderSound.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.sliderSound.ShrinkSizeLimit = 3;
            this.sliderSound.Size = new System.Drawing.Size(298, 31);
            this.sliderSound.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.sliderSound.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.sliderSound.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.sliderSound.SmallChange = 1;
            this.sliderSound.TabIndex = 12;
            this.sliderSound.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.sliderSound.ThumbFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.sliderSound.ThumbLength = 29;
            this.sliderSound.ThumbMargin = 1;
            this.sliderSound.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.tooltippath.SetToolTip(this.sliderSound, "");
            this.tooltipError.SetToolTip(this.sliderSound, "");
            this.tooltippath.SetToolTipIcon(this.sliderSound, null);
            this.tooltipError.SetToolTipIcon(this.sliderSound, null);
            this.tooltipError.SetToolTipTitle(this.sliderSound, "");
            this.tooltippath.SetToolTipTitle(this.sliderSound, "");
            this.sliderSound.Value = 100;
            this.sliderSound.ValueChanged += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs>(this.sliderSound_ValueChanged);
            // 
            // picBoxSound
            // 
            this.picBoxSound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxSound.BackgroundImage")));
            this.picBoxSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxSound.Location = new System.Drawing.Point(13, 261);
            this.picBoxSound.Name = "picBoxSound";
            this.picBoxSound.Size = new System.Drawing.Size(46, 41);
            this.picBoxSound.TabIndex = 13;
            this.picBoxSound.TabStop = false;
            this.tooltippath.SetToolTip(this.picBoxSound, "");
            this.tooltipError.SetToolTip(this.picBoxSound, "");
            this.tooltipError.SetToolTipIcon(this.picBoxSound, null);
            this.tooltippath.SetToolTipIcon(this.picBoxSound, null);
            this.tooltippath.SetToolTipTitle(this.picBoxSound, "");
            this.tooltipError.SetToolTipTitle(this.picBoxSound, "");
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblSound.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSound.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSound.Location = new System.Drawing.Point(77, 261);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(29, 17);
            this.lblSound.TabIndex = 14;
            this.lblSound.Text = "100";
            this.tooltipError.SetToolTip(this.lblSound, "");
            this.tooltippath.SetToolTip(this.lblSound, "");
            this.tooltipError.SetToolTipIcon(this.lblSound, null);
            this.tooltippath.SetToolTipIcon(this.lblSound, null);
            this.tooltippath.SetToolTipTitle(this.lblSound, "");
            this.tooltipError.SetToolTipTitle(this.lblSound, "");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tooltippath
            // 
            this.tooltippath.Active = true;
            this.tooltippath.AlignTextWithTitle = false;
            this.tooltippath.AllowAutoClose = true;
            this.tooltippath.AllowFading = true;
            this.tooltippath.AutoCloseDuration = 800;
            this.tooltippath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.tooltippath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(60)))), ((int)(((byte)(30)))));
            this.tooltippath.ClickToShowDisplayControl = false;
            this.tooltippath.ConvertNewlinesToBreakTags = true;
            this.tooltippath.DisplayControl = null;
            this.tooltippath.EntryAnimationSpeed = 350;
            this.tooltippath.ExitAnimationSpeed = 200;
            this.tooltippath.GenerateAutoCloseDuration = false;
            this.tooltippath.IconMargin = 6;
            this.tooltippath.InitialDelay = 0;
            this.tooltippath.Name = "tooltippath";
            this.tooltippath.Opacity = 1D;
            this.tooltippath.OverrideToolTipTitles = false;
            this.tooltippath.Padding = new System.Windows.Forms.Padding(10);
            this.tooltippath.ReshowDelay = 0;
            this.tooltippath.ShowAlways = true;
            this.tooltippath.ShowBorders = true;
            this.tooltippath.ShowIcons = false;
            this.tooltippath.ShowShadows = true;
            this.tooltippath.Tag = null;
            this.tooltippath.TextFont = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tooltippath.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(60)))), ((int)(((byte)(30)))));
            this.tooltippath.TextMargin = 2;
            this.tooltippath.TitleFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tooltippath.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(60)))), ((int)(((byte)(30)))));
            this.tooltippath.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.tooltippath.ToolTipTitle = "Error";
            this.tooltippath.Popup += new System.EventHandler<Bunifu.UI.WinForms.BunifuToolTip.PopupEventArgs>(this.tooltippath_Popup);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Title = "Browse the application";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(395, 322);
            this.Controls.Add(this.lblSound);
            this.Controls.Add(this.picBoxSound);
            this.Controls.Add(this.sliderSound);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbovoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sliderTrans);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuHSlider sliderTrans;
        private System.Windows.Forms.Label lblVal;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private MetroFramework.Controls.MetroComboBox cmbovoice;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBoxCmd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBoxPath;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBrowse;
        private Bunifu.UI.WinForms.BunifuToolTip tooltipError;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuToolTip tooltippath;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private Bunifu.UI.WinForms.BunifuHSlider sliderSound;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.PictureBox picBoxSound;
    }
}