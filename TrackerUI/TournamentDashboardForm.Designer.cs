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
            loadExitingTournamentDropDown = new ComboBox();
            loadExitingTournamentLabel = new Label();
            tournamentDashboardLabel = new Label();
            createTournamentButton = new Button();
            loadTournamentButton = new Button();
            SuspendLayout();
            // 
            // loadExitingTournamentDropDown
            // 
            loadExitingTournamentDropDown.FormattingEnabled = true;
            loadExitingTournamentDropDown.Location = new Point(183, 213);
            loadExitingTournamentDropDown.Name = "loadExitingTournamentDropDown";
            loadExitingTournamentDropDown.Size = new Size(403, 32);
            loadExitingTournamentDropDown.TabIndex = 36;
            // 
            // loadExitingTournamentLabel
            // 
            loadExitingTournamentLabel.AutoSize = true;
            loadExitingTournamentLabel.BackColor = Color.White;
            loadExitingTournamentLabel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            loadExitingTournamentLabel.Location = new Point(144, 151);
            loadExitingTournamentLabel.Name = "loadExitingTournamentLabel";
            loadExitingTournamentLabel.Size = new Size(480, 47);
            loadExitingTournamentLabel.TabIndex = 35;
            loadExitingTournamentLabel.Text = "Load Exiting Tournament";
            // 
            // tournamentDashboardLabel
            // 
            tournamentDashboardLabel.AutoSize = true;
            tournamentDashboardLabel.BackColor = Color.White;
            tournamentDashboardLabel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            tournamentDashboardLabel.Location = new Point(158, 38);
            tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            tournamentDashboardLabel.Size = new Size(453, 47);
            tournamentDashboardLabel.TabIndex = 37;
            tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.White;
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Location = new Point(235, 354);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(298, 71);
            createTournamentButton.TabIndex = 38;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            loadTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            loadTournamentButton.FlatAppearance.MouseOverBackColor = Color.White;
            loadTournamentButton.FlatStyle = FlatStyle.Flat;
            loadTournamentButton.Location = new Point(276, 277);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(216, 56);
            loadTournamentButton.TabIndex = 38;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(757, 510);
            Controls.Add(loadTournamentButton);
            Controls.Add(createTournamentButton);
            Controls.Add(tournamentDashboardLabel);
            Controls.Add(loadExitingTournamentDropDown);
            Controls.Add(loadExitingTournamentLabel);
            Name = "TournamentDashboardForm";
            Text = "TournamentDashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox loadExitingTournamentDropDown;
        private Label loadExitingTournamentLabel;
        private Label tournamentDashboardLabel;
        private Button createTournamentButton;
        private Button loadTournamentButton;
    }
}