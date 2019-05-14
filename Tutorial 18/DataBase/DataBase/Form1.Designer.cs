namespace DataBase
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
            this.Record = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Recordlbl = new System.Windows.Forms.Label();
            this.NextRecordbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Record
            // 
            this.Record.AutoSize = true;
            this.Record.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Record.Location = new System.Drawing.Point(12, 9);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(72, 24);
            this.Record.TabIndex = 0;
            this.Record.Text = "Record";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(13, 33);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(104, 16);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID     Description";
            // 
            // Recordlbl
            // 
            this.Recordlbl.AutoSize = true;
            this.Recordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recordlbl.Location = new System.Drawing.Point(13, 49);
            this.Recordlbl.Name = "Recordlbl";
            this.Recordlbl.Size = new System.Drawing.Size(11, 16);
            this.Recordlbl.TabIndex = 3;
            this.Recordlbl.Text = ".";
            // 
            // NextRecordbtn
            // 
            this.NextRecordbtn.Location = new System.Drawing.Point(9, 81);
            this.NextRecordbtn.Name = "NextRecordbtn";
            this.NextRecordbtn.Size = new System.Drawing.Size(75, 23);
            this.NextRecordbtn.TabIndex = 5;
            this.NextRecordbtn.Text = "Next Record";
            this.NextRecordbtn.UseVisualStyleBackColor = true;
            this.NextRecordbtn.Click += new System.EventHandler(this.NextRecordbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 113);
            this.Controls.Add(this.NextRecordbtn);
            this.Controls.Add(this.Recordlbl);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Record);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Record;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Recordlbl;
        private System.Windows.Forms.Button NextRecordbtn;
    }
}

