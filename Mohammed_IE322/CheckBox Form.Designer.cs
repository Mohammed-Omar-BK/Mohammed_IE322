namespace Mohammed_IE322
{
    partial class CheckBox_Form
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
            this.show = new System.Windows.Forms.Button();
            this.coffee = new System.Windows.Forms.CheckBox();
            this.donut = new System.Windows.Forms.CheckBox();
            this.brownie = new System.Windows.Forms.CheckBox();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.show.Location = new System.Drawing.Point(47, 46);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(151, 38);
            this.show.TabIndex = 0;
            this.show.Text = "Show";
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // coffee
            // 
            this.coffee.AutoSize = true;
            this.coffee.Location = new System.Drawing.Point(106, 158);
            this.coffee.Name = "coffee";
            this.coffee.Size = new System.Drawing.Size(80, 23);
            this.coffee.TabIndex = 1;
            this.coffee.Text = "Coffee";
            this.coffee.UseVisualStyleBackColor = true;
            // 
            // donut
            // 
            this.donut.AutoSize = true;
            this.donut.Location = new System.Drawing.Point(106, 220);
            this.donut.Name = "donut";
            this.donut.Size = new System.Drawing.Size(78, 23);
            this.donut.TabIndex = 2;
            this.donut.Text = "Donut";
            this.donut.UseVisualStyleBackColor = true;
            // 
            // brownie
            // 
            this.brownie.AutoSize = true;
            this.brownie.Location = new System.Drawing.Point(106, 281);
            this.brownie.Name = "brownie";
            this.brownie.Size = new System.Drawing.Size(92, 23);
            this.brownie.TabIndex = 3;
            this.brownie.Text = "Brownie";
            this.brownie.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.back.Location = new System.Drawing.Point(296, 359);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(138, 43);
            this.back.TabIndex = 4;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // CheckBox_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.brownie);
            this.Controls.Add(this.donut);
            this.Controls.Add(this.coffee);
            this.Controls.Add(this.show);
            this.Name = "CheckBox_Form";
            this.Text = "CheckBox_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button show;
        private System.Windows.Forms.CheckBox coffee;
        private System.Windows.Forms.CheckBox donut;
        private System.Windows.Forms.CheckBox brownie;
        private System.Windows.Forms.Button back;
    }
}