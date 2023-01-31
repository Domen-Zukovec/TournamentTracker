namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.headerLabel1 = new System.Windows.Forms.Label();
            this.TournamentNameLabel1 = new System.Windows.Forms.Label();
            this.roundLabel1 = new System.Windows.Forms.Label();
            this.roundDropDownComboBox1 = new System.Windows.Forms.ComboBox();
            this.UnplayedOnlyCheckBox1 = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneNameLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreTextBox1 = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreTextBox = new System.Windows.Forms.TextBox();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.TeamTwoLabel = new System.Windows.Forms.Label();
            this.versusLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel1
            // 
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel1.Location = new System.Drawing.Point(213, 9);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(118, 50);
            this.headerLabel1.TabIndex = 0;
            this.headerLabel1.Text = "Turnir:";
            // 
            // TournamentNameLabel1
            // 
            this.TournamentNameLabel1.AutoSize = true;
            this.TournamentNameLabel1.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentNameLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TournamentNameLabel1.Location = new System.Drawing.Point(337, 9);
            this.TournamentNameLabel1.Name = "TournamentNameLabel1";
            this.TournamentNameLabel1.Size = new System.Drawing.Size(150, 50);
            this.TournamentNameLabel1.TabIndex = 1;
            this.TournamentNameLabel1.Text = "<none>";
            this.TournamentNameLabel1.Click += new System.EventHandler(this.TournamentNameLabel1_Click);
            // 
            // roundLabel1
            // 
            this.roundLabel1.AutoSize = true;
            this.roundLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.roundLabel1.Location = new System.Drawing.Point(12, 80);
            this.roundLabel1.Name = "roundLabel1";
            this.roundLabel1.Size = new System.Drawing.Size(93, 37);
            this.roundLabel1.TabIndex = 2;
            this.roundLabel1.Text = "Runda";
            this.roundLabel1.Click += new System.EventHandler(this.roundLabel1_Click);
            // 
            // roundDropDownComboBox1
            // 
            this.roundDropDownComboBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundDropDownComboBox1.FormattingEnabled = true;
            this.roundDropDownComboBox1.Location = new System.Drawing.Point(111, 79);
            this.roundDropDownComboBox1.Name = "roundDropDownComboBox1";
            this.roundDropDownComboBox1.Size = new System.Drawing.Size(185, 38);
            this.roundDropDownComboBox1.TabIndex = 3;
            // 
            // UnplayedOnlyCheckBox1
            // 
            this.UnplayedOnlyCheckBox1.AutoSize = true;
            this.UnplayedOnlyCheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedOnlyCheckBox1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnplayedOnlyCheckBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UnplayedOnlyCheckBox1.Location = new System.Drawing.Point(111, 123);
            this.UnplayedOnlyCheckBox1.Name = "UnplayedOnlyCheckBox1";
            this.UnplayedOnlyCheckBox1.Size = new System.Drawing.Size(204, 41);
            this.UnplayedOnlyCheckBox1.TabIndex = 4;
            this.UnplayedOnlyCheckBox1.Text = "Samo neigrani";
            this.UnplayedOnlyCheckBox1.UseVisualStyleBackColor = true;
            this.UnplayedOnlyCheckBox1.CheckedChanged += new System.EventHandler(this.UnplayedOnlyCheckBox1_CheckedChanged);
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 30;
            this.matchupListBox.Location = new System.Drawing.Point(12, 178);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(285, 272);
            this.matchupListBox.TabIndex = 5;
            // 
            // teamOneNameLabel
            // 
            this.teamOneNameLabel.AutoSize = true;
            this.teamOneNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamOneNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teamOneNameLabel.Location = new System.Drawing.Point(337, 178);
            this.teamOneNameLabel.Name = "teamOneNameLabel";
            this.teamOneNameLabel.Size = new System.Drawing.Size(165, 37);
            this.teamOneNameLabel.TabIndex = 6;
            this.teamOneNameLabel.Text = "<team one>";
            // 
            // TeamOneScoreLabel
            // 
            this.TeamOneScoreLabel.AutoSize = true;
            this.TeamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamOneScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TeamOneScoreLabel.Location = new System.Drawing.Point(337, 228);
            this.TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            this.TeamOneScoreLabel.Size = new System.Drawing.Size(83, 37);
            this.TeamOneScoreLabel.TabIndex = 7;
            this.TeamOneScoreLabel.Text = "Točke";
            this.TeamOneScoreLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TeamOneScoreTextBox1
            // 
            this.TeamOneScoreTextBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamOneScoreTextBox1.Location = new System.Drawing.Point(426, 230);
            this.TeamOneScoreTextBox1.Name = "TeamOneScoreTextBox1";
            this.TeamOneScoreTextBox1.Size = new System.Drawing.Size(100, 35);
            this.TeamOneScoreTextBox1.TabIndex = 8;
            this.TeamOneScoreTextBox1.TextChanged += new System.EventHandler(this.TeamOneScoreTextBox1_TextChanged);
            // 
            // TeamTwoScoreTextBox
            // 
            this.TeamTwoScoreTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamTwoScoreTextBox.Location = new System.Drawing.Point(426, 405);
            this.TeamTwoScoreTextBox.Name = "TeamTwoScoreTextBox";
            this.TeamTwoScoreTextBox.Size = new System.Drawing.Size(100, 35);
            this.TeamTwoScoreTextBox.TabIndex = 11;
            this.TeamTwoScoreTextBox.TextChanged += new System.EventHandler(this.TeamTwoScoreTextBox_TextChanged);
            // 
            // teamTwoScoreLabel
            // 
            this.teamTwoScoreLabel.AutoSize = true;
            this.teamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamTwoScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(337, 403);
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(83, 37);
            this.teamTwoScoreLabel.TabIndex = 10;
            this.teamTwoScoreLabel.Text = "Točke";
            // 
            // TeamTwoLabel
            // 
            this.TeamTwoLabel.AutoSize = true;
            this.TeamTwoLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamTwoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TeamTwoLabel.Location = new System.Drawing.Point(337, 353);
            this.TeamTwoLabel.Name = "TeamTwoLabel";
            this.TeamTwoLabel.Size = new System.Drawing.Size(165, 37);
            this.TeamTwoLabel.TabIndex = 9;
            this.TeamTwoLabel.Text = "<team two>";
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.versusLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.versusLabel.Location = new System.Drawing.Point(384, 304);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(70, 37);
            this.versusLabel.TabIndex = 12;
            this.versusLabel.Text = "-VS-";
            this.versusLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.scoreButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.scoreButton.Location = new System.Drawing.Point(549, 297);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(107, 44);
            this.scoreButton.TabIndex = 13;
            this.scoreButton.Text = "Točke";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 483);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.TeamTwoScoreTextBox);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.TeamTwoLabel);
            this.Controls.Add(this.TeamOneScoreTextBox1);
            this.Controls.Add(this.TeamOneScoreLabel);
            this.Controls.Add(this.teamOneNameLabel);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.UnplayedOnlyCheckBox1);
            this.Controls.Add(this.roundDropDownComboBox1);
            this.Controls.Add(this.roundLabel1);
            this.Controls.Add(this.TournamentNameLabel1);
            this.Controls.Add(this.headerLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TournamentViewerForm";
            this.Text = "Pregled Turnijra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel1;
        private Label TournamentNameLabel1;
        private Label roundLabel1;
        private ComboBox roundDropDownComboBox1;
        private CheckBox UnplayedOnlyCheckBox1;
        private ListBox matchupListBox;
        private Label teamOneNameLabel;
        private Label TeamOneScoreLabel;
        private TextBox TeamOneScoreTextBox1;
        private TextBox TeamTwoScoreTextBox;
        private Label teamTwoScoreLabel;
        private Label TeamTwoLabel;
        private Label versusLabel;
        private Button scoreButton;
    }
}