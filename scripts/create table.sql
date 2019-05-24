CREATE TABLE Product
(
	Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
	Name VARCHAR(120),
	Description VARCHAR(500),
	RegisterDate DateTime
);