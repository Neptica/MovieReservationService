CREATE TABLE [Role] (
	Id INT PRIMARY KEY,
	[Name] varchar(255) NOT NULL,
	PrivilegeLevel INT UNIQUE
)