CREATE TABLE [User] (
	Id INT PRIMARY KEY,
	Username varchar(255) NOT NULL,
	[Password] varchar(255) NOT NULL,
	RoleId INT,
		CONSTRAINT fk_Role
		FOREIGN KEY (RoleId)
		REFERENCES [Role](Id)
)