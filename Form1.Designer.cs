using LR2.Models;
using LR2.TabForms.Scale;
using LR2.TabForms.Shear;

namespace LR2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            loadImageButton = new Button();
            resetBtn = new Button();
            tabControl1 = new TabControl();
            Scale = new TabPage();
            scaleForm1 = new ScaleForm();
            Shearing = new TabPage();
            shearForm1 = new ShearForm();
            Rotate = new TabPage();
            rotateForm1 = new LR2.TabForms.Rotate.RotateForm();
            Reflection = new TabPage();
            reflectionForm1 = new LR2.TabForms.Reflection.ReflectionForm();
            Homography = new TabPage();
            homographyForm1 = new LR2.TabForms.Homography.HomographyForm();
            imageBoxOriginal = new Emgu.CV.UI.ImageBox();
            imageBoxResult = new Emgu.CV.UI.ImageBox();
            tabControl1.SuspendLayout();
            Scale.SuspendLayout();
            Shearing.SuspendLayout();
            Rotate.SuspendLayout();
            Reflection.SuspendLayout();
            Homography.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageBoxOriginal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageBoxResult).BeginInit();
            SuspendLayout();
            // 
            // loadImageButton
            // 
            loadImageButton.Location = new Point(22, 12);
            loadImageButton.Name = "loadImageButton";
            loadImageButton.Size = new Size(165, 23);
            loadImageButton.TabIndex = 4;
            loadImageButton.Text = "Загрузить изображение";
            loadImageButton.UseVisualStyleBackColor = true;
            loadImageButton.Click += loadImageButton_Click;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(196, 12);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(75, 23);
            resetBtn.TabIndex = 5;
            resetBtn.Text = "Сбросить";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Scale);
            tabControl1.Controls.Add(Shearing);
            tabControl1.Controls.Add(Rotate);
            tabControl1.Controls.Add(Reflection);
            tabControl1.Controls.Add(Homography);
            tabControl1.Location = new Point(12, 427);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(784, 147);
            tabControl1.TabIndex = 6;
            // 
            // Scale
            // 
            Scale.Controls.Add(scaleForm1);
            Scale.Location = new Point(4, 24);
            Scale.Name = "Scale";
            Scale.Padding = new Padding(3);
            Scale.Size = new Size(776, 119);
            Scale.TabIndex = 0;
            Scale.Text = "Масштабироование";
            Scale.UseVisualStyleBackColor = true;
            // 
            // scaleForm1
            // 
            scaleForm1.Location = new Point(203, 17);
            scaleForm1.Name = "scaleForm1";
            scaleForm1.Size = new Size(346, 83);
            scaleForm1.TabIndex = 0;
            scaleForm1.ImageUpdated += UpdateImage;
            // 
            // Shearing
            // 
            Shearing.Controls.Add(shearForm1);
            Shearing.Location = new Point(4, 24);
            Shearing.Name = "Shearing";
            Shearing.Padding = new Padding(3);
            Shearing.Size = new Size(776, 119);
            Shearing.TabIndex = 1;
            Shearing.Text = "Сдвиг";
            Shearing.UseVisualStyleBackColor = true;
            // 
            // shearForm1
            // 
            shearForm1.Location = new Point(180, 17);
            shearForm1.Name = "shearForm1";
            shearForm1.Size = new Size(440, 87);
            shearForm1.TabIndex = 0;
            shearForm1.ImageUpdated += UpdateImage;
            // 
            // Rotate
            // 
            Rotate.Controls.Add(rotateForm1);
            Rotate.Location = new Point(4, 24);
            Rotate.Name = "Rotate";
            Rotate.Size = new Size(776, 119);
            Rotate.TabIndex = 2;
            Rotate.Text = "Поворот";
            Rotate.UseVisualStyleBackColor = true;
            // 
            // rotateForm1
            // 
            rotateForm1.Location = new Point(65, 3);
            rotateForm1.Name = "rotateForm1";
            rotateForm1.Size = new Size(641, 112);
            rotateForm1.TabIndex = 0;
            rotateForm1.ImageUpdated += UpdateImage;
            // 
            // Reflection
            // 
            Reflection.Controls.Add(reflectionForm1);
            Reflection.Location = new Point(4, 24);
            Reflection.Name = "Reflection";
            Reflection.Size = new Size(776, 119);
            Reflection.TabIndex = 3;
            Reflection.Text = "Отражение";
            Reflection.UseVisualStyleBackColor = true;
            // 
            // reflectionForm1
            // 
            reflectionForm1.Location = new Point(128, 48);
            reflectionForm1.Name = "reflectionForm1";
            reflectionForm1.Size = new Size(513, 25);
            reflectionForm1.TabIndex = 0;
            reflectionForm1.ImageUpdated += UpdateImage;
            // 
            // Homography
            // 
            Homography.Controls.Add(homographyForm1);
            Homography.Location = new Point(4, 24);
            Homography.Name = "Homography";
            Homography.Size = new Size(776, 119);
            Homography.TabIndex = 4;
            Homography.Text = "Гомография";
            Homography.UseVisualStyleBackColor = true;
            // 
            // homographyForm1
            // 
            homographyForm1.Location = new Point(220, 30);
            homographyForm1.Name = "homographyForm1";
            homographyForm1.Size = new Size(334, 66);
            homographyForm1.TabIndex = 0;
            homographyForm1.ImageUpdated += UpdateImage;
            // 
            // imageBoxOriginal
            // 
            imageBoxOriginal.Location = new Point(22, 41);
            imageBoxOriginal.Name = "imageBoxOriginal";
            imageBoxOriginal.Size = new Size(369, 369);
            imageBoxOriginal.TabIndex = 7;
            imageBoxOriginal.TabStop = false;
            imageBoxOriginal.MouseClick += imageBox_MouseClick;
            // 
            // imageBoxResult
            // 
            imageBoxResult.Location = new Point(417, 42);
            imageBoxResult.Name = "imageBoxResult";
            imageBoxResult.Size = new Size(369, 369);
            imageBoxResult.TabIndex = 8;
            imageBoxResult.TabStop = false;
            imageBoxResult.MouseClick += imageBox_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 585);
            Controls.Add(imageBoxOriginal);
            Controls.Add(imageBoxResult);
            Controls.Add(tabControl1);
            Controls.Add(resetBtn);
            Controls.Add(loadImageButton);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            Scale.ResumeLayout(false);
            Shearing.ResumeLayout(false);
            Rotate.ResumeLayout(false);
            Reflection.ResumeLayout(false);
            Homography.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imageBoxOriginal).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageBoxResult).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button loadImageButton;
        private Button resetBtn;
        private TabControl tabControl1;
        private TabPage Scale;
        private TabPage Shearing;
        private TabPage Rotate;
        private TabPage Reflection;
        private TabPage Homography;
        private Emgu.CV.UI.ImageBox imageBoxOriginal;
        private Emgu.CV.UI.ImageBox imageBoxResult;
        private ScaleForm scaleForm1;
        private ShearForm shearForm1;
        private TabForms.Rotate.RotateForm rotateForm1;
        private TabForms.Reflection.ReflectionForm reflectionForm1;
        private TabForms.Homography.HomographyForm homographyForm1;
    }
}
