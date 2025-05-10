using Emgu.CV.Structure;
using Emgu.CV;
using LR2.Models;

namespace LR2.Services.Affine
{
    internal class ShearService
    {
        public static Image<Bgr, byte> ShearCv(Image<Bgr, byte> image, float shift, ShearDirection direction)
        {
            var newSize = CalculateNewSize(image, shift, direction, out var offsetX, out var offsetY);
            var newImage = new Image<Bgr, byte>(newSize.Width, newSize.Height);
            newImage.SetZero();

            ApplyShear(image, newImage, shift, direction, offsetX, offsetY);

            return newImage;
        }

        private static (int Width, int Height) CalculateNewSize(Image<Bgr, byte> image, float shift, ShearDirection direction, out int offsetX, out int offsetY)
        {
            int width = image.Width;
            int height = image.Height;
            offsetX = 0;
            offsetY = 0;

            switch (direction)
            {
                case ShearDirection.Top:
                    offsetY = (int)Math.Abs(shift * image.Width);
                    height += offsetY;
                    break;
                case ShearDirection.Bottom:
                    height += (int)Math.Abs(shift * image.Width);
                    break;
                case ShearDirection.Left:
                    offsetX = (int)Math.Abs(shift * image.Height);
                    width += offsetX;
                    break;
                case ShearDirection.Right:
                    width += (int)Math.Abs(shift * image.Height);
                    break;
            }

            return (width, height);
        }

        private static void ApplyShear(Image<Bgr, byte> source, Image<Bgr, byte> target, float shift, ShearDirection direction, int offsetX, int offsetY)
        {
            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    var (newX, newY) = CalculateNewCoordinates(x, y, shift, direction, source.Width, source.Height);

                    newX += offsetX;
                    newY += offsetY;

                    if (newX >= 0 && newX < target.Width && newY >= 0 && newY < target.Height)
                    {
                        target[newY, newX] = source[y, x];
                    }
                }
            }
        }

        private static (int NewX, int NewY) CalculateNewCoordinates(int x, int y, float shift, ShearDirection direction, int width, int height)
        {
            int newX = x;
            int newY = y;

            switch (direction)
            {
                case ShearDirection.Top:
                    newY = y - (int)(shift * (width - x));
                    break;
                case ShearDirection.Bottom:
                    newY = y + (int)(shift * (width - x));
                    break;
                case ShearDirection.Left:
                    newX = x - (int)(shift * (height - y));
                    break;
                case ShearDirection.Right:
                    newX = x + (int)(shift * (height - y));
                    break;
            }

            return (newX, newY);
        }
    }
}
