using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using System.IO;
using System.Collections.ObjectModel;

namespace WallpaperMonsterApplication
{

    class UnsplashImageProvider
    {
        public static readonly IList<KeyValuePair<string, string>> categories = new ReadOnlyCollection<KeyValuePair<string, string>>(new List<KeyValuePair<string, string>> {
            new KeyValuePair<string, string>("Random", "random"),
            new KeyValuePair<string, string>("Building", "category/building"),
            new KeyValuePair<string, string>("Food", "category/food"),
            new KeyValuePair<string, string>("Nature", "category/nature"),
            new KeyValuePair<string, string>("People", "category/people"),
            new KeyValuePair<string, string>("Technology", "category/technology"),
            new KeyValuePair<string, string>("Objects", "category/objects"),
        });

        private const string URL = "https://source.unsplash.com/{0}/{1}x{2}";

        private WallpaperMonsterConfiguration wallpaperMonsterConfiguration;

        public UnsplashImageProvider(WallpaperMonsterConfiguration wallpaperMonsterConfiguration) {
            this.wallpaperMonsterConfiguration = wallpaperMonsterConfiguration;
        }

        public Image FindRandomImage(Stream webResponseStream)
        {
            return Image.FromStream(webResponseStream);
        }

        public Stream FindRandomImageStream(WebResponse webResponse)
        {
            return webResponse.GetResponseStream();
        }

        public WebResponse LoadWebResponse(Rectangle dimensions) {
            string urlWithSize = string.Format(URL, wallpaperMonsterConfiguration.FindCategory(), dimensions.Height, dimensions.Width);
            var request = WebRequest.Create(urlWithSize);
            return request.GetResponse();
        }


    }
}