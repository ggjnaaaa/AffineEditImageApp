namespace LR2.TabForms.Rotate
{
    public partial class RotateForm
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
            label12 = new Label();
            label13 = new Label();
            LowerRightCorner = new NumericUpDown();
            LowerLeftCorner = new NumericUpDown();
            UpperRightCorner = new NumericUpDown();
            UpperLeftCorner = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            rotatePoint = new CheckBox();
            userPoint = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)LowerRightCorner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LowerLeftCorner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpperRightCorner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpperLeftCorner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userPoint).BeginInit();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(247, 83);
            label12.Name = "label12";
            label12.Size = new Size(51, 15);
            label12.TabIndex = 27;
            label12.Text = "Правый";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(247, 43);
            label13.Name = "label13";
            label13.Size = new Size(43, 15);
            label13.TabIndex = 26;
            label13.Text = "Левый";
            // 
            // LowerRightCorner
            // 
            LowerRightCorner.Location = new Point(312, 81);
            LowerRightCorner.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            LowerRightCorner.Minimum = new decimal(new int[] { 360, 0, 0, -2147483648 });
            LowerRightCorner.Name = "LowerRightCorner";
            LowerRightCorner.Size = new Size(120, 23);
            LowerRightCorner.TabIndex = 25;
            // 
            // LowerLeftCorner
            // 
            LowerLeftCorner.Location = new Point(312, 41);
            LowerLeftCorner.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            LowerLeftCorner.Minimum = new decimal(new int[] { 360, 0, 0, -2147483648 });
            LowerLeftCorner.Name = "LowerLeftCorner";
            LowerLeftCorner.Size = new Size(120, 23);
            LowerLeftCorner.TabIndex = 24;
            // 
            // UpperRightCorner
            // 
            UpperRightCorner.Location = new Point(81, 81);
            UpperRightCorner.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            UpperRightCorner.Minimum = new decimal(new int[] { 360, 0, 0, -2147483648 });
            UpperRightCorner.Name = "UpperRightCorner";
            UpperRightCorner.Size = new Size(120, 23);
            UpperRightCorner.TabIndex = 23;
            // 
            // UpperLeftCorner
            // 
            UpperLeftCorner.Location = new Point(81, 41);
            UpperLeftCorner.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            UpperLeftCorner.Minimum = new decimal(new int[] { 360, 0, 0, -2147483648 });
            UpperLeftCorner.Name = "UpperLeftCorner";
            UpperLeftCorner.Size = new Size(120, 23);
            UpperLeftCorner.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 83);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 21;
            label8.Text = "Правый";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(106, 11);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 20;
            label9.Text = "Верхний";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(343, 11);
            label10.Name = "label10";
            label10.Size = new Size(53, 15);
            label10.TabIndex = 19;
            label10.Text = "Нижний";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 43);
            label11.Name = "label11";
            label11.Size = new Size(43, 15);
            label11.TabIndex = 18;
            label11.Text = "Левый";
            // 
            // rotatePoint
            // 
            rotatePoint.AutoSize = true;
            rotatePoint.Location = new Point(461, 29);
            rotatePoint.Name = "rotatePoint";
            rotatePoint.Size = new Size(176, 19);
            rotatePoint.TabIndex = 28;
            rotatePoint.Text = "Поставить точку вращения";
            rotatePoint.UseVisualStyleBackColor = true;
            rotatePoint.CheckedChanged += rotatePoint_CheckedChanged;
            // 
            // userPoint
            // 
            userPoint.Enabled = false;
            userPoint.Location = new Point(488, 59);
            userPoint.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            userPoint.Minimum = new decimal(new int[] { 360, 0, 0, -2147483648 });
            userPoint.Name = "userPoint";
            userPoint.Size = new Size(120, 23);
            userPoint.TabIndex = 29;
            userPoint.ValueChanged += userPoint_ValueChanged;
            // 
            // RotateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(userPoint);
            Controls.Add(rotatePoint);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(LowerRightCorner);
            Controls.Add(LowerLeftCorner);
            Controls.Add(UpperRightCorner);
            Controls.Add(UpperLeftCorner);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Name = "RotateForm";
            Size = new Size(659, 112);
            ((System.ComponentModel.ISupportInitialize)LowerRightCorner).EndInit();
            ((System.ComponentModel.ISupportInitialize)LowerLeftCorner).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpperRightCorner).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpperLeftCorner).EndInit();
            ((System.ComponentModel.ISupportInitialize)userPoint).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Label label13;
        private NumericUpDown LowerRightCorner;
        private NumericUpDown LowerLeftCorner;
        private NumericUpDown UpperRightCorner;
        private NumericUpDown UpperLeftCorner;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private CheckBox rotatePoint;
        private NumericUpDown userPoint;
    }
}
