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
    public partial class FormLevel : Form
    {
        public int height;
        public int width;
        public int columns;
        public int widthCell;
        public int rows;
        public int heightCell;
        public FormLevel()
        {
            InitializeComponent();
        }

        private void FormLevel_Load(object sender, EventArgs e)
        {
            CreateGrid cg = new CreateGrid(dataGridView1);
        }
    }
}
