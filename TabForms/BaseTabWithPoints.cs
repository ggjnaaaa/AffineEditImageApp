using LR2.Interfaces;
using LR2.Models;
using LR2.Models.ShapesOnPhoto;

namespace LR2.TabForms
{
    public abstract class BaseTabWithPoints : BaseTab, IHasPoints
    {
        protected BaseShape? _shape;

        public BaseTabWithPoints() : base() { }

        public abstract void AddPoint(Point point);
    }
}
