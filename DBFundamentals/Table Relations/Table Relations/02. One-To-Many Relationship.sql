CREATE TABLE Models(
 ModelID INT NOT NULL,
 Name VARCHAR(50),
 ManufacturerID INT
)

CREATE TABLE Manufacturers(
 ManufacturerId INT NOT NULL,
 Name VARCHAR(50),
 EstablishedOn DATE
)

INSERT INTO Models VALUES
(101,'X1',1),
(102,'i6',1),
(103,'Model S',2),
(104,'Model X',2),
(105,'Model 3',2),
(106,'Nova',3)

INSERT INTO Manufacturers VALUES
(1, 'BMW','07/03/1916'),
(2, 'Tesla','01/01/2003'),
(3, 'Lada','01/05/1966')

ALTER TABLE Models
ADD CONSTRAINT PK_ModelsId
PRIMARY KEY (ModelId)

ALTER TABLE Manufacturers
ADD CONSTRAINT PK_ManufacturerId
PRIMARY KEY (ManufacturerId)

ALTER TABLE Models
ADD CONSTRAINT FK_ModelsManufacturers
FOREIGN KEY(ManufacturerId) REFERENCES Manufacturers(ManufacturerId)