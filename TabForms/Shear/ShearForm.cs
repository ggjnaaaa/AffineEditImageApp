using LR2.Models;

namespace LR2.TabForms.Shear
{
    public partial class ShearForm : BaseTab
    {
        public ShearForm() : base()
        {
            InitializeComponent();

            numericUpDownTop.ValueChanged += (s, e) => ShearValueChanged(s, e, ShearDirection.Top);
            numericUpDownBottom.ValueChanged += (s, e) => ShearValueChanged(s, e, ShearDirection.Bottom);
            numericUpDownLeft.ValueChanged += (s, e) => ShearValueChanged(s, e, ShearDirection.Left);
            numericUpDownRight.ValueChanged += (s, e) => ShearValueChanged(s, e, ShearDirection.Right);

            _numericUpDowns = new List<NumericUpDown>
                {
                    numericUpDownTop,
                    numericUpDownBottom,
                    numericUpDownLeft,
                    numericUpDownRight
                };
        }

        private void ShearValueChanged(object sender, EventArgs e, ShearDirection direction)
        {
            if (_isClearingValuesNow) return;
            var numericUpDown = sender as NumericUpDown;
            if (numericUpDown == null) return;

            float shiftValue = (float)numericUpDown.Value;

            _imageEditor.ApplyShear(shiftValue, direction);
            clearUpDowns(numericUpDown);
            OnImageUpdated();
        }
    }
}
