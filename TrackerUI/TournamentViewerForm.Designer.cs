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
            CheckBox unplayedOnlyCheck;
            HeaderLabel = new Label();
            tournamentName = new Label();
            roundLabel = new Label();
            comboDropDown = new ComboBox();
            matchupListBox = new ListBox();
            teamOneName = new Label();
            teamOneScore = new Label();
            teamOneScoreText = new TextBox();
            teamTwoScoreText = new TextBox();
            teamTwoScore = new Label();
            teamTwoName = new Label();
            versusLabel = new Label();
            scoreButton = new Button();
            unplayedOnlyCheck = new CheckBox();
            SuspendLayout();
            // 
            // unplayedOnlyCheck
            // 
            unplayedOnlyCheck.AutoSize = true;
            unplayedOnlyCheck.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            unplayedOnlyCheck.Location = new Point(243, 212);
            unplayedOnlyCheck.Name = "unplayedOnlyCheck";
            unplayedOnlyCheck.Size = new Size(220, 35);
            unplayedOnlyCheck.TabIndex = 4;
            unplayedOnlyCheck.Text = "Unplayed Only";
            unplayedOnlyCheck.UseVisualStyleBackColor = true;
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 134);
            HeaderLabel.Location = new Point(63, 39);
            HeaderLabel.Margin = new Padding(5, 0, 5, 0);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(339, 64);
            HeaderLabel.TabIndex = 0;
            HeaderLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 134);
            tournamentName.Location = new Point(438, 39);
            tournamentName.Margin = new Padding(5, 0, 5, 0);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(233, 64);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "<None>";
            tournamentName.Click += label1_Click;
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.BackColor = Color.White;
            roundLabel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            roundLabel.Location = new Point(81, 141);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(139, 47);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // comboDropDown
            // 
            comboDropDown.FormattingEnabled = true;
            comboDropDown.Location = new Point(243, 141);
            comboDropDown.Name = "comboDropDown";
            comboDropDown.Size = new Size(326, 48);
            comboDropDown.TabIndex = 3;
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 40;
            matchupListBox.Location = new Point(81, 253);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(506, 362);
            matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.BackColor = Color.White;
            teamOneName.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            teamOneName.Location = new Point(678, 253);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(253, 47);
            teamOneName.TabIndex = 6;
            teamOneName.Text = "<Team one>";
            // 
            // teamOneScore
            // 
            teamOneScore.AutoSize = true;
            teamOneScore.BackColor = Color.White;
            teamOneScore.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            teamOneScore.Location = new Point(668, 328);
            teamOneScore.Name = "teamOneScore";
            teamOneScore.Size = new Size(121, 47);
            teamOneScore.TabIndex = 7;
            teamOneScore.Text = "Score";
            // 
            // teamOneScoreText
            // 
            teamOneScoreText.BorderStyle = BorderStyle.FixedSingle;
            teamOneScoreText.Location = new Point(795, 328);
            teamOneScoreText.Name = "teamOneScoreText";
            teamOneScoreText.Size = new Size(150, 46);
            teamOneScoreText.TabIndex = 8;
            // 
            // teamTwoScoreText
            // 
            teamTwoScoreText.BorderStyle = BorderStyle.FixedSingle;
            teamTwoScoreText.Location = new Point(795, 548);
            teamTwoScoreText.Name = "teamTwoScoreText";
            teamTwoScoreText.Size = new Size(150, 46);
            teamTwoScoreText.TabIndex = 11;
            // 
            // teamTwoScore
            // 
            teamTwoScore.AutoSize = true;
            teamTwoScore.BackColor = Color.White;
            teamTwoScore.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            teamTwoScore.Location = new Point(668, 548);
            teamTwoScore.Name = "teamTwoScore";
            teamTwoScore.Size = new Size(121, 47);
            teamTwoScore.TabIndex = 10;
            teamTwoScore.Text = "Score";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.BackColor = Color.White;
            teamTwoName.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            teamTwoName.Location = new Point(678, 473);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(255, 47);
            teamTwoName.TabIndex = 9;
            teamTwoName.Text = "<Team two>";
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.BackColor = Color.White;
            versusLabel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            versusLabel.Location = new Point(831, 404);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(100, 47);
            versusLabel.TabIndex = 12;
            versusLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.White;
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Location = new Point(1004, 415);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(118, 62);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(19F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1166, 688);
            Controls.Add(scoreButton);
            Controls.Add(versusLabel);
            Controls.Add(teamTwoScoreText);
            Controls.Add(teamTwoScore);
            Controls.Add(teamTwoName);
            Controls.Add(teamOneScoreText);
            Controls.Add(teamOneScore);
            Controls.Add(teamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheck);
            Controls.Add(comboDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(HeaderLabel);
            Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 134);
            Margin = new Padding(5);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label tournamentName;
        private Label roundLabel;
        private ComboBox comboDropDown;
        private CheckBox unplayedOnlyCheck;
        private ListBox matchupListBox;
        internal Label teamOneName;
        internal Label teamOneScore;
        private TextBox teamOneScoreText;
        private TextBox teamTwoScoreText;
        internal Label teamTwoScore;
        internal Label teamTwoName;
        internal Label versusLabel;
        private Button scoreButton;
    }
}
