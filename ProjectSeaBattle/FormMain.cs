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
    public partial class FormMain : Form
    {
        public static int rows = 1;
        public static int columns = 1;
        public static int ships = 1;
        public FormMain()
        {
            
            InitializeComponent();
        }

        private void comboBoxFirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            rows = int.Parse(comboBoxFirst.Text);
        }

        private void comboBoxSecond_SelectedIndexChanged(object sender, EventArgs e)
        {
            columns = int.Parse(comboBoxSecond.Text);
        }

        private void comboBoxThird_SelectedIndexChanged(object sender, EventArgs e)
        {
            ships = int.Parse(comboBoxThird.Text);
        }

        private void buttonGreate_Click(object sender, EventArgs e)
        {
            comboBoxFirst_SelectedIndexChanged(sender, e);
            comboBoxSecond_SelectedIndexChanged(sender, e);
            comboBoxThird_SelectedIndexChanged(sender, e);
            FormField formField = new FormField();
            formField.Show();
        }

       
    }
}
