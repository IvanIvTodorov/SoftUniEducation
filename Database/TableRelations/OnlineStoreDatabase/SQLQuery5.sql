CREATE TABLE Cities
(
	CityID INT PRIMARY KEY,
	[Name] VARCHAR(50)
);

CREATE TABLE Customers
(
	CustomerID INT PRIMARY KEY,
	[Name] VARCHAR(50),
	Birthday DATE,
	CityID INT REFERENCES Cities(CityID),
);

CREATE TABLE Orders 
(
	OrderID INT PRIMARY KEY,
	CustomerID  INT REFERENCES Customers(CustomerID)
);


CREATE TABLE ItemTypes
(
	ItemTypeID INT PRIMARY KEY,
	[Name] VARCHAR(50)
);

CREATE TABLE Items
(
	ItemID INT  PRIMARY KEY,
	[Name] VARCHAR(50),
	ItemTypeID INT REFERENCES ItemTypes(ItemTypeID)
);

CREATE TABLE OrderItems
(
	OrderID INT REFERENCES Orders(OrderID),
	ItemID INT REFERENCES Items(ItemID)
	PRIMARY KEY(OrderID, ItemID)
);