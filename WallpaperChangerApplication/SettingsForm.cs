﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Storage.Streams;
using Windows.System.UserProfile;

namespace WallpaperChangerApplication
{
    public partial class SettingsForm : Form
    {
        private WallpaperChangerService wallpaperChangerService;
        private WallpaperChangerTimer wallpaperChangerTimer;
        private WallpaperChangerConfiguration wallpaperChangerConfiguration;

        public SettingsForm()
        {
            InitializeComponent();
            wallpaperChangerService = new WallpaperChangerService(ScreenResolution.findScreenResolution(this));
            wallpaperChangerTimer = new WallpaperChangerTimer(wallpaperChangerService);
            wallpaperChangerConfiguration = new WallpaperChangerConfiguration();
            periodSettings.Value = wallpaperChangerConfiguration.findPeriodDecimal();
            wallpaperChangerTimer.ChangeTimerPeriod(wallpaperChangerConfiguration.findPeriod());
        }

        private async void changeNow_Click(object sender, EventArgs e)
        {
            wallpaperChangerService.DoChange();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

 
    private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            wallpaperChangerConfiguration.savePeriod(periodSettings.Value);
            wallpaperChangerTimer.ChangeTimerPeriod(wallpaperChangerConfiguration.findPeriod());
        }

    }
}
