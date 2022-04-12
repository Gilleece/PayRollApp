namespace PayRollApp
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.userIDinput = new System.Windows.Forms.TextBox();
            this.userIDlabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.placeholderText = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userIDinput
            // 
            this.userIDinput.Location = new System.Drawing.Point(171, 111);
            this.userIDinput.Name = "userIDinput";
            this.userIDinput.Size = new System.Drawing.Size(100, 20);
            this.userIDinput.TabIndex = 0;
            // 
            // userIDlabel
            // 
            this.userIDlabel.AutoSize = true;
            this.userIDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDlabel.Location = new System.Drawing.Point(87, 108);
            this.userIDlabel.Name = "userIDlabel";
            this.userIDlabel.Size = new System.Drawing.Size(83, 25);
            this.userIDlabel.TabIndex = 1;
            this.userIDlabel.Text = "User ID:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(67, 144);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(104, 25);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(171, 147);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(100, 20);
            this.passwordInput.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.logInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInButton.Location = new System.Drawing.Point(141, 184);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(75, 23);
            this.logInButton.TabIndex = 5;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // placeholderText
            // 
            this.placeholderText.AutoSize = true;
            this.placeholderText.Location = new System.Drawing.Point(24, 313);
            this.placeholderText.Name = "placeholderText";
            this.placeholderText.Size = new System.Drawing.Size(301, 13);
            this.placeholderText.TabIndex = 6;
            this.placeholderText.Text = "PLACEHOLDER LOGINS FOR TESTING PURPOSES ONLY:";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 329);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(344, 188);
            this.dataGridView.TabIndex = 7;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(357, 527);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.placeholderText);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.userIDlabel);
            this.Controls.Add(this.userIDinput);
            this.Name = "login";
            this.Text = "Please Log In";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userIDinput;
        private System.Windows.Forms.Label userIDlabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Label placeholderText;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

