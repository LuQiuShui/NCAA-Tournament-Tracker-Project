namespace CreateTournamentForm
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
            HeaderLabel = new Label();
            tournamentValue = new TextBox();
            tournamentNameLabel = new Label();
            entryFeeValue = new TextBox();
            entryFeeNameLabel = new Label();
            addTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLink = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentPlayersListBox = new ListBox();
            tournamentPlayersLabel = new Label();
            deletePlayerSelectedButton = new Button();
            deletePrizeSelectedButton = new Button();
            prizesLabel = new Label();
            prizesListBox = new ListBox();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 134);
            HeaderLabel.Location = new Point(77, 68);
            HeaderLabel.Margin = new Padding(5, 0, 5, 0);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(339, 64);
            HeaderLabel.TabIndex = 1;
            HeaderLabel.Text = "Tournament:";
            // 
            // tournamentValue
            // 
            tournamentValue.BorderStyle = BorderStyle.FixedSingle;
            tournamentValue.Location = new Point(110, 226);
            tournamentValue.Name = "tournamentValue";
            tournamentValue.Size = new Size(145, 30);
            tournamentValue.TabIndex = 10;
            tournamentValue.TextChanged += tournamentValue_TextChanged;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.BackColor = Color.White;
            tournamentNameLabel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            tournamentNameLabel.Location = new Point(98, 159);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(362, 47);
            tournamentNameLabel.TabIndex = 9;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            entryFeeValue.BorderStyle = BorderStyle.FixedSingle;
            entryFeeValue.Location = new Point(310, 299);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(150, 30);
            entryFeeValue.TabIndex = 12;
            entryFeeValue.Text = "0";
            // 
            // entryFeeNameLabel
            // 
            entryFeeNameLabel.AutoSize = true;
            entryFeeNameLabel.BackColor = Color.White;
            entryFeeNameLabel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            entryFeeNameLabel.Location = new Point(110, 282);
            entryFeeNameLabel.Name = "entryFeeNameLabel";
            entryFeeNameLabel.Size = new Size(188, 47);
            entryFeeNameLabel.TabIndex = 11;
            entryFeeNameLabel.Text = "Entry Fee";
            // 
            // addTeamDropDown
            // 
            addTeamDropDown.FormattingEnabled = true;
            addTeamDropDown.Location = new Point(110, 416);
            addTeamDropDown.Name = "addTeamDropDown";
            addTeamDropDown.Size = new Size(326, 32);
            addTeamDropDown.TabIndex = 14;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.BackColor = Color.White;
            selectTeamLabel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            selectTeamLabel.Location = new Point(110, 353);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(240, 47);
            selectTeamLabel.TabIndex = 13;
            selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Location = new Point(356, 372);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(103, 24);
            createNewTeamLink.TabIndex = 15;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "create new";
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.White;
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Location = new Point(182, 486);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(168, 42);
            addTeamButton.TabIndex = 16;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.White;
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Location = new Point(182, 551);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(168, 42);
            createPrizeButton.TabIndex = 17;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 24;
            tournamentPlayersListBox.Location = new Point(557, 148);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(419, 170);
            tournamentPlayersListBox.TabIndex = 18;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 134);
            tournamentPlayersLabel.Location = new Point(557, 68);
            tournamentPlayersLabel.Margin = new Padding(5, 0, 5, 0);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(409, 64);
            tournamentPlayersLabel.TabIndex = 19;
            tournamentPlayersLabel.Text = "Teams / Players";
            // 
            // deletePlayerSelectedButton
            // 
            deletePlayerSelectedButton.FlatAppearance.BorderColor = Color.Silver;
            deletePlayerSelectedButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            deletePlayerSelectedButton.FlatAppearance.MouseOverBackColor = Color.White;
            deletePlayerSelectedButton.FlatStyle = FlatStyle.Flat;
            deletePlayerSelectedButton.Location = new Point(1000, 209);
            deletePlayerSelectedButton.Name = "deletePlayerSelectedButton";
            deletePlayerSelectedButton.Size = new Size(118, 62);
            deletePlayerSelectedButton.TabIndex = 20;
            deletePlayerSelectedButton.Text = "Delete Selected";
            deletePlayerSelectedButton.UseVisualStyleBackColor = true;
            // 
            // deletePrizeSelectedButton
            // 
            deletePrizeSelectedButton.FlatAppearance.BorderColor = Color.Silver;
            deletePrizeSelectedButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            deletePrizeSelectedButton.FlatAppearance.MouseOverBackColor = Color.White;
            deletePrizeSelectedButton.FlatStyle = FlatStyle.Flat;
            deletePrizeSelectedButton.Location = new Point(1000, 495);
            deletePrizeSelectedButton.Name = "deletePrizeSelectedButton";
            deletePrizeSelectedButton.Size = new Size(118, 62);
            deletePrizeSelectedButton.TabIndex = 23;
            deletePrizeSelectedButton.Text = "Delete Selected";
            deletePrizeSelectedButton.UseVisualStyleBackColor = true;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 134);
            prizesLabel.Location = new Point(557, 354);
            prizesLabel.Margin = new Padding(5, 0, 5, 0);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(409, 64);
            prizesLabel.TabIndex = 22;
            prizesLabel.Text = "Teams / Players";
            // 
            // prizesListBox
            // 
            prizesListBox.BorderStyle = BorderStyle.FixedSingle;
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 24;
            prizesListBox.Location = new Point(557, 434);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(419, 170);
            prizesListBox.TabIndex = 21;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.White;
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Location = new Point(394, 652);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(269, 59);
            createTournamentButton.TabIndex = 24;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1130, 745);
            Controls.Add(createTournamentButton);
            Controls.Add(deletePrizeSelectedButton);
            Controls.Add(prizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(deletePlayerSelectedButton);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLink);
            Controls.Add(addTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeNameLabel);
            Controls.Add(tournamentValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(HeaderLabel);
            Name = "Form1";
            Text = "Creat Tournament";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private TextBox tournamentValue;
        internal Label tournamentNameLabel;
        private TextBox entryFeeValue;
        internal Label entryFeeNameLabel;
        private ComboBox addTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLink;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentPlayersListBox;
        private Label tournamentPlayersLabel;
        private Button deletePlayerSelectedButton;
        private Button deletePrizeSelectedButton;
        private Label prizesLabel;
        private ListBox prizesListBox;
        private Button createTournamentButton;
    }
}
