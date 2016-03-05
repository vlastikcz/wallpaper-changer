using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallpaperMonsterApplication
{
    class WallpaperMonsterConfiguration
    {
        public Double findPeriod() {
            return Convert.ToDouble(findPeriodDecimal());
        }

        public Decimal findPeriodDecimal()
        {
            return Properties.Settings.Default.timer;
        }

        public void savePeriod(Decimal period) {
            Properties.Settings.Default.timer = period;
            Properties.Settings.Default.Save();
        }
    }
}
