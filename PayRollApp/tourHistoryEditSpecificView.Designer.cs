namespace PayRollApp
{
    partial class tourHistoryEditSpecificView
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
            this.updateBtn = new System.Windows.Forms.Button();
            this.guideBox = new System.Windows.Forms.TextBox();
            this.dayBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tourIDBox = new System.Windows.Forms.TextBox();
            this.attenBox = new System.Windows.Forms.TextBox();
            this.monthBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.MediumVioletRed;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(279, 184);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(72, 46);
            this.Exit.TabIndex = 24;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Location = new System.Drawing.Point(138, 156);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(113, 46);
            this.updateBtn.TabIndex = 23;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // guideBox
            // 
            this.guideBox.Location = new System.Drawing.Point(226, 118);
            this.guideBox.Name = "guideBox";
            this.guideBox.Size = new System.Drawing.Size(135, 20);
            this.guideBox.TabIndex = 22;
            // 
            // dayBox
            // 
            this.dayBox.Location = new System.Drawing.Point(226, 85);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(34, 20);
            this.dayBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Guide by UserID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "DD/MM/YYYY:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Attendance:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tour ID:";
            // 
            // tourIDBox
            // 
            this.tourIDBox.Location = new System.Drawing.Point(226, 21);
            this.tourIDBox.Name = "tourIDBox";
            this.tourIDBox.Size = new System.Drawing.Size(135, 20);
            this.tourIDBox.TabIndex = 25;
            // 
            // attenBox
            // 
            this.attenBox.Location = new System.Drawing.Point(226, 52);
            this.attenBox.Name = "attenBox";
            this.attenBox.Size = new System.Drawing.Size(135, 20);
            this.attenBox.TabIndex = 26;
            // 
            // monthBox
            // 
            this.monthBox.Location = new System.Drawing.Point(266, 85);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(34, 20);
            this.monthBox.TabIndex = 27;
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(306, 85);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(55, 20);
            this.yearBox.TabIndex = 28;
            // 
            // tourHistoryEditSpecificView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(370, 244);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.attenBox);
            this.Controls.Add(this.tourIDBox);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.guideBox);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "tourHistoryEditSpecificView";
            this.Text = "tourHistoryEditSpecificView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox guideBox;
        private System.Windows.Forms.TextBox dayBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tourIDBox;
        private System.Windows.Forms.TextBox attenBox;
        private System.Windows.Forms.TextBox monthBox;
        private System.Windows.Forms.TextBox yearBox;
    }
}