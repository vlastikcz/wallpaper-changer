namespace WallpaperMonsterApplication
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.chnageNow = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.periodSettings = new System.Windows.Forms.NumericUpDown();
            this.periodSettingsBefore = new System.Windows.Forms.Label();
            this.periodSettingsAfter = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wallpaperCheckBox = new System.Windows.Forms.CheckBox();
            this.lockScreenCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.periodSettings)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chnageNow
            // 
            this.chnageNow.Location = new System.Drawing.Point(82, 163);
            this.chnageNow.Name = "chnageNow";
            this.chnageNow.Size = new System.Drawing.Size(75, 23);
            this.chnageNow.TabIndex = 0;
            this.chnageNow.Text = "Change now";
            this.chnageNow.UseVisualStyleBackColor = true;
            this.chnageNow.Click += new System.EventHandler(this.changeNow_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Wallpaper Monster";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // periodSettings
            // 
            this.periodSettings.Location = new System.Drawing.Point(119, 7);
            this.periodSettings.Name = "periodSettings";
            this.periodSettings.Size = new System.Drawing.Size(57, 20);
            this.periodSettings.TabIndex = 2;
            // 
            // periodSettingsBefore
            // 
            this.periodSettingsBefore.AutoSize = true;
            this.periodSettingsBefore.Location = new System.Drawing.Point(9, 9);
            this.periodSettingsBefore.Name = "periodSettingsBefore";
            this.periodSettingsBefore.Size = new System.Drawing.Size(104, 13);
            this.periodSettingsBefore.TabIndex = 3;
            this.periodSettingsBefore.Text = "Change image every";
            // 
            // periodSettingsAfter
            // 
            this.periodSettingsAfter.AutoSize = true;
            this.periodSettingsAfter.Location = new System.Drawing.Point(182, 9);
            this.periodSettingsAfter.Name = "periodSettingsAfter";
            this.periodSettingsAfter.Size = new System.Drawing.Size(33, 13);
            this.periodSettingsAfter.TabIndex = 4;
            this.periodSettingsAfter.Text = "hours";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(163, 163);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lockScreenCheckBox);
            this.groupBox1.Controls.Add(this.wallpaperCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 44);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apply to";
            // 
            // wallpaperCheckBox
            // 
            this.wallpaperCheckBox.AutoSize = true;
            this.wallpaperCheckBox.Location = new System.Drawing.Point(24, 19);
            this.wallpaperCheckBox.Name = "wallpaperCheckBox";
            this.wallpaperCheckBox.Size = new System.Drawing.Size(74, 17);
            this.wallpaperCheckBox.TabIndex = 0;
            this.wallpaperCheckBox.Text = "Wallpaper";
            this.wallpaperCheckBox.UseVisualStyleBackColor = true;
            this.wallpaperCheckBox.CheckedChanged += new System.EventHandler(this.wallpaperCheckBox_CheckedChanged);
            // 
            // lockScreenCheckBox
            // 
            this.lockScreenCheckBox.AutoSize = true;
            this.lockScreenCheckBox.Location = new System.Drawing.Point(104, 19);
            this.lockScreenCheckBox.Name = "lockScreenCheckBox";
            this.lockScreenCheckBox.Size = new System.Drawing.Size(85, 17);
            this.lockScreenCheckBox.TabIndex = 1;
            this.lockScreenCheckBox.Text = "Lock screen";
            this.lockScreenCheckBox.UseVisualStyleBackColor = true;
            this.lockScreenCheckBox.CheckedChanged += new System.EventHandler(this.lockScreenCheckBox_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 198);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.periodSettingsAfter);
            this.Controls.Add(this.periodSettingsBefore);
            this.Controls.Add(this.periodSettings);
            this.Controls.Add(this.chnageNow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.RightToLeftLayout = true;
            this.Text = "Wallpaper Monster";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.periodSettings)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chnageNow;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.NumericUpDown periodSettings;
        private System.Windows.Forms.Label periodSettingsBefore;
        private System.Windows.Forms.Label periodSettingsAfter;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox lockScreenCheckBox;
        private System.Windows.Forms.CheckBox wallpaperCheckBox;
    }
}

