using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSeaBattle
{
    class CreateGrid
    {
        public int height = 250;
        public int width = 250;
        public int columns;
        public int widthCell;
        public int rows;
        public int heightCell;
        public DataGridView DgvField;

        public CreateGrid(DataGridView dgvField)
        {
            DgvField = dgvField;
            dgvField.ClearSelection();
            dgvField.Height = 255;
            DgvField.Width = 255;


            columns = FormMain.columns;
            widthCell = width / columns;
            rows = FormMain.rows;
            heightCell = height / rows;
            dgvField.ColumnHeadersVisible = false;
            dgvField.RowHeadersVisible = false;

            for (int i = 1; i <= columns; i++)
            {
                string name = "column" + i;
                dgvField.Columns.Add(new DataGridViewTextBoxColumn() { Name = name, Width = widthCell });
            }

            dgvField.RowTemplate.Height = height / rows;
            dgvField.Rows.Add(rows);
            dgvField.ClearSelection();
        }
        
    }
}
