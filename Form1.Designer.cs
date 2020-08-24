namespace updater
{
    partial class ULauncher
    {
        
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ULauncher));
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.text1 = new MetroFramework.Controls.MetroLabel();
            this.text2 = new MetroFramework.Controls.MetroLabel();
            this.launch = new MetroFramework.Controls.MetroButton();
            this.nick = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.memText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.JavaPatchText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.widthText = new MetroFramework.Controls.MetroTextBox();
            this.heightText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroProgressSpinner1
            // 
            resources.ApplyResources(this.metroProgressSpinner1, "metroProgressSpinner1");
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroProgressSpinner1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroProgressSpinner1.UseSelectable = true;
            // 
            // text1
            // 
            resources.ApplyResources(this.text1, "text1");
            this.text1.Name = "text1";
            this.text1.Style = MetroFramework.MetroColorStyle.White;
            this.text1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // text2
            // 
            resources.ApplyResources(this.text2, "text2");
            this.text2.Name = "text2";
            this.text2.Style = MetroFramework.MetroColorStyle.White;
            this.text2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.text2.Click += new System.EventHandler(this.text2_Click);
            // 
            // launch
            // 
            this.launch.FontSize = MetroFramework.MetroButtonSize.Medium;
            resources.ApplyResources(this.launch, "launch");
            this.launch.Name = "launch";
            this.launch.Style = MetroFramework.MetroColorStyle.Teal;
            this.launch.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.launch.UseSelectable = true;
            this.launch.Click += new System.EventHandler(this.launch_Click);
            // 
            // nick
            // 
            // 
            // 
            // 
            this.nick.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.nick.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.nick.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.nick.CustomButton.Name = "";
            this.nick.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.nick.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nick.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.nick.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nick.CustomButton.UseSelectable = true;
            this.nick.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.nick.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.nick.Lines = new string[0];
            resources.ApplyResources(this.nick, "nick");
            this.nick.MaxLength = 32767;
            this.nick.Name = "nick";
            this.nick.PasswordChar = '\0';
            this.nick.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nick.SelectedText = "";
            this.nick.SelectionLength = 0;
            this.nick.SelectionStart = 0;
            this.nick.ShortcutsEnabled = true;
            this.nick.Style = MetroFramework.MetroColorStyle.Teal;
            this.nick.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.nick.UseSelectable = true;
            this.nick.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nick.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ULauncher.Properties.Resources.imgonline_com_ua_Blur_gArSNi1vUDSW;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            resources.ApplyResources(this.metroTabControl1, "metroTabControl1");
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.launch);
            this.metroTabPage1.Controls.Add(this.nick);
            this.metroTabPage1.Controls.Add(this.pictureBox2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.metroTabPage1, "metroTabPage1");
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroButton2);
            this.metroTabPage2.Controls.Add(this.metroButton1);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.heightText);
            this.metroTabPage2.Controls.Add(this.widthText);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.JavaPatchText);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.memText);
            this.metroTabPage2.Controls.Add(this.pictureBox1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.metroTabPage2, "metroTabPage2");
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ULauncher.Properties.Resources.imgonline_com_ua_Blur_gArSNi1vUDSW;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // memText
            // 
            // 
            // 
            // 
            this.memText.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.memText.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location4")));
            this.memText.CustomButton.Name = "";
            this.memText.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size4")));
            this.memText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.memText.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex4")));
            this.memText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.memText.CustomButton.UseSelectable = true;
            this.memText.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible4")));
            this.memText.Lines = new string[] {
        "6144"};
            resources.ApplyResources(this.memText, "memText");
            this.memText.MaxLength = 32767;
            this.memText.Name = "memText";
            this.memText.PasswordChar = '\0';
            this.memText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memText.SelectedText = "";
            this.memText.SelectionLength = 0;
            this.memText.SelectionStart = 0;
            this.memText.ShortcutsEnabled = true;
            this.memText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.memText.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.memText.UseSelectable = true;
            this.memText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.memText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.memText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.memText_KeyPress);
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // JavaPatchText
            // 
            // 
            // 
            // 
            this.JavaPatchText.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.JavaPatchText.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode3")));
            this.JavaPatchText.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location3")));
            this.JavaPatchText.CustomButton.Name = "";
            this.JavaPatchText.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size3")));
            this.JavaPatchText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.JavaPatchText.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex3")));
            this.JavaPatchText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.JavaPatchText.CustomButton.UseSelectable = true;
            this.JavaPatchText.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible3")));
            this.JavaPatchText.Lines = new string[] {
        "javaw.exe"};
            resources.ApplyResources(this.JavaPatchText, "JavaPatchText");
            this.JavaPatchText.MaxLength = 32767;
            this.JavaPatchText.Name = "JavaPatchText";
            this.JavaPatchText.PasswordChar = '\0';
            this.JavaPatchText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.JavaPatchText.SelectedText = "";
            this.JavaPatchText.SelectionLength = 0;
            this.JavaPatchText.SelectionStart = 0;
            this.JavaPatchText.ShortcutsEnabled = true;
            this.JavaPatchText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.JavaPatchText.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.JavaPatchText.UseSelectable = true;
            this.JavaPatchText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.JavaPatchText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            resources.ApplyResources(this.metroLabel2, "metroLabel2");
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // widthText
            // 
            // 
            // 
            // 
            this.widthText.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.widthText.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode2")));
            this.widthText.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location2")));
            this.widthText.CustomButton.Name = "";
            this.widthText.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size2")));
            this.widthText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.widthText.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex2")));
            this.widthText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.widthText.CustomButton.UseSelectable = true;
            this.widthText.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible2")));
            this.widthText.Lines = new string[] {
        "925"};
            resources.ApplyResources(this.widthText, "widthText");
            this.widthText.MaxLength = 32767;
            this.widthText.Name = "widthText";
            this.widthText.PasswordChar = '\0';
            this.widthText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.widthText.SelectedText = "";
            this.widthText.SelectionLength = 0;
            this.widthText.SelectionStart = 0;
            this.widthText.ShortcutsEnabled = true;
            this.widthText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.widthText.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.widthText.UseSelectable = true;
            this.widthText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.widthText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.widthText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.memText_KeyPress);
            this.widthText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.widthText_KeyUp);
            // 
            // heightText
            // 
            // 
            // 
            // 
            this.heightText.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.heightText.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.heightText.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.heightText.CustomButton.Name = "";
            this.heightText.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.heightText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.heightText.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.heightText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.heightText.CustomButton.UseSelectable = true;
            this.heightText.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.heightText.Lines = new string[] {
        "530"};
            resources.ApplyResources(this.heightText, "heightText");
            this.heightText.MaxLength = 32767;
            this.heightText.Name = "heightText";
            this.heightText.PasswordChar = '\0';
            this.heightText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.heightText.SelectedText = "";
            this.heightText.SelectionLength = 0;
            this.heightText.SelectionStart = 0;
            this.heightText.ShortcutsEnabled = true;
            this.heightText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.heightText.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.heightText.UseSelectable = true;
            this.heightText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.heightText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.heightText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.memText_KeyPress);
            // 
            // metroLabel3
            // 
            resources.ApplyResources(this.metroLabel3, "metroLabel3");
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            resources.ApplyResources(this.metroLabel4, "metroLabel4");
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton1
            // 
            resources.ApplyResources(this.metroButton1, "metroButton1");
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // metroButton2
            // 
            resources.ApplyResources(this.metroButton2, "metroButton2");
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            // 
            // ULauncher
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.MaximizeBox = false;
            this.Name = "ULauncher";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroLabel text1;
        private MetroFramework.Controls.MetroLabel text2;
        private MetroFramework.Controls.MetroButton launch;
        private MetroFramework.Controls.MetroTextBox nick;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox memText;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox JavaPatchText;
        private MetroFramework.Controls.MetroTextBox heightText;
        private MetroFramework.Controls.MetroTextBox widthText;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}

