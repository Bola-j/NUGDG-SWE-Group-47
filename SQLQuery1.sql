CREATE DATABASE RetailStoreDB;
USE RetailStoreDB;

CREATE TABLE Customers	(
CustomerID  INT NOT NULL PRIMARY KEY,
FirstName nvarchar(50) NOT NULL,
LastName nvarchar(50) NOT NULL,
email varchar(50) NOT NULL,
RegistrationDate date NOT NULL
);
