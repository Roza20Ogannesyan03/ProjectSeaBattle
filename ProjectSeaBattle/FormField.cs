using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSeaBattle
{
    public partial class FormField : Form
    {
        public Pen fill = new Pen(Color.White);
        public int height;
        public int width;
        public int columns;
        public int widthCell;
        public int rows;
        public int heightCell;

        public FormField()
        {
            InitializeComponent();
           
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            fill.Color = ((Button)sender).BackColor;
        }

        private void dgvField_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvField.DefaultCellStyle.SelectionBackColor = fill.Color;
            dgvField.CurrentCell.Style.BackColor = fill.Color;
        }

        public void FormField_Load(object sender, EventArgs e)
        {
            dgvField.ClearSelection();
            dgvField.Height = 255;
            dgvField.Width = 255;
            height = 250;
            width = 250;
            columns = FormMain.columns;
            widthCell = width / columns;
            rows = FormMain.rows;
            heightCell = height / rows;
            dgvField.ColumnHeadersVisible = false;
            dgvField.RowHeadersVisible = false;
            
            for (int i = 1; i <= columns; i++)
            {
                string name = "column"+ i;
                dgvField.Columns.Add(new DataGridViewTextBoxColumn() { Name = name, Width = widthCell });
            }

            dgvField.RowTemplate.Height = height / rows;
            dgvField.Rows.Add(rows);
            dgvField.ClearSelection();
            dgvField.DefaultCellStyle.SelectionBackColor = Color.Purple;
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            
        }
    }
}
