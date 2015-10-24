namespace Client_Layer
{
    partial class PlayerWindow
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
            this.components = new System.ComponentModel.Container();
            this.clubComboBox = new System.Windows.Forms.ComboBox();
            this.teamsClubTeamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gAA_TemplatesDataSet = new Client_Layer.GAA_TemplatesDataSet();
            this.countyComboBox = new System.Windows.Forms.ComboBox();
            this.countiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teams_ClubTeamTableAdapter = new Client_Layer.GAA_TemplatesDataSetTableAdapters.Teams_ClubTeamTableAdapter();
            this.countiesTableAdapter = new Client_Layer.GAA_TemplatesDataSetTableAdapters.CountiesTableAdapter();
            this.countyPlayerCheckBox = new System.Windows.Forms.CheckBox();
            this.countyLabel = new System.Windows.Forms.Label();
            this.clubLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newCountyButton = new System.Windows.Forms.Button();
            this.newClubButton = new System.Windows.Forms.Button();
            this.obsoleteCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.teamsClubTeamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAA_TemplatesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clubComboBox
            // 
            this.clubComboBox.DataSource = this.teamsClubTeamBindingSource;
            this.clubComboBox.DisplayMember = "Name";
            this.clubComboBox.FormattingEnabled = true;
            this.clubComboBox.Location = new System.Drawing.Point(81, 85);
            this.clubComboBox.Name = "clubComboBox";
            this.clubComboBox.Size = new System.Drawing.Size(121, 21);
            this.clubComboBox.TabIndex = 3;
            this.clubComboBox.ValueMember = "ID";
            // 
            // teamsClubTeamBindingSource
            // 
            this.teamsClubTeamBindingSource.DataMember = "Teams_ClubTeam";
            this.teamsClubTeamBindingSource.DataSource = this.gAA_TemplatesDataSet;
            // 
            // gAA_TemplatesDataSet
            // 
            this.gAA_TemplatesDataSet.DataSetName = "GAA_TemplatesDataSet";
            this.gAA_TemplatesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countyComboBox
            // 
            this.countyComboBox.DataSource = this.countiesBindingSource;
            this.countyComboBox.DisplayMember = "Name";
            this.countyComboBox.FormattingEnabled = true;
            this.countyComboBox.Location = new System.Drawing.Point(81, 58);
            this.countyComboBox.Name = "countyComboBox";
            this.countyComboBox.Size = new System.Drawing.Size(121, 21);
            this.countyComboBox.TabIndex = 2;
            this.countyComboBox.ValueMember = "ID";
            // 
            // countiesBindingSource
            // 
            this.countiesBindingSource.DataMember = "Counties";
            this.countiesBindingSource.DataSource = this.gAA_TemplatesDataSet;
            // 
            // teams_ClubTeamTableAdapter
            // 
            this.teams_ClubTeamTableAdapter.ClearBeforeFill = true;
            // 
            // countiesTableAdapter
            // 
            this.countiesTableAdapter.ClearBeforeFill = true;
            // 
            // countyPlayerCheckBox
            // 
            this.countyPlayerCheckBox.AutoSize = true;
            this.countyPlayerCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.countyPlayerCheckBox.Location = new System.Drawing.Point(99, 112);
            this.countyPlayerCheckBox.Name = "countyPlayerCheckBox";
            this.countyPlayerCheckBox.Size = new System.Drawing.Size(103, 17);
            this.countyPlayerCheckBox.TabIndex = 4;
            this.countyPlayerCheckBox.Text = "County Player? :";
            this.countyPlayerCheckBox.UseVisualStyleBackColor = true;
            // 
            // countyLabel
            // 
            this.countyLabel.AutoSize = true;
            this.countyLabel.Location = new System.Drawing.Point(12, 61);
            this.countyLabel.Name = "countyLabel";
            this.countyLabel.Size = new System.Drawing.Size(46, 13);
            this.countyLabel.TabIndex = 3;
            this.countyLabel.Text = "County :";
            // 
            // clubLabel
            // 
            this.clubLabel.AutoSize = true;
            this.clubLabel.Location = new System.Drawing.Point(12, 88);
            this.clubLabel.Name = "clubLabel";
            this.clubLabel.Size = new System.Drawing.Size(34, 13);
            this.clubLabel.TabIndex = 4;
            this.clubLabel.Text = "Club :";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(81, 32);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 35);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(64, 13);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name :";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 9);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(63, 13);
            this.firstNameLabel.TabIndex = 8;
            this.firstNameLabel.Text = "First Name :";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(81, 6);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(127, 158);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(11, 158);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newCountyButton
            // 
            this.newCountyButton.Location = new System.Drawing.Point(208, 56);
            this.newCountyButton.Name = "newCountyButton";
            this.newCountyButton.Size = new System.Drawing.Size(25, 23);
            this.newCountyButton.TabIndex = 11;
            this.newCountyButton.Text = "...";
            this.newCountyButton.UseVisualStyleBackColor = true;
            this.newCountyButton.Click += new System.EventHandler(this.newCountyButton_Click);
            // 
            // newClubButton
            // 
            this.newClubButton.Location = new System.Drawing.Point(208, 85);
            this.newClubButton.Name = "newClubButton";
            this.newClubButton.Size = new System.Drawing.Size(25, 23);
            this.newClubButton.TabIndex = 12;
            this.newClubButton.Text = "...";
            this.newClubButton.UseVisualStyleBackColor = true;
            this.newClubButton.Click += new System.EventHandler(this.newClubButton_Click);
            // 
            // obsoleteCheckBox
            // 
            this.obsoleteCheckBox.AutoSize = true;
            this.obsoleteCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.obsoleteCheckBox.Location = new System.Drawing.Point(121, 135);
            this.obsoleteCheckBox.Name = "obsoleteCheckBox";
            this.obsoleteCheckBox.Size = new System.Drawing.Size(80, 17);
            this.obsoleteCheckBox.TabIndex = 5;
            this.obsoleteCheckBox.Text = "Obsolete? :";
            this.obsoleteCheckBox.UseVisualStyleBackColor = true;
            // 
            // PlayerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 192);
            this.Controls.Add(this.obsoleteCheckBox);
            this.Controls.Add(this.newClubButton);
            this.Controls.Add(this.newCountyButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.clubLabel);
            this.Controls.Add(this.countyLabel);
            this.Controls.Add(this.countyPlayerCheckBox);
            this.Controls.Add(this.countyComboBox);
            this.Controls.Add(this.clubComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PlayerWindow";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.PlayerWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamsClubTeamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAA_TemplatesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox clubComboBox;
        private System.Windows.Forms.ComboBox countyComboBox;
        private GAA_TemplatesDataSet gAA_TemplatesDataSet;
        private System.Windows.Forms.BindingSource teamsClubTeamBindingSource;
        private GAA_TemplatesDataSetTableAdapters.Teams_ClubTeamTableAdapter teams_ClubTeamTableAdapter;
        private System.Windows.Forms.BindingSource countiesBindingSource;
        private GAA_TemplatesDataSetTableAdapters.CountiesTableAdapter countiesTableAdapter;
        private System.Windows.Forms.CheckBox countyPlayerCheckBox;
        private System.Windows.Forms.Label countyLabel;
        private System.Windows.Forms.Label clubLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newCountyButton;
        private System.Windows.Forms.Button newClubButton;
        private System.Windows.Forms.CheckBox obsoleteCheckBox;
    }
}