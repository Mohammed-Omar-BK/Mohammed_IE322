namespace Mohammed_IE322
{
	partial class IE322_Project
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.log_in = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.checkbox = new System.Windows.Forms.Button();
            this.radio = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupieapp = new System.Windows.Forms.Button();
            this.picturebox2 = new System.Windows.Forms.Button();
            this.selfieapp = new System.Windows.Forms.Button();
            this.picturebox = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.randomcom = new System.Windows.Forms.Button();
            this.random = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.talk = new System.Windows.Forms.Button();
            this.draw = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.johari = new System.Windows.Forms.Button();
            this.ABC = new System.Windows.Forms.Button();
            this.RC = new System.Windows.Forms.Button();
            this.MC = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.arduino = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.User);
            this.groupBox1.Controls.Add(this.log_in);
            this.groupBox1.Controls.Add(this.pass);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "User name";
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(163, 28);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(117, 27);
            this.User.TabIndex = 1;
            this.User.TextChanged += new System.EventHandler(this.User_TextChanged);
            // 
            // log_in
            // 
            this.log_in.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.log_in.Location = new System.Drawing.Point(104, 120);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(116, 34);
            this.log_in.TabIndex = 2;
            this.log_in.Text = "Log in";
            this.log_in.UseVisualStyleBackColor = false;
            this.log_in.Click += new System.EventHandler(this.button1_Click);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(163, 68);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(117, 27);
            this.pass.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.exit.Location = new System.Drawing.Point(706, 355);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(151, 64);
            this.exit.TabIndex = 1;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.checkbox);
            this.groupBox2.Controls.Add(this.radio);
            this.groupBox2.Location = new System.Drawing.Point(352, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 136);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Control ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Location = new System.Drawing.Point(73, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Combo";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkbox
            // 
            this.checkbox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.checkbox.Location = new System.Drawing.Point(146, 26);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(97, 41);
            this.checkbox.TabIndex = 1;
            this.checkbox.Text = "CheckBox";
            this.checkbox.UseVisualStyleBackColor = false;
            this.checkbox.Click += new System.EventHandler(this.button2_Click);
            // 
            // radio
            // 
            this.radio.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radio.Location = new System.Drawing.Point(18, 26);
            this.radio.Name = "radio";
            this.radio.Size = new System.Drawing.Size(91, 41);
            this.radio.TabIndex = 0;
            this.radio.Text = "Radio";
            this.radio.UseVisualStyleBackColor = false;
            this.radio.Click += new System.EventHandler(this.radio_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupieapp);
            this.groupBox3.Controls.Add(this.picturebox2);
            this.groupBox3.Controls.Add(this.selfieapp);
            this.groupBox3.Controls.Add(this.picturebox);
            this.groupBox3.Location = new System.Drawing.Point(339, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 175);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graphical";
            // 
            // groupieapp
            // 
            this.groupieapp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupieapp.Location = new System.Drawing.Point(168, 101);
            this.groupieapp.Name = "groupieapp";
            this.groupieapp.Size = new System.Drawing.Size(123, 33);
            this.groupieapp.TabIndex = 3;
            this.groupieapp.Text = "Groupie App";
            this.groupieapp.UseVisualStyleBackColor = false;
            // 
            // picturebox2
            // 
            this.picturebox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.picturebox2.Location = new System.Drawing.Point(13, 101);
            this.picturebox2.Name = "picturebox2";
            this.picturebox2.Size = new System.Drawing.Size(130, 34);
            this.picturebox2.TabIndex = 2;
            this.picturebox2.Text = "PictureBox2";
            this.picturebox2.UseVisualStyleBackColor = false;
            // 
            // selfieapp
            // 
            this.selfieapp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.selfieapp.Location = new System.Drawing.Point(168, 43);
            this.selfieapp.Name = "selfieapp";
            this.selfieapp.Size = new System.Drawing.Size(123, 32);
            this.selfieapp.TabIndex = 1;
            this.selfieapp.Text = "SelfieApp";
            this.selfieapp.UseVisualStyleBackColor = false;
            // 
            // picturebox
            // 
            this.picturebox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.picturebox.Location = new System.Drawing.Point(13, 43);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(130, 32);
            this.picturebox.TabIndex = 0;
            this.picturebox.Text = "PictureBox";
            this.picturebox.UseVisualStyleBackColor = false;
            this.picturebox.Click += new System.EventHandler(this.picturebox_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.randomcom);
            this.groupBox4.Controls.Add(this.random);
            this.groupBox4.Controls.Add(this.timer);
            this.groupBox4.Controls.Add(this.progress);
            this.groupBox4.Location = new System.Drawing.Point(32, 217);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 155);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "More Control";
            // 
            // randomcom
            // 
            this.randomcom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.randomcom.Location = new System.Drawing.Point(157, 94);
            this.randomcom.Name = "randomcom";
            this.randomcom.Size = new System.Drawing.Size(111, 38);
            this.randomcom.TabIndex = 3;
            this.randomcom.Text = "RandomCom";
            this.randomcom.UseVisualStyleBackColor = false;
            // 
            // random
            // 
            this.random.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.random.Location = new System.Drawing.Point(33, 95);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(101, 37);
            this.random.TabIndex = 2;
            this.random.Text = "Random";
            this.random.UseVisualStyleBackColor = false;
            // 
            // timer
            // 
            this.timer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.timer.Location = new System.Drawing.Point(157, 38);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(111, 42);
            this.timer.TabIndex = 1;
            this.timer.Text = "Timer";
            this.timer.UseVisualStyleBackColor = false;
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.progress.Location = new System.Drawing.Point(33, 38);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(101, 42);
            this.progress.TabIndex = 0;
            this.progress.Text = "Progress";
            this.progress.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.talk);
            this.groupBox5.Controls.Add(this.draw);
            this.groupBox5.Location = new System.Drawing.Point(328, 355);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(278, 100);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Draw and Talk";
            // 
            // talk
            // 
            this.talk.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.talk.Location = new System.Drawing.Point(156, 40);
            this.talk.Name = "talk";
            this.talk.Size = new System.Drawing.Size(111, 37);
            this.talk.TabIndex = 1;
            this.talk.Text = "Talk";
            this.talk.UseVisualStyleBackColor = false;
            // 
            // draw
            // 
            this.draw.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.draw.Location = new System.Drawing.Point(11, 40);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(107, 37);
            this.draw.TabIndex = 0;
            this.draw.Text = "Draw";
            this.draw.UseVisualStyleBackColor = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.johari);
            this.groupBox6.Controls.Add(this.ABC);
            this.groupBox6.Controls.Add(this.RC);
            this.groupBox6.Controls.Add(this.MC);
            this.groupBox6.Location = new System.Drawing.Point(625, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(275, 156);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Exam Apps";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // johari
            // 
            this.johari.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.johari.Location = new System.Drawing.Point(157, 91);
            this.johari.Name = "johari";
            this.johari.Size = new System.Drawing.Size(75, 39);
            this.johari.TabIndex = 3;
            this.johari.Text = "Johari";
            this.johari.UseVisualStyleBackColor = false;
            this.johari.Click += new System.EventHandler(this.johari_Click);
            // 
            // ABC
            // 
            this.ABC.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ABC.Location = new System.Drawing.Point(14, 91);
            this.ABC.Name = "ABC";
            this.ABC.Size = new System.Drawing.Size(117, 39);
            this.ABC.TabIndex = 2;
            this.ABC.Text = "ABC Analysis";
            this.ABC.UseVisualStyleBackColor = false;
            this.ABC.Click += new System.EventHandler(this.ABC_Click);
            // 
            // RC
            // 
            this.RC.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.RC.Location = new System.Drawing.Point(157, 31);
            this.RC.Name = "RC";
            this.RC.Size = new System.Drawing.Size(75, 46);
            this.RC.TabIndex = 1;
            this.RC.Text = "Robtic Cell";
            this.RC.UseVisualStyleBackColor = false;
            this.RC.Click += new System.EventHandler(this.RC_Click);
            // 
            // MC
            // 
            this.MC.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MC.Location = new System.Drawing.Point(14, 31);
            this.MC.Name = "MC";
            this.MC.Size = new System.Drawing.Size(117, 50);
            this.MC.TabIndex = 0;
            this.MC.Text = "Manufacturing Cell";
            this.MC.UseVisualStyleBackColor = false;
            this.MC.Click += new System.EventHandler(this.MC_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.arduino);
            this.groupBox7.Location = new System.Drawing.Point(667, 184);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 100);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Micro Controller";
            // 
            // arduino
            // 
            this.arduino.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.arduino.Location = new System.Drawing.Point(39, 41);
            this.arduino.Name = "arduino";
            this.arduino.Size = new System.Drawing.Size(117, 37);
            this.arduino.TabIndex = 0;
            this.arduino.Text = "Arduino";
            this.arduino.UseVisualStyleBackColor = false;
            this.arduino.Click += new System.EventHandler(this.arduino_Click);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.about.Location = new System.Drawing.Point(65, 402);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(182, 53);
            this.about.TabIndex = 8;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = false;
            // 
            // IE322_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(912, 611);
            this.Controls.Add(this.about);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.groupBox1);
            this.Name = "IE322_Project";
            this.Text = "Mohammad ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox User;
		private System.Windows.Forms.Button log_in;
		private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button checkbox;
        private System.Windows.Forms.Button radio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button groupieapp;
        private System.Windows.Forms.Button picturebox2;
        private System.Windows.Forms.Button selfieapp;
        private System.Windows.Forms.Button picturebox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button randomcom;
        private System.Windows.Forms.Button random;
        private System.Windows.Forms.Button timer;
        private System.Windows.Forms.Button progress;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button talk;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button MC;
        private System.Windows.Forms.Button johari;
        private System.Windows.Forms.Button ABC;
        private System.Windows.Forms.Button RC;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button arduino;
        private System.Windows.Forms.Button about;
    }
}

