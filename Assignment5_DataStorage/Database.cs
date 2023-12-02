using System.Data;
using System.Data.SqlClient;

namespace Assignment5_DataStorage
{
    /*
    * Author: Ramiyan Gangatharan
    * Last Modified: December 2, 2023 @ 1:06am
    * Description: This file handles all the database interactions for the application.
    */

    internal class Database
    {
        /*
         * SQL_CONNECTION - Holds the database connection.
         * SQL_COMMAND - Tool used to execute SQL commands.
         */
        private SqlConnection conn;
        private SqlCommand command;

        // Constructor
        public Database()
        {
            // This creates the connection string for the application in order to connect to the database.
            string connectionString = "Data Source=LAPTOP-3UT42LKF;Initial Catalog=DC_RegistrationApp;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection(connectionString);
            command = new SqlCommand(connectionString, conn);
        }

        /*
         * This method inserts rows into the database where it presets the query, then it adds the values via parameters, 
         * then it makes sure that the connection is open, then finally it actually makes it through into the database I have created externally.
         */
        public void AddStudent(Student student)
        {
            string query = "INSERT INTO users (FirstName, LastName, PhoneNumber, studentID, SocialInsuranceNumber, EmailAddress, HS_Grade, AdmissionScore, CampusLocation, Programs) " +
                   "VALUES (@FirstName, @LastName, @Phone, @StudentID, @SIN, @Email, @HighSchoolGrade, @Admission, @Location, @Program);";

            command.CommandText = query;
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@FirstName", student.firstName);
            command.Parameters.AddWithValue("@LastName", student.lastName);
            command.Parameters.AddWithValue("@Phone", student.phoneNumber);
            command.Parameters.AddWithValue("@StudentID", student.studentID);
            command.Parameters.AddWithValue("@SIN", student.SIN);
            command.Parameters.AddWithValue("@Email", student.email);
            command.Parameters.AddWithValue("@HighSchoolGrade", student.grade);
            command.Parameters.AddWithValue("@Admission", student.admissionScore);
            command.Parameters.AddWithValue("@Location", student.location);
            command.Parameters.AddWithValue("@Program", student.program);

            // Open the connection if it's not already open
            if (conn.State != ConnectionState.Open) { conn.Open(); }
            command.ExecuteNonQuery();
        }

        /*
         * This method permanently deletes records from a database where you select a row, then press delete in order to remove it.
         * Keep in mind, this is different from the delete all button where you can only delete one row at a time for safety purposes.
         */
        public void DeleteStudentBySIN(string sin)
        {
            string deleteQuery = "DELETE FROM users WHERE SocialInsuranceNumber = @SIN;";

            command.CommandText = deleteQuery;
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@SIN", sin);
            command.ExecuteNonQuery(); // Execute the command
        }

        // These two methods manipulate the database connection.
        public void OpenConnection() { if (conn.State != ConnectionState.Open) { conn.Open(); } }
        public void CloseConnection() { if (conn.State != ConnectionState.Closed) { conn.Close(); } }

        // This method simply adds the parameters to the SQL command being executed.
        public void AddParameter(string name, object value) { command.Parameters.AddWithValue(name, value); }

        // This method loads all values into the data grid view from the database.
        public void LoadGridView(DataGridView DC_DGV)
        {
            try
            {
                command.CommandText =
                    "SELECT " +
                    "   FirstName AS 'First Name', " +
                    "   LastName AS 'Last Name'," +
                    "   PhoneNumber AS 'Phone Number'," +
                    "   studentID AS 'ID', " +
                    "   SocialInsuranceNumber AS 'SIN'," +
                    "   EmailAddress AS 'Email'," +
                    "   HS_Grade AS 'Grade'," +
                    "   AdmissionScore AS 'Score'," +
                    "   CampusLocation AS 'Location'," +
                    "   Programs AS 'Program'" +
                    "FROM users;";

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DC_DGV.DataSource = dt;
                DC_DGV.Refresh();
            }
            catch (Exception ex) { MessageBox.Show("Failed to load data: " + ex.Message); }
        }

        // This method creates the connection to the database.
        public void CreateConnection(DataGridView DC_DGV)
        {
            string connectionString = "Data Source=LAPTOP-3UT42LKF;Initial Catalog=DC_RegistrationApp;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection(connectionString);
            conn.Open();
            command = conn.CreateCommand();
            LoadGridView(DC_DGV);
        }
    }
}
