using Emgu.CV.Structure;
using Emgu.CV;

namespace LR2.Interfaces
{
    public interface IImageEditor
    {
        public Image<Bgr, byte> GetImage(bool needOriginal = false);

        public void SetImage(Image<Bgr, byte> image);

        public void Reset();
    }
}
