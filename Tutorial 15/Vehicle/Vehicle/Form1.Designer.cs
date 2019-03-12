namespace Vehicle
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.BicycleLabel = new System.Windows.Forms.Label();
            this.CarLabel = new System.Windows.Forms.Label();
            this.MotorBikeLabel = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BicycleLabel
            // 
            this.BicycleLabel.AutoSize = true;
            this.BicycleLabel.Location = new System.Drawing.Point(12, 12);
            this.BicycleLabel.Name = "BicycleLabel";
            this.BicycleLabel.Size = new System.Drawing.Size(10, 13);
            this.BicycleLabel.TabIndex = 3;
            this.BicycleLabel.Text = "-";
            // 
            // CarLabel
            // 
            this.CarLabel.AutoSize = true;
            this.CarLabel.Location = new System.Drawing.Point(12, 77);
            this.CarLabel.Name = "CarLabel";
            this.CarLabel.Size = new System.Drawing.Size(10, 13);
            this.CarLabel.TabIndex = 4;
            this.CarLabel.Text = "-";
            // 
            // MotorBikeLabel
            // 
            this.MotorBikeLabel.AutoSize = true;
            this.MotorBikeLabel.Location = new System.Drawing.Point(12, 149);
            this.MotorBikeLabel.Name = "MotorBikeLabel";
            this.MotorBikeLabel.Size = new System.Drawing.Size(10, 13);
            this.MotorBikeLabel.TabIndex = 5;
            this.MotorBikeLabel.Text = "-";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(12, 215);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(10, 13);
            this.Total.TabIndex = 6;
            this.Total.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 260);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.MotorBikeLabel);
            this.Controls.Add(this.CarLabel);
            this.Controls.Add(this.BicycleLabel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label BicycleLabel;
        private System.Windows.Forms.Label CarLabel;
        private System.Windows.Forms.Label MotorBikeLabel;
        private System.Windows.Forms.Label Total;
    }
}

