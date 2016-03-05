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

namespace WallpaperMonsterApplication
{
    class WallpaperMonsterService
    {
        private Rectangle dimensions;
        private WallpaperMonsterConfiguration wallpaperMonsterConfiguration;

        public WallpaperMonsterService(WallpaperMonsterConfiguration wallpaperMonsterConfiguration, Rectangle dimensions) {
            this.dimensions = dimensions;
            this.wallpaperMonsterConfiguration = wallpaperMonsterConfiguration;
        }

        public async void DoChange() {
            UnsplashImageProvider unsplahsImage = new UnsplashImageProvider();
            WebResponse webResponse = unsplahsImage.LoadWebResponse(dimensions);
            InMemoryRandomAccessStream randomAccessStream = new InMemoryRandomAccessStream();
            using (Stream stream = unsplahsImage.FindRandomImageStream(webResponse))
            {
                Stream memoryStream = new MemoryStream();
                await stream.CopyToAsync(memoryStream);
                memoryStream.Position = 0;
                await memoryStream.CopyToAsync(randomAccessStream.AsStreamForWrite());
                memoryStream.Position = 0;
                if (wallpaperMonsterConfiguration.FindShouldChangeWallpaper()) {
                    ChangeWallpaper(unsplahsImage, memoryStream);
                }
            }

            if (wallpaperMonsterConfiguration.FindShouldChangeLockScreen()) {
                ChangeLockScreen(randomAccessStream);
            }
        }

        private void ChangeWallpaper(UnsplashImageProvider unsplahsImage, Stream imageStream) {
            Image image = unsplahsImage.FindRandomImage(imageStream);
            WallpaperImage wallpaper = new WallpaperImage();
            wallpaper.Save(image);
            DesktopWallpaper.ChangeWallpaper(WallpaperImage.PATH);
        }

        public async void ChangeLockScreen(InMemoryRandomAccessStream randomAccessStream)
        {
            await LockScreen.SetImageStreamAsync(randomAccessStream);
        }

    }
}
