--CREATE TABLE userMaster (
--    userId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
--	accNumber VARCHAR(20) NOT NULL,
--	accBalance VARCHAR(20) NOT NULL,
--    pin binary(50) NOT NULL,
--	fname VARCHAR(20) NOT NULL,
--	lname VARCHAR(20) NOT NULL,
--	email VARCHAR(50) NOT NULL,
--	mobile VARCHAR(10) NOT NULL,
--	gender VARCHAR(10) NOT NULL,
--	address VARCHAR(100) NOT NULL,
--    createdAt DATETIME NULL,
--	lastModified DATETIME NULL
--);

/*
INSERT INTO userMaster (accNumber, accBalance, pin, fname, lname, email, mobile, gender, address, createdAt, lastModified)
VALUES('12345678910', '0', '1234', 'Satvik','Naik', 'satvik@gmail.com', '8866126679', 'male', 'on earth', '08/12/2019 21:41:56', '08/12/2019 21:41:56');
*/

--CREATE TABLE transactionHistory (
--	transactionId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
--	userId INT NOT NULL,
--	accNum varchar(20) NOT NULL,
--	debited varchar(20) NOT NULL,
--	credited varchar(20) NOT NULL,
--	transactionType varchar(20) NOT NULL,
--	currBal varchar(20) NOT NULL,
--	timestamp DATETIME NOT NULL,
--	FOREIGN KEY (userId) REFERENCES userMaster(userId),
--);

select * from userMaster;