using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P13Colors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void red_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void blue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;

        }

        private void yellow_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

        }

        private void black_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;

        }

        private void pink_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.HotPink;

        }

        private void gray_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;

        }

        private void green_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.ForestGreen;

        }
    }
}
