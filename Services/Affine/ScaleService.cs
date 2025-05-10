using Emgu.CV.Structure;
using Emgu.CV;

namespace LR2.Services.Affine
{
    internal class ScaleService
    {
        public static Image<Bgr, byte> ScaleCv(Image<Bgr, byte> image, int scaleX, int scaleY)
        {
            int newWidth = image.Width + scaleX;
            int newHeight = image.Height + scaleY;

            if (newWidth <= 0 || newHeight <= 0)
                throw new ArgumentException("Масштаб слишком мал");

            float ratioX = (float)image.Width / newWidth;
            float ratioY = (float)image.Height / newHeight;

            var newImage = new Image<Bgr, byte>(newWidth, newHeight);

            for (int y = 0; y < newHeight; y++)
            {
                for (int x = 0; x < newWidth; x++)
                {
                    int srcX = (int)(x * ratioX);
                    int srcY = (int)(y * ratioY);

                    if (srcX >= 0 && srcX < image.Width && srcY >= 0 && srcY < image.Height)
                    {
                        newImage[y, x] = image[srcY, srcX];
                    }
                }
            }

            return newImage;
        }
    }
}
