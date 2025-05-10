using Emgu.CV.Structure;
using Emgu.CV;

namespace LR2.Services.Affine
{
    internal class RotateService
    {
        public static Image<Bgr, byte> RotateImage(Image<Bgr, byte> image, float angleDegrees, Point center)
        {
            using var rotationMatrix = new Mat();
            CvInvoke.GetRotationMatrix2D(center, angleDegrees, 1.0, rotationMatrix);

            var matrix = new Matrix<double>(2, 3);
            rotationMatrix.CopyTo(matrix);

            int width = image.Width;
            int height = image.Height;

            var corners = new[]
            {
                TransformPoint(matrix, new Point(0, 0)),
                TransformPoint(matrix, new Point(width, 0)),
                TransformPoint(matrix, new Point(0, height)),
                TransformPoint(matrix, new Point(width, height))
            };

            var minX = corners.Min(p => p.X);
            var maxX = corners.Max(p => p.X);
            var minY = corners.Min(p => p.Y);
            var maxY = corners.Max(p => p.Y);

            int newWidth = (int)Math.Ceiling(maxX - minX);
            int newHeight = (int)Math.Ceiling(maxY - minY);

            matrix[0, 2] -= minX;
            matrix[1, 2] -= minY;

            var rotated = new Image<Bgr, byte>(newWidth, newHeight);
            CvInvoke.WarpAffine(image, rotated, matrix, new Size(newWidth, newHeight));
            return rotated;
        }

        private static PointF TransformPoint(Matrix<double> matrix, Point pt)
        {
            float x = (float)(matrix[0, 0] * pt.X + matrix[0, 1] * pt.Y + matrix[0, 2]);
            float y = (float)(matrix[1, 0] * pt.X + matrix[1, 1] * pt.Y + matrix[1, 2]);
            return new PointF(x, y);
        }
    }
}
