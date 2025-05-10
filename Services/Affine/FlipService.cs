using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV;

namespace LR2.Services.Affine
{
    internal class FlipService
    {
        public static Image<Bgr, byte> FlipImage(Image<Bgr, byte> image, bool reflectHorizontally, bool reflectVertically)
        {
            var reflected = new Image<Bgr, byte>(image.Size);

            FlipType flipCode;
            if (reflectHorizontally && reflectVertically)
                flipCode = FlipType.Both;
            else if (reflectHorizontally)
                flipCode = FlipType.Horizontal;
            else
                flipCode = FlipType.Vertical;

            CvInvoke.Flip(image, reflected, flipCode);
            return reflected;
        }
    }
}
