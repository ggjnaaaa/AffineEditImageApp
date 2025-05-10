namespace LR2.TabForms.Reflection
{
    partial class ReflectionForm
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
            ApplyHorizontalReflection = new CheckBox();
            ApplyVerticalReflection = new CheckBox();
            SuspendLayout();
            // 
            // ApplyHorizontalReflection
            // 
            ApplyHorizontalReflection.AutoSize = true;
            ApplyHorizontalReflection.Location = new Point(268, 3);
            ApplyHorizontalReflection.Name = "ApplyHorizontalReflection";
            ApplyHorizontalReflection.Size = new Size(242, 19);
            ApplyHorizontalReflection.TabIndex = 3;
            ApplyHorizontalReflection.Text = "Применить отражение по горизонтали";
            ApplyHorizontalReflection.UseVisualStyleBackColor = true;
            ApplyHorizontalReflection.CheckedChanged += CheckedChanged;
            // 
            // ApplyVerticalReflection
            // 
            ApplyVerticalReflection.AutoSize = true;
            ApplyVerticalReflection.Location = new Point(3, 3);
            ApplyVerticalReflection.Name = "ApplyVerticalReflection";
            ApplyVerticalReflection.Size = new Size(229, 19);
            ApplyVerticalReflection.TabIndex = 2;
            ApplyVerticalReflection.Text = "Применить отражение по вертикали";
            ApplyVerticalReflection.UseVisualStyleBackColor = true;
            ApplyVerticalReflection.CheckedChanged += CheckedChanged;
            // 
            // ReflectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ApplyHorizontalReflection);
            Controls.Add(ApplyVerticalReflection);
            Name = "ReflectionForm";
            Size = new Size(513, 25);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ApplyHorizontalReflection;
        private CheckBox ApplyVerticalReflection;
    }
}
