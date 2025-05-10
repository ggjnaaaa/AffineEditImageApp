using Emgu.CV;
using Emgu.CV.Structure;

namespace LR2.Models.ShapesOnPhoto
{
    internal class PointShape : BaseShape
    {
        public PointShape() : base(1)
        {
        }
        public override void DrawShape(Image<Bgr, byte> image)
        {
            var pts = GetPoints();
            if (pts.Count == 1)
            {
                Point center = pts[0];
                int radius = 10;
                int thickness = -1;
                image.Draw(new CircleF(center, radius), new Bgr(Color.White), thickness);
                image.Draw(new CircleF(center, radius-2), new Bgr(Color.Black), thickness);
            }
        }

    }
}
