namespace Mohammed_IE322
{
    partial class Combo
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
            this.show1 = new System.Windows.Forms.Button();
            this.show2 = new System.Windows.Forms.Button();
            this.remove_last1 = new System.Windows.Forms.Button();
            this.remove_last2 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.remove_index = new System.Windows.Forms.Button();
            this.remove_name = new System.Windows.Forms.Button();
            this.combo_days = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // show1
            // 
            this.show1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.show1.Location = new System.Drawing.Point(80, 46);
            this.show1.Name = "show1";
            this.show1.Size = new System.Drawing.Size(148, 65);
            this.show1.TabIndex = 0;
            this.show1.Text = "Show Selected Method1";
            this.show1.UseVisualStyleBackColor = false;
            this.show1.Click += new System.EventHandler(this.button1_Click);
            // 
            // show2
            // 
            this.show2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.show2.Location = new System.Drawing.Point(225, 46);
            this.show2.Name = "show2";
            this.show2.Size = new System.Drawing.Size(150, 65);
            this.show2.TabIndex = 1;
            this.show2.Text = "Show Selected Method2";
            this.show2.UseVisualStyleBackColor = false;
            this.show2.Click += new System.EventHandler(this.show2_Click);
            // 
            // remove_last1
            // 
            this.remove_last1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.remove_last1.Location = new System.Drawing.Point(587, 87);
            this.remove_last1.Name = "remove_last1";
            this.remove_last1.Size = new System.Drawing.Size(128, 109);
            this.remove_last1.TabIndex = 2;
            this.remove_last1.Text = "Remove last item";
            this.remove_last1.UseVisualStyleBackColor = false;
            this.remove_last1.Click += new System.EventHandler(this.remove_last1_Click);
            // 
            // remove_last2
            // 
            this.remove_last2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.remove_last2.Location = new System.Drawing.Point(587, 215);
            this.remove_last2.Name = "remove_last2";
            this.remove_last2.Size = new System.Drawing.Size(128, 104);
            this.remove_last2.TabIndex = 3;
            this.remove_last2.Text = "Remove 2nd last item";
            this.remove_last2.UseVisualStyleBackColor = false;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.back.Location = new System.Drawing.Point(587, 364);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(140, 44);
            this.back.TabIndex = 4;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // remove_index
            // 
            this.remove_index.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.remove_index.Location = new System.Drawing.Point(104, 295);
            this.remove_index.Name = "remove_index";
            this.remove_index.Size = new System.Drawing.Size(135, 65);
            this.remove_index.TabIndex = 5;
            this.remove_index.Text = "Remove by Index";
            this.remove_index.UseVisualStyleBackColor = false;
            this.remove_index.Click += new System.EventHandler(this.remove_index_Click);
            // 
            // remove_name
            // 
            this.remove_name.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.remove_name.Location = new System.Drawing.Point(254, 295);
            this.remove_name.Name = "remove_name";
            this.remove_name.Size = new System.Drawing.Size(137, 65);
            this.remove_name.TabIndex = 6;
            this.remove_name.Text = "Remove by Name";
            this.remove_name.UseVisualStyleBackColor = false;
            this.remove_name.Click += new System.EventHandler(this.remove_name_Click);
            // 
            // combo_days
            // 
            this.combo_days.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.combo_days.FormattingEnabled = true;
            this.combo_days.Location = new System.Drawing.Point(161, 186);
            this.combo_days.Name = "combo_days";
            this.combo_days.Size = new System.Drawing.Size(230, 27);
            this.combo_days.TabIndex = 7;
            this.combo_days.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Days";
            // 
            // Combo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_days);
            this.Controls.Add(this.remove_name);
            this.Controls.Add(this.remove_index);
            this.Controls.Add(this.back);
            this.Controls.Add(this.remove_last2);
            this.Controls.Add(this.remove_last1);
            this.Controls.Add(this.show2);
            this.Controls.Add(this.show1);
            this.Name = "Combo";
            this.Text = "Combo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button show1;
        private System.Windows.Forms.Button show2;
        private System.Windows.Forms.Button remove_last1;
        private System.Windows.Forms.Button remove_last2;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button remove_index;
        private System.Windows.Forms.Button remove_name;
        private System.Windows.Forms.ComboBox combo_days;
        private System.Windows.Forms.Label label1;
    }
}