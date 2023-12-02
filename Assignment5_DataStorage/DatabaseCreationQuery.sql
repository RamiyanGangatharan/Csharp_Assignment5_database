DROP TABLE IF EXISTS users;

CREATE TABLE users
(
	FirstName VARCHAR(255),
	LastName  VARCHAR(255),
	PhoneNumber VARCHAR(255),
	studentID VARCHAR(255),
	SocialInsuranceNumber INT PRIMARY KEY,
	EmailAddress VARCHAR (255),
	HS_Grade DECIMAL,
	AdmissionScore DECIMAL, 
	CampusLocation VARCHAR (255),
	Programs VARCHAR (255)
);

--DROP TABLE users;
SELECT * FROM users;
