CREATE TABLE Location (
	Id INT PRIMARY KEY,
	[Name] varchar(255) NOT NULL,
	BusinessLocationCode varchar(11) NOT NULL,
	AddressLine1 varchar(255) NOT NULL,
	AddressLine2 varchar(255) NULL,
	City varchar(255) NOT NULL,
	[State] varchar(2) NOT NULL,
	PostalCode varchar(5) NOT NULL,
	AddOnPostalCode varchar(4) NULL,
	country varchar(255) NOT NULL
)