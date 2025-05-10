using Emgu.CV.Structure;
using Emgu.CV;
using LR2.Services;
using LR2.Interfaces;

namespace LR2.Models
{
    public class ImageEditor : IImageEditor
    {
        private Image<Bgr, byte> _original;
        private Image<Bgr, byte> _transformed;

        public Image<Bgr, byte> Original => _original;
        public Image<Bgr, byte> Transformed => _transformed;

        private static ImageEditor _instance;

        private ImageEditor() { }

        public static ImageEditor GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ImageEditor();
                _instance._original = new Image<Bgr, byte>(1, 1);
                _instance._transformed = new Image<Bgr, byte>(1, 1);
            }
            return _instance;
        }

        /// <summary>
        /// Получить изображение с фильтрами или без
        /// </summary>
        /// <param name="applyFilters">Применять фильтры да/нет</param>
        /// <returns>Изображение с фильтрами или без</returns>
        public Image<Bgr, byte> GetImage(bool needOriginal = false)
        {
            if (needOriginal) return _original.Copy();
            return _transformed.Copy();
        }

        /// <summary>
        /// Установить новое изображение
        /// </summary>
        /// <param name="image">Новое изображение</param>
        public void SetImage(Image<Bgr, byte> image)
        {
            _original = image.Clone();
            _transformed = image.Clone();
        }

        public void SetTransformed(Image<Bgr, byte> img)
        {
            _transformed = img.Clone();
        }

        public void Reset() => _transformed = _original.Clone();

        public void ApplyScale(int scaleX, int scaleY)
        {
            try
            {
                _transformed = AffineFacade.Scale(_original, scaleX, scaleY);
            }
            catch (ArgumentException)
            {
                MessageBox.Show($"Масштаб слишком мал, нынешний размер фото: \nВысота: {_original.Height}\nШирина: {_original.Width}");
            }
        }

        public void ApplyShear(float shiftValue, ShearDirection direction)
        {
            _transformed = AffineFacade.Shear(_original, shiftValue, direction);
        }

        public void RotateByAnchor(float angleDegrees, AnglesOfPhoto anchor)
        {
            Point center = anchor switch
            {
                AnglesOfPhoto.UpperLeft => new Point(0, 0),
                AnglesOfPhoto.UpperRight => new Point(_original.Width - 1, 0),
                AnglesOfPhoto.LowerLeft => new Point(0, _original.Height - 1),
                AnglesOfPhoto.LowerRight => new Point(_original.Width - 1, _original.Height - 1),
                _ => throw new ArgumentOutOfRangeException(nameof(anchor))
            };

            _transformed = AffineFacade.Rotate(_original, angleDegrees, center);
        }

        public void RotateByCustomPoint( float angleDegrees, Point customCenter)
        {
            _transformed = AffineFacade.Rotate(_original.Clone(), angleDegrees, customCenter);
        }

        public void ReflectImage(bool reflectHorizontally, bool reflectVertically)
        {
            if (!reflectHorizontally && !reflectVertically)
            {
                _transformed = _original.Clone();
                return;
            }

            _transformed = AffineFacade.Flip(GetImage(true), reflectHorizontally, reflectVertically).Clone();
        }

        public void ApplyHomography(Point[] selectedPoints)
        {
            _transformed = AffineFacade.Homography(_original.Clone(), selectedPoints);
        }
    }

}
