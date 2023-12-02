namespace Assignment5_DataStorage
{
    internal class Student
    {
        /*
            * Author: Ramiyan Gangatharan
            * Last Modified: December 1, 2023 @ 12:55pm
            * Description: This file is for the Student Class
        */

        // These are the accessors and mutators of the application. 
        // This is the area that primarily handle inputs and outputs.
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string studentID { get; set; }
        public string SIN { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string grade { get; set; }
        public string admissionScore { get; set; }
        public string location { get; set; }
        public string program { get; set; }

        // Default Constructor
        public Student()
        {
            firstName = "John";
            lastName = "Doe";
            studentID = "100835223";
            SIN = "123456789";
            phoneNumber = "647 555 5555";
            email = "john.doe@dcmail.ca";
            grade = "69";
            admissionScore = "88";
            location = "Ontario";
            program = "Computer Programming";
        }

        // Parameterized Constructor
        public Student(string firstName, string lastName, string studentID, string sIN, string phoneNumber, string email, string grade, string admissionScore, string location, string program)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentID = studentID;
            SIN = sIN;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.grade = grade;
            this.admissionScore = admissionScore;
            this.location = location;
            this.program = program;
        }
    }
}
