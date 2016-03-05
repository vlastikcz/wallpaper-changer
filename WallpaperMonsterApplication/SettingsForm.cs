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

namespace WallpaperMonsterApplication
{
    public partial class SettingsForm : Form
    {
        private WallpaperMonsterService wallpaperMonsterService;
        private WallpaperMonsterTimer wallpaperMonsterTimer;
        private WallpaperMonsterConfiguration wallpaperMonsterConfiguration;

        public SettingsForm()
        {
            InitializeComponent();
            wallpaperMonsterConfiguration = new WallpaperMonsterConfiguration();
            wallpaperMonsterService = new WallpaperMonsterService(wallpaperMonsterConfiguration, ScreenResolution.findScreenResolution(this));
            wallpaperMonsterTimer = new WallpaperMonsterTimer(wallpaperMonsterService);
            periodSettings.Value = wallpaperMonsterConfiguration.FindPeriodDecimal();
            wallpaperCheckBox.Checked = wallpaperMonsterConfiguration.FindShouldChangeWallpaper();
            lockScreenCheckBox.Checked = wallpaperMonsterConfiguration.FindShouldChangeLockScreen();
            wallpaperMonsterTimer.ChangeTimerPeriod(wallpaperMonsterConfiguration.FindPeriod());
            prepareCategoryCombobox();
        }

        private void prepareCategoryCombobox() {
            categoryComboBox.DataSource = new BindingSource(UnsplashImageProvider.categories, null);
            categoryComboBox.DisplayMember = "Key";
            categoryComboBox.ValueMember = "Value";
            categoryComboBox.SelectedValue = wallpaperMonsterConfiguration.FindCategory();
        }

        private async void changeNow_Click(object sender, EventArgs e)
        {
            wallpaperMonsterService.DoChange();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
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
            wallpaperMonsterConfiguration.ChangePeriod(periodSettings.Value);
            wallpaperMonsterConfiguration.ChangeCategory(Convert.ToString(categoryComboBox.SelectedValue));
            wallpaperMonsterConfiguration.ChangeLockScreen(lockScreenCheckBox.Checked);
            wallpaperMonsterConfiguration.ChangeWallpaper(wallpaperCheckBox.Checked);
            wallpaperMonsterConfiguration.Save();
            wallpaperMonsterTimer.ChangeTimerPeriod(wallpaperMonsterConfiguration.FindPeriod());
        }
    }
}
