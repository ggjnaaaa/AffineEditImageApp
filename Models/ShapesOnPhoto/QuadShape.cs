using Emgu.CV;
using Emgu.CV.Structure;

namespace LR2.Models.ShapesOnPhoto
{
    internal class QuadShape : BaseShape
    {
        public QuadShape() : base(4)
        {
        }


        public override void DrawShape(Image<Bgr, byte> image)
        {
            var pts = GetPoints();
            if (pts.Count == 4)
            {
                var color = new Bgr(Color.Green);
                int thickness = 2;

                for (int i = 0; i < 4; i++)
                {
                    Point p1 = pts[i];
                    Point p2 = pts[(i + 1) % 4];
                    image.Draw(new LineSegment2D(p1, p2), color, thickness);
                }
            }
            else
            {
                int radius = 3;
                int thickness = -1;

                foreach (var p in pts)
                {
                    image.Draw(new CircleF(p, radius), new Bgr(Color.White), thickness);
                    image.Draw(new CircleF(p, radius - 2), new Bgr(Color.Black), thickness);
                }
            }
        }

    }
}
