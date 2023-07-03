CREATE TABLE Wash (
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Plate VARCHAR(225),
	Employee_Id INT FOREIGN KEY REFERENCES Employee(Id),
	Type_Id VARCHAR(225) FOREIGN KEY REFERENCES Vehicle_Type(Type),
	"Date" DATE
)

CREATE TABLE Vehicle_Type (
	"Type" VARCHAR(225),
	Price INT,
	"Date" DATE
)

CREATE TABLE Employee (
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(225),
	Id_Number INT,
	Ethnic VARCHAR(225),
	Birth_Date DATE,
	Join_Date DATE,
	Left_Date DATE
)