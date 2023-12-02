namespace Assignment5_DataStorage
{
    partial class Window
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            FileTSM = new ToolStripMenuItem();
            RegisterTSM = new ToolStripMenuItem();
            CheckTSM = new ToolStripMenuItem();
            ActualRegisterTSM = new ToolStripMenuItem();
            RecordTSM = new ToolStripMenuItem();
            UpdateRecordTSM = new ToolStripMenuItem();
            LoadRecordsTSM = new ToolStripMenuItem();
            DeleteRecordTSM = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            DeleteAllRecordsTSM = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            ExitTSM = new ToolStripMenuItem();
            ExitAppTSM = new ToolStripMenuItem();
            HelpTSM = new ToolStripMenuItem();
            UserManualTSM = new ToolStripMenuItem();
            TechSupportTSM = new ToolStripMenuItem();
            AboutTSM = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            costLabel = new Label();
            periodLabel = new Label();
            locationLabel = new Label();
            scoreLabel = new Label();
            programLabel = new Label();
            GradeLabel = new Label();
            GeneralInformation = new GroupBox();
            PhoneLabel = new Label();
            mailLabel = new Label();
            IDLabel = new Label();
            sinLabel = new Label();
            LNameLabel = new Label();
            FNameLabel = new Label();
            groupBox2 = new GroupBox();
            LocationCombo = new ComboBox();
            ProgramCombo = new ComboBox();
            DeleteAll = new Button();
            ExitButton = new Button();
            AddButton = new Button();
            resetButton = new Button();
            label3 = new Label();
            DeleteButton = new Button();
            UserManualButton = new Button();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            FirstnameLabel = new Label();
            AdmissionRTB = new RichTextBox();
            HighSchoolGrade_RTB = new RichTextBox();
            FirstnameRTB = new RichTextBox();
            CheckButton = new Button();
            LastnameRTB = new RichTextBox();
            LastnameLabel = new Label();
            PhoneNumberLabel = new Label();
            LoadButton = new Button();
            PhoneRTB = new RichTextBox();
            label1 = new Label();
            UpdateButton = new Button();
            label2 = new Label();
            Email_RTB = new RichTextBox();
            SIN_RTB = new RichTextBox();
            StudentNumberLabel = new Label();
            StudentNumberRTB = new RichTextBox();
            DC_DGV = new DataGridView();
            label7 = new Label();
            CopyrightLabel = new Label();
            toolTip1 = new ToolTip(components);
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            GeneralInformation.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DC_DGV).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Items.AddRange(new ToolStripItem[] { FileTSM, HelpTSM });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1410, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // FileTSM
            // 
            FileTSM.DropDownItems.AddRange(new ToolStripItem[] { RegisterTSM, RecordTSM, toolStripSeparator1, ExitTSM });
            FileTSM.Name = "FileTSM";
            FileTSM.Size = new Size(37, 19);
            FileTSM.Text = "File";
            // 
            // RegisterTSM
            // 
            RegisterTSM.DropDownItems.AddRange(new ToolStripItem[] { CheckTSM, ActualRegisterTSM });
            RegisterTSM.Name = "RegisterTSM";
            RegisterTSM.Size = new Size(137, 22);
            RegisterTSM.Text = "Registration";
            // 
            // CheckTSM
            // 
            CheckTSM.Name = "CheckTSM";
            CheckTSM.Size = new Size(147, 22);
            CheckTSM.Text = "Check Record";
            CheckTSM.Click += CheckTSM_Click;
            // 
            // ActualRegisterTSM
            // 
            ActualRegisterTSM.Name = "ActualRegisterTSM";
            ActualRegisterTSM.Size = new Size(147, 22);
            ActualRegisterTSM.Text = "Register";
            ActualRegisterTSM.Click += ActualRegisterTSM_Click;
            // 
            // RecordTSM
            // 
            RecordTSM.DropDownItems.AddRange(new ToolStripItem[] { UpdateRecordTSM, LoadRecordsTSM, DeleteRecordTSM, toolStripSeparator2, DeleteAllRecordsTSM });
            RecordTSM.Name = "RecordTSM";
            RecordTSM.Size = new Size(137, 22);
            RecordTSM.Text = "Record";
            // 
            // UpdateRecordTSM
            // 
            UpdateRecordTSM.Name = "UpdateRecordTSM";
            UpdateRecordTSM.Size = new Size(194, 22);
            UpdateRecordTSM.Text = "Update Record";
            UpdateRecordTSM.Click += UpdateRecordTSM_Click;
            // 
            // LoadRecordsTSM
            // 
            LoadRecordsTSM.Name = "LoadRecordsTSM";
            LoadRecordsTSM.Size = new Size(194, 22);
            LoadRecordsTSM.Text = "Load Records to Server";
            LoadRecordsTSM.Click += LoadRecordsTSM_Click;
            // 
            // DeleteRecordTSM
            // 
            DeleteRecordTSM.Name = "DeleteRecordTSM";
            DeleteRecordTSM.Size = new Size(194, 22);
            DeleteRecordTSM.Text = "Delete Record";
            DeleteRecordTSM.Click += DeleteRecordTSM_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(191, 6);
            // 
            // DeleteAllRecordsTSM
            // 
            DeleteAllRecordsTSM.Name = "DeleteAllRecordsTSM";
            DeleteAllRecordsTSM.Size = new Size(194, 22);
            DeleteAllRecordsTSM.Text = "Delete All Records";
            DeleteAllRecordsTSM.Click += DeleteAllRecordsTSM_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(134, 6);
            // 
            // ExitTSM
            // 
            ExitTSM.DropDownItems.AddRange(new ToolStripItem[] { ExitAppTSM });
            ExitTSM.Name = "ExitTSM";
            ExitTSM.Size = new Size(137, 22);
            ExitTSM.Text = "Exit";
            // 
            // ExitAppTSM
            // 
            ExitAppTSM.Name = "ExitAppTSM";
            ExitAppTSM.Size = new Size(157, 22);
            ExitAppTSM.Text = "Exit Application";
            ExitAppTSM.Click += ExitAppTSM_Click;
            // 
            // HelpTSM
            // 
            HelpTSM.DropDownItems.AddRange(new ToolStripItem[] { UserManualTSM, TechSupportTSM, AboutTSM });
            HelpTSM.Name = "HelpTSM";
            HelpTSM.Size = new Size(44, 19);
            HelpTSM.Text = "Help";
            // 
            // UserManualTSM
            // 
            UserManualTSM.Name = "UserManualTSM";
            UserManualTSM.Size = new Size(168, 22);
            UserManualTSM.Text = "User Manual";
            UserManualTSM.Click += UserManualTSM_Click;
            // 
            // TechSupportTSM
            // 
            TechSupportTSM.Name = "TechSupportTSM";
            TechSupportTSM.Size = new Size(168, 22);
            TechSupportTSM.Text = "Technical Support";
            TechSupportTSM.Click += TechSupportTSM_Click;
            // 
            // AboutTSM
            // 
            AboutTSM.Name = "AboutTSM";
            AboutTSM.Size = new Size(168, 22);
            AboutTSM.Text = "About";
            AboutTSM.Click += AboutTSM_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(GeneralInformation);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(DC_DGV);
            groupBox1.Location = new Point(17, 40);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1380, 576);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Records";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(costLabel);
            groupBox3.Controls.Add(periodLabel);
            groupBox3.Controls.Add(locationLabel);
            groupBox3.Controls.Add(scoreLabel);
            groupBox3.Controls.Add(programLabel);
            groupBox3.Controls.Add(GradeLabel);
            groupBox3.Location = new Point(681, 434);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(691, 135);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "Educational Background";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(389, 100);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(107, 20);
            costLabel.TabIndex = 11;
            costLabel.Text = "Total Cost: ";
            // 
            // periodLabel
            // 
            periodLabel.AutoSize = true;
            periodLabel.Location = new Point(15, 100);
            periodLabel.Name = "periodLabel";
            periodLabel.Size = new Size(119, 20);
            periodLabel.TabIndex = 10;
            periodLabel.Text = "Study Period:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new Point(15, 30);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(156, 20);
            locationLabel.TabIndex = 2;
            locationLabel.Text = "Campus Location:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(389, 65);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(192, 20);
            scoreLabel.TabIndex = 9;
            scoreLabel.Text = "Admission Test Score:";
            // 
            // programLabel
            // 
            programLabel.AutoSize = true;
            programLabel.Location = new Point(15, 65);
            programLabel.Name = "programLabel";
            programLabel.Size = new Size(83, 20);
            programLabel.TabIndex = 7;
            programLabel.Text = "Program:";
            // 
            // GradeLabel
            // 
            GradeLabel.AutoSize = true;
            GradeLabel.Location = new Point(389, 30);
            GradeLabel.Name = "GradeLabel";
            GradeLabel.Size = new Size(159, 20);
            GradeLabel.TabIndex = 8;
            GradeLabel.Text = "Highschool Grade:";
            // 
            // GeneralInformation
            // 
            GeneralInformation.Controls.Add(PhoneLabel);
            GeneralInformation.Controls.Add(mailLabel);
            GeneralInformation.Controls.Add(IDLabel);
            GeneralInformation.Controls.Add(sinLabel);
            GeneralInformation.Controls.Add(LNameLabel);
            GeneralInformation.Controls.Add(FNameLabel);
            GeneralInformation.Location = new Point(681, 294);
            GeneralInformation.Name = "GeneralInformation";
            GeneralInformation.Size = new Size(691, 135);
            GeneralInformation.TabIndex = 31;
            GeneralInformation.TabStop = false;
            GeneralInformation.Text = "Personal Overview";
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(428, 100);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(72, 20);
            PhoneLabel.TabIndex = 6;
            PhoneLabel.Text = "Phone: ";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new Point(15, 100);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new Size(132, 20);
            mailLabel.TabIndex = 5;
            mailLabel.Text = "Email Address:";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(389, 65);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(111, 20);
            IDLabel.TabIndex = 4;
            IDLabel.Text = "Student ID: ";
            // 
            // sinLabel
            // 
            sinLabel.AutoSize = true;
            sinLabel.Location = new Point(389, 30);
            sinLabel.Name = "sinLabel";
            sinLabel.Size = new Size(51, 20);
            sinLabel.TabIndex = 3;
            sinLabel.Text = "SIN: ";
            // 
            // LNameLabel
            // 
            LNameLabel.AutoSize = true;
            LNameLabel.Location = new Point(15, 65);
            LNameLabel.Name = "LNameLabel";
            LNameLabel.Size = new Size(104, 20);
            LNameLabel.TabIndex = 1;
            LNameLabel.Text = "Last Name:";
            // 
            // FNameLabel
            // 
            FNameLabel.AutoSize = true;
            FNameLabel.Location = new Point(15, 30);
            FNameLabel.Name = "FNameLabel";
            FNameLabel.Size = new Size(111, 20);
            FNameLabel.TabIndex = 0;
            FNameLabel.Text = "First Name: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LocationCombo);
            groupBox2.Controls.Add(ProgramCombo);
            groupBox2.Controls.Add(DeleteAll);
            groupBox2.Controls.Add(ExitButton);
            groupBox2.Controls.Add(AddButton);
            groupBox2.Controls.Add(resetButton);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(DeleteButton);
            groupBox2.Controls.Add(UserManualButton);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(FirstnameLabel);
            groupBox2.Controls.Add(AdmissionRTB);
            groupBox2.Controls.Add(HighSchoolGrade_RTB);
            groupBox2.Controls.Add(FirstnameRTB);
            groupBox2.Controls.Add(CheckButton);
            groupBox2.Controls.Add(LastnameRTB);
            groupBox2.Controls.Add(LastnameLabel);
            groupBox2.Controls.Add(PhoneNumberLabel);
            groupBox2.Controls.Add(LoadButton);
            groupBox2.Controls.Add(PhoneRTB);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(UpdateButton);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(Email_RTB);
            groupBox2.Controls.Add(SIN_RTB);
            groupBox2.Controls.Add(StudentNumberLabel);
            groupBox2.Controls.Add(StudentNumberRTB);
            groupBox2.Location = new Point(9, 294);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(666, 275);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Information Form";
            // 
            // LocationCombo
            // 
            LocationCombo.FormattingEnabled = true;
            LocationCombo.Items.AddRange(new object[] { "Alberta", "British Columbia", "Manitoba", "New Brunswick", "Newfoundland", "Northwest Territories", "Nova Scotia", "Nunavut", "Ontario", "Prince Edward Island", "Quebec", "Saskatchewan", "Yukon" });
            LocationCombo.Location = new Point(348, 46);
            LocationCombo.Name = "LocationCombo";
            LocationCombo.Size = new Size(200, 28);
            LocationCombo.TabIndex = 36;
            toolTip1.SetToolTip(LocationCombo, "Select a campus location");
            // 
            // ProgramCombo
            // 
            ProgramCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ProgramCombo.FormattingEnabled = true;
            ProgramCombo.Items.AddRange(new object[] { "911 Emergency Communications", "Accounting", "Addictions ", "Advanced Law Enforcement", "Advertising", "Animal Care", "Animation", "Architectural Technology", "Artificial Intelligence", "Behavioural Sciences", "Automotive Technician", "Biomedical Engineering ", "Broadcasting", "Business", "Carpentry", "Chemical Engineering ", "Child & Youth Care", "Civil Engineering", "Clinical Bioinformatics", "Cloud Computing", "Communicative Disorders", "Community Mental Health", "Computer Foundations", "Computer Programming", "Computer Systems ", "Construction Management", "Cosmetic Technologist", "Crane Operation", "Critical Care Nursing", "Culinary", "Cybersecurity", "Data Analytics", "Dental Assistant", "Dental Hygiene", "Dental Administration", "Developmental Services Worker", "Early Childhood Education", "Electrical Engineering", "Electromechanical Engineering", "Electronics Engineering", "Emergency Services ", "Entrepreneurship", "Environmental Technology", "Esthetician", "Event Planning", "Film & Motion Design", "Finance", "Fine Arts", "Fire Prevention", "Firefighter", "Fitness & Health", "Game - Art", "Gas Tech [1]", "Gas Tech [2]", "Gas Tech [3]", "General Arts", "Graphic Design", "HVAC Tech", "Horticulture", "Hospitality", "Human Resources", "Interactive Media Design", "International Management", "Journalism", "Law Clerk", "Marketing", "Massage Therapy", "Mechanical Engineering", "Mechanical Tech", "Music", "Nursing", "Nutrition", "Occupational Therapy", "Office Administration", "Paralegal", "Paramedic", "Personal Support Worker", "Pharmaceutical Science", "Photography", "Police Foundations", "Power Engineering", "Practical Nursing", "Pre-Health Sciences", "Project Management", "Public Relations", "Recreation & Leisure Services", "Recreation Therapy", "Social Service Worker", "Sports Administration", "Sports Management", "Supply Chain Management", "Tourism", "Video Production", "Web Development", "Welding Engineering Tech" });
            ProgramCombo.Location = new Point(6, 164);
            ProgramCombo.Name = "ProgramCombo";
            ProgramCombo.Size = new Size(408, 28);
            ProgramCombo.TabIndex = 35;
            toolTip1.SetToolTip(ProgramCombo, "Select a program you would like to enrol into");
            // 
            // DeleteAll
            // 
            DeleteAll.Location = new Point(416, 236);
            DeleteAll.Name = "DeleteAll";
            DeleteAll.Size = new Size(121, 30);
            DeleteAll.TabIndex = 33;
            DeleteAll.Text = "De&lete All";
            toolTip1.SetToolTip(DeleteAll, "Click here to delete all rows from the table");
            DeleteAll.UseVisualStyleBackColor = true;
            DeleteAll.Click += DeleteAll_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(486, 200);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(51, 30);
            ExitButton.TabIndex = 28;
            ExitButton.Text = "E&xit";
            toolTip1.SetToolTip(ExitButton, "Click here to exit the application");
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(224, 236);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(92, 30);
            AddButton.TabIndex = 10;
            AddButton.Text = "R&egister";
            toolTip1.SetToolTip(AddButton, "Click here to push your data from the text fields into your table");
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(142, 236);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(76, 30);
            resetButton.TabIndex = 32;
            resetButton.Text = "&Reset ";
            toolTip1.SetToolTip(resetButton, "Click here to reset the entire application including all your data");
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(596, 141);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 15;
            label3.Text = "Grade";
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(409, 200);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(71, 30);
            DeleteButton.TabIndex = 25;
            DeleteButton.Text = "&Delete ";
            toolTip1.SetToolTip(DeleteButton, "Click here after you have selected a row in order to permanently delete the row");
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UserManualButton
            // 
            UserManualButton.Location = new Point(348, 200);
            UserManualButton.Name = "UserManualButton";
            UserManualButton.Size = new Size(55, 30);
            UserManualButton.TabIndex = 29;
            UserManualButton.Text = "&Help";
            toolTip1.SetToolTip(UserManualButton, "Click here to see the user manual");
            UserManualButton.UseVisualStyleBackColor = true;
            UserManualButton.Click += UserManualButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(348, 20);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 19;
            label5.Text = "Location";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 138);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 21;
            label6.Text = "Program";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(529, 141);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 16;
            label4.Text = "Score";
            // 
            // FirstnameLabel
            // 
            FirstnameLabel.AutoSize = true;
            FirstnameLabel.Location = new Point(6, 23);
            FirstnameLabel.Name = "FirstnameLabel";
            FirstnameLabel.Size = new Size(98, 20);
            FirstnameLabel.TabIndex = 2;
            FirstnameLabel.Text = "First Name";
            // 
            // AdmissionRTB
            // 
            AdmissionRTB.Location = new Point(537, 164);
            AdmissionRTB.Name = "AdmissionRTB";
            AdmissionRTB.Size = new Size(45, 30);
            AdmissionRTB.TabIndex = 18;
            AdmissionRTB.Text = "";
            toolTip1.SetToolTip(AdmissionRTB, "Insert your admission test score here");
            // 
            // HighSchoolGrade_RTB
            // 
            HighSchoolGrade_RTB.Location = new Point(596, 164);
            HighSchoolGrade_RTB.Name = "HighSchoolGrade_RTB";
            HighSchoolGrade_RTB.Size = new Size(45, 30);
            HighSchoolGrade_RTB.TabIndex = 17;
            HighSchoolGrade_RTB.Text = "";
            toolTip1.SetToolTip(HighSchoolGrade_RTB, "Insert your highschool grade here");
            // 
            // FirstnameRTB
            // 
            FirstnameRTB.Location = new Point(6, 46);
            FirstnameRTB.Name = "FirstnameRTB";
            FirstnameRTB.Size = new Size(165, 30);
            FirstnameRTB.TabIndex = 6;
            FirstnameRTB.Text = "";
            toolTip1.SetToolTip(FirstnameRTB, "Insert First name");
            // 
            // CheckButton
            // 
            CheckButton.Location = new Point(142, 200);
            CheckButton.Name = "CheckButton";
            CheckButton.Size = new Size(137, 30);
            CheckButton.TabIndex = 23;
            CheckButton.Text = "&Check Records";
            toolTip1.SetToolTip(CheckButton, "Click here to check to see if your inputted SIN Number is a duplicate value");
            CheckButton.UseVisualStyleBackColor = true;
            CheckButton.Click += CheckButton_Click;
            // 
            // LastnameRTB
            // 
            LastnameRTB.Location = new Point(177, 46);
            LastnameRTB.Name = "LastnameRTB";
            LastnameRTB.Size = new Size(165, 30);
            LastnameRTB.TabIndex = 7;
            LastnameRTB.Text = "";
            toolTip1.SetToolTip(LastnameRTB, "Insert lastname");
            // 
            // LastnameLabel
            // 
            LastnameLabel.AutoSize = true;
            LastnameLabel.Location = new Point(177, 20);
            LastnameLabel.Name = "LastnameLabel";
            LastnameLabel.Size = new Size(97, 20);
            LastnameLabel.TabIndex = 3;
            LastnameLabel.Text = "Last Name";
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(420, 79);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(128, 20);
            PhoneNumberLabel.TabIndex = 5;
            PhoneNumberLabel.Text = "Phone Number";
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(285, 200);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(57, 30);
            LoadButton.TabIndex = 26;
            LoadButton.Text = "&Load ";
            toolTip1.SetToolTip(LoadButton, "Click here to load the values of the row you selected into the text fields");
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // PhoneRTB
            // 
            PhoneRTB.Location = new Point(420, 105);
            PhoneRTB.Name = "PhoneRTB";
            PhoneRTB.Size = new Size(234, 30);
            PhoneRTB.TabIndex = 9;
            PhoneRTB.Text = "";
            toolTip1.SetToolTip(PhoneRTB, "Insert your telephone number");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(420, 141);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 11;
            label1.Text = "SIN ";
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(322, 236);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(88, 30);
            UpdateButton.TabIndex = 24;
            UpdateButton.Text = "&Update ";
            toolTip1.SetToolTip(UpdateButton, "Click here to update pre-existing information, just remember to select a row before pressing this button.");
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 79);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 12;
            label2.Text = "Email";
            // 
            // Email_RTB
            // 
            Email_RTB.Location = new Point(6, 105);
            Email_RTB.Name = "Email_RTB";
            Email_RTB.Size = new Size(408, 30);
            Email_RTB.TabIndex = 14;
            Email_RTB.Text = "";
            toolTip1.SetToolTip(Email_RTB, "Insert your Email Address");
            // 
            // SIN_RTB
            // 
            SIN_RTB.Location = new Point(420, 164);
            SIN_RTB.Name = "SIN_RTB";
            SIN_RTB.Size = new Size(96, 30);
            SIN_RTB.TabIndex = 13;
            SIN_RTB.Text = "";
            toolTip1.SetToolTip(SIN_RTB, "Insert your social insurance number here, remember to check to see if it is a duplicate or not");
            // 
            // StudentNumberLabel
            // 
            StudentNumberLabel.AutoSize = true;
            StudentNumberLabel.Location = new Point(554, 23);
            StudentNumberLabel.Name = "StudentNumberLabel";
            StudentNumberLabel.Size = new Size(67, 20);
            StudentNumberLabel.TabIndex = 4;
            StudentNumberLabel.Text = "Stu. ID";
            // 
            // StudentNumberRTB
            // 
            StudentNumberRTB.Location = new Point(554, 46);
            StudentNumberRTB.Name = "StudentNumberRTB";
            StudentNumberRTB.Size = new Size(100, 30);
            StudentNumberRTB.TabIndex = 8;
            StudentNumberRTB.Text = "";
            toolTip1.SetToolTip(StudentNumberRTB, "Insert your student ID Number");
            // 
            // DC_DGV
            // 
            DC_DGV.AllowUserToAddRows = false;
            DC_DGV.AllowUserToDeleteRows = false;
            DC_DGV.AllowUserToResizeColumns = false;
            DC_DGV.AllowUserToResizeRows = false;
            DC_DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DC_DGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DC_DGV.BorderStyle = BorderStyle.Fixed3D;
            DC_DGV.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            DC_DGV.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            DC_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            DC_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DC_DGV.Location = new Point(9, 28);
            DC_DGV.Margin = new Padding(4);
            DC_DGV.Name = "DC_DGV";
            DC_DGV.ReadOnly = true;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            DC_DGV.RowsDefaultCellStyle = dataGridViewCellStyle10;
            DC_DGV.RowTemplate.Height = 25;
            DC_DGV.ShowEditingIcon = false;
            DC_DGV.Size = new Size(1363, 259);
            DC_DGV.TabIndex = 0;
            toolTip1.SetToolTip(DC_DGV, "This is where your information will be stored");
            DC_DGV.SelectionChanged += DC_DGV_SelectionChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(552, 25);
            label7.Name = "label7";
            label7.Size = new Size(342, 20);
            label7.TabIndex = 2;
            label7.Text = "Durham College Registration Application";
            // 
            // CopyrightLabel
            // 
            CopyrightLabel.AutoSize = true;
            CopyrightLabel.Font = new Font("MS Reference Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            CopyrightLabel.Location = new Point(552, 620);
            CopyrightLabel.Margin = new Padding(1, 0, 1, 0);
            CopyrightLabel.Name = "CopyrightLabel";
            CopyrightLabel.Size = new Size(277, 15);
            CopyrightLabel.TabIndex = 13;
            CopyrightLabel.Text = "Copyright © Ramiyan Gangatharan - DC 2023 ";
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1410, 651);
            Controls.Add(CopyrightLabel);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Window";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DC Registration App";
            FormClosed += Window_FormClosed;
            Load += Window_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            GeneralInformation.ResumeLayout(false);
            GeneralInformation.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DC_DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileTSM;
        private ToolStripMenuItem HelpTSM;
        private ToolStripMenuItem RegisterTSM;
        private ToolStripMenuItem RecordTSM;
        private ToolStripMenuItem UpdateRecordTSM;
        private ToolStripMenuItem LoadRecordsTSM;
        private ToolStripMenuItem DeleteRecordTSM;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem DeleteAllRecordsTSM;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ExitTSM;
        private ToolStripMenuItem UserManualTSM;
        private ToolStripMenuItem TechSupportTSM;
        private ToolStripMenuItem AboutTSM;
        private GroupBox groupBox1;
        private DataGridView DC_DGV;
        private Button AddButton;
        private RichTextBox PhoneRTB;
        private RichTextBox StudentNumberRTB;
        private Label PhoneNumberLabel;
        private RichTextBox LastnameRTB;
        private Label StudentNumberLabel;
        private RichTextBox FirstnameRTB;
        private Label FirstnameLabel;
        private Label LastnameLabel;
        private Label label6;
        private Label label5;
        private RichTextBox AdmissionRTB;
        private RichTextBox HighSchoolGrade_RTB;
        private Label label4;
        private Label label3;
        private RichTextBox Email_RTB;
        private RichTextBox SIN_RTB;
        private Label label2;
        private Label label1;
        private Button ExitButton;
        private Button LoadButton;
        private Button DeleteButton;
        private Button UpdateButton;
        private Button CheckButton;
        private Button UserManualButton;
        private Label label7;
        private Label CopyrightLabel;
        private ToolTip toolTip1;
        private GroupBox groupBox2;
        private Button resetButton;
        private ToolStripMenuItem CheckTSM;
        private ToolStripMenuItem ActualRegisterTSM;
        private ToolStripMenuItem ExitAppTSM;
        private Button DeleteAll;
        private GroupBox GeneralInformation;
        private Label sinLabel;
        private Label locationLabel;
        private Label LNameLabel;
        private Label FNameLabel;
        private Label scoreLabel;
        private Label GradeLabel;
        private Label programLabel;
        private Label PhoneLabel;
        private Label mailLabel;
        private Label IDLabel;
        private GroupBox groupBox3;
        private Label costLabel;
        private Label periodLabel;
        private ComboBox ProgramCombo;
        private ComboBox LocationCombo;
    }
}