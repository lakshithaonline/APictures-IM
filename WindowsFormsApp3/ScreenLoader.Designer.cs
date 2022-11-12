
namespace WindowsFormsApp3
{
    partial class ScreenLoader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenLoader));
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.progressbar = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(18)))));
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BorderRadius = 20;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Location = new System.Drawing.Point(0, 456);
            this.bunifuPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(1413, 170);
            this.bunifuPanel3.TabIndex = 75;
            this.bunifuPanel3.Click += new System.EventHandler(this.bunifuPanel3_Click);
            // 
            // progressbar
            // 
            this.progressbar.Animated = false;
            this.progressbar.AnimationInterval = 1;
            this.progressbar.AnimationSpeed = 1;
            this.progressbar.BackColor = System.Drawing.Color.Transparent;
            this.progressbar.CircleMargin = 10;
            this.progressbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.progressbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressbar.IsPercentage = false;
            this.progressbar.LineProgressThickness = 10;
            this.progressbar.LineThickness = 17;
            this.progressbar.Location = new System.Drawing.Point(201, 209);
            this.progressbar.Name = "progressbar";
            this.progressbar.ProgressAnimationSpeed = 200;
            this.progressbar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.progressbar.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.progressbar.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.progressbar.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.progressbar.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.progressbar.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.progressbar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.progressbar.Size = new System.Drawing.Size(216, 216);
            this.progressbar.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressbar.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.progressbar.SubScriptText = "";
            this.progressbar.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressbar.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.progressbar.SuperScriptText = "%";
            this.progressbar.TabIndex = 16;
            this.progressbar.Text = "30";
            this.progressbar.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.progressbar.Value = 30;
            this.progressbar.ValueByTransition = 30;
            this.progressbar.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.progressbar.ProgressChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs>(this.progressbar_ProgressChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(56, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 49);
            this.label1.TabIndex = 76;
            this.label1.Text = "Inventry Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 52.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 116);
            this.label2.TabIndex = 77;
            this.label2.Text = "APictures";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.Asset_2_4x;
            this.guna2PictureBox1.Location = new System.Drawing.Point(724, -6);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(1142, 545);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 78;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::WindowsFormsApp3.Properties.Resources.Untitled_3ssss;
            this.guna2PictureBox2.Location = new System.Drawing.Point(654, -6);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(416, 431);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 79;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            // 
            // ScreenLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1413, 532);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressbar);
            this.Controls.Add(this.bunifuPanel3);
            this.Controls.Add(this.guna2PictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenLoader";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScreenLoader";
            this.Load += new System.EventHandler(this.ScreenLoader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.UI.WinForms.BunifuCircleProgress progressbar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}