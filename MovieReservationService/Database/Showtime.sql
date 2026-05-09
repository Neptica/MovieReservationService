CREATE TABLE Showtime (
	Id varchar(36) UNIQUE,
	MovieId INT NOT NULL,
		CONSTRAINT fk_Movie
		FOREIGN KEY (MovieId)
		REFERENCES Movie(Id),
	AuditoriumId INT NOT NULL,
		CONSTRAINT fk_Theater
		FOREIGN KEY (AuditoriumId)
		REFERENCES Auditorium(Id),
	LocationId INT NOT NULL,
		CONSTRAINT fk_Location
		FOREIGN KEY (LocationId)
		REFERENCES [Location](Id),
	Showing TIMESTAMP NOT NULL
)