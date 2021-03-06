CREATE TABLE Orders 
(
OrderID int NOT NULL,
CustomerID int NOT NULL
)

CREATE TABLE Customers
(
CustomerID int NOT NULL,
Name varchar(50),
Birthday date,
CityID int NOT NULL
)

CREATE TABLE Cities
(
CityID int NOT NULL,
Name varchar(50)
)

CREATE TABLE OrderItems
(
OrderID int NOT NULL,
ItemID int NOT NULL
)

CREATE TABLE Items
(
ItemID int NOT NULL,
Name varchar(50),
ItemTypeID int NOT NULL
)

CREATE TABLE ItemTypes
(
ItemTypeID int NOT NULL,
Name varchar(50)
)

ALTER TABLE Orders
ADD CONSTRAINT PK_Orders PRIMARY KEY (OrderID)

ALTER TABLE Customers
ADD CONSTRAINT PK_Customers PRIMARY KEY (CustomerID)

ALTER TABLE Orders
ADD CONSTRAINT FK_OrdersCustomers FOREIGN KEY (CustomerID)
REFERENCES Customers(CustomerID)

ALTER TABLE Cities
ADD CONSTRAINT PK_Cities PRIMARY KEY (CityID)

ALTER TABLE Customers
ADD CONSTRAINT FK_Cities FOREIGN KEY (CityID)
REFERENCES Cities(CityID)

ALTER TABLE Items
ADD CONSTRAINT PK_Items PRIMARY KEY (ItemID)

ALTER TABLE ItemTypes
ADD CONSTRAINT PK_ItemTypes PRIMARY KEY (ItemTypeID)

ALTER TABLE Items
ADD CONSTRAINT FK_ItemTypes FOREIGN KEY (ItemTypeID)
REFERENCES ItemTypes(ItemTypeID)

ALTER TABLE OrderItems
ADD CONSTRAINT PK_OrderItems PRIMARY KEY (OrderID, ItemID)

ALTER TABLE OrderItems
ADD CONSTRAINT FK_Orders FOREIGN KEY (OrderID)
REFERENCES Orders(OrderID)

ALTER TABLE OrderItems
ADD CONSTRAINT FK_Items FOREIGN KEY (ItemID)
REFERENCES Items(ItemID)