namespace LR2.TabForms.Homography
{
    partial class HomographyForm
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            apply = new Button();
            checkPlane = new Button();
            SuspendLayout();
            // 
            // apply
            // 
            apply.Location = new Point(179, 3);
            apply.Name = "apply";
            apply.Size = new Size(112, 23);
            apply.TabIndex = 4;
            apply.Text = "Применить";
            apply.UseVisualStyleBackColor = true;
            apply.Click += apply_Click;
            // 
            // checkPlane
            // 
            checkPlane.Location = new Point(3, 3);
            checkPlane.Name = "checkPlane";
            checkPlane.Size = new Size(150, 23);
            checkPlane.TabIndex = 3;
            checkPlane.Text = "Выбрать плоскость";
            checkPlane.UseVisualStyleBackColor = true;
            checkPlane.Click += checkPlane_Click;
            // 
            // HomographyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(apply);
            Controls.Add(checkPlane);
            Name = "HomographyForm";
            Size = new Size(295, 31);
            ResumeLayout(false);
        }

        #endregion
        private Button apply;
        private Button checkPlane;
    }
}
