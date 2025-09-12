namespace CreateTeamForm
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
            teamValue = new TextBox();
            teamNameLabel = new Label();
            HeaderLabel = new Label();
            addMemberDropDown = new ComboBox();
            selectTeamMemberLabel = new Label();
            addMemberButton = new Button();
            groupBox1 = new GroupBox();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            cellphoneValue = new TextBox();
            cellphoneLabel = new Label();
            createMemberLabel = new Button();
            teamMemberListBox = new ListBox();
            deleteSelectedMemberButton = new Button();
            createTeamButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // teamValue
            // 
            teamValue.BorderStyle = BorderStyle.FixedSingle;
            teamValue.Location = new Point(69, 189);
            teamValue.Name = "teamValue";
            teamValue.Size = new Size(275, 30);
            teamValue.TabIndex = 13;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.BackColor = Color.White;
            teamNameLabel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            teamNameLabel.Location = new Point(57, 122);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(239, 47);
            teamNameLabel.TabIndex = 12;
            teamNameLabel.Text = "Team Name";
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 134);
            HeaderLabel.Location = new Point(36, 31);
            HeaderLabel.Margin = new Padding(5, 0, 5, 0);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(330, 64);
            HeaderLabel.TabIndex = 11;
            HeaderLabel.Text = "Create Team";
            // 
            // addMemberDropDown
            // 
            addMemberDropDown.FormattingEnabled = true;
            addMemberDropDown.Location = new Point(69, 312);
            addMemberDropDown.Name = "addMemberDropDown";
            addMemberDropDown.Size = new Size(326, 32);
            addMemberDropDown.TabIndex = 16;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.BackColor = Color.White;
            selectTeamMemberLabel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            selectTeamMemberLabel.Location = new Point(69, 249);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(404, 47);
            selectTeamMemberLabel.TabIndex = 15;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.White;
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Location = new Point(128, 384);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(168, 42);
            addMemberButton.TabIndex = 17;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
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
            groupBox1.Location = new Point(69, 455);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(461, 314);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Member";
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
            // teamMemberListBox
            // 
            teamMemberListBox.BorderStyle = BorderStyle.FixedSingle;
            teamMemberListBox.FormattingEnabled = true;
            teamMemberListBox.ItemHeight = 24;
            teamMemberListBox.Location = new Point(625, 122);
            teamMemberListBox.Name = "teamMemberListBox";
            teamMemberListBox.Size = new Size(375, 626);
            teamMemberListBox.TabIndex = 27;
            // 
            // deleteSelectedMemberButton
            // 
            deleteSelectedMemberButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = Color.White;
            deleteSelectedMemberButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedMemberButton.Location = new Point(1041, 296);
            deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            deleteSelectedMemberButton.Size = new Size(118, 62);
            deleteSelectedMemberButton.TabIndex = 28;
            deleteSelectedMemberButton.Text = "Delete Selected";
            deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.White;
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Location = new Point(437, 820);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(269, 59);
            createTeamButton.TabIndex = 29;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1201, 950);
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
            Name = "Form1";
            Text = "Create Team";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teamValue;
        internal Label teamNameLabel;
        private Label HeaderLabel;
        private ComboBox addMemberDropDown;
        private Label selectTeamMemberLabel;
        private Button addMemberButton;
        private GroupBox groupBox1;
        private TextBox firstNameValue;
        internal Label firstNameLabel;
        private TextBox cellphoneValue;
        internal Label cellphoneLabel;
        private TextBox emailValue;
        internal Label emailLabel;
        private TextBox lastNameValue;
        internal Label lastNameLabel;
        private Button createMemberLabel;
        private ListBox teamMemberListBox;
        private Button deleteSelectedMemberButton;
        private Button createTeamButton;
    }
}
