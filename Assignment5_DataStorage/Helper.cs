using System.Data.SqlClient;

namespace Assignment5_DataStorage
{
    /*
    * Author: Ramiyan Gangatharan
    * Last Modified: December 2, 2023 @ 1:15am
    * Description: This file handles all miscellaneous functions to keep form1.cs prioritized with event handlers.
    */
    internal class Helper
    {
        Database database = new Database();
        Student newStudent = new Student();

        /*
         * I did not intend for this method to be this long but here we go...
         * 
         * This method takes the input of a mouse, where it selects a row. 
         * After a row is selected, it is displayed in a series of labels
         * where it is shown in a clean, organized manner. The way I have 
         * implemented the Student Class into this section was by just loading 
         * up and displaying the contents of each parameter. Once all parameters 
         * have been loaded with information, it shall transfer it to the labels.
         */
        public void RowViewer(DataGridView DC_DGV, Label FNameLabel, Label LNameLabel, Label PhoneLabel, Label IDLabel, Label sinLabel, Label mailLabel,
                               Label GradeLabel, Label scoreLabel, Label locationLabel, Label programLabel)
        {
            if (DC_DGV.SelectedRows.Count > 0)
            {
                // Create a new instance of Student
                Student student = new Student
                {
                    firstName = DC_DGV.SelectedRows[0].Cells["First Name"].Value?.ToString() ?? "",
                    lastName = DC_DGV.SelectedRows[0].Cells["Last Name"].Value?.ToString() ?? "",
                    phoneNumber = DC_DGV.SelectedRows[0].Cells["Phone Number"].Value?.ToString() ?? "",
                    studentID = DC_DGV.SelectedRows[0].Cells["ID"].Value?.ToString() ?? "",
                    SIN = DC_DGV.SelectedRows[0].Cells["SIN"].Value?.ToString() ?? "",
                    email = DC_DGV.SelectedRows[0].Cells["Email"].Value?.ToString() ?? "",
                    grade = DC_DGV.SelectedRows[0].Cells["Grade"].Value?.ToString() ?? "",
                    admissionScore = DC_DGV.SelectedRows[0].Cells["Score"].Value?.ToString() ?? "",
                    location = DC_DGV.SelectedRows[0].Cells["Location"].Value?.ToString() ?? "",
                    program = DC_DGV.SelectedRows[0].Cells["Program"].Value?.ToString() ?? ""
                };

                // Update labels using the properties of the Student object
                FNameLabel.Text = "First Name: " + student.firstName;
                LNameLabel.Text = "Last Name: " + student.lastName;
                PhoneLabel.Text = "Phone: " + student.phoneNumber;
                IDLabel.Text = "Student ID: " + student.studentID;
                sinLabel.Text = "SIN: " + student.SIN;
                mailLabel.Text = "Email Address: " + student.email;
                GradeLabel.Text = "Highschool Grade: " + student.grade;
                scoreLabel.Text = "Admission Test Score: " + student.admissionScore;
                locationLabel.Text = "Campus Location: " + student.location;
                programLabel.Text = "Program: " + student.program;
            }
        }

        // These two methods get all the index positions of the ComboBoxes.
        public int GetProgramIndex(string? programName, System.Windows.Forms.ComboBox ProgramCombo) // Accept nullable argument
        {
            if (programName == null) { return -1; }
            return ProgramCombo.Items.IndexOf(programName);
        }

        public int GetLocationIndex(string? locationName, System.Windows.Forms.ComboBox LocationCombo) // Accept nullable argument
        {
            if (locationName == null) { return -1; }
            return LocationCombo.Items.IndexOf(locationName);
        }

