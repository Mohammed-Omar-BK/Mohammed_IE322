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
    public partial class CheckBox_Form : Form
    {
        public CheckBox_Form()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void show_Click(object sender, EventArgs e)
        { string msg = "";
            if (coffee.Checked == true)
            {
                msg=coffee+""+"orderd";
            }
            if (donut.Checked == true)
            {
                 msg =msg+""+donut+""+"orderd";
            }
            if (brownie.Checked == true)
            {
                msg = msg+""+brownie+""+"orderd";
            }
            if (msg.Length==0)
            {
                msg = "nothing selected";
            }

            //MessageBox.Show(msg);
        } 
    }
}
