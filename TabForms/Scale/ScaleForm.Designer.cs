namespace LR2.TabForms.Scale
{
    partial class ScaleForm
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
            buttonApplyScale = new Button();
            label2 = new Label();
            label1 = new Label();
            YScale = new NumericUpDown();
            XScale = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)YScale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)XScale).BeginInit();
            SuspendLayout();
            // 
            // buttonApplyScale
            // 
            buttonApplyScale.Location = new Point(225, 29);
            buttonApplyScale.Name = "buttonApplyScale";
            buttonApplyScale.Size = new Size(108, 23);
            buttonApplyScale.TabIndex = 12;
            buttonApplyScale.Text = "Применить";
            buttonApplyScale.UseVisualStyleBackColor = true;
            buttonApplyScale.Click += buttonApplyScale_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 50);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 11;
            label2.Text = "Масштаб по Y";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 10);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 10;
            label1.Text = "Масштаб по X";
            // 
            // YScale
            // 
            YScale.Location = new Point(96, 48);
            YScale.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            YScale.Minimum = new decimal(new int[] { 10000000, 0, 0, int.MinValue });
            YScale.Name = "YScale";
            YScale.Size = new Size(98, 23);
            YScale.TabIndex = 9;
            // 
            // XScale
            // 
            XScale.Location = new Point(96, 8);
            XScale.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            XScale.Minimum = new decimal(new int[] { 10000000, 0, 0, int.MinValue });
            XScale.Name = "XScale";
            XScale.Size = new Size(98, 23);
            XScale.TabIndex = 8;
            // 
            // ScaleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonApplyScale);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(YScale);
            Controls.Add(XScale);
            Name = "ScaleForm";
            Size = new Size(343, 80);
            ((System.ComponentModel.ISupportInitialize)YScale).EndInit();
            ((System.ComponentModel.ISupportInitialize)XScale).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonApplyScale;
        private Label label2;
        private Label label1;
        private NumericUpDown YScale;
        private NumericUpDown XScale;
    }
}
