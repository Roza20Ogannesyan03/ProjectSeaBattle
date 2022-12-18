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
        public FormField()
        {
            InitializeComponent();
           
        }
        
        public int height;
        public int width;

        public void FormField_Load(object sender, EventArgs e)
        {
            dgvField1.Height = 255;
            dgvField1.Width = 255;
            height = 250;
            width = 250;
            int columns = FormMain.columns;
            int widthCell = width / columns;
            int rows = FormMain.rows;
            int heightCell = height / rows;
            dgvField1.ColumnHeadersVisible = false;
            dgvField1.RowHeadersVisible = false;
            
            for (int i = 1; i <= columns; i++)
            {
                string name = "column"+ i;
                dgvField1.Columns.Add(new DataGridViewTextBoxColumn() { Name = name, Width = widthCell });
            }

            dgvField1.RowTemplate.Height = height / rows;
            dgvField1.Rows.Add(rows);
        }
    }
}
