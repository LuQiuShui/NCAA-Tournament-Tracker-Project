namespace TrackerUI
{
    partial class CreateTeamForm
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
            createTeamButton = new Button();
            deleteSelectedMemberButton = new Button();
            teamMemberListBox = new ListBox();
            groupBox1 = new GroupBox();
            createMemberLabel = new Button();
            cellphoneValue = new TextBox();
            cellphoneLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            addMemberButton = new Button();
            addMemberDropDown = new ComboBox();
            selectTeamMemberLabel = new Label();
            teamValue = new TextBox();
            teamNameLabel = new Label();
            HeaderLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.White;
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Location = new Point(469, 818);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(269, 59);
            createTeamButton.TabIndex = 39;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedMemberButton
            // 
            deleteSelectedMemberButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = Color.White;
            deleteSelectedMemberButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedMemberButton.Location = new Point(1073, 294);
            deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            deleteSelectedMemberButton.Size = new Size(118, 62);
            deleteSelectedMemberButton.TabIndex = 38;
            deleteSelectedMemberButton.Text = "Delete Selected";
            deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMemberListBox
            // 
            teamMemberListBox.BorderStyle = BorderStyle.FixedSingle;
            teamMemberListBox.FormattingEnabled = true;
            teamMemberListBox.ItemHeight = 24;
            teamMemberListBox.Location = new Point(657, 120);
            teamMemberListBox.Name = "teamMemberListBox";
            teamMemberListBox.Size = new Size(375, 626);
            teamMemberListBox.TabIndex = 37;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(createMemberLabel);
            groupBox1.Controls.Add(cellphoneValue);
            groupBox1.Controls.Add(cellphoneLabel);
            groupBox1.Controls.Add(emailValue);
            groupBox1.Controls.Add(emailLabel);
            groupBox1.Controls.Add(lastNameValue);
            groupBox1.Controls.Add(lastNameLabel);
            groupBox1.Controls.Add(firstNameValue);
            groupBox1.Controls.Add(firstNameLabel);
            groupBox1.Location = new Point(101, 453);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(461, 314);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Member";
            // 
            // createMemberLabel
            // 
            createMemberLabel.FlatAppearance.BorderColor = Color.Silver;
            createMemberLabel.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            createMemberLabel.FlatAppearance.MouseOverBackColor = Color.White;
            createMemberLabel.FlatStyle = FlatStyle.Flat;
            createMemberLabel.Location = new Point(107, 246);
            createMemberLabel.Name = "createMemberLabel";
            createMemberLabel.Size = new Size(168, 42);
            createMemberLabel.TabIndex = 19;
            createMemberLabel.Text = "Create Member";
            createMemberLabel.UseVisualStyleBackColor = true;
            // 
            // cellphoneValue
            // 
            cellphoneValue.BorderStyle = BorderStyle.FixedSingle;
            cellphoneValue.Location = new Point(201, 193);
            cellphoneValue.Name = "cellphoneValue";
            cellphoneValue.Size = new Size(212, 30);
            cellphoneValue.TabIndex = 26;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.BackColor = Color.White;
            cellphoneLabel.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            cellphoneLabel.Location = new Point(24, 186);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(157, 37);
            cellphoneLabel.TabIndex = 25;
            cellphoneLabel.Text = "Cellphone";
            // 
            // emailValue
            // 
            emailValue.BorderStyle = BorderStyle.FixedSingle;
            emailValue.Location = new Point(201, 149);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(212, 30);
            emailValue.TabIndex = 24;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.White;
            emailLabel.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            emailLabel.Location = new Point(24, 142);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(93, 37);
            emailLabel.TabIndex = 23;
            emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            lastNameValue.BorderStyle = BorderStyle.FixedSingle;
            lastNameValue.Location = new Point(201, 99);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(212, 30);
            lastNameValue.TabIndex = 22;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = Color.White;
            lastNameLabel.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lastNameLabel.Location = new Point(24, 92);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(166, 37);
            lastNameLabel.TabIndex = 21;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            firstNameValue.BorderStyle = BorderStyle.FixedSingle;
            firstNameValue.Location = new Point(201, 48);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(212, 30);
            firstNameValue.TabIndex = 20;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = Color.White;
            firstNameLabel.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            firstNameLabel.Location = new Point(24, 41);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(171, 37);
            firstNameLabel.TabIndex = 19;
            firstNameLabel.Text = "First Name";
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.White;
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Location = new Point(160, 382);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(168, 42);
            addMemberButton.TabIndex = 35;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            // 
            // addMemberDropDown
            // 
            addMemberDropDown.FormattingEnabled = true;
            addMemberDropDown.Location = new Point(101, 310);
            addMemberDropDown.Name = "addMemberDropDown";
            addMemberDropDown.Size = new Size(326, 32);
            addMemberDropDown.TabIndex = 34;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.BackColor = Color.White;
            selectTeamMemberLabel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            selectTeamMemberLabel.Location = new Point(101, 247);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(404, 47);
            selectTeamMemberLabel.TabIndex = 33;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // teamValue
            // 
            teamValue.BorderStyle = BorderStyle.FixedSingle;
            teamValue.Location = new Point(101, 187);
            teamValue.Name = "teamValue";
            teamValue.Size = new Size(275, 30);
            teamValue.TabIndex = 32;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.BackColor = Color.White;
            teamNameLabel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            teamNameLabel.Location = new Point(89, 120);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(239, 47);
            teamNameLabel.TabIndex = 31;
            teamNameLabel.Text = "Team Name";
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 134);
            HeaderLabel.Location = new Point(68, 29);
            HeaderLabel.Margin = new Padding(5, 0, 5, 0);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(330, 64);
            HeaderLabel.TabIndex = 30;
            HeaderLabel.Text = "Create Team";
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1279, 895);
            Controls.Add(createTeamButton);
            Controls.Add(deleteSelectedMemberButton);
            Controls.Add(teamMemberListBox);
            Controls.Add(groupBox1);
            Controls.Add(addMemberButton);
            Controls.Add(addMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamValue);
            Controls.Add(teamNameLabel);
            Controls.Add(HeaderLabel);
            Name = "CreateTeamForm";
            Text = "CreateTeamForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createTeamButton;
        private Button deleteSelectedMemberButton;
        private ListBox teamMemberListBox;
        private GroupBox groupBox1;
        private Button createMemberLabel;
        private TextBox cellphoneValue;
        internal Label cellphoneLabel;
        private TextBox emailValue;
        internal Label emailLabel;
        private TextBox lastNameValue;
        internal Label lastNameLabel;
        private TextBox firstNameValue;
        internal Label firstNameLabel;
        private Button addMemberButton;
        private ComboBox addMemberDropDown;
        private Label selectTeamMemberLabel;
        private TextBox teamValue;
        internal Label teamNameLabel;
        private Label HeaderLabel;
    }
}