CREATE TABLE Teachers (
 TeacherID INT NOT NULL,
 Name VARCHAR(50),
 ManagerID INT
)

ALTER TABLE Teachers
ADD CONSTRAINT PK_TeacherId
PRIMARY KEY(TeacherId)

ALTER TABLE Teachers
ADD CONSTRAINT FK_ManagerId
FOREIGN KEY (ManagerID) REFERENCES Teachers(TeacherId)

INSERT INTO Teachers VALUES
(101,'John',NULL),
(102,'Maya',106),
(103,'Silvia',106),
(104,'Ted',105),
(105,'Mark',101),
(106,'Greta',101)