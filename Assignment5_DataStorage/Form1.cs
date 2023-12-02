using System.Data.SqlClient;

namespace Assignment5_DataStorage
{

    /*
    * Author: Ramiyan Gangatharan
    * Last Modified: December 2, 2023 @ 1:15am
    * Description: This file handles all controls of the application
    */

    public partial class Window : Form
    {
        Helper Assistant = new Helper();
        Database database = new Database();

        public Window()
        {
            InitializeComponent();
            Assistant.AssignDuration(ProgramCombo, periodLabel);
        }

        private void UpdatePriceLabel(DataGridView DC_DGV, Label costLabel)
        {
            if (DC_DGV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DC_DGV.SelectedRows[0];
                int programIndex = Assistant.GetProgramIndex(selectedRow.Cells["Program"].Value?.ToString(), ProgramCombo);
                int locationIndex = Assistant.GetLocationIndex(selectedRow.Cells["Location"].Value?.ToString(), LocationCombo);
                int price = Assistant.CalculatePrice(programIndex, locationIndex, LocationCombo);
                costLabel.Text = $"Total Cost: ${price}";
            }
        }

        private void Window_Load(object sender, EventArgs e)
        {
            database.CreateConnection(DC_DGV);
            database.OpenConnection();
        }
        private void ActualRegisterTSM_Click(object sender, EventArgs e) { AddButton_Click(sender, e); }
        private void ExitAppTSM_Click(object sender, EventArgs e) { Close(); }
        private void UpdateRecordTSM_Click(object sender, EventArgs e) { UpdateButton_Click(sender, e); }
        private void LoadRecordsTSM_Click(object sender, EventArgs e) { LoadButton_Click(sender, e); }
        private void DeleteRecordTSM_Click(object sender, EventArgs e) { DeleteButton_Click(sender, e); }
        private void DeleteAllRecordsTSM_Click(object sender, EventArgs e) { DeleteAll_Click(sender, e); }
        private void UserManualTSM_Click(object sender, EventArgs e) { UserManualButton_Click(sender, e); }
        private void TechSupportTSM_Click(object sender, EventArgs e) 
        { 
            TechSupport support = new TechSupport();
            support.Show();
        }
        private void AboutTSM_Click(object sender, EventArgs e) 
        {
            About about = new About();
            about.Show();
        }

        // This method takes the information from the textboxes and puts them in to the database.
        private void AddButton_Click(object sender, EventArgs e)
        {
            Assistant.studentCreator(FirstnameRTB, LastnameRTB, StudentNumberRTB, SIN_RTB, PhoneRTB, Email_RTB, HighSchoolGrade_RTB, AdmissionRTB, LocationCombo, ProgramCombo);
            database.LoadGridView(DC_DGV); // Refresh the DataGridView
            Assistant.ClearTextboxes(FirstnameRTB, LastnameRTB, StudentNumberRTB, SIN_RTB, PhoneRTB, Email_RTB, HighSchoolGrade_RTB, AdmissionRTB, LocationCombo,
                                       ProgramCombo, FNameLabel, LNameLabel, PhoneLabel, IDLabel, sinLabel, mailLabel, GradeLabel, scoreLabel, locationLabel,
                                       programLabel, costLabel, periodLabel);
        }

        private void ExitButton_Click(object sender, EventArgs e) { Close(); }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DC_DGV.SelectedRows.Count > 0)
            {
                var selectedRow = DC_DGV.SelectedRows[0];
                var sin = selectedRow.Cells["SIN"].Value.ToString() ?? "";

                // Delete the user with the specified SIN
                try { database.DeleteStudentBySIN(sin); }
                catch (SqlException ex) { MessageBox.Show("An error occurred: " + ex.Message); }

                database.LoadGridView(DC_DGV); // Refresh the DataGridView
            }
            else { MessageBox.Show("No row selected."); }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (DC_DGV.SelectedRows.Count > 0) { Assistant.transfer(DC_DGV, FirstnameRTB, LastnameRTB, StudentNumberRTB, SIN_RTB, PhoneRTB, Email_RTB, HighSchoolGrade_RTB, AdmissionRTB, LocationCombo, ProgramCombo); }
            else { MessageBox.Show("Please select a row first."); }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (DC_DGV.SelectedRows.Count == 1)
            {
                LoadButton_Click(sender, e); // Load the data from the selected row
                DeleteButton_Click(sender, e); // Delete the selected row
            }
            else { MessageBox.Show("Please only select one row to update"); }
        }

        private void DC_DGV_SelectionChanged(object sender, EventArgs e)
        {
            Assistant.RowViewer(DC_DGV, FNameLabel, LNameLabel, PhoneLabel, IDLabel, sinLabel, mailLabel, GradeLabel, scoreLabel, locationLabel, programLabel);
            UpdatePriceLabel(DC_DGV, costLabel);
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete ALL records?", "Confirm Delete All", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Loop backwards since we are removing rows
                for (int i = DC_DGV.Rows.Count - 1; i >= 0; i--)
                {
                    DC_DGV.Rows[i].Selected = true; // Select the row
                    DeleteButton_Click(DeleteButton, new EventArgs()); // Call the Delete button's event handler
                }
                database.LoadGridView(DC_DGV); // Refresh the DataGridView after deletion
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            DeleteAll_Click(sender, e);
            Assistant.ClearTextboxes(FirstnameRTB, LastnameRTB, StudentNumberRTB, SIN_RTB, PhoneRTB, Email_RTB, HighSchoolGrade_RTB, AdmissionRTB,
            LocationCombo, ProgramCombo, FNameLabel, LNameLabel, PhoneLabel, IDLabel, sinLabel, mailLabel, GradeLabel, scoreLabel, locationLabel, programLabel,
            costLabel, periodLabel);
        }

        private void CheckButton_Click(object sender, EventArgs e) { Assistant.inputValidator(SIN_RTB, DC_DGV); }
        private void CheckTSM_Click(object sender, EventArgs e) { CheckButton_Click(sender, e); }
        private void UserManualButton_Click(object sender, EventArgs e) 
        {
            UserManual manual = new UserManual();
            manual.Show();
        }
        private void Window_FormClosed(object sender, FormClosedEventArgs e) { database.CloseConnection(); }
    }
}