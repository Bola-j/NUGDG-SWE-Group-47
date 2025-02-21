CREATE DATABASE RetailStoreDB;
-- creating the database. Only execute on the first time

USE RetailStoreDB;
-- execute when needs accessing RetailStoreDB


-- Use camelCase except for primary keys use PascalCase


CREATE TABLE customers	(
	-- creating customers table
	CustomerID  INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	firstName nvarchar(50) NOT NULL,
	lastName nvarchar(50) NOT NULL,
	email varchar(50) NOT NULL,
	registrationDate date NOT NULL
);
SELECT * FROM customers;

CREATE TABLE products (
	-- creating products table
	ProductID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	productName NVARCHAR(50) NOT NULL,
	productCategory NVARCHAR(50) NOT NULL,
	price DECIMAL(18, 3) NOT NULL,
	stockQuantity INT,
);
SELECT * FROM products;

CREATE TABLE orders (
	-- creating orders table
	ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
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
	('Rich Bake Toast', 'Bakery', 40, 5);
SELECT * FROM products;

INSERT INTO customers(firstName, lastName, email, registrationDate)
-- inserting data into customers table
VALUES 	('Hany', 'Maher', 'Hany.m@gmail.com', '2021-01-25'),
		('Ragy', 'Mohsen', 'R.mohsen@gmail.com', '2019-05-01'),
		('Eman', 'Ali', 'Eman124@gmail.com', '2023-12-05');

SELECT * FROM customers;

INSERT INTO orders(customerID, orderDate, productID, quantity)
-- inserting data into orders table
VALUES (1, '2021-02-02', 1, 2),
		(2, '2019-07-15', 2, 1),
		(3, '2025-01-01', 3, 3),
		(1, '2024-12-25', 4, 1),
		(2, '2020-05-22', 5, 2);
SELECT * FROM orders;

SELECT TOP 3 productID, productName, price, stockQuantity FROM products 
ORDER BY price DESC;
-- DISPLAY the top 3 most expensive products.

SELECT * FROM customers WHERE registrationDate > '2021-01-01'; 
--Show customers who registered after a specific date.

SELECT customers.firstName,customers.lastName, * FROM orders JOIN customers ON orders.customerid = customers.customerid;
--Orders with customer names and product details.

SELECT sub.customerID, sum(sub.total_price) AS total_spent
FROM (
SELECT products.price * quantity AS total_price, ID, orders.customerID 
FROM orders 
JOIN products 
ON orders.productID = products.productID) sub
GROUP BY sub.customerID;
-- Total amount spent by each customer

SELECT sales.productID , sum(sales.total_price) AS product_sales 
FROM
(SELECT products.price * quantity AS total_price, products.ProductID, orders.customerID 
FROM orders 
JOIN products 
ON orders.productID = products.productID) sales
GROUP BY sales.ProductID;
-- Total sales for each product.


SELECT count(customerID) AS orders_done , customerID FROM orders GROUP BY customerID;
--The number of orders placed by each customer.