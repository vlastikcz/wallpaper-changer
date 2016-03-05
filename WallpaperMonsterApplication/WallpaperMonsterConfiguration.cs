using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallpaperMonsterApplication
{
    class WallpaperMonsterConfiguration
    {
        public Double FindPeriod() {
            return Convert.ToDouble(FindPeriodDecimal());
        }

        public Decimal FindPeriodDecimal()
        {
            return Properties.Settings.Default.timer;
        }

        public Boolean FindShouldChangeWallpaper() {
            return Properties.Settings.Default.changeWallpaper;
        }

        public Boolean FindShouldChangeLockScreen()
        {
            return Properties.Settings.Default.changeLockScreen;
        }

        public void ChangePeriod(Decimal period) {
            Properties.Settings.Default.timer = period;
        }

        public void ChangeWallpaper(Boolean changeWallpaper)
        {
            Properties.Settings.Default.changeWallpaper = changeWallpaper;
        }

        public void ChangeLockScreen(Boolean changeLockScreen)
        {
            Properties.Settings.Default.changeLockScreen = changeLockScreen;
        }

        public void Save() { 
            Properties.Settings.Default.Save();
        }
    }
}
