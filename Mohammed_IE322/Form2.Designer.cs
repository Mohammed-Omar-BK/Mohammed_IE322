namespace Mohammed_IE322
{
    partial class Radio_Form
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
            this.reset = new System.Windows.Forms.Button();
            this.red1 = new System.Windows.Forms.RadioButton();
            this.green1 = new System.Windows.Forms.RadioButton();
            this.blue1 = new System.Windows.Forms.RadioButton();
            this.yellow1 = new System.Windows.Forms.RadioButton();
            this.red2 = new System.Windows.Forms.RadioButton();
            this.green2 = new System.Windows.Forms.RadioButton();
            this.blue2 = new System.Windows.Forms.RadioButton();
            this.yellow2 = new System.Windows.Forms.RadioButton();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reset.Location = new System.Drawing.Point(279, 81);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(147, 45);
            this.reset.TabIndex = 0;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // red1
            // 
            this.red1.AutoSize = true;
            this.red1.Location = new System.Drawing.Point(221, 170);
            this.red1.Name = "red1";
            this.red1.Size = new System.Drawing.Size(61, 23);
            this.red1.TabIndex = 1;
            this.red1.TabStop = true;
            this.red1.Text = "Red";
            this.red1.UseVisualStyleBackColor = true;
            this.red1.CheckedChanged += new System.EventHandler(this.red1_CheckedChanged);
            // 
            // green1
            // 
            this.green1.AutoSize = true;
            this.green1.Location = new System.Drawing.Point(221, 211);
            this.green1.Name = "green1";
            this.green1.Size = new System.Drawing.Size(76, 23);
            this.green1.TabIndex = 2;
            this.green1.Text = "Green";
            this.green1.UseVisualStyleBackColor = true;
            this.green1.CheckedChanged += new System.EventHandler(this.green1_CheckedChanged);
            // 
            // blue1
            // 
            this.blue1.AutoSize = true;
            this.blue1.Location = new System.Drawing.Point(221, 253);
            this.blue1.Name = "blue1";
            this.blue1.Size = new System.Drawing.Size(64, 23);
            this.blue1.TabIndex = 3;
            this.blue1.TabStop = true;
            this.blue1.Text = "Blue";
            this.blue1.UseVisualStyleBackColor = true;
            this.blue1.CheckedChanged += new System.EventHandler(this.blue1_CheckedChanged);
            // 
            // yellow1
            // 
            this.yellow1.AutoSize = true;
            this.yellow1.Location = new System.Drawing.Point(221, 293);
            this.yellow1.Name = "yellow1";
            this.yellow1.Size = new System.Drawing.Size(81, 23);
            this.yellow1.TabIndex = 4;
            this.yellow1.TabStop = true;
            this.yellow1.Text = "Yellow";
            this.yellow1.UseVisualStyleBackColor = true;
            this.yellow1.CheckedChanged += new System.EventHandler(this.yellow1_CheckedChanged);
            // 
            // red2
            // 
            this.red2.AutoSize = true;
            this.red2.Location = new System.Drawing.Point(417, 170);
            this.red2.Name = "red2";
            this.red2.Size = new System.Drawing.Size(61, 23);
            this.red2.TabIndex = 5;
            this.red2.TabStop = true;
            this.red2.Text = "Red";
            this.red2.UseVisualStyleBackColor = true;
            this.red2.CheckedChanged += new System.EventHandler(this.red2_CheckedChanged);
            // 
            // green2
            // 
            this.green2.AutoSize = true;
            this.green2.Location = new System.Drawing.Point(417, 211);
            this.green2.Name = "green2";
            this.green2.Size = new System.Drawing.Size(76, 23);
            this.green2.TabIndex = 6;
            this.green2.TabStop = true;
            this.green2.Text = "Green";
            this.green2.UseVisualStyleBackColor = true;
            this.green2.CheckedChanged += new System.EventHandler(this.green2_CheckedChanged);
            // 
            // blue2
            // 
            this.blue2.AutoSize = true;
            this.blue2.Location = new System.Drawing.Point(417, 253);
            this.blue2.Name = "blue2";
            this.blue2.Size = new System.Drawing.Size(64, 23);
            this.blue2.TabIndex = 7;
            this.blue2.TabStop = true;
            this.blue2.Text = "Blue";
            this.blue2.UseVisualStyleBackColor = true;
            this.blue2.CheckedChanged += new System.EventHandler(this.blue2_CheckedChanged);
            // 
            // yellow2
            // 
            this.yellow2.AutoSize = true;
            this.yellow2.Location = new System.Drawing.Point(417, 293);
            this.yellow2.Name = "yellow2";
            this.yellow2.Size = new System.Drawing.Size(81, 23);
            this.yellow2.TabIndex = 8;
            this.yellow2.TabStop = true;
            this.yellow2.Text = "Yellow";
            this.yellow2.UseVisualStyleBackColor = true;
            this.yellow2.CheckedChanged += new System.EventHandler(this.yellow2_CheckedChanged);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.back.Location = new System.Drawing.Point(597, 352);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(115, 46);
            this.back.TabIndex = 9;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Radio_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.yellow2);
            this.Controls.Add(this.blue2);
            this.Controls.Add(this.green2);
            this.Controls.Add(this.red2);
            this.Controls.Add(this.yellow1);
            this.Controls.Add(this.blue1);
            this.Controls.Add(this.green1);
            this.Controls.Add(this.red1);
            this.Controls.Add(this.reset);
            this.Name = "Radio_Form";
            this.Text = "Radio Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.RadioButton red1;
        private System.Windows.Forms.RadioButton green1;
        private System.Windows.Forms.RadioButton blue1;
        private System.Windows.Forms.RadioButton yellow1;
        private System.Windows.Forms.RadioButton red2;
        private System.Windows.Forms.RadioButton green2;
        private System.Windows.Forms.RadioButton blue2;
        private System.Windows.Forms.RadioButton yellow2;
        private System.Windows.Forms.Button back;
    }
}