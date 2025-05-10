using Emgu.CV.UI;
using LR2.Models;
using LR2.TabForms;

namespace LR2
{
    public partial class Form1
    {
        private void imageBox_MouseClick(object sender, MouseEventArgs e)
        {
            var currentTab = tabControl1.SelectedTab?.Controls.OfType<BaseTabWithPoints>().FirstOrDefault();
            if (currentTab == null) return;

            var imageBox = sender as ImageBox;

            if (imageBox == null || imageBox.Image == null)
                return;

            int x = (int)(e.Location.X / imageBox.ZoomScale);
            int y = (int)(e.Location.Y / imageBox.ZoomScale);

            Point center = new Point(x, y);

            currentTab?.AddPoint(center);
            imageBoxResult.Image = _imageEditor.GetImage();
        }
    }
}
