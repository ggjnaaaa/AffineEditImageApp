namespace LR2.TabForms.Shear
{
    partial class ShearForm
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
            numericUpDownBottom = new NumericUpDown();
            numericUpDownTop = new NumericUpDown();
            numericUpDownRight = new NumericUpDown();
            numericUpDownLeft = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLeft).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownBottom
            // 
            numericUpDownBottom.Location = new Point(313, 53);
            numericUpDownBottom.Name = "numericUpDownBottom";
            numericUpDownBottom.Size = new Size(120, 23);
            numericUpDownBottom.TabIndex = 15;
            // 
            // numericUpDownTop
            // 
            numericUpDownTop.Location = new Point(313, 13);
            numericUpDownTop.Name = "numericUpDownTop";
            numericUpDownTop.Size = new Size(120, 23);
            numericUpDownTop.TabIndex = 14;
            // 
            // numericUpDownRight
            // 
            numericUpDownRight.Location = new Point(82, 53);
            numericUpDownRight.Name = "numericUpDownRight";
            numericUpDownRight.Size = new Size(120, 23);
            numericUpDownRight.TabIndex = 13;
            // 
            // numericUpDownLeft
            // 
            numericUpDownLeft.Location = new Point(82, 13);
            numericUpDownLeft.Name = "numericUpDownLeft";
            numericUpDownLeft.Size = new Size(120, 23);
            numericUpDownLeft.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 55);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 11;
            label7.Text = "Правый";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(245, 15);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 10;
            label6.Text = "Верхний";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(245, 55);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 9;
            label5.Text = "Нижний";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 15);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 8;
            label4.Text = "Левый";
            // 
            // ShearForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(numericUpDownBottom);
            Controls.Add(numericUpDownTop);
            Controls.Add(numericUpDownRight);
            Controls.Add(numericUpDownLeft);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Name = "ShearForm";
            Size = new Size(440, 87);
            ((System.ComponentModel.ISupportInitialize)numericUpDownBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLeft).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownBottom;
        private NumericUpDown numericUpDownTop;
        private NumericUpDown numericUpDownRight;
        private NumericUpDown numericUpDownLeft;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}
