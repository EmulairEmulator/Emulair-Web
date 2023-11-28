-- Tabelul Roles
CREATE TABLE Roles (
	RoleID INT PRIMARY KEY,
	RoleName varchar(20)
);

-- Tabelul Users
CREATE TABLE Users (
    UserID UNIQUEIDENTIFIER PRIMARY KEY,
	RoleID INT,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100) UNIQUE,
    PasswordHash VARCHAR(255),
    RegistrationDate DATETIME,
	IsDeleted BIT,
	FOREIGN KEY (RoleID) REFERENCES Roles(RoleID),
);

-- Tabelul Games
CREATE TABLE Games (
    GameID UNIQUEIDENTIFIER PRIMARY KEY,
    Title VARCHAR(100),
    Description TEXT,
    ReleaseDate DATE,
    IsDeleted BIT
);

-- Tabelul Reviews
CREATE TABLE Reviews (
    ReviewID UNIQUEIDENTIFIER PRIMARY KEY,
    GameID UNIQUEIDENTIFIER,
    UserID UNIQUEIDENTIFIER,
    Rating INT,
    Comment TEXT,
    ReviewDate DATETIME,
	IsDeleted BIT,
    FOREIGN KEY (GameID) REFERENCES Games(GameID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

-- Tabelul Highlights
CREATE TABLE Highlights (
    HighlightID UNIQUEIDENTIFIER PRIMARY KEY,
    Title VARCHAR(100),
    Description TEXT,
    ImageURL VARCHAR(255),
    LinkURL VARCHAR(255),
	IsDeleted BIT
);

-- Tabelul UserStats
CREATE TABLE UserStats (
    StatID UNIQUEIDENTIFIER PRIMARY KEY,
    UserID UNIQUEIDENTIFIER,
    TotalHoursPlayed INT,
    IsDeleted BIT,
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

