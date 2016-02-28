namespace WallpaperChangerApplication
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
            ((System.ComponentModel.ISupportInitialize)(this.periodSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // chnageNow
            // 
            this.chnageNow.Location = new System.Drawing.Point(82, 44);
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
            this.periodSettings.Location = new System.Drawing.Point(136, 7);
            this.periodSettings.Name = "periodSettings";
            this.periodSettings.Size = new System.Drawing.Size(57, 20);
            this.periodSettings.TabIndex = 2;
            // 
            // periodSettingsBefore
            // 
            this.periodSettingsBefore.AutoSize = true;
            this.periodSettingsBefore.Location = new System.Drawing.Point(9, 9);
            this.periodSettingsBefore.Name = "periodSettingsBefore";
            this.periodSettingsBefore.Size = new System.Drawing.Size(121, 13);
            this.periodSettingsBefore.TabIndex = 3;
            this.periodSettingsBefore.Text = "Change wallpaper every";
            // 
            // periodSettingsAfter
            // 
            this.periodSettingsAfter.AutoSize = true;
            this.periodSettingsAfter.Location = new System.Drawing.Point(199, 9);
            this.periodSettingsAfter.Name = "periodSettingsAfter";
            this.periodSettingsAfter.Size = new System.Drawing.Size(33, 13);
            this.periodSettingsAfter.TabIndex = 4;
            this.periodSettingsAfter.Text = "hours";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(163, 44);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 77);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.periodSettingsAfter);
            this.Controls.Add(this.periodSettingsBefore);
            this.Controls.Add(this.periodSettings);
            this.Controls.Add(this.chnageNow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.RightToLeftLayout = true;
            this.Text = "WallpaperChanger";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.periodSettings)).EndInit();
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
    }
}

