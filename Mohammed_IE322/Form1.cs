using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
namespace Mohammed_IE322
{
	public partial class IE322_Project : Form
	{

		private string ToolStripStatusLabel;
		
		public IE322_Project()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int attempt = 1;
			int Max = 3;
			
			while (attempt <= Max)
			{
				if (User.Text!= "Mohammed")
				{
					MessageBox.Show("Invaild username," + (Max - attempt) + "remaining attempts");


					attempt++;
					return;
				}
                else
				{
					if(pass.Text!="1234")
					{
						attempt++;
						MessageBox.Show("Incorrect password" + (Max - attempt) + "remaning attempts");
							return;

					}
					else
					{ attempt = 0;
						MessageBox.Show("Log in successfuly");
							}
					log_in.Text = "logout";
					ToolStripStatusLabel = "You are logged in";
					break;

				}
			}
            
		}

		private void button2_Click(object sender, EventArgs e)
		{
			CheckBox_Form frm = new CheckBox_Form();
			frm.ShowDialog();

		}

		private void groupBox6_Enter(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void ABC_Click(object sender, EventArgs e)
		{

		}

		private void arduino_Click(object sender, EventArgs e)
		{

		}

		private void MC_Click(object sender, EventArgs e)
		{

		}

		private void RC_Click(object sender, EventArgs e)
		{

		}

		private void johari_Click(object sender, EventArgs e)
		{

		}

		private void radio_Click(object sender, EventArgs e)
		{
			Radio_Form frm = new Radio_Form();
			frm.ShowDialog();

		}

		private void button3_Click(object sender, EventArgs e)
		{
			Combo frm = new Combo();
			frm.ShowDialog();

		}

		private void User_TextChanged(object sender, EventArgs e)
		{

		}

		private void exit_Click(object sender, EventArgs e)
		{
			Close();

		}

		private void picturebox_Click(object sender, EventArgs e)
		{

		}
	}
}


