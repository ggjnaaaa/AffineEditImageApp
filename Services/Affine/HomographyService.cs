using Emgu.CV.Structure;
using Emgu.CV;
using LR2.Interfaces;

namespace LR2.Services.Affine
{
    internal class HomographyService : IAffineOperation
    {
        private Point[] sourcePoints;

        public HomographyService(Point[] sourcePoints)
        {
            this.sourcePoints = sourcePoints;
        }

        public Image<Bgr, byte> Apply(Image<Bgr, byte> image)
        {
            var destinationSize = image.Size;

            // Преобразуем Point[] в PointF[]
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
            CvInvoke.WarpPerspective(image, destImage, homographyMatrix, destinationSize);

            return destImage;
        }
    }
}
