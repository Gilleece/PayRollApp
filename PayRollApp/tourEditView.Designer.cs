namespace PayRollApp
{
    partial class tourEditView
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
            this.tourData = new System.Windows.Forms.DataGridView();
            this.editTourBtn = new System.Windows.Forms.Button();
            this.addTourBtn = new System.Windows.Forms.Button();
            this.deleteTourBtn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tourData)).BeginInit();
            this.SuspendLayout();
            // 
            // tourData
            // 
            this.tourData.AllowUserToAddRows = false;
            this.tourData.AllowUserToDeleteRows = false;
            this.tourData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tourData.Location = new System.Drawing.Point(12, 12);
            this.tourData.MultiSelect = false;
            this.tourData.Name = "tourData";
            this.tourData.ReadOnly = true;
            this.tourData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tourData.Size = new System.Drawing.Size(776, 342);
            this.tourData.TabIndex = 0;
            this.tourData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tourData_CellClick_1);
            // 
            // editTourBtn
            // 
            this.editTourBtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.editTourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTourBtn.Location = new System.Drawing.Point(89, 371);
            this.editTourBtn.Name = "editTourBtn";
            this.editTourBtn.Size = new System.Drawing.Size(113, 46);
            this.editTourBtn.TabIndex = 8;
            this.editTourBtn.Text = "Edit Selected Tour";
            this.editTourBtn.UseVisualStyleBackColor = false;
            this.editTourBtn.Click += new System.EventHandler(this.editTourBtn_Click);
            // 
            // addTourBtn
            // 
            this.addTourBtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.addTourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTourBtn.Location = new System.Drawing.Point(564, 371);
            this.addTourBtn.Name = "addTourBtn";
            this.addTourBtn.Size = new System.Drawing.Size(113, 46);
            this.addTourBtn.TabIndex = 9;
            this.addTourBtn.Text = "Add New Tour";
            this.addTourBtn.UseVisualStyleBackColor = false;
            // 
            // deleteTourBtn
            // 
            this.deleteTourBtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.deleteTourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTourBtn.Location = new System.Drawing.Point(323, 371);
            this.deleteTourBtn.Name = "deleteTourBtn";
            this.deleteTourBtn.Size = new System.Drawing.Size(113, 46);
            this.deleteTourBtn.TabIndex = 10;
            this.deleteTourBtn.Text = "Delete Selected Tour";
            this.deleteTourBtn.UseVisualStyleBackColor = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.MediumVioletRed;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(726, 401);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(72, 46);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // tourEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.deleteTourBtn);
            this.Controls.Add(this.addTourBtn);
            this.Controls.Add(this.editTourBtn);
            this.Controls.Add(this.tourData);
            this.Name = "tourEditView";
            this.Text = "tourEditView";
            ((System.ComponentModel.ISupportInitialize)(this.tourData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tourData;
        private System.Windows.Forms.Button editTourBtn;
        private System.Windows.Forms.Button addTourBtn;
        private System.Windows.Forms.Button deleteTourBtn;
        private System.Windows.Forms.Button Exit;
    }
}