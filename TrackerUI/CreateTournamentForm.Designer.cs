namespace TrackerUI
{
    partial class CreateTournamentForm
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
            createTournamentButton = new Button();
            deletePrizeSelectedButton = new Button();
            prizesLabel = new Label();
            prizesListBox = new ListBox();
            deletePlayerSelectedButton = new Button();
            tournamentPlayersLabel = new Label();
            tournamentPlayersListBox = new ListBox();
            createPrizeButton = new Button();
            addTeamButton = new Button();
            createNewTeamLink = new LinkLabel();
            addTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            entryFeeValue = new TextBox();
            entryFeeNameLabel = new Label();
            tournamentValue = new TextBox();
            tournamentNameLabel = new Label();
            HeaderLabel = new Label();
            SuspendLayout();
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.White;
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Location = new Point(345, 630);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(269, 59);
            createTournamentButton.TabIndex = 41;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // deletePrizeSelectedButton
            // 
            deletePrizeSelectedButton.FlatAppearance.BorderColor = Color.Silver;
            deletePrizeSelectedButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            deletePrizeSelectedButton.FlatAppearance.MouseOverBackColor = Color.White;
            deletePrizeSelectedButton.FlatStyle = FlatStyle.Flat;
            deletePrizeSelectedButton.Location = new Point(951, 473);
            deletePrizeSelectedButton.Name = "deletePrizeSelectedButton";
            deletePrizeSelectedButton.Size = new Size(118, 62);
            deletePrizeSelectedButton.TabIndex = 40;
            deletePrizeSelectedButton.Text = "Delete Selected";
            deletePrizeSelectedButton.UseVisualStyleBackColor = true;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 134);
            prizesLabel.Location = new Point(508, 332);
            prizesLabel.Margin = new Padding(5, 0, 5, 0);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(409, 64);
            prizesLabel.TabIndex = 39;
            prizesLabel.Text = "Teams / Players";
            // 
            // prizesListBox
            // 
            prizesListBox.BorderStyle = BorderStyle.FixedSingle;
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 24;
            prizesListBox.Location = new Point(508, 412);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(419, 170);
            prizesListBox.TabIndex = 38;
            // 
            // deletePlayerSelectedButton
            // 
            deletePlayerSelectedButton.FlatAppearance.BorderColor = Color.Silver;
            deletePlayerSelectedButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            deletePlayerSelectedButton.FlatAppearance.MouseOverBackColor = Color.White;
            deletePlayerSelectedButton.FlatStyle = FlatStyle.Flat;
            deletePlayerSelectedButton.Location = new Point(951, 187);
            deletePlayerSelectedButton.Name = "deletePlayerSelectedButton";
            deletePlayerSelectedButton.Size = new Size(118, 62);
            deletePlayerSelectedButton.TabIndex = 37;
            deletePlayerSelectedButton.Text = "Delete Selected";
            deletePlayerSelectedButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 134);
            tournamentPlayersLabel.Location = new Point(508, 46);
            tournamentPlayersLabel.Margin = new Padding(5, 0, 5, 0);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(409, 64);
            tournamentPlayersLabel.TabIndex = 36;
            tournamentPlayersLabel.Text = "Teams / Players";
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 24;
            tournamentPlayersListBox.Location = new Point(508, 126);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(419, 170);
            tournamentPlayersListBox.TabIndex = 35;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.White;
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Location = new Point(133, 529);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(168, 42);
            createPrizeButton.TabIndex = 34;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.White;
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Location = new Point(133, 464);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(168, 42);
            addTeamButton.TabIndex = 33;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Location = new Point(307, 350);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(103, 24);
            createNewTeamLink.TabIndex = 32;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "create new";
            // 
            // addTeamDropDown
            // 
            addTeamDropDown.FormattingEnabled = true;
            addTeamDropDown.Location = new Point(61, 394);
            addTeamDropDown.Name = "addTeamDropDown";
            addTeamDropDown.Size = new Size(326, 32);
            addTeamDropDown.TabIndex = 31;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.BackColor = Color.White;
            selectTeamLabel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            selectTeamLabel.Location = new Point(61, 331);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(240, 47);
            selectTeamLabel.TabIndex = 30;
            selectTeamLabel.Text = "Select Team";
            // 
            // entryFeeValue
            // 
            entryFeeValue.BorderStyle = BorderStyle.FixedSingle;
            entryFeeValue.Location = new Point(261, 277);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(150, 30);
            entryFeeValue.TabIndex = 29;
            entryFeeValue.Text = "0";
            // 
            // entryFeeNameLabel
            // 
            entryFeeNameLabel.AutoSize = true;
            entryFeeNameLabel.BackColor = Color.White;
            entryFeeNameLabel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            entryFeeNameLabel.Location = new Point(61, 260);
            entryFeeNameLabel.Name = "entryFeeNameLabel";
            entryFeeNameLabel.Size = new Size(188, 47);
            entryFeeNameLabel.TabIndex = 28;
            entryFeeNameLabel.Text = "Entry Fee";
            // 
            // tournamentValue
            // 
            tournamentValue.BorderStyle = BorderStyle.FixedSingle;
            tournamentValue.Location = new Point(61, 204);
            tournamentValue.Name = "tournamentValue";
            tournamentValue.Size = new Size(145, 30);
            tournamentValue.TabIndex = 27;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.BackColor = Color.White;
            tournamentNameLabel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            tournamentNameLabel.Location = new Point(49, 137);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(362, 47);
            tournamentNameLabel.TabIndex = 26;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 134);
            HeaderLabel.Location = new Point(28, 46);
            HeaderLabel.Margin = new Padding(5, 0, 5, 0);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(339, 64);
            HeaderLabel.TabIndex = 25;
            HeaderLabel.Text = "Tournament:";
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1111, 724);
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
            Name = "CreateTournamentForm";
            Text = "CreateTournamentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createTournamentButton;
        private Button deletePrizeSelectedButton;
        private Label prizesLabel;
        private ListBox prizesListBox;
        private Button deletePlayerSelectedButton;
        private Label tournamentPlayersLabel;
        private ListBox tournamentPlayersListBox;
        private Button createPrizeButton;
        private Button addTeamButton;
        private LinkLabel createNewTeamLink;
        private ComboBox addTeamDropDown;
        private Label selectTeamLabel;
        private TextBox entryFeeValue;
        internal Label entryFeeNameLabel;
        private TextBox tournamentValue;
        internal Label tournamentNameLabel;
        private Label HeaderLabel;
    }
}