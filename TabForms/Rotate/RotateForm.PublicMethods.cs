namespace LR2.TabForms.Rotate
{
    public partial class RotateForm
    {
        public override void AddPoint(Point point)
		{
            if (!_isUserPointActive) return;
            _shape?.AddPoint(point);
            var img = _imageEditor.GetImage(true);
            _shape?.DrawShape(img);
            _imageEditor.SetTransformed(img);
        }
	}
}
