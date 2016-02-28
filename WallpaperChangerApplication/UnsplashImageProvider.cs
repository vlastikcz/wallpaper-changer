using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using System.IO;

namespace WallpaperChangerApplication
{
    class UnsplashImageProvider
    {
        private const string URL = "https://source.unsplash.com/random/{0}x{1}";

        public Image FindRandomImage(Stream webResponseStream)
        {
            return Image.FromStream(webResponseStream);
        }

        public Stream FindRandomImageStream(WebResponse webResponse)
        {
            return webResponse.GetResponseStream();
        }

        public WebResponse LoadWebResponse(Rectangle dimensions) {
            string urlWithSize = string.Format(URL, dimensions.Height, dimensions.Width);
            var request = WebRequest.Create(URL);
            return request.GetResponse();
        }


    }
}
