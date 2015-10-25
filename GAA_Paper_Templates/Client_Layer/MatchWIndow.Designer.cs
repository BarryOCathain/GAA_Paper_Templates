namespace Client_Layer
{
    partial class MatchWIndow
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
            this.awayTeamGroupBox = new System.Windows.Forms.GroupBox();
            this.homeTeamGroupBox = new System.Windows.Forms.GroupBox();
            this.homeTeamDataGridView = new System.Windows.Forms.DataGridView();
            this.awayTeamDataGridView = new System.Windows.Forms.DataGridView();
            this.classificationComboBox = new System.Windows.Forms.ComboBox();
            this.homeTeamComboBox = new System.Windows.Forms.ComboBox();
            this.awayTeamComboBox = new System.Windows.Forms.ComboBox();
            this.classificationLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.awayTeamLabel = new System.Windows.Forms.Label();
            this.countyLabel = new System.Windows.Forms.Label();
            this.countiesComboBox = new System.Windows.Forms.ComboBox();
            this.awayTeamGroupBox.SuspendLayout();
            this.homeTeamGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeTeamDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awayTeamDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // awayTeamGroupBox
            // 
            this.awayTeamGroupBox.Controls.Add(this.awayTeamDataGridView);
            this.awayTeamGroupBox.Location = new System.Drawing.Point(433, 73);
            this.awayTeamGroupBox.Name = "awayTeamGroupBox";
            this.awayTeamGroupBox.Size = new System.Drawing.Size(407, 460);
            this.awayTeamGroupBox.TabIndex = 4;
            this.awayTeamGroupBox.TabStop = false;
            this.awayTeamGroupBox.Text = "Away Team";
            // 
            // homeTeamGroupBox
            // 
            this.homeTeamGroupBox.Controls.Add(this.homeTeamDataGridView);
            this.homeTeamGroupBox.Location = new System.Drawing.Point(12, 73);
            this.homeTeamGroupBox.Name = "homeTeamGroupBox";
            this.homeTeamGroupBox.Size = new System.Drawing.Size(407, 460);
            this.homeTeamGroupBox.TabIndex = 5;
            this.homeTeamGroupBox.TabStop = false;
            this.homeTeamGroupBox.Text = "Home Team";
            // 
            // homeTeamDataGridView
            // 
            this.homeTeamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homeTeamDataGridView.Location = new System.Drawing.Point(7, 20);
            this.homeTeamDataGridView.Name = "homeTeamDataGridView";
            this.homeTeamDataGridView.Size = new System.Drawing.Size(394, 453);
            this.homeTeamDataGridView.TabIndex = 0;
            // 
            // awayTeamDataGridView
            // 
            this.awayTeamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.awayTeamDataGridView.Location = new System.Drawing.Point(6, 19);
            this.awayTeamDataGridView.Name = "awayTeamDataGridView";
            this.awayTeamDataGridView.Size = new System.Drawing.Size(394, 453);
            this.awayTeamDataGridView.TabIndex = 1;
            // 
            // classificationComboBox
            // 
            this.classificationComboBox.FormattingEnabled = true;
            this.classificationComboBox.Location = new System.Drawing.Point(95, 12);
            this.classificationComboBox.Name = "classificationComboBox";
            this.classificationComboBox.Size = new System.Drawing.Size(121, 21);
            this.classificationComboBox.TabIndex = 6;
            this.classificationComboBox.SelectedIndexChanged += new System.EventHandler(this.classificationComboBox_SelectedIndexChanged);
            // 
            // homeTeamComboBox
            // 
            this.homeTeamComboBox.FormattingEnabled = true;
            this.homeTeamComboBox.Location = new System.Drawing.Point(95, 46);
            this.homeTeamComboBox.Name = "homeTeamComboBox";
            this.homeTeamComboBox.Size = new System.Drawing.Size(121, 21);
            this.homeTeamComboBox.TabIndex = 7;
            // 
            // awayTeamComboBox
            // 
            this.awayTeamComboBox.FormattingEnabled = true;
            this.awayTeamComboBox.Location = new System.Drawing.Point(514, 46);
            this.awayTeamComboBox.Name = "awayTeamComboBox";
            this.awayTeamComboBox.Size = new System.Drawing.Size(121, 21);
            this.awayTeamComboBox.TabIndex = 8;
            // 
            // classificationLabel
            // 
            this.classificationLabel.AutoSize = true;
            this.classificationLabel.Location = new System.Drawing.Point(15, 15);
            this.classificationLabel.Name = "classificationLabel";
            this.classificationLabel.Size = new System.Drawing.Size(74, 13);
            this.classificationLabel.TabIndex = 9;
            this.classificationLabel.Text = "Classification :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Home Team :";
            // 
            // awayTeamLabel
            // 
            this.awayTeamLabel.AutoSize = true;
            this.awayTeamLabel.Location = new System.Drawing.Point(439, 49);
            this.awayTeamLabel.Name = "awayTeamLabel";
            this.awayTeamLabel.Size = new System.Drawing.Size(69, 13);
            this.awayTeamLabel.TabIndex = 11;
            this.awayTeamLabel.Text = "Away Team :";
            // 
            // countyLabel
            // 
            this.countyLabel.AutoSize = true;
            this.countyLabel.Location = new System.Drawing.Point(246, 15);
            this.countyLabel.Name = "countyLabel";
            this.countyLabel.Size = new System.Drawing.Size(46, 13);
            this.countyLabel.TabIndex = 13;
            this.countyLabel.Text = "County :";
            // 
            // countiesComboBox
            // 
            this.countiesComboBox.FormattingEnabled = true;
            this.countiesComboBox.Location = new System.Drawing.Point(298, 12);
            this.countiesComboBox.Name = "countiesComboBox";
            this.countiesComboBox.Size = new System.Drawing.Size(121, 21);
            this.countiesComboBox.TabIndex = 12;
            this.countiesComboBox.SelectedIndexChanged += new System.EventHandler(this.countiesComboBox_SelectedIndexChanged);
            // 
            // MatchWIndow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 545);
            this.Controls.Add(this.countyLabel);
            this.Controls.Add(this.countiesComboBox);
            this.Controls.Add(this.awayTeamLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.classificationLabel);
            this.Controls.Add(this.awayTeamComboBox);
            this.Controls.Add(this.homeTeamComboBox);
            this.Controls.Add(this.classificationComboBox);
            this.Controls.Add(this.homeTeamGroupBox);
            this.Controls.Add(this.awayTeamGroupBox);
            this.Name = "MatchWIndow";
            this.Text = "Match";
            this.awayTeamGroupBox.ResumeLayout(false);
            this.homeTeamGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homeTeamDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awayTeamDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox awayTeamGroupBox;
        private System.Windows.Forms.DataGridView awayTeamDataGridView;
        private System.Windows.Forms.GroupBox homeTeamGroupBox;
        private System.Windows.Forms.DataGridView homeTeamDataGridView;
        private System.Windows.Forms.ComboBox classificationComboBox;
        private System.Windows.Forms.ComboBox homeTeamComboBox;
        private System.Windows.Forms.ComboBox awayTeamComboBox;
        private System.Windows.Forms.Label classificationLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label awayTeamLabel;
        private System.Windows.Forms.Label countyLabel;
        private System.Windows.Forms.ComboBox countiesComboBox;
    }
}