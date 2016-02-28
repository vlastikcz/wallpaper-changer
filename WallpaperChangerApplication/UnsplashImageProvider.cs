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
        const String URL = "https://source.unsplash.com/random/{0}x{1}";

        public Image findRandomImage(WebResponse webResponse)
        {
            Image image;
            using (var stream = findRandomImageStream(webResponse))
            {
                image = Image.FromStream(stream);
            }
            return image;
        }

        public Stream findRandomImageStream(WebResponse webResponse)
        {
            return webResponse.GetResponseStream();
        }

        public WebResponse buildWebResponse(Form form) {
            Rectangle rectangle = ScreenResolution.findScreenResolution(form);
            String urlWithSize = String.Format(URL, rectangle.Height, rectangle.Width);
            var request = WebRequest.Create(URL);
            return request.GetResponse();
        }


    }
}
