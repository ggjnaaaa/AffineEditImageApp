using Emgu.CV.Structure;
using Emgu.CV;

namespace LR2.Services.Affine
{
    internal class HomographyService
    {
        public static Image<Bgr, byte> ApplyHomography(Image<Bgr, byte> sourceImage, Point[] sourcePoints)
        {
            var destinationSize = sourceImage.Size;

            // Преобразуем Point[] → PointF[]
            var srcPoints = sourcePoints.Select(p => new PointF(p.X, p.Y)).ToArray();

            var destPoints = new PointF[]
            {
                new PointF(0, 0),
                new PointF(0, destinationSize.Height - 1),
                new PointF(destinationSize.Width - 1, destinationSize.Height - 1),
                new PointF(destinationSize.Width - 1, 0)
            };

            var homographyMatrix = CvInvoke.GetPerspectiveTransform(srcPoints, destPoints);
            var destImage = new Image<Bgr, byte>(destinationSize);
            CvInvoke.WarpPerspective(sourceImage, destImage, homographyMatrix, destinationSize);

            return destImage;
        }
    }
}
