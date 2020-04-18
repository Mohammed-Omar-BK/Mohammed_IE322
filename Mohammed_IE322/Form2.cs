using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mohammed_IE322
{
    public partial class Radio_Form : Form
    {
        public Radio_Form()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void red1_CheckedChanged(object sender, EventArgs e)
        {
            red1.ForeColor = Color.FromName("red");
        }

        private void green1_CheckedChanged(object sender, EventArgs e)
        {
            green1.ForeColor = Color.FromName("green");
        }

        private void blue1_CheckedChanged(object sender, EventArgs e)
        {
            blue1.ForeColor = Color.FromName("blue");
        }

        private void yellow1_CheckedChanged(object sender, EventArgs e)
        {
            yellow1.ForeColor = Color.FromName("yellow");
        }

        private void red2_CheckedChanged(object sender, EventArgs e)
        {
            red2.ForeColor = Color.FromName("red");
        }

        private void green2_CheckedChanged(object sender, EventArgs e)
        {
            green2.ForeColor = Color.FromName("green");
        }

        private void blue2_CheckedChanged(object sender, EventArgs e)
        {
            blue2.ForeColor = Color.FromName("blue");
        }

        private void yellow2_CheckedChanged(object sender, EventArgs e)
        {
            yellow2.ForeColor = Color.FromName("yellow");
        }

        private void reset_Click(object sender, EventArgs e)
        {
            red1.ForeColor = Color.FromName("black");
            red2.ForeColor = Color.FromName("black");
            green1.ForeColor = Color.FromName("black");
            green2.ForeColor = Color.FromName("black");
            blue1.ForeColor = Color.FromName("black");
            blue2.ForeColor = Color.FromName("black");
            yellow1.ForeColor = Color.FromName("black");
            yellow2.ForeColor = Color.FromName("black");
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
