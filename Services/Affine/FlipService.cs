using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV;
using LR2.Interfaces;

namespace LR2.Services.Affine
{
    internal class FlipService : IAffineOperation
    {
        private bool reflectHorizontally, reflectVertically;

        public FlipService(bool reflectHorizontally, bool reflectVertically)
        {
            this.reflectHorizontally = reflectHorizontally;
            this.reflectVertically = reflectVertically;
        }

        public Image<Bgr, byte> Apply(Image<Bgr, byte> image)
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
