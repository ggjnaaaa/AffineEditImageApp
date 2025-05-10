using LR2.Models;
using LR2.Services;

namespace LR2
{
    public partial class Form1 : Form
    {
        private ImageEditor _imageEditor;

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateImage()
        {
            imageBoxResult.Image = _imageEditor.Transformed;
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            _imageEditor = _imageEditor = ImageEditor.GetInstance();
            _imageEditor.SetImage(ImageLoader.LoadImage());

            imageBoxOriginal.Image = _imageEditor.Original;
            imageBoxResult.Image = _imageEditor.Transformed;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            _imageEditor?.Reset();
            imageBoxResult.Image = _imageEditor?.Transformed;
        }
    }
}
