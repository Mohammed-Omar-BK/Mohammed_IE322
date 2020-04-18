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
    public partial class Combo : Form
    {
        public Combo()
        {
            InitializeComponent();

            combo_days.Items.Add("Sunday");
            combo_days.Items.Add("Monday");
            combo_days.Items.Add("Tuesday");
            combo_days.Items.Add("Wednsday");
            combo_days.Items.Add("Thursday");
            combo_days.Items.Add("Friday");
            combo_days.Items.Add("Saturday");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(combo_days.Text);
        }

        private void show2_Click(object sender, EventArgs e)
        {

        }

        private void remove_last1_Click(object sender, EventArgs e)
        {
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void remove_name_Click(object sender, EventArgs e)
        {
            combo_days.Items.Remove("Friday");
        }

        private void remove_index_Click(object sender, EventArgs e)
        {
            combo_days.Items.RemoveAt(1);
        }
    }
}
