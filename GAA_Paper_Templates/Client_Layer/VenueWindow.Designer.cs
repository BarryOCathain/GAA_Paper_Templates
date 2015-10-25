namespace Client_Layer
{
    partial class VenueWindow
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.countyComboBox = new System.Windows.Forms.ComboBox();
            this.venueLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.countyLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(72, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(122, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(72, 32);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(122, 20);
            this.locationTextBox.TabIndex = 1;
            // 
            // countyComboBox
            // 
            this.countyComboBox.FormattingEnabled = true;
            this.countyComboBox.Location = new System.Drawing.Point(72, 59);
            this.countyComboBox.Name = "countyComboBox";
            this.countyComboBox.Size = new System.Drawing.Size(122, 21);
            this.countyComboBox.TabIndex = 2;
            // 
            // venueLabel
            // 
            this.venueLabel.AutoSize = true;
            this.venueLabel.Location = new System.Drawing.Point(12, 9);
            this.venueLabel.Name = "venueLabel";
            this.venueLabel.Size = new System.Drawing.Size(44, 13);
            this.venueLabel.TabIndex = 3;
            this.venueLabel.Text = "Venue :";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(12, 35);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(54, 13);
            this.locationLabel.TabIndex = 4;
            this.locationLabel.Text = "Location :";
            // 
            // countyLabel
            // 
            this.countyLabel.AutoSize = true;
            this.countyLabel.Location = new System.Drawing.Point(12, 62);
            this.countyLabel.Name = "countyLabel";
            this.countyLabel.Size = new System.Drawing.Size(46, 13);
            this.countyLabel.TabIndex = 5;
            this.countyLabel.Text = "County :";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(15, 86);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(119, 86);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // VenueWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 118);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.countyLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.venueLabel);
            this.Controls.Add(this.countyComboBox);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "VenueWindow";
            this.Text = "Venue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.ComboBox countyComboBox;
        private System.Windows.Forms.Label venueLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label countyLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button closeButton;
    }
}