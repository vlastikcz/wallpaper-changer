using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.Streams;
using Windows.System.UserProfile;

namespace WallpaperChangerApplication
{
    class WallpaperChangerService
    {
        private Rectangle dimensions;

        public WallpaperChangerService(Rectangle dimensions) {
            this.dimensions = dimensions;
        }

        public async void DoChange() {
            UnsplashImageProvider unsplahsImage = new UnsplashImageProvider();
            WebResponse webResponse = unsplahsImage.LoadWebResponse(dimensions);
            InMemoryRandomAccessStream ras = new InMemoryRandomAccessStream();
            using (Stream stream = unsplahsImage.FindRandomImageStream(webResponse))
            {
                Stream memoryStream = new MemoryStream();
                await stream.CopyToAsync(memoryStream);
                memoryStream.Position = 0;
                await memoryStream.CopyToAsync(ras.AsStreamForWrite());
                memoryStream.Position = 0;
                Image image = unsplahsImage.FindRandomImage(memoryStream);
                WallpaperImage wallpaper = new WallpaperImage();
                wallpaper.Save(image);
            }
            DesktopWallpaper.ChangeWallpaper(WallpaperImage.PATH);
            await LockScreen.SetImageStreamAsync(ras);
        }
    }
}
