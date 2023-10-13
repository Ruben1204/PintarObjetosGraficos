using System.Text;
using System.Threading.Tasks;
#if IOS || ANDROID || MACCATALYST
using Microsoft.Maui.Graphics.Platform;
#elif WINDOWS
using Microsoft.Maui.Graphics.Win2D;
#endif
using System.Reflection;
using IImage = Microsoft.Maui.Graphics.IImage;

using System.Security.Cryptography.X509Certificates;

namespace PintarObjetos.Graficos
{
    public class PintarConImagen : IDrawable
    {
        IImage image;

        public PintarConImagen()
        {
            Assembly assembly = GetType().GetTypeInfo().Assembly;
            using (Stream stream = assembly.GetManifestResourceStream("PintarObjetos.Resources.Images.DibujoPrueba.jpg"))
            {
#if IOS || ANDROID || MACCATALYST
                // PlatformImage isn't currently supported on Windows.
                image = PlatformImage.FromStream(stream);
#elif WINDOWS
    image = new W2DImageLoadingService().FromStream(stream);
#endif
            }
        }

        public void Draw(ICanvas superficie, Microsoft.Maui.Graphics.RectF dirtyRect)
        {

            ImagePaint imagePaint = new ImagePaint
            {
                Image = image.Downsize(100)
            };

            superficie.SetFillPaint(imagePaint, RectF.Zero);
            superficie.FillRectangle(0, 0, 440, 300);
           


        }
    }
}
