
namespace ProjectSeaBattle
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
            this.labelSize = new System.Windows.Forms.Label();
            this.comboBoxFirst = new System.Windows.Forms.ComboBox();
            this.comboBoxSecond = new System.Windows.Forms.ComboBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.comboBoxThird = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSize.Location = new System.Drawing.Point(126, 34);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(337, 25);
            this.labelSize.TabIndex = 1;
            this.labelSize.Text = "Выберите размер игрового поля";
            // 
            // comboBoxFirst
            // 
            this.comboBoxFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFirst.FormattingEnabled = true;
            this.comboBoxFirst.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBoxFirst.Location = new System.Drawing.Point(131, 79);
            this.comboBoxFirst.Name = "comboBoxFirst";
            this.comboBoxFirst.Size = new System.Drawing.Size(135, 26);
            this.comboBoxFirst.TabIndex = 11;
            // 
            // comboBoxSecond
            // 
            this.comboBoxSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSecond.FormattingEnabled = true;
            this.comboBoxSecond.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBoxSecond.Location = new System.Drawing.Point(331, 79);
            this.comboBoxSecond.Name = "comboBoxSecond";
            this.comboBoxSecond.Size = new System.Drawing.Size(132, 26);
            this.comboBoxSecond.TabIndex = 12;
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(283, 81);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(31, 24);
            this.textBox.TabIndex = 13;
            this.textBox.Text = "X";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(126, 140);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(332, 25);
            this.labelCount.TabIndex = 14;
            this.labelCount.Text = "Выберите количество кораблей";
            // 
            // comboBoxThird
            // 
            this.comboBoxThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxThird.FormattingEnabled = true;
            this.comboBoxThird.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBoxThird.Location = new System.Drawing.Point(131, 186);
            this.comboBoxThird.Name = "comboBoxThird";
            this.comboBoxThird.Size = new System.Drawing.Size(135, 26);
            this.comboBoxThird.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 461);
            this.Controls.Add(this.comboBoxThird);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.comboBoxSecond);
            this.Controls.Add(this.comboBoxFirst);
            this.Controls.Add(this.labelSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.ComboBox comboBoxFirst;
        private System.Windows.Forms.ComboBox comboBoxSecond;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.ComboBox comboBoxThird;
    }
}

