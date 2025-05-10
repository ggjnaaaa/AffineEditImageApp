using LR2.Models;
using LR2.Models.ShapesOnPhoto;

namespace LR2.TabForms.Homography
{
    public partial class HomographyForm : BaseTabWithPoints
    {
        public HomographyForm()
        {
            InitializeComponent();
        }

        private void checkPlane_Click(object sender, EventArgs e)
        {
            _shape = new QuadShape();
        }

        private void apply_Click(object sender, EventArgs e)
        {
            var points = _shape.GetPoints().ToArray();
            if (points.Length != 4)
            {
                MessageBox.Show("Ошибка преобразования\nПроверьте, установлены ли все 4 точки");
                return;
            }
            _imageEditor.ApplyHomography(points);
            _shape.ClearPoints();
            _shape = null;
            OnImageUpdated();
        }

        public override void AddPoint(Point point)
        {
            _shape?.AddPoint(point);
            var img = _imageEditor.GetImage(true);
            _shape?.DrawShape(img);
            _imageEditor.SetTransformed(img);
        }
    }
}
