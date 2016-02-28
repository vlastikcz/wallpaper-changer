using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Runtime;
using System.Threading.Tasks;
using Windows.Storage;
using System.Net;
using Windows.System.UserProfile;
using System.IO.IsolatedStorage;
using Windows.UI.Xaml.Media.Imaging;

namespace WallpaperChangerApplication
{
    class WallpaperImage
    {
        public static string PATH = Path.Combine(Path.GetTempPath(), "wallpaper.jpg");

        public void Save(Image image)
        {
            image.Save(PATH, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }

}
