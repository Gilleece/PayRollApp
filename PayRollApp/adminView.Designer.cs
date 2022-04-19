namespace PayRollApp
{
    partial class adminView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminView));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.editTourBtn = new System.Windows.Forms.Button();
            this.editTourHistoryBtn = new System.Windows.Forms.Button();
            this.PayrollBtn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(72, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 56);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // editTourBtn
            // 
            this.editTourBtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.editTourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTourBtn.Location = new System.Drawing.Point(122, 140);
            this.editTourBtn.Name = "editTourBtn";
            this.editTourBtn.Size = new System.Drawing.Size(113, 46);
            this.editTourBtn.TabIndex = 7;
            this.editTourBtn.Text = "Edit Tours";
            this.editTourBtn.UseVisualStyleBackColor = false;
            this.editTourBtn.Click += new System.EventHandler(this.editTourBtn_Click);
            // 
            // editTourHistoryBtn
            // 
            this.editTourHistoryBtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.editTourHistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTourHistoryBtn.Location = new System.Drawing.Point(121, 202);
            this.editTourHistoryBtn.Name = "editTourHistoryBtn";
            this.editTourHistoryBtn.Size = new System.Drawing.Size(113, 46);
            this.editTourHistoryBtn.TabIndex = 8;
            this.editTourHistoryBtn.Text = "Edit Tour History";
            this.editTourHistoryBtn.UseVisualStyleBackColor = false;
            this.editTourHistoryBtn.Click += new System.EventHandler(this.editTourHistoryBtn_Click);
            // 
            // PayrollBtn
            // 
            this.PayrollBtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.PayrollBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayrollBtn.Location = new System.Drawing.Point(121, 264);
            this.PayrollBtn.Name = "PayrollBtn";
            this.PayrollBtn.Size = new System.Drawing.Size(113, 46);
            this.PayrollBtn.TabIndex = 9;
            this.PayrollBtn.Text = "Payroll";
            this.PayrollBtn.UseVisualStyleBackColor = false;
            this.PayrollBtn.Click += new System.EventHandler(this.PayrollBtn_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.MediumVioletRed;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(270, 392);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(72, 46);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // adminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.PayrollBtn);
            this.Controls.Add(this.editTourHistoryBtn);
            this.Controls.Add(this.editTourBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "adminView";
            this.Text = "adminView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button editTourBtn;
        private System.Windows.Forms.Button editTourHistoryBtn;
        private System.Windows.Forms.Button PayrollBtn;
        private System.Windows.Forms.Button Exit;
    }
}