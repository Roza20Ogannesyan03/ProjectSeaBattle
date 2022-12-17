
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvField1 = new System.Windows.Forms.DataGridView();
            this.buttonToRun = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.dgvField2 = new System.Windows.Forms.DataGridView();
            this.dgvMove = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvField1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvField2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMove)).BeginInit();
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
            // dgvMove
            // 
            this.dgvMove.AllowUserToAddRows = false;
            this.dgvMove.AllowUserToDeleteRows = false;
            this.dgvMove.AllowUserToResizeColumns = false;
            this.dgvMove.AllowUserToResizeRows = false;
            this.dgvMove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMove.ColumnHeadersVisible = false;
            this.dgvMove.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.dataGridViewImageColumn2,
            this.dataGridViewImageColumn3,
            this.dataGridViewImageColumn4});
            this.dgvMove.Location = new System.Drawing.Point(607, 59);
            this.dgvMove.Name = "dgvMove";
            this.dgvMove.ReadOnly = true;
            this.dgvMove.RowHeadersVisible = false;
            this.dgvMove.RowTemplate.Height = 35;
            this.dgvMove.Size = new System.Drawing.Size(143, 283);
            this.dgvMove.TabIndex = 35;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewImageColumn1.HeaderText = "Column1";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 35;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewImageColumn2.HeaderText = "Column2";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 35;
            // 
            // dataGridViewImageColumn3
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewImageColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewImageColumn3.HeaderText = "Column3";
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 35;
            // 
            // dataGridViewImageColumn4
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewImageColumn4.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewImageColumn4.HeaderText = "Column4";
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            this.dataGridViewImageColumn4.Width = 35;
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.White;
            this.buttonLeft.Image = global::ProjectSeaBattle.Properties.Resources.left;
            this.buttonLeft.Location = new System.Drawing.Point(725, 348);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(40, 40);
            this.buttonLeft.TabIndex = 40;
            this.buttonLeft.Tag = "1";
            this.buttonLeft.UseVisualStyleBackColor = false;
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.Color.White;
            this.buttonRight.Image = global::ProjectSeaBattle.Properties.Resources.right;
            this.buttonRight.Location = new System.Drawing.Point(679, 348);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(40, 40);
            this.buttonRight.TabIndex = 39;
            this.buttonRight.Tag = "1";
            this.buttonRight.UseVisualStyleBackColor = false;
            // 
            // buttonDown
            // 
            this.buttonDown.BackColor = System.Drawing.Color.White;
            this.buttonDown.Image = global::ProjectSeaBattle.Properties.Resources.down;
            this.buttonDown.Location = new System.Drawing.Point(633, 348);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(40, 40);
            this.buttonDown.TabIndex = 38;
            this.buttonDown.Tag = "1";
            this.buttonDown.UseVisualStyleBackColor = false;
            // 
            // buttonUp
            // 
            this.buttonUp.BackColor = System.Drawing.Color.White;
            this.buttonUp.Image = global::ProjectSeaBattle.Properties.Resources.up;
            this.buttonUp.Location = new System.Drawing.Point(587, 348);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(40, 40);
            this.buttonUp.TabIndex = 36;
            this.buttonUp.Tag = "1";
            this.buttonUp.UseVisualStyleBackColor = false;
            // 
            // FormField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.dgvMove);
            this.Controls.Add(this.dgvField2);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonToRun);
            this.Controls.Add(this.dgvField1);
            this.Name = "FormField";
            this.Text = "FormField";
            ((System.ComponentModel.ISupportInitialize)(this.dgvField1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvField2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvField1;
        private System.Windows.Forms.Button buttonToRun;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.DataGridView dgvField2;
        private System.Windows.Forms.DataGridView dgvMove;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
    }
}