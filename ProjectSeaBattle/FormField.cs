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
            CreateGrid cg = new CreateGrid(dgvField);
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dgvField.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }

        private void buttonToRun_Click(object sender, EventArgs e)
        {
            if (dgvField.DefaultCellStyle.SelectionBackColor == Color.White)
            {
                MessageBox.Show("Вы не выбрали цвета!");
            }
            else
            {
                FormLevel fl = new FormLevel();
                fl.Show();
            }
        }

        private void dgvField_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
