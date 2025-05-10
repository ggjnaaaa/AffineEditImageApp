using LR2.Interfaces;
using LR2.Models;

namespace LR2.TabForms
{
    public partial class BaseTab : UserControl, ITabEvent
    {
        public event Action ImageUpdated;

        protected ImageEditor _imageEditor;

        protected List<NumericUpDown> _numericUpDowns;
        protected bool _isClearingValuesNow = false;

        public BaseTab()
        {
            _imageEditor = ImageEditor.GetInstance();
            InitializeComponent();
        }

        protected void clearUpDowns(NumericUpDown updatedNumericUpDown)
        {
            _isClearingValuesNow = true;
            foreach (var numericUpDown in _numericUpDowns)
            {
                if (numericUpDown.Name == updatedNumericUpDown.Name) continue;
                numericUpDown.Value = 0;
            }
            _isClearingValuesNow = false;
        }

        protected void OnImageUpdated()
        {
            ImageUpdated?.Invoke();
        }
    }
}
