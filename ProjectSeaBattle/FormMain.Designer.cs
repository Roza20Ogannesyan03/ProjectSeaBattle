
namespace ProjectSeaBattle
{
    partial class FormMain
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
            this.buttonGreate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSize.Location = new System.Drawing.Point(90, 55);
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
            this.comboBoxFirst.Location = new System.Drawing.Point(95, 111);
            this.comboBoxFirst.Name = "comboBoxFirst";
            this.comboBoxFirst.Size = new System.Drawing.Size(123, 26);
            this.comboBoxFirst.TabIndex = 11;
            this.comboBoxFirst.SelectedIndexChanged += new System.EventHandler(this.comboBoxFirst_SelectedIndexChanged);
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
            this.comboBoxSecond.Location = new System.Drawing.Point(291, 111);
            this.comboBoxSecond.Name = "comboBoxSecond";
            this.comboBoxSecond.Size = new System.Drawing.Size(123, 26);
            this.comboBoxSecond.TabIndex = 12;
            this.comboBoxSecond.SelectedIndexChanged += new System.EventHandler(this.comboBoxSecond_SelectedIndexChanged);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(240, 111);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(31, 24);
            this.textBox.TabIndex = 13;
            this.textBox.Text = "X";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonGreate
            // 
            this.buttonGreate.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonGreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGreate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGreate.Location = new System.Drawing.Point(95, 172);
            this.buttonGreate.Name = "buttonGreate";
            this.buttonGreate.Size = new System.Drawing.Size(135, 44);
            this.buttonGreate.TabIndex = 24;
            this.buttonGreate.Text = "Создать";
            this.buttonGreate.UseVisualStyleBackColor = false;
            this.buttonGreate.Click += new System.EventHandler(this.buttonGreate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClear.Location = new System.Drawing.Point(261, 172);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(135, 44);
            this.buttonClear.TabIndex = 25;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 304);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonGreate);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.comboBoxSecond);
            this.Controls.Add(this.comboBoxFirst);
            this.Controls.Add(this.labelSize);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.ComboBox comboBoxFirst;
        private System.Windows.Forms.ComboBox comboBoxSecond;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonGreate;
        private System.Windows.Forms.Button buttonClear;
    }
}

