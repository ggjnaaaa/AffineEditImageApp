using Emgu.CV.Structure;
using Emgu.CV;
using LR2.Services.Affine;
using LR2.Models;

namespace LR2.Services
{
    internal class AffineFacade
    {
        public static Image<Bgr, byte> Scale(Image<Bgr, byte> image, int scaleX, int scaleY) => ScaleService.ScaleCv(image, scaleX, scaleY);
        public static Image<Bgr, byte> Shear(Image<Bgr, byte> image, float shift, ShearDirection direction) => ShearService.ShearCv(image, shift, direction);
        public static Image<Bgr, byte> Rotate(Image<Bgr, byte> image, float angleDegrees, Point center) => RotateService.RotateImage(image, angleDegrees, center);
        public static Image<Bgr, byte> Flip(Image<Bgr, byte> image, bool reflectHorizontally, bool reflectVertically) => FlipService.FlipImage(image, reflectHorizontally, reflectVertically);
        public static Image<Bgr, byte> Homography(Image<Bgr, byte> sourceImage, Point[] sourcePoints) => HomographyService.ApplyHomography(sourceImage, sourcePoints);
    }
}
