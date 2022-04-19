namespace PayRollApp
{
    partial class guideView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guideView));
            this.Exit = new System.Windows.Forms.Button();
            this.PayrollBtn = new System.Windows.Forms.Button();
            this.editTourHistoryBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.MediumVioletRed;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(246, 250);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(72, 39);
            this.Exit.TabIndex = 16;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // PayrollBtn
            // 
            this.PayrollBtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.PayrollBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayrollBtn.Location = new System.Drawing.Point(97, 122);
            this.PayrollBtn.Name = "PayrollBtn";
            this.PayrollBtn.Size = new System.Drawing.Size(113, 39);
            this.PayrollBtn.TabIndex = 15;
            this.PayrollBtn.Text = "Payroll";
            this.PayrollBtn.UseVisualStyleBackColor = false;
            this.PayrollBtn.Click += new System.EventHandler(this.PayrollBtn_Click);
            // 
            // editTourHistoryBtn
            // 
            this.editTourHistoryBtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.editTourHistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTourHistoryBtn.Location = new System.Drawing.Point(97, 60);
            this.editTourHistoryBtn.Name = "editTourHistoryBtn";
            this.editTourHistoryBtn.Size = new System.Drawing.Size(113, 39);
            this.editTourHistoryBtn.TabIndex = 14;
            this.editTourHistoryBtn.Text = "Edit Tour History";
            this.editTourHistoryBtn.UseVisualStyleBackColor = false;
            this.editTourHistoryBtn.Click += new System.EventHandler(this.editTourHistoryBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 43);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // guideView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(336, 293);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.PayrollBtn);
            this.Controls.Add(this.editTourHistoryBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "guideView";
            this.Text = "guideView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button PayrollBtn;
        private System.Windows.Forms.Button editTourHistoryBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}