CREATE DATABASE RetailStoreDB;
-- creating the database. Only execute on the first time

USE RetailStoreDB;
-- execute when needs accessing RetailStoreDB


-- Use camelCase except for primary keys use PascalCase


CREATE TABLE customers	(
	-- creating customers table
	CustomerID  INT NOT NULL PRIMARY KEY IDENTITY,
	firstName nvarchar(50) NOT NULL,
	lastName nvarchar(50) NOT NULL,
	email varchar(50) NOT NULL,
	registrationDate date NOT NULL
);
SELECT * FROM customers;

CREATE TABLE products (
	-- creating products table
	ProductID INT PRIMARY KEY IDENTITY NOT NULL,
	productName NVARCHAR(50) NOT NULL,
	productCategory NVARCHAR(50) NOT NULL,
	price DECIMAL(18, 3) NOT NULL,
	stockQuantity INT,
);
SELECT * FROM products;

CREATE TABLE orders (
	-- creating orders table
	ID INT PRIMARY KEY IDENTITY NOT NULL,
	customerID INT FOREIGN KEY REFERENCES customers(CustomerID),
	orderDate DATE NOT NULL,
	productID INT FOREIGN KEY REFERENCES products(ProductID) NOT NULL,
	quantity INT NOT NULL
);
SELECT * FROM orders;

INSERT INTO products(productName, productCategory, price, stockQuantity)
-- inserting data into products table
VALUES ('BIG Chips', 'Snacks', 10, 100),
	('Vilvita', 'Detergents', 70, 20),
	('Green Land', 'FoodSupplies', 40, 60),
	('V Cola', 'Beverges', 12.3, 80),
	('Rich Bakre Toast', 'Bakery', 40, 5);
SELECT * FROM products;
