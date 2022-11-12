namespace WindowsFormsApp3
{
    partial class Login
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.unametype1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.password = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.showpw = new Guna.UI.WinForms.GunaCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(18)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(36, 433);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(114)))), ((int)(((byte)(30)))));
            this.guna2Button1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(114)))), ((int)(((byte)(30)))));
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(413, 48);
            this.guna2Button1.TabIndex = 14;
            this.guna2Button1.Text = "Sing In";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // unametype1
            // 
            this.unametype1.BorderRadius = 10;
            this.unametype1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.unametype1.DefaultText = "";
            this.unametype1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.unametype1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.unametype1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.unametype1.DisabledState.Parent = this.unametype1;
            this.unametype1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.unametype1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.unametype1.FocusedState.Parent = this.unametype1;
            this.unametype1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unametype1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.unametype1.HoverState.Parent = this.unametype1;
            this.unametype1.Location = new System.Drawing.Point(36, 266);
            this.unametype1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.unametype1.Name = "unametype1";
            this.unametype1.PasswordChar = '\0';
            this.unametype1.PlaceholderText = "Enter Your Username";
            this.unametype1.SelectedText = "";
            this.unametype1.ShadowDecoration.Parent = this.unametype1;
            this.unametype1.Size = new System.Drawing.Size(413, 54);
            this.unametype1.TabIndex = 15;
            this.unametype1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged_1);
            // 
            // password
            // 
            this.password.BorderRadius = 10;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.DefaultText = "";
            this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.DisabledState.Parent = this.password;
            this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.FocusedState.Parent = this.password;
            this.password.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.HoverState.Parent = this.password;
            this.password.Location = new System.Drawing.Point(36, 332);
            this.password.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.PlaceholderText = "Enter Your Password";
            this.password.SelectedText = "";
            this.password.ShadowDecoration.Parent = this.password;
            this.password.Size = new System.Drawing.Size(413, 54);
            this.password.TabIndex = 16;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(36, 510);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(196, 23);
            this.guna2HtmlLabel1.TabIndex = 17;
            this.guna2HtmlLabel1.Text = "CALL US: +94 702 34 34 00";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(32, 537);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(275, 23);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "EMAIL US: apicturesgc@gmail.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(36, 207);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel4.TabIndex = 21;
            this.guna2HtmlLabel4.Text = null;
            this.guna2HtmlLabel4.Click += new System.EventHandler(this.guna2HtmlLabel4_Click);
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = global::WindowsFormsApp3.Properties.Resources.mc_red1;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::WindowsFormsApp3.Properties.Resources.sign_error_icon1;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::WindowsFormsApp3.Properties.Resources.sign_error_icon1;
            this.kryptonPalette1.ButtonSpecs.FormClose.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit;
            this.kryptonPalette1.ButtonSpecs.FormClose.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Inherit;
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = global::WindowsFormsApp3.Properties.Resources.mc_yellw;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageCheckedPressed = global::WindowsFormsApp3.Properties.Resources.mc_yellw;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImagePressed = global::WindowsFormsApp3.Properties.Resources.mc_yellw;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::WindowsFormsApp3.Properties.Resources.mc_yellw;
            this.kryptonPalette1.ButtonSpecs.FormMax.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit;
            this.kryptonPalette1.ButtonSpecs.FormMax.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Inherit;
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = global::WindowsFormsApp3.Properties.Resources.mc_green;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed = global::WindowsFormsApp3.Properties.Resources.mc_green2;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::WindowsFormsApp3.Properties.Resources.mc_green1;
            this.kryptonPalette1.ButtonSpecs.FormMin.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit;
            this.kryptonPalette1.ButtonSpecs.FormMin.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.Asset_2_4x;
            this.guna2PictureBox1.Location = new System.Drawing.Point(740, -32);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(1833, 892);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 9;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::WindowsFormsApp3.Properties.Resources.Untitled_3ssss;
            this.guna2PictureBox2.Location = new System.Drawing.Point(535, -32);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(897, 817);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 24;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // showpw
            // 
            this.showpw.BaseColor = System.Drawing.Color.White;
            this.showpw.CheckedOffColor = System.Drawing.Color.Gray;
            this.showpw.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.showpw.FillColor = System.Drawing.Color.White;
            this.showpw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpw.Location = new System.Drawing.Point(36, 395);
            this.showpw.Name = "showpw";
            this.showpw.Size = new System.Drawing.Size(174, 31);
            this.showpw.TabIndex = 25;
            this.showpw.Text = "Show Password";
            this.showpw.CheckedChanged += new System.EventHandler(this.showpw_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 106);
            this.label1.TabIndex = 26;
            this.label1.Text = "APictures";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(27, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 46);
            this.label2.TabIndex = 27;
            this.label2.Text = "Sign In Here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(31, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(590, 28);
            this.label3.TabIndex = 28;
            this.label3.Text = "Apictures, serve you for the last 31+ years. We are an independent,";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(31, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(436, 28);
            this.label4.TabIndex = 29;
            this.label4.Text = "leading high quality electronics shop in Sri Lanka";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1683, 828);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showpw);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.unametype1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2PictureBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1701, 875);
            this.MinimumSize = new System.Drawing.Size(1701, 875);
            this.Name = "Login";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox unametype1;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Guna.UI.WinForms.GunaCheckBox showpw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

