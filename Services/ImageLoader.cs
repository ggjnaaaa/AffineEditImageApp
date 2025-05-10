using Emgu.CV.Structure;
using Emgu.CV;

namespace LR2.Services
{
    /// <summary>
    /// Сервис для загрузки изображений.
    /// </summary>
    public static class ImageLoader
    {
        /// <summary>
        /// Загружает изображение с помощью диалогового окна.
        /// </summary>
        /// <returns>Загруженное изображение в формате BGR, или null, если изображение не выбрано.</returns>
        public static Image<Bgr, byte> LoadImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Изображения|*.jpg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return new Image<Bgr, byte>(openFileDialog.FileName);
                }
            }
            return null;
        }
    }
}
