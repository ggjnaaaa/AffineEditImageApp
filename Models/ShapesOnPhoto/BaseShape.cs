using Emgu.CV;
using Emgu.CV.Structure;

namespace LR2.Models.ShapesOnPhoto
{
    public abstract class BaseShape
    {
        private readonly int _verticlesCount;
        private readonly Point[] _points;
        private int _currentIndex = 0;
        private int _count = 0;

        protected BaseShape(int verticlesCount)
        {
            _verticlesCount = verticlesCount;
            _points = new Point[verticlesCount];
        }

        public List<Point> AddPoint(Point point)
        {
            _points[_currentIndex % _verticlesCount] = point;
            _currentIndex++;
            if (_count < _verticlesCount)
                _count++;

            return GetPoints();
        }

        public void ClearPoints()
        {
            _currentIndex = 0;
            _count = 0;
            Array.Clear(_points, 0, _verticlesCount);
        }

        public List<Point> GetPoints()
        {
            var orderedPoints = new List<Point>();
            int start = _currentIndex >= _verticlesCount ? _currentIndex % _verticlesCount : 0;

            for (int i = 0; i < _count; i++)
            {
                int index = (start + i) % _verticlesCount;
                orderedPoints.Add(_points[index]);
            }

            return orderedPoints;
        }

        public abstract void DrawShape(Image<Bgr, byte> image);
    }
}
