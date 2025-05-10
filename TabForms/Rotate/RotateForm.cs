using LR2.Models;
using LR2.Models.ShapesOnPhoto;

namespace LR2.TabForms.Rotate
{
    public partial class RotateForm : BaseTabWithPoints
    {
        private bool _isUserPointActive = false;

        public RotateForm()
        {
            InitializeComponent();

            UpperLeftCorner.ValueChanged += (s, e) => RotateValueChanged(s, e, AnglesOfPhoto.UpperLeft);
            UpperRightCorner.ValueChanged += (s, e) => RotateValueChanged(s, e, AnglesOfPhoto.UpperRight);
            LowerLeftCorner.ValueChanged += (s, e) => RotateValueChanged(s, e, AnglesOfPhoto.LowerLeft);
            LowerRightCorner.ValueChanged += (s, e) => RotateValueChanged(s, e, AnglesOfPhoto.LowerRight);

            _numericUpDowns = new List<NumericUpDown>
                {
                    UpperLeftCorner,
                    UpperRightCorner,
                    LowerLeftCorner,
                    LowerRightCorner
                };
        }

        private void RotateValueChanged(object sender, EventArgs e, AnglesOfPhoto angle)
        {
            if (_isClearingValuesNow) return;
            _imageEditor.RotateByAnchor((float)((NumericUpDown)sender).Value, angle);
            clearUpDowns((NumericUpDown)sender);
            OnImageUpdated();
        }

        private void userPoint_ValueChanged(object sender, EventArgs e)
        {
            if (!_isUserPointActive) return;

            var points = _shape.GetPoints();
            if (points.Count != 1)
            {
                MessageBox.Show("Ошибка поворота\nПроверьте, установлена ли точка");
                return;
            }
            _imageEditor.RotateByCustomPoint((float)userPoint.Value, points[0]);
            OnImageUpdated();
        }

        private void rotatePoint_CheckedChanged(object sender, EventArgs e)
        {
            if (rotatePoint.Checked) userPointActivate();
            else defaultAnglesActivate();
        }

        private void defaultAnglesActivate()
        {
            _isUserPointActive = false;
            _shape.ClearPoints();
            _shape = null;
            foreach (var numericUpDown in _numericUpDowns)
            {
                numericUpDown.Enabled = true;
            }
            userPoint.Enabled = false;
        }

        private void userPointActivate()
        {
            _isUserPointActive = true;
            _shape = new PointShape();
            foreach (var numericUpDown in _numericUpDowns)
            {
                numericUpDown.Enabled = false;
            }
            userPoint.Enabled = true;
        }
    }
}
