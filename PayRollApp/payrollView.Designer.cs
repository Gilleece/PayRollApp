namespace PayRollApp
{
    partial class payrollView
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
            this.Exit = new System.Windows.Forms.Button();
            this.genBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userID = new System.Windows.Forms.NumericUpDown();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.month = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.userID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.month)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.MediumVioletRed;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(149, 172);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(72, 46);
            this.Exit.TabIndex = 34;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // genBtn
            // 
            this.genBtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.genBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genBtn.Location = new System.Drawing.Point(58, 120);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(113, 46);
            this.genBtn.TabIndex = 33;
            this.genBtn.Text = "Generate Payroll";
            this.genBtn.UseVisualStyleBackColor = false;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Month:";
            // 
            // yearBox
            // 
            this.yearBox.AutoSize = true;
            this.yearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearBox.Location = new System.Drawing.Point(31, 50);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(64, 25);
            this.yearBox.TabIndex = 26;
            this.yearBox.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "UserID:";
            // 
            // userID
            // 
            this.userID.Location = new System.Drawing.Point(101, 23);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(120, 20);
            this.userID.TabIndex = 35;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(101, 53);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(120, 20);
            this.year.TabIndex = 36;
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(101, 82);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(120, 20);
            this.month.TabIndex = 37;
            // 
            // payrollView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(236, 232);
            this.Controls.Add(this.month);
            this.Controls.Add(this.year);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.genBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.label2);
            this.Name = "payrollView";
            this.Text = "payrollView";
            ((System.ComponentModel.ISupportInitialize)(this.userID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.month)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button genBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label yearBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown userID;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.NumericUpDown month;
    }
}