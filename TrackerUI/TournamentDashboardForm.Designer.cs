namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            this.headerLabel1 = new System.Windows.Forms.Label();
            this.LoadExistingTournamentDropDownComboBox1 = new System.Windows.Forms.ComboBox();
            this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.loadTurnamentButton = new System.Windows.Forms.Button();
            this.createTurnamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel1
            // 
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel1.Location = new System.Drawing.Point(71, 9);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(283, 50);
            this.headerLabel1.TabIndex = 25;
            this.headerLabel1.Text = "Nadzorna plošča";
            this.headerLabel1.Click += new System.EventHandler(this.headerLabel1_Click);
            // 
            // LoadExistingTournamentDropDownComboBox1
            // 
            this.LoadExistingTournamentDropDownComboBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadExistingTournamentDropDownComboBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LoadExistingTournamentDropDownComboBox1.FormattingEnabled = true;
            this.LoadExistingTournamentDropDownComboBox1.Location = new System.Drawing.Point(60, 164);
            this.LoadExistingTournamentDropDownComboBox1.Name = "LoadExistingTournamentDropDownComboBox1";
            this.LoadExistingTournamentDropDownComboBox1.Size = new System.Drawing.Size(315, 38);
            this.LoadExistingTournamentDropDownComboBox1.TabIndex = 27;
            // 
            // loadExistingTournamentLabel
            // 
            this.loadExistingTournamentLabel.AutoSize = true;
            this.loadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadExistingTournamentLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.loadExistingTournamentLabel.Location = new System.Drawing.Point(140, 124);
            this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            this.loadExistingTournamentLabel.Size = new System.Drawing.Size(153, 37);
            this.loadExistingTournamentLabel.TabIndex = 26;
            this.loadExistingTournamentLabel.Text = "Izberi turnir";
            // 
            // loadTurnamentButton
            // 
            this.loadTurnamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadTurnamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadTurnamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loadTurnamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTurnamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.loadTurnamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.loadTurnamentButton.Location = new System.Drawing.Point(130, 208);
            this.loadTurnamentButton.Name = "loadTurnamentButton";
            this.loadTurnamentButton.Size = new System.Drawing.Size(173, 44);
            this.loadTurnamentButton.TabIndex = 31;
            this.loadTurnamentButton.Text = "Naloži turnir";
            this.loadTurnamentButton.UseVisualStyleBackColor = true;
            // 
            // createTurnamentButton
            // 
            this.createTurnamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTurnamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTurnamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTurnamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTurnamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.createTurnamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createTurnamentButton.Location = new System.Drawing.Point(229, 328);
            this.createTurnamentButton.Name = "createTurnamentButton";
            this.createTurnamentButton.Size = new System.Drawing.Size(194, 53);
            this.createTurnamentButton.TabIndex = 36;
            this.createTurnamentButton.Text = "Ustvari turnir";
            this.createTurnamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 393);
            this.Controls.Add(this.createTurnamentButton);
            this.Controls.Add(this.loadTurnamentButton);
            this.Controls.Add(this.LoadExistingTournamentDropDownComboBox1);
            this.Controls.Add(this.loadExistingTournamentLabel);
            this.Controls.Add(this.headerLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TournamentDashboardForm";
            this.Text = "TournamentDashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel1;
        private ComboBox LoadExistingTournamentDropDownComboBox1;
        private Label loadExistingTournamentLabel;
        private Button loadTurnamentButton;
        private Button createTurnamentButton;
    }
}