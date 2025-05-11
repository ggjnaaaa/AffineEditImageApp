using Emgu.CV.Structure;
using Emgu.CV;
using LR2.Services.Affine;
using LR2.Models;
using LR2.Interfaces;

namespace LR2.Services
{
    internal class AffineFacade
    {
        public static Image<Bgr, byte> Scale(Image<Bgr, byte> image, int scaleX, int scaleY) => ApplyAffineOperation(image, new ScaleService(scaleX, scaleY));
        public static Image<Bgr, byte> Shear(Image<Bgr, byte> image, float shift, ShearDirection direction) => ApplyAffineOperation(image, new ShearService(shift, direction));
        public static Image<Bgr, byte> Rotate(Image<Bgr, byte> image, float angleDegrees, Point center) => ApplyAffineOperation(image, new RotateService(angleDegrees, center));
        public static Image<Bgr, byte> Flip(Image<Bgr, byte> image, bool reflectHorizontally, bool reflectVertically) => ApplyAffineOperation(image, new FlipService(reflectHorizontally, reflectVertically));
        public static Image<Bgr, byte> Homography(Image<Bgr, byte> image, Point[] sourcePoints) => ApplyAffineOperation(image, new HomographyService(sourcePoints));

        private static Image<Bgr, byte> ApplyAffineOperation(Image<Bgr, byte> image, IAffineOperation operation)
        {
            return operation.Apply(image);
        }
    }
}