        // This method calculates the price of the education annually. This was put together using arbitrary numbers.
        public int CalculatePrice(int programIndex, int locationIndex, System.Windows.Forms.ComboBox LocationCombo)
        {
            // This is going to be based off of how close the province is from Ontario
            int basePrice = 1000;
            int programIncrement = 100 * programIndex;
            int locationIncrement = 50 * locationIndex;

            if (LocationCombo.SelectedIndex == 0)
            {
                //Alberta
                basePrice = 3000;
                programIncrement = 500 * programIndex;
                locationIncrement = 90 * locationIndex;
            }

            if
                (
                    LocationCombo.SelectedIndex == 1 ||
                    LocationCombo.SelectedIndex == 3 ||
                    LocationCombo.SelectedIndex == 4 ||
                    LocationCombo.SelectedIndex == 6 ||
                    LocationCombo.SelectedIndex == 9
                )
            {
                // British Columbia + islands
                basePrice = 4000;
                programIncrement = 800 * programIndex;
                locationIncrement = 120 * locationIndex;
            }

            if (LocationCombo.SelectedIndex == 2 || LocationCombo.SelectedIndex == 10)
            {
                //Close Vicinity to Ontario (Manitoba Quebec)
                basePrice = 2150;
                programIncrement = 150 * programIndex;
                locationIncrement = 65 * locationIndex;
            }

            if (LocationCombo.SelectedIndex == 5 || LocationCombo.SelectedIndex == 7 || LocationCombo.SelectedIndex == 12)
            {
                //NWT Yukon and Nunavut (territories will be far more expensive)
                basePrice = 8000;
                programIncrement = 1200 * programIndex;
                locationIncrement = 240 * locationIndex;
            }
            if (LocationCombo.SelectedIndex == 8)
            {
                //Ontario (Cheapest)
                basePrice = 1000;
                programIncrement = 10 * programIndex;
                locationIncrement = 15 * locationIndex;
            }
            return basePrice + programIncrement + locationIncrement;
        }

        private Dictionary<int, int> programYears = new Dictionary<int, int>();

        // Not sure why it isnt displaying anything but it is meant to create a random number from 2 - 5 and display it as years.
        public void AssignDuration(System.Windows.Forms.ComboBox ProgramCombo, Label periodLabel)
        {

            Random random = new Random();

            for (int i = 0; i < ProgramCombo.Items.Count; i++)
            {
                int randomYears = random.Next(2, 6);
                programYears[i] = randomYears;

                if (randomYears == 1)
                {
                    periodLabel.Text = "Study Period: " + randomYears + " Year";
                }
                else
                {
                    periodLabel.Text = "Study Period: " + randomYears + " Years";
                }
            }
        }

        public int GetYearsForProgram(int programIndex)
        {
            if (programYears.TryGetValue(programIndex, out int years)) { return years; }
            else { return -1; }
        }

        // This method clears all the textboxes as well as the labels (I did not update the function name).
        public void ClearTextboxes
            (
                RichTextBox FirstnameRTB, RichTextBox LastnameRTB, RichTextBox StudentNumberRTB, RichTextBox SIN_RTB, RichTextBox PhoneRTB, RichTextBox Email_RTB,
                RichTextBox HighSchoolGrade_RTB, RichTextBox AdmissionRTB, ComboBox LocationCombo, ComboBox ProgramCombo, Label FNameLabel, Label LNameLabel,
                Label PhoneLabel, Label IDLabel, Label sinLabel, Label mailLabel, Label GradeLabel, Label scoreLabel, Label locationLabel, Label programLabel,
                Label costLabel, Label periodLabel
            )
        {
            // Clear the Text properties of textboxes, not labels.
            FirstnameRTB.Text = string.Empty;
            LastnameRTB.Text = string.Empty;
            StudentNumberRTB.Text = string.Empty;
            SIN_RTB.Text = string.Empty;
            PhoneRTB.Text = string.Empty;
            Email_RTB.Text = string.Empty;
            HighSchoolGrade_RTB.Text = string.Empty;
            AdmissionRTB.Text = string.Empty;
            LocationCombo.SelectedItem = 1;
            ProgramCombo.SelectedItem = 1;

            FNameLabel.Text = "First Name: ";
            LNameLabel.Text = "Last Name: ";
            PhoneLabel.Text = "Phone: ";
            IDLabel.Text = "Student ID: ";
            sinLabel.Text = "SIN: ";
            mailLabel.Text = "Email Address: ";
            GradeLabel.Text = "Highschool Grade: ";
            scoreLabel.Text = "Admission Test Score: ";
            locationLabel.Text = "Campus Location: ";
            programLabel.Text = "Program: ";
            costLabel.Text = "Total Cost: ";
            periodLabel.Text = "Study Period: ";
        }

        // This method ensures that the SIN number is not a duplicate value in addition to the SQL exception handling.
        public void inputValidator(RichTextBox SIN_RTB, DataGridView DC_DGV)
        {
            string textBoxValue = SIN_RTB.Text;
            bool valueExists = false;

            foreach (DataGridViewRow row in DC_DGV.Rows)
            {
                if (row.Cells["SIN"].Value != null && row.Cells["SIN"].Value.ToString() == textBoxValue)
                {
                    valueExists = true;
                    break; // Stop the loop if we found a match
                }
            }

            if (valueExists) { MessageBox.Show("This value exists in the database."); }
            else { MessageBox.Show("This value does not exist in the database."); }
        }

