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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
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
            this.clubComboBox.TabIndex = 0;
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
            this.countyComboBox.TabIndex = 1;
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
            this.countyPlayerCheckBox.TabIndex = 2;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 5;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 7;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(127, 135);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(11, 135);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // PlayerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 168);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.clubLabel);
            this.Controls.Add(this.countyLabel);
            this.Controls.Add(this.countyPlayerCheckBox);
            this.Controls.Add(this.countyComboBox);
            this.Controls.Add(this.clubComboBox);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
    }
}