namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            this.headerLabel1 = new System.Windows.Forms.Label();
            this.PlaceNumberValueTextBox1 = new System.Windows.Forms.TextBox();
            this.placeNumberLabel = new System.Windows.Forms.Label();
            this.placeNameValueTextBox = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.priceAmountValueTextBox = new System.Windows.Forms.TextBox();
            this.priceAmountLabel = new System.Windows.Forms.Label();
            this.prizePercantageValueTextBox = new System.Windows.Forms.TextBox();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel1
            // 
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel1.Location = new System.Drawing.Point(90, 10);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(267, 50);
            this.headerLabel1.TabIndex = 24;
            this.headerLabel1.Text = "Ustvari nagrado";
            this.headerLabel1.Click += new System.EventHandler(this.headerLabel1_Click);
            // 
            // PlaceNumberValueTextBox1
            // 
            this.PlaceNumberValueTextBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlaceNumberValueTextBox1.Location = new System.Drawing.Point(240, 95);
            this.PlaceNumberValueTextBox1.Name = "PlaceNumberValueTextBox1";
            this.PlaceNumberValueTextBox1.Size = new System.Drawing.Size(186, 35);
            this.PlaceNumberValueTextBox1.TabIndex = 26;
            this.PlaceNumberValueTextBox1.TextChanged += new System.EventHandler(this.firstNameValueTextBox1_TextChanged);
            // 
            // placeNumberLabel
            // 
            this.placeNumberLabel.AutoSize = true;
            this.placeNumberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNumberLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.placeNumberLabel.Location = new System.Drawing.Point(30, 92);
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Size = new System.Drawing.Size(177, 37);
            this.placeNumberLabel.TabIndex = 25;
            this.placeNumberLabel.Text = "Mesto igralca";
            // 
            // placeNameValueTextBox
            // 
            this.placeNameValueTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNameValueTextBox.Location = new System.Drawing.Point(240, 150);
            this.placeNameValueTextBox.Name = "placeNameValueTextBox";
            this.placeNameValueTextBox.Size = new System.Drawing.Size(186, 35);
            this.placeNameValueTextBox.TabIndex = 28;
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.placeNameLabel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.placeNameLabel.Location = new System.Drawing.Point(30, 148);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(139, 37);
            this.placeNameLabel.TabIndex = 27;
            this.placeNameLabel.Text = "Ime mesta";
            // 
            // priceAmountValueTextBox
            // 
            this.priceAmountValueTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceAmountValueTextBox.Location = new System.Drawing.Point(240, 201);
            this.priceAmountValueTextBox.Name = "priceAmountValueTextBox";
            this.priceAmountValueTextBox.Size = new System.Drawing.Size(186, 35);
            this.priceAmountValueTextBox.TabIndex = 30;
            this.priceAmountValueTextBox.Text = "0";
            // 
            // priceAmountLabel
            // 
            this.priceAmountLabel.AutoSize = true;
            this.priceAmountLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceAmountLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.priceAmountLabel.Location = new System.Drawing.Point(30, 199);
            this.priceAmountLabel.Name = "priceAmountLabel";
            this.priceAmountLabel.Size = new System.Drawing.Size(204, 37);
            this.priceAmountLabel.TabIndex = 29;
            this.priceAmountLabel.Text = "Znesek nagrade";
            // 
            // prizePercantageValueTextBox
            // 
            this.prizePercantageValueTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizePercantageValueTextBox.Location = new System.Drawing.Point(240, 316);
            this.prizePercantageValueTextBox.Name = "prizePercantageValueTextBox";
            this.prizePercantageValueTextBox.Size = new System.Drawing.Size(186, 35);
            this.prizePercantageValueTextBox.TabIndex = 32;
            this.prizePercantageValueTextBox.Text = "0";
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.AutoSize = true;
            this.prizePercentageLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizePercentageLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.prizePercentageLabel.Location = new System.Drawing.Point(30, 313);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(188, 37);
            this.prizePercentageLabel.TabIndex = 31;
            this.prizePercentageLabel.Text = "Delež nagrade";
            this.prizePercentageLabel.Click += new System.EventHandler(this.prizePercentageLabel_Click);
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.orLabel.Location = new System.Drawing.Point(190, 262);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(67, 37);
            this.orLabel.TabIndex = 33;
            this.orLabel.Text = "-ali-";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.createPrizeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createPrizeButton.Location = new System.Drawing.Point(126, 412);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(194, 53);
            this.createPrizeButton.TabIndex = 35;
            this.createPrizeButton.Text = "Ustvari nagrado";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(462, 476);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.prizePercantageValueTextBox);
            this.Controls.Add(this.prizePercentageLabel);
            this.Controls.Add(this.priceAmountValueTextBox);
            this.Controls.Add(this.priceAmountLabel);
            this.Controls.Add(this.placeNameValueTextBox);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.PlaceNumberValueTextBox1);
            this.Controls.Add(this.placeNumberLabel);
            this.Controls.Add(this.headerLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreatePrizeForm";
            this.Text = "Ustvari nagrado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel1;
        private TextBox PlaceNumberValueTextBox1;
        private Label placeNumberLabel;
        private TextBox placeNameValueTextBox;
        private Label placeNameLabel;
        private TextBox priceAmountValueTextBox;
        private Label priceAmountLabel;
        private TextBox prizePercantageValueTextBox;
        private Label prizePercentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}