        // This method creates student "objects".
        public void studentCreator(RichTextBox FirstnameRTB, RichTextBox LastnameRTB, RichTextBox StudentNumberRTB, RichTextBox SIN_RTB, RichTextBox PhoneRTB,
            RichTextBox Email_RTB, RichTextBox HighSchoolGrade_RTB, RichTextBox AdmissionRTB, ComboBox LocationCombo, ComboBox ProgramCombo)
        {
            // Create a new instance of Student and assign values from the form
            Student newStudent = new Student
            {
                firstName = FirstnameRTB.Text.Trim(),
                lastName = LastnameRTB.Text.Trim(),
                studentID = StudentNumberRTB.Text.Trim(),
                SIN = SIN_RTB.Text.Trim(), // Assuming SIN is a string
                phoneNumber = PhoneRTB.Text.Trim(),
                email = Email_RTB.Text.Trim(),
                grade = HighSchoolGrade_RTB.Text.Trim(),
                admissionScore = AdmissionRTB.Text.Trim(),
                location = LocationCombo.SelectedItem?.ToString() ?? string.Empty,
                program = ProgramCombo.SelectedItem?.ToString() ?? string.Empty
            };

            // Add parameters from the Student object
            database.AddParameter("@FirstName", newStudent.firstName);
            database.AddParameter("@LastName", newStudent.lastName);
            database.AddParameter("@Phone", newStudent.phoneNumber);
            database.AddParameter("@StudentID", newStudent.studentID);
            database.AddParameter("@SIN", newStudent.SIN);
            database.AddParameter("@Email", newStudent.email);
            database.AddParameter("@HighSchoolGrade", newStudent.grade);
            database.AddParameter("@Admission", newStudent.admissionScore);
            database.AddParameter("@Location", newStudent.location);
            database.AddParameter("@Program", newStudent.program);

            try { database.AddStudent(newStudent); }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return;
            }
        }

        // This method transfers the information from the user selected row into the form's controls.
        public void transfer(DataGridView DC_DGV, RichTextBox FirstnameRTB, RichTextBox LastnameRTB, RichTextBox StudentNumberRTB, RichTextBox SIN_RTB,
            RichTextBox PhoneRTB, RichTextBox Email_RTB, RichTextBox HighSchoolGrade_RTB, RichTextBox AdmissionRTB, ComboBox LocationCombo, ComboBox ProgramCombo)
        {
            if (DC_DGV.SelectedRows.Count > 0)
            {
                // Get the first selected row
                DataGridViewRow row = DC_DGV.SelectedRows[0];

                newStudent.firstName = row.Cells["First Name"].Value?.ToString() ?? "";
                newStudent.lastName = row.Cells["Last Name"].Value?.ToString() ?? "";
                newStudent.studentID = row.Cells["ID"].Value?.ToString() ?? "";
                newStudent.SIN = row.Cells["SIN"].Value?.ToString() ?? "";
                newStudent.phoneNumber = row.Cells["Phone Number"].Value?.ToString() ?? "";
                newStudent.email = row.Cells["Email"].Value.ToString() ?? "";
                newStudent.grade = row.Cells["Grade"].Value.ToString() ?? "";
                newStudent.admissionScore = row.Cells["Score"].Value.ToString() ?? "";
                newStudent.location = row.Cells["Location"].Value?.ToString() ?? "";
                newStudent.program = row.Cells["Program"].Value.ToString() ?? "";

                // Update textboxes
                FirstnameRTB.Text = newStudent.firstName;
                LastnameRTB.Text = newStudent.lastName;
                StudentNumberRTB.Text = newStudent.studentID;
                SIN_RTB.Text = newStudent.SIN;
                PhoneRTB.Text = newStudent.phoneNumber;
                Email_RTB.Text = newStudent.email;
                HighSchoolGrade_RTB.Text = newStudent.grade;
                AdmissionRTB.Text = newStudent.admissionScore;
                LocationCombo.SelectedItem = LocationCombo.Items.Cast<Object>().FirstOrDefault(item => item.ToString() == newStudent.location);
                ProgramCombo.SelectedItem = ProgramCombo.Items.Cast<Object>().FirstOrDefault(item => item.ToString() == newStudent.program);
            }
        }
    }
}
