namespace Client_Layer
{
    partial class ClubWindow
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
            this.countyComboBox = new System.Windows.Forms.ComboBox();
            this.countyLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.clubLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // countyComboBox
            // 
            this.countyComboBox.FormattingEnabled = true;
            this.countyComboBox.Location = new System.Drawing.Point(64, 32);
            this.countyComboBox.Name = "countyComboBox";
            this.countyComboBox.Size = new System.Drawing.Size(121, 21);
            this.countyComboBox.TabIndex = 0;
            // 
            // countyLabel
            // 
            this.countyLabel.AutoSize = true;
            this.countyLabel.Location = new System.Drawing.Point(12, 35);
            this.countyLabel.Name = "countyLabel";
            this.countyLabel.Size = new System.Drawing.Size(46, 13);
            this.countyLabel.TabIndex = 1;
            this.countyLabel.Text = "County :";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(64, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // clubLabel
            // 
            this.clubLabel.AutoSize = true;
            this.clubLabel.Location = new System.Drawing.Point(12, 9);
            this.clubLabel.Name = "clubLabel";
            this.clubLabel.Size = new System.Drawing.Size(34, 13);
            this.clubLabel.TabIndex = 3;
            this.clubLabel.Text = "Club :";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(111, 59);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(15, 59);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ClubWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 97);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.clubLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.countyLabel);
            this.Controls.Add(this.countyComboBox);
            this.Name = "ClubWindow";
            this.Text = "Club";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox countyComboBox;
        private System.Windows.Forms.Label countyLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label clubLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
    }
}