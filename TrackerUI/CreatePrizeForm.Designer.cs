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
            createPrizeButton = new Button();
            prizePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            orLabel = new Label();
            prizeAmountValue = new TextBox();
            prizeAmountLabel = new Label();
            placeNameValue = new TextBox();
            placeNamelabel = new Label();
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            createPrizeLabel = new Label();
            SuspendLayout();
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.White;
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Location = new Point(150, 349);
            createPrizeButton.Margin = new Padding(2, 2, 2, 2);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(119, 47);
            createPrizeButton.TabIndex = 43;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.BorderStyle = BorderStyle.FixedSingle;
            prizePercentageValue.Location = new Point(228, 295);
            prizePercentageValue.Margin = new Padding(2, 2, 2, 2);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(136, 23);
            prizePercentageValue.TabIndex = 42;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.BackColor = Color.White;
            prizePercentageLabel.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            prizePercentageLabel.Location = new Point(63, 290);
            prizePercentageLabel.Margin = new Padding(2, 0, 2, 0);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(172, 26);
            prizePercentageLabel.TabIndex = 41;
            prizePercentageLabel.Text = "Prize Percentage";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.BackColor = Color.White;
            orLabel.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            orLabel.Location = new Point(184, 246);
            orLabel.Margin = new Padding(2, 0, 2, 0);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(48, 26);
            orLabel.TabIndex = 40;
            orLabel.Text = "-or-";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.BorderStyle = BorderStyle.FixedSingle;
            prizeAmountValue.Location = new Point(228, 200);
            prizeAmountValue.Margin = new Padding(2, 2, 2, 2);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(136, 23);
            prizeAmountValue.TabIndex = 39;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.BackColor = Color.White;
            prizeAmountLabel.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            prizeAmountLabel.Location = new Point(59, 196);
            prizeAmountLabel.Margin = new Padding(2, 0, 2, 0);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(142, 26);
            prizeAmountLabel.TabIndex = 38;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // placeNameValue
            // 
            placeNameValue.BorderStyle = BorderStyle.FixedSingle;
            placeNameValue.Location = new Point(228, 160);
            placeNameValue.Margin = new Padding(2, 2, 2, 2);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(136, 23);
            placeNameValue.TabIndex = 37;
            // 
            // placeNamelabel
            // 
            placeNamelabel.AutoSize = true;
            placeNamelabel.BackColor = Color.White;
            placeNamelabel.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            placeNamelabel.Location = new Point(59, 155);
            placeNamelabel.Margin = new Padding(2, 0, 2, 0);
            placeNamelabel.Name = "placeNamelabel";
            placeNamelabel.Size = new Size(125, 26);
            placeNamelabel.TabIndex = 36;
            placeNamelabel.Text = "Place Name";
            // 
            // placeNumberValue
            // 
            placeNumberValue.BorderStyle = BorderStyle.FixedSingle;
            placeNumberValue.Location = new Point(228, 117);
            placeNumberValue.Margin = new Padding(2, 2, 2, 2);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(136, 23);
            placeNumberValue.TabIndex = 35;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.BackColor = Color.White;
            placeNumberLabel.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            placeNumberLabel.Location = new Point(59, 112);
            placeNumberLabel.Margin = new Padding(2, 0, 2, 0);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(147, 26);
            placeNumberLabel.TabIndex = 34;
            placeNumberLabel.Text = "Place Number";
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.BackColor = SystemColors.ButtonHighlight;
            createPrizeLabel.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 134);
            createPrizeLabel.Location = new Point(28, 37);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(212, 42);
            createPrizeLabel.TabIndex = 33;
            createPrizeLabel.Text = "Create Prize";
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(426, 438);
            Controls.Add(createPrizeButton);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(orLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNamelabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(createPrizeLabel);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CreatePrizeForm";
            Text = "CreatePrizeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createPrizeButton;
        private TextBox prizePercentageValue;
        internal Label prizePercentageLabel;
        internal Label orLabel;
        private TextBox prizeAmountValue;
        internal Label prizeAmountLabel;
        private TextBox placeNameValue;
        internal Label placeNamelabel;
        private TextBox placeNumberValue;
        internal Label placeNumberLabel;
        private Label createPrizeLabel;
    }
}