namespace CreatePrizeForm
{
    partial class Form1
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
            createPrizeLabel = new Label();
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            placeNameValue = new TextBox();
            placeNamelabel = new Label();
            prizeAmountValue = new TextBox();
            prizeAmountLabel = new Label();
            orLabel = new Label();
            prizePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.BackColor = SystemColors.ButtonHighlight;
            createPrizeLabel.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 134);
            createPrizeLabel.Location = new Point(43, 41);
            createPrizeLabel.Margin = new Padding(5, 0, 5, 0);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(316, 64);
            createPrizeLabel.TabIndex = 12;
            createPrizeLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.BorderStyle = BorderStyle.FixedSingle;
            placeNumberValue.Location = new Point(358, 154);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(212, 30);
            placeNumberValue.TabIndex = 22;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.BackColor = Color.White;
            placeNumberLabel.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            placeNumberLabel.Location = new Point(91, 147);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(214, 37);
            placeNumberLabel.TabIndex = 21;
            placeNumberLabel.Text = "Place Number";
            // 
            // placeNameValue
            // 
            placeNameValue.BorderStyle = BorderStyle.FixedSingle;
            placeNameValue.Location = new Point(358, 215);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(212, 30);
            placeNameValue.TabIndex = 24;
            // 
            // placeNamelabel
            // 
            placeNamelabel.AutoSize = true;
            placeNamelabel.BackColor = Color.White;
            placeNamelabel.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            placeNamelabel.Location = new Point(91, 208);
            placeNamelabel.Name = "placeNamelabel";
            placeNamelabel.Size = new Size(181, 37);
            placeNamelabel.TabIndex = 23;
            placeNamelabel.Text = "Place Name";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.BorderStyle = BorderStyle.FixedSingle;
            prizeAmountValue.Location = new Point(358, 272);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(212, 30);
            prizeAmountValue.TabIndex = 26;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.BackColor = Color.White;
            prizeAmountLabel.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            prizeAmountLabel.Location = new Point(91, 265);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(208, 37);
            prizeAmountLabel.TabIndex = 25;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.BackColor = Color.White;
            orLabel.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            orLabel.Location = new Point(288, 337);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(71, 37);
            orLabel.TabIndex = 29;
            orLabel.Text = "-or-";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.BorderStyle = BorderStyle.FixedSingle;
            prizePercentageValue.Location = new Point(358, 406);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(212, 30);
            prizePercentageValue.TabIndex = 31;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.BackColor = Color.White;
            prizePercentageLabel.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            prizePercentageLabel.Location = new Point(98, 399);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(250, 37);
            prizePercentageLabel.TabIndex = 30;
            prizePercentageLabel.Text = "Prize Percentage";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.White;
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Location = new Point(234, 482);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(187, 66);
            createPrizeButton.TabIndex = 32;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(620, 699);
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
            Name = "Form1";
            Text = "Create Prize";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createPrizeLabel;
        private TextBox placeNumberValue;
        internal Label placeNumberLabel;
        private TextBox placeNameValue;
        internal Label placeNamelabel;
        private TextBox prizeAmountValue;
        internal Label prizeAmountLabel;
        internal Label orLabel;
        private TextBox prizePercentageValue;
        internal Label prizePercentageLabel;
        private Button createPrizeButton;
    }
}
