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
    class UnsplashImage
    {
        const String URL = "https://source.unsplash.com/random/{0}x{1}";

        public Image findRandomImage(Form form)
        {
            return findRandomImage(ScreenResolution.findScreenResolution(form));
        }

        public Stream findRandomImageStream(Form form)
        {
            return findRandomImageStream(ScreenResolution.findScreenResolution(form));
        }

        private Image findRandomImage(Rectangle rectangle)
        {
            Image image;
            String urlWithSize = String.Format(URL, rectangle.Height, rectangle.Width);
            var request = WebRequest.Create(URL);
            var response = request.GetResponse();
            using (var stream = response.GetResponseStream())
            {
                image = Image.FromStream(stream);
            }
            return image;
        }

        private Stream findRandomImageStream(Rectangle rectangle)
        {
            Image image;
            String urlWithSize = String.Format(URL, rectangle.Height, rectangle.Width);
            var request = WebRequest.Create(URL);
            var response = request.GetResponse();
            return response.GetResponseStream();
        }
    }
}
