using System.Windows.Forms;

namespace Testy_nauka
{
    partial class AddEmployeeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AddEmployeeButton2 = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.BonusLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BirthdateLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.BonusTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.BudgetLabel = new System.Windows.Forms.Label();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.TeamsizeLabel = new System.Windows.Forms.Label();
            this.BudgetTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentTextBox = new System.Windows.Forms.TextBox();
            this.TeamsizeTextBox = new System.Windows.Forms.TextBox();
            this.ProgLangLabel = new System.Windows.Forms.Label();
            this.GithubLabel = new System.Windows.Forms.Label();
            this.ProgLangTextBox = new System.Windows.Forms.TextBox();
            this.GithubTextBox = new System.Windows.Forms.TextBox();
            this.CommRateLabel = new System.Windows.Forms.Label();
            this.KeyAccountsLabel = new System.Windows.Forms.Label();
            this.KeyAccountsTextBox = new System.Windows.Forms.TextBox();
            this.CommRateTextBox = new System.Windows.Forms.TextBox();
            this.SuppSysLabel = new System.Windows.Forms.Label();
            this.TicResLabel = new System.Windows.Forms.Label();
            this.TicResTextBox = new System.Windows.Forms.TextBox();
            this.SuppSysTextBox = new System.Windows.Forms.TextBox();
            this.CampManTextBox = new System.Windows.Forms.TextBox();
            this.DMSTextBox = new System.Windows.Forms.TextBox();
            this.DMSLabel = new System.Windows.Forms.Label();
            this.CampManLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(405, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose emploee\'s position:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Manager",
            "Developer",
            "Marketing Specialist",
            "IT support",
            "Sales Representative"});
            this.comboBox1.Location = new System.Drawing.Point(410, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddEmployeeButton2
            // 
            this.AddEmployeeButton2.Location = new System.Drawing.Point(645, 246);
            this.AddEmployeeButton2.Name = "AddEmployeeButton2";
            this.AddEmployeeButton2.Size = new System.Drawing.Size(154, 41);
            this.AddEmployeeButton2.TabIndex = 2;
            this.AddEmployeeButton2.Text = "Add employee";
            this.AddEmployeeButton2.UseVisualStyleBackColor = true;
            this.AddEmployeeButton2.Click += new System.EventHandler(this.AddEmployeeButton2_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(29, 29);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 20);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(29, 67);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(74, 20);
            this.SurnameLabel.TabIndex = 4;
            this.SurnameLabel.Text = "Surname";
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(29, 141);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(53, 20);
            this.SalaryLabel.TabIndex = 5;
            this.SalaryLabel.Text = "Salary";
            // 
            // BonusLabel
            // 
            this.BonusLabel.AutoSize = true;
            this.BonusLabel.Location = new System.Drawing.Point(29, 184);
            this.BonusLabel.Name = "BonusLabel";
            this.BonusLabel.Size = new System.Drawing.Size(55, 20);
            this.BonusLabel.TabIndex = 6;
            this.BonusLabel.Text = "Bonus";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(32, 225);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(48, 20);
            this.EmailLabel.TabIndex = 7;
            this.EmailLabel.Text = "Email";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(29, 261);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(55, 20);
            this.PhoneLabel.TabIndex = 8;
            this.PhoneLabel.Text = "Phone";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 104);
            this.dateTimePicker1.MaxDate = new System.DateTime(3000, 5, 30, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2024, 5, 30, 0, 0, 0, 0);
            // 
            // BirthdateLabel
            // 
            this.BirthdateLabel.AutoSize = true;
            this.BirthdateLabel.Location = new System.Drawing.Point(29, 104);
            this.BirthdateLabel.Name = "BirthdateLabel";
            this.BirthdateLabel.Size = new System.Drawing.Size(78, 20);
            this.BirthdateLabel.TabIndex = 10;
            this.BirthdateLabel.Text = "Birth date";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(154, 29);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(200, 26);
            this.NameTextBox.TabIndex = 11;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(154, 67);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(200, 26);
            this.SurnameTextBox.TabIndex = 12;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(154, 142);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(200, 26);
            this.SalaryTextBox.TabIndex = 13;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(154, 219);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(200, 26);
            this.EmailTextBox.TabIndex = 15;
            // 
            // BonusTextBox
            // 
            this.BonusTextBox.Location = new System.Drawing.Point(154, 181);
            this.BonusTextBox.Name = "BonusTextBox";
            this.BonusTextBox.Size = new System.Drawing.Size(200, 26);
            this.BonusTextBox.TabIndex = 14;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(154, 261);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(200, 26);
            this.PhoneTextBox.TabIndex = 16;
            // 
            // BudgetLabel
            // 
            this.BudgetLabel.AutoSize = true;
            this.BudgetLabel.Location = new System.Drawing.Point(406, 109);
            this.BudgetLabel.Name = "BudgetLabel";
            this.BudgetLabel.Size = new System.Drawing.Size(61, 20);
            this.BudgetLabel.TabIndex = 17;
            this.BudgetLabel.Text = "Budget";
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Location = new System.Drawing.Point(406, 147);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(94, 20);
            this.DepartmentLabel.TabIndex = 18;
            this.DepartmentLabel.Text = "Department";
            // 
            // TeamsizeLabel
            // 
            this.TeamsizeLabel.AutoSize = true;
            this.TeamsizeLabel.Location = new System.Drawing.Point(406, 184);
            this.TeamsizeLabel.Name = "TeamsizeLabel";
            this.TeamsizeLabel.Size = new System.Drawing.Size(81, 20);
            this.TeamsizeLabel.TabIndex = 19;
            this.TeamsizeLabel.Text = "Team size";
            // 
            // BudgetTextBox
            // 
            this.BudgetTextBox.Location = new System.Drawing.Point(532, 106);
            this.BudgetTextBox.Name = "BudgetTextBox";
            this.BudgetTextBox.Size = new System.Drawing.Size(200, 26);
            this.BudgetTextBox.TabIndex = 20;
            // 
            // DepartmentTextBox
            // 
            this.DepartmentTextBox.Location = new System.Drawing.Point(532, 147);
            this.DepartmentTextBox.Name = "DepartmentTextBox";
            this.DepartmentTextBox.Size = new System.Drawing.Size(200, 26);
            this.DepartmentTextBox.TabIndex = 21;
            // 
            // TeamsizeTextBox
            // 
            this.TeamsizeTextBox.Location = new System.Drawing.Point(532, 184);
            this.TeamsizeTextBox.Name = "TeamsizeTextBox";
            this.TeamsizeTextBox.Size = new System.Drawing.Size(200, 26);
            this.TeamsizeTextBox.TabIndex = 22;
            // 
            // ProgLangLabel
            // 
            this.ProgLangLabel.AutoSize = true;
            this.ProgLangLabel.Location = new System.Drawing.Point(406, 106);
            this.ProgLangLabel.Name = "ProgLangLabel";
            this.ProgLangLabel.Size = new System.Drawing.Size(187, 20);
            this.ProgLangLabel.TabIndex = 23;
            this.ProgLangLabel.Text = "Programming Languages";
            // 
            // GithubLabel
            // 
            this.GithubLabel.AutoSize = true;
            this.GithubLabel.Location = new System.Drawing.Point(406, 148);
            this.GithubLabel.Name = "GithubLabel";
            this.GithubLabel.Size = new System.Drawing.Size(57, 20);
            this.GithubLabel.TabIndex = 24;
            this.GithubLabel.Text = "Github";
            // 
            // ProgLangTextBox
            // 
            this.ProgLangTextBox.Location = new System.Drawing.Point(599, 106);
            this.ProgLangTextBox.Name = "ProgLangTextBox";
            this.ProgLangTextBox.Size = new System.Drawing.Size(200, 26);
            this.ProgLangTextBox.TabIndex = 25;
            // 
            // GithubTextBox
            // 
            this.GithubTextBox.Location = new System.Drawing.Point(599, 147);
            this.GithubTextBox.Name = "GithubTextBox";
            this.GithubTextBox.Size = new System.Drawing.Size(200, 26);
            this.GithubTextBox.TabIndex = 26;
            // 
            // CommRateLabel
            // 
            this.CommRateLabel.AutoSize = true;
            this.CommRateLabel.Location = new System.Drawing.Point(405, 106);
            this.CommRateLabel.Name = "CommRateLabel";
            this.CommRateLabel.Size = new System.Drawing.Size(127, 20);
            this.CommRateLabel.TabIndex = 27;
            this.CommRateLabel.Text = "Commission rate";
            // 
            // KeyAccountsLabel
            // 
            this.KeyAccountsLabel.AutoSize = true;
            this.KeyAccountsLabel.Location = new System.Drawing.Point(405, 147);
            this.KeyAccountsLabel.Name = "KeyAccountsLabel";
            this.KeyAccountsLabel.Size = new System.Drawing.Size(104, 20);
            this.KeyAccountsLabel.TabIndex = 28;
            this.KeyAccountsLabel.Text = "Key accounts";
            // 
            // KeyAccountsTextBox
            // 
            this.KeyAccountsTextBox.Location = new System.Drawing.Point(552, 147);
            this.KeyAccountsTextBox.Name = "KeyAccountsTextBox";
            this.KeyAccountsTextBox.Size = new System.Drawing.Size(200, 26);
            this.KeyAccountsTextBox.TabIndex = 29;
            // 
            // CommRateTextBox
            // 
            this.CommRateTextBox.Location = new System.Drawing.Point(552, 106);
            this.CommRateTextBox.Name = "CommRateTextBox";
            this.CommRateTextBox.Size = new System.Drawing.Size(200, 26);
            this.CommRateTextBox.TabIndex = 30;
            // 
            // SuppSysLabel
            // 
            this.SuppSysLabel.AutoSize = true;
            this.SuppSysLabel.Location = new System.Drawing.Point(405, 112);
            this.SuppSysLabel.Name = "SuppSysLabel";
            this.SuppSysLabel.Size = new System.Drawing.Size(146, 20);
            this.SuppSysLabel.TabIndex = 31;
            this.SuppSysLabel.Text = "Supported systems";
            // 
            // TicResLabel
            // 
            this.TicResLabel.AutoSize = true;
            this.TicResLabel.Location = new System.Drawing.Point(405, 150);
            this.TicResLabel.Name = "TicResLabel";
            this.TicResLabel.Size = new System.Drawing.Size(129, 20);
            this.TicResLabel.TabIndex = 32;
            this.TicResLabel.Text = "Ticekts Resolved";
            // 
            // TicResTextBox
            // 
            this.TicResTextBox.Location = new System.Drawing.Point(599, 144);
            this.TicResTextBox.Name = "TicResTextBox";
            this.TicResTextBox.Size = new System.Drawing.Size(200, 26);
            this.TicResTextBox.TabIndex = 33;
            // 
            // SuppSysTextBox
            // 
            this.SuppSysTextBox.Location = new System.Drawing.Point(599, 106);
            this.SuppSysTextBox.Name = "SuppSysTextBox";
            this.SuppSysTextBox.Size = new System.Drawing.Size(200, 26);
            this.SuppSysTextBox.TabIndex = 34;
            // 
            // CampManTextBox
            // 
            this.CampManTextBox.Location = new System.Drawing.Point(599, 106);
            this.CampManTextBox.Name = "CampManTextBox";
            this.CampManTextBox.Size = new System.Drawing.Size(200, 26);
            this.CampManTextBox.TabIndex = 38;
            // 
            // DMSTextBox
            // 
            this.DMSTextBox.Location = new System.Drawing.Point(599, 144);
            this.DMSTextBox.Name = "DMSTextBox";
            this.DMSTextBox.Size = new System.Drawing.Size(200, 26);
            this.DMSTextBox.TabIndex = 37;
            // 
            // DMSLabel
            // 
            this.DMSLabel.AutoSize = true;
            this.DMSLabel.Location = new System.Drawing.Point(405, 150);
            this.DMSLabel.Name = "DMSLabel";
            this.DMSLabel.Size = new System.Drawing.Size(167, 20);
            this.DMSLabel.TabIndex = 36;
            this.DMSLabel.Text = "Digital Marketing Skills";
            // 
            // CampManLabel
            // 
            this.CampManLabel.AutoSize = true;
            this.CampManLabel.Location = new System.Drawing.Point(405, 112);
            this.CampManLabel.Name = "CampManLabel";
            this.CampManLabel.Size = new System.Drawing.Size(160, 20);
            this.CampManLabel.TabIndex = 35;
            this.CampManLabel.Text = "Campaigns Managed";
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 324);
            this.Controls.Add(this.CampManTextBox);
            this.Controls.Add(this.DMSTextBox);
            this.Controls.Add(this.DMSLabel);
            this.Controls.Add(this.CampManLabel);
            this.Controls.Add(this.SuppSysTextBox);
            this.Controls.Add(this.TicResTextBox);
            this.Controls.Add(this.TicResLabel);
            this.Controls.Add(this.SuppSysLabel);
            this.Controls.Add(this.CommRateTextBox);
            this.Controls.Add(this.KeyAccountsTextBox);
            this.Controls.Add(this.KeyAccountsLabel);
            this.Controls.Add(this.CommRateLabel);
            this.Controls.Add(this.GithubTextBox);
            this.Controls.Add(this.ProgLangTextBox);
            this.Controls.Add(this.GithubLabel);
            this.Controls.Add(this.ProgLangLabel);
            this.Controls.Add(this.TeamsizeTextBox);
            this.Controls.Add(this.DepartmentTextBox);
            this.Controls.Add(this.BudgetTextBox);
            this.Controls.Add(this.TeamsizeLabel);
            this.Controls.Add(this.DepartmentLabel);
            this.Controls.Add(this.BudgetLabel);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.BonusTextBox);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.BirthdateLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.BonusLabel);
            this.Controls.Add(this.SalaryLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AddEmployeeButton2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button AddEmployeeButton2;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.Label BonusLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label BirthdateLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox BonusTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label BudgetLabel;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.Label TeamsizeLabel;
        private System.Windows.Forms.TextBox BudgetTextBox;
        private System.Windows.Forms.TextBox DepartmentTextBox;
        private System.Windows.Forms.TextBox TeamsizeTextBox;
        private System.Windows.Forms.Label ProgLangLabel;
        private System.Windows.Forms.Label GithubLabel;
        private System.Windows.Forms.TextBox ProgLangTextBox;
        private System.Windows.Forms.TextBox GithubTextBox;
        private System.Windows.Forms.Label CommRateLabel;
        private System.Windows.Forms.Label KeyAccountsLabel;
        private System.Windows.Forms.TextBox KeyAccountsTextBox;
        private System.Windows.Forms.TextBox CommRateTextBox;
        private System.Windows.Forms.Label SuppSysLabel;
        private System.Windows.Forms.Label TicResLabel;
        private System.Windows.Forms.TextBox TicResTextBox;
        private System.Windows.Forms.TextBox SuppSysTextBox;
        private System.Windows.Forms.TextBox CampManTextBox;
        private System.Windows.Forms.TextBox DMSTextBox;
        private System.Windows.Forms.Label DMSLabel;
        private System.Windows.Forms.Label CampManLabel;
    }
}