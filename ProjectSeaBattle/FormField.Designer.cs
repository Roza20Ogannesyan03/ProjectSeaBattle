
namespace ProjectSeaBattle
{
    partial class FormField
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvField1 = new System.Windows.Forms.DataGridView();
            this.buttonToRun = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.dgvField2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvField1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvField2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvField1
            // 
            this.dgvField1.BackgroundColor = System.Drawing.Color.White;
            this.dgvField1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvField1.Location = new System.Drawing.Point(73, 74);
            this.dgvField1.Name = "dgvField1";
            this.dgvField1.Size = new System.Drawing.Size(243, 243);
            this.dgvField1.TabIndex = 31;
            // 
            // buttonToRun
            // 
            this.buttonToRun.BackColor = System.Drawing.Color.White;
            this.buttonToRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToRun.Location = new System.Drawing.Point(73, 339);
            this.buttonToRun.Name = "buttonToRun";
            this.buttonToRun.Size = new System.Drawing.Size(243, 40);
            this.buttonToRun.TabIndex = 32;
            this.buttonToRun.Text = "Запустить";
            this.buttonToRun.UseVisualStyleBackColor = false;
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.White;
            this.buttonRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRestart.Location = new System.Drawing.Point(73, 385);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(243, 32);
            this.buttonRestart.TabIndex = 33;
            this.buttonRestart.Text = "Начать заново";
            this.buttonRestart.UseVisualStyleBackColor = false;
            // 
            // dgvField2
            // 
            this.dgvField2.BackgroundColor = System.Drawing.Color.White;
            this.dgvField2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvField2.Location = new System.Drawing.Point(377, 111);
            this.dgvField2.Name = "dgvField2";
            this.dgvField2.Size = new System.Drawing.Size(183, 183);
            this.dgvField2.TabIndex = 34;
            // 
            // FormField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvField2);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonToRun);
            this.Controls.Add(this.dgvField1);
            this.Name = "FormField";
            this.Text = "FormField";
            ((System.ComponentModel.ISupportInitialize)(this.dgvField1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvField2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvField1;
        private System.Windows.Forms.Button buttonToRun;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.DataGridView dgvField2;
    }
}