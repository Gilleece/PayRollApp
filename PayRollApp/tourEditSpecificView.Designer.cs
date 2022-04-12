namespace PayRollApp
{
    partial class tourEditSpecificView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tourIDBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.tier1Box = new System.Windows.Forms.TextBox();
            this.tier2Box = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tour ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price Per Person:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tier 1 Commission %:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tier 2 Comssion %:";
            // 
            // tourIDBox
            // 
            this.tourIDBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tourIDBox.Location = new System.Drawing.Point(227, 75);
            this.tourIDBox.Name = "tourIDBox";
            this.tourIDBox.ReadOnly = true;
            this.tourIDBox.Size = new System.Drawing.Size(100, 20);
            this.tourIDBox.TabIndex = 5;
            // 
            // cityBox
            // 
            this.cityBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cityBox.Location = new System.Drawing.Point(227, 107);
            this.cityBox.Name = "cityBox";
            this.cityBox.ReadOnly = true;
            this.cityBox.Size = new System.Drawing.Size(100, 20);
            this.cityBox.TabIndex = 6;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(227, 137);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(100, 20);
            this.priceBox.TabIndex = 7;
            // 
            // tier1Box
            // 
            this.tier1Box.Location = new System.Drawing.Point(228, 169);
            this.tier1Box.Name = "tier1Box";
            this.tier1Box.Size = new System.Drawing.Size(100, 20);
            this.tier1Box.TabIndex = 8;
            // 
            // tier2Box
            // 
            this.tier2Box.Location = new System.Drawing.Point(227, 205);
            this.tier2Box.Name = "tier2Box";
            this.tier2Box.Size = new System.Drawing.Size(100, 20);
            this.tier2Box.TabIndex = 9;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Location = new System.Drawing.Point(139, 249);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(113, 46);
            this.updateBtn.TabIndex = 10;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.MediumVioletRed;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(280, 277);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(72, 46);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // tourEditSpecificView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(364, 335);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.tier2Box);
            this.Controls.Add(this.tier1Box);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.tourIDBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "tourEditSpecificView";
            this.Text = "tourEditSpecificView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tourIDBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox tier1Box;
        private System.Windows.Forms.TextBox tier2Box;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button Exit;
    }
}