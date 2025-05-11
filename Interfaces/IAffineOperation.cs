using Emgu.CV.Structure;
using Emgu.CV;

namespace LR2.Interfaces
{
    internal interface IAffineOperation
    {
        Image<Bgr, byte> Apply(Image<Bgr, byte> image);
    }
}
