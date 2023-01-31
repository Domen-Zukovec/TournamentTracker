namespace TrackerUI
{
    partial class CreateTurnamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTurnamentForm));
            this.addTeamButton = new System.Windows.Forms.Button();
            this.entryFeeValueTextBox = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.turnamentNameValueTextBox1 = new System.Windows.Forms.TextBox();
            this.turnamentNameLabel = new System.Windows.Forms.Label();
            this.turnamentPlayersLabel = new System.Windows.Forms.Label();
            this.TurnamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.selectTeamDropDownComboBox1 = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.headerLabel1 = new System.Windows.Forms.Label();
            this.createNewTeamLinkLabel = new System.Windows.Forms.LinkLabel();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.deleteSelectedPlayerButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.createTurnamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.addTeamButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addTeamButton.Location = new System.Drawing.Point(12, 320);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(216, 44);
            this.addTeamButton.TabIndex = 27;
            this.addTeamButton.Text = "Dodaj ekipo";
            this.addTeamButton.UseVisualStyleBackColor = true;
            // 
            // entryFeeValueTextBox
            // 
            this.entryFeeValueTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entryFeeValueTextBox.Location = new System.Drawing.Point(203, 175);
            this.entryFeeValueTextBox.Name = "entryFeeValueTextBox";
            this.entryFeeValueTextBox.Size = new System.Drawing.Size(124, 35);
            this.entryFeeValueTextBox.TabIndex = 25;
            this.entryFeeValueTextBox.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entryFeeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.entryFeeLabel.Location = new System.Drawing.Point(12, 173);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(136, 37);
            this.entryFeeLabel.TabIndex = 24;
            this.entryFeeLabel.Text = "Vstopnina";
            this.entryFeeLabel.Click += new System.EventHandler(this.teamTwoScoreLabel_Click);
            // 
            // turnamentNameValueTextBox1
            // 
            this.turnamentNameValueTextBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.turnamentNameValueTextBox1.Location = new System.Drawing.Point(12, 111);
            this.turnamentNameValueTextBox1.Name = "turnamentNameValueTextBox1";
            this.turnamentNameValueTextBox1.Size = new System.Drawing.Size(315, 35);
            this.turnamentNameValueTextBox1.TabIndex = 22;
            this.turnamentNameValueTextBox1.TextChanged += new System.EventHandler(this.TeamOneScoreTextBox1_TextChanged);
            // 
            // turnamentNameLabel
            // 
            this.turnamentNameLabel.AutoSize = true;
            this.turnamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.turnamentNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.turnamentNameLabel.Location = new System.Drawing.Point(12, 71);
            this.turnamentNameLabel.Name = "turnamentNameLabel";
            this.turnamentNameLabel.Size = new System.Drawing.Size(153, 37);
            this.turnamentNameLabel.TabIndex = 21;
            this.turnamentNameLabel.Text = "Ime turnirja";
            // 
            // turnamentPlayersLabel
            // 
            this.turnamentPlayersLabel.AutoSize = true;
            this.turnamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.turnamentPlayersLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.turnamentPlayersLabel.Location = new System.Drawing.Point(397, 79);
            this.turnamentPlayersLabel.Name = "turnamentPlayersLabel";
            this.turnamentPlayersLabel.Size = new System.Drawing.Size(178, 37);
            this.turnamentPlayersLabel.TabIndex = 20;
            this.turnamentPlayersLabel.Text = "Ekipe / Igralci";
            this.turnamentPlayersLabel.Click += new System.EventHandler(this.teamOneNameLabel_Click);
            // 
            // TurnamentPlayersListBox
            // 
            this.TurnamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TurnamentPlayersListBox.FormattingEnabled = true;
            this.TurnamentPlayersListBox.ItemHeight = 30;
            this.TurnamentPlayersListBox.Location = new System.Drawing.Point(397, 121);
            this.TurnamentPlayersListBox.Name = "TurnamentPlayersListBox";
            this.TurnamentPlayersListBox.Size = new System.Drawing.Size(311, 152);
            this.TurnamentPlayersListBox.TabIndex = 19;
            this.TurnamentPlayersListBox.SelectedIndexChanged += new System.EventHandler(this.matchupListBox_SelectedIndexChanged);
            // 
            // selectTeamDropDownComboBox1
            // 
            this.selectTeamDropDownComboBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamDropDownComboBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectTeamDropDownComboBox1.FormattingEnabled = true;
            this.selectTeamDropDownComboBox1.Location = new System.Drawing.Point(12, 268);
            this.selectTeamDropDownComboBox1.Name = "selectTeamDropDownComboBox1";
            this.selectTeamDropDownComboBox1.Size = new System.Drawing.Size(315, 38);
            this.selectTeamDropDownComboBox1.TabIndex = 17;
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectTeamLabel.Location = new System.Drawing.Point(12, 228);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(155, 37);
            this.selectTeamLabel.TabIndex = 16;
            this.selectTeamLabel.Text = "Izberi ekipo";
            // 
            // headerLabel1
            // 
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel1.Location = new System.Drawing.Point(253, 9);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(219, 50);
            this.headerLabel1.TabIndex = 14;
            this.headerLabel1.Text = "Ustvari turnir";
            // 
            // createNewTeamLinkLabel
            // 
            this.createNewTeamLinkLabel.AutoSize = true;
            this.createNewTeamLinkLabel.Location = new System.Drawing.Point(203, 235);
            this.createNewTeamLinkLabel.Name = "createNewTeamLinkLabel";
            this.createNewTeamLinkLabel.Size = new System.Drawing.Size(124, 30);
            this.createNewTeamLinkLabel.TabIndex = 28;
            this.createNewTeamLinkLabel.TabStop = true;
            this.createNewTeamLinkLabel.Text = "Dodaj ekipo";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.createPrizeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createPrizeButton.Location = new System.Drawing.Point(12, 381);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(216, 44);
            this.createPrizeButton.TabIndex = 29;
            this.createPrizeButton.Text = "Ustvari nagrado";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPlayerButton
            // 
            this.deleteSelectedPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPlayerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedPlayerButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteSelectedPlayerButton.Location = new System.Drawing.Point(724, 229);
            this.deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            this.deleteSelectedPlayerButton.Size = new System.Drawing.Size(82, 44);
            this.deleteSelectedPlayerButton.TabIndex = 30;
            this.deleteSelectedPlayerButton.Text = "Izbriši";
            this.deleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeButton
            // 
            this.deleteSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedPrizeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteSelectedPrizeButton.Location = new System.Drawing.Point(724, 428);
            this.deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            this.deleteSelectedPrizeButton.Size = new System.Drawing.Size(82, 44);
            this.deleteSelectedPrizeButton.TabIndex = 33;
            this.deleteSelectedPrizeButton.Text = "Izbirši";
            this.deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizesLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.prizesLabel.Location = new System.Drawing.Point(397, 278);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(178, 37);
            this.prizesLabel.TabIndex = 32;
            this.prizesLabel.Text = "Ekipe / Igralci";
            // 
            // prizesListBox
            // 
            this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 30;
            this.prizesListBox.Location = new System.Drawing.Point(397, 320);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(311, 152);
            this.prizesListBox.TabIndex = 31;
            // 
            // createTurnamentButton
            // 
            this.createTurnamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTurnamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTurnamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTurnamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTurnamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.createTurnamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createTurnamentButton.Location = new System.Drawing.Point(281, 491);
            this.createTurnamentButton.Name = "createTurnamentButton";
            this.createTurnamentButton.Size = new System.Drawing.Size(163, 43);
            this.createTurnamentButton.TabIndex = 34;
            this.createTurnamentButton.Text = "Ustvari turnir";
            this.createTurnamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTurnamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 553);
            this.Controls.Add(this.createTurnamentButton);
            this.Controls.Add(this.deleteSelectedPrizeButton);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.deleteSelectedPlayerButton);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.createNewTeamLinkLabel);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.entryFeeValueTextBox);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.turnamentNameValueTextBox1);
            this.Controls.Add(this.turnamentNameLabel);
            this.Controls.Add(this.turnamentPlayersLabel);
            this.Controls.Add(this.TurnamentPlayersListBox);
            this.Controls.Add(this.selectTeamDropDownComboBox1);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.headerLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTurnamentForm";
            this.Text = "Ustvari turnir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addTeamButton;
        private TextBox entryFeeValueTextBox;
        private Label entryFeeLabel;
        private TextBox turnamentNameValueTextBox1;
        private Label turnamentNameLabel;
        private Label turnamentPlayersLabel;
        private ListBox TurnamentPlayersListBox;
        private ComboBox selectTeamDropDownComboBox1;
        private Label selectTeamLabel;
        private Label headerLabel1;
        private LinkLabel createNewTeamLinkLabel;
        private Button createPrizeButton;
        private Button deleteSelectedPlayerButton;
        private Button deleteSelectedPrizeButton;
        private Label prizesLabel;
        private ListBox prizesListBox;
        private Button createTurnamentButton;
    }
}