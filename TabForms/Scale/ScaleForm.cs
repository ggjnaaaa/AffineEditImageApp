namespace LR2.TabForms.Scale
{
    public partial class ScaleForm : BaseTab
    {
        public ScaleForm() : base()
        {
            InitializeComponent();
        }

        private void buttonApplyScale_Click(object sender, EventArgs e)
        {
            int scaleX = (int)XScale.Value;
            int scaleY = (int)YScale.Value;

            _imageEditor.ApplyScale(scaleX, scaleY);
            OnImageUpdated();
        }
    }
}
