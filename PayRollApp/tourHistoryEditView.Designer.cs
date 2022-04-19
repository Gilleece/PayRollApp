namespace PayRollApp
{
    partial class tourHistoryEditView
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
            this.addTourBtn = new System.Windows.Forms.Button();
            this.editTourBtn = new System.Windows.Forms.Button();
            this.tourData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tourData)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.MediumVioletRed;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(721, 397);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(72, 46);
            this.Exit.TabIndex = 15;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            // 
            // addTourBtn
            // 
            this.addTourBtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.addTourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTourBtn.Location = new System.Drawing.Point(459, 367);
            this.addTourBtn.Name = "addTourBtn";
            this.addTourBtn.Size = new System.Drawing.Size(113, 46);
            this.addTourBtn.TabIndex = 14;
            this.addTourBtn.Text = "Add New Tour";
            this.addTourBtn.UseVisualStyleBackColor = false;
            this.addTourBtn.Click += new System.EventHandler(this.addTourBtn_Click);
            // 
            // editTourBtn
            // 
            this.editTourBtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.editTourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTourBtn.Location = new System.Drawing.Point(215, 367);
            this.editTourBtn.Name = "editTourBtn";
            this.editTourBtn.Size = new System.Drawing.Size(113, 46);
            this.editTourBtn.TabIndex = 13;
            this.editTourBtn.Text = "Edit Selected Tour";
            this.editTourBtn.UseVisualStyleBackColor = false;
            this.editTourBtn.Click += new System.EventHandler(this.editTourBtn_Click);
            // 
            // tourData
            // 
            this.tourData.AllowUserToAddRows = false;
            this.tourData.AllowUserToDeleteRows = false;
            this.tourData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tourData.Location = new System.Drawing.Point(7, 8);
            this.tourData.MultiSelect = false;
            this.tourData.Name = "tourData";
            this.tourData.ReadOnly = true;
            this.tourData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tourData.Size = new System.Drawing.Size(776, 342);
            this.tourData.TabIndex = 12;
            this.tourData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tourData_CellClick_1);
            this.tourData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tourData_CellContentClick);
            // 
            // tourHistoryEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.addTourBtn);
            this.Controls.Add(this.editTourBtn);
            this.Controls.Add(this.tourData);
            this.Name = "tourHistoryEditView";
            this.Text = "tourHistoryEditView";
            ((System.ComponentModel.ISupportInitialize)(this.tourData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button addTourBtn;
        private System.Windows.Forms.Button editTourBtn;
        private System.Windows.Forms.DataGridView tourData;
    }
}