
namespace WindowsFormsApp3
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelRes = new System.Windows.Forms.Label();
            this.Вычислить = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Формулы:";
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Location = new System.Drawing.Point(48, 71);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(86, 21);
            this.radio1.TabIndex = 1;
            this.radio1.TabStop = true;
            this.radio1.Text = "x*sin(x)/2";
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(48, 108);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(87, 21);
            this.radio2.TabIndex = 2;
            this.radio2.TabStop = true;
            this.radio2.Text = "sqrt(x)/2x";
            this.radio2.UseVisualStyleBackColor = true;
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(48, 148);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(78, 21);
            this.radio3.TabIndex = 3;
            this.radio3.TabStop = true;
            this.radio3.Text = "x^2+3.5";
            this.radio3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите x:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(286, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(38, 22);
            this.textBox1.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(206, 148);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(155, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Удвоить результат";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Location = new System.Drawing.Point(48, 211);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(0, 17);
            this.labelRes.TabIndex = 8;
            // 
            // Вычислить
            // 
            this.Вычислить.Location = new System.Drawing.Point(466, 106);
            this.Вычислить.Name = "Вычислить";
            this.Вычислить.Size = new System.Drawing.Size(112, 23);
            this.Вычислить.TabIndex = 9;
            this.Вычислить.Text = "Вычислить";
            this.Вычислить.UseVisualStyleBackColor = true;
            this.Вычислить.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Вычислить);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radio3);
            this.Controls.Add(this.radio2);
            this.Controls.Add(this.radio1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Вычислить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Button Вычислить;
    }
}

