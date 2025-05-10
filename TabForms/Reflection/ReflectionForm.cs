namespace LR2.TabForms.Reflection
{
    public partial class ReflectionForm : BaseTab
    {
        public ReflectionForm()
        {
            InitializeComponent();
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            _imageEditor.ReflectImage(
                ApplyHorizontalReflection.Checked,
                ApplyVerticalReflection.Checked
            );
            OnImageUpdated();
        }
    }
}
