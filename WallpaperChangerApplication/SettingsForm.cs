using System;
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
        public SettingsForm()
        {
            InitializeComponent();
            periodSettings.Value = Properties.Settings.Default.timer;
        }

        private async void changeNow_Click(object sender, EventArgs e)
        {
            UnsplashImageProvider unsplahsImage = new UnsplashImageProvider();
            WebResponse webResponse = unsplahsImage.buildWebResponse(this);
            Image image = unsplahsImage.findRandomImage(webResponse);
            WallpaperImage wallpaper = new WallpaperImage();
            wallpaper.save(image);
            DesktopWallpaper.changeWallpaper(WallpaperImage.PATH);
            InMemoryRandomAccessStream ras = new InMemoryRandomAccessStream();

            using (Stream stream = unsplahsImage.findRandomImageStream(webResponse))
            {
                await stream.CopyToAsync(ras.AsStreamForWrite());
            }
            await LockScreen.SetImageStreamAsync(ras);
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
            Properties.Settings.Default.timer = periodSettings.Value;
        }

    }
}
