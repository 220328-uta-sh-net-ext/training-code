-- Demonstration A

-- Step 1: Open a new query window to a database

-- Step 2: Create a table to support the demonstrations
-- Clean up if the tables already exists
IF OBJECT_ID('dbo.SimpleOrderDetails','U') IS NOT NULL
	DROP TABLE dbo.SimpleOrderDetails;
IF OBJECT_ID('dbo.SimpleOrders','U') IS NOT NULL
	DROP TABLE dbo.SimpleOrders;
GO
CREATE TABLE dbo.SimpleOrders(
	orderid int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	custid int NOT NULL FOREIGN KEY REFERENCES dbo.Customer(CustomerId),
	empid int NOT NULL FOREIGN KEY REFERENCES dbo.Employee(EmployeeId),
	orderdate datetime NOT NULL
);
GO
CREATE TABLE dbo.SimpleOrderDetails(
	orderid int NOT NULL FOREIGN KEY REFERENCES dbo.SimpleOrders(orderid),
	productid int NOT NULL FOREIGN KEY REFERENCES dbo.Track(TrackId),
	unitprice money NOT NULL,
	qty smallint NOT NULL,
 CONSTRAINT PK_OrderDetails PRIMARY KEY (orderid, productid)
);
GO

-- Step 3: Execute a multi-statement batch with error
-- NOTE: THIS STEP WILL CAUSE AN ERROR

-- remove $1000 from account A
-- put $1000 into account B

-- ACID (properties of a transaction)
-- atomic: indivisible. either totally finished or doesn't make any changes at all
--     (atomicity)
-- consistent: it shouldn't allow the DB constraints to be violated
--     (consistency)
-- isolated: even if we run multiple transactions at once,
--           each one shouldn't have to worry about the others, their operations
--           should be isolated from each other.
--     (isolation)
-- durable: a transaction is not "complete" until it's been persisted to non-volatile memory
--     (durability)

BEGIN TRY
	INSERT INTO dbo.SimpleOrders(custid, empid, orderdate) VALUES (6,4,'2006-07-12');
	INSERT INTO dbo.SimpleOrders(custid, empid, orderdate) VALUES (8,3,'2006-07-15');
	INSERT INTO dbo.SimpleOrderDetails(orderid,productid,unitprice,qty) VALUES (1, 2,15.20,20);
	INSERT INTO dbo.SimpleOrderDetails(orderid,productid,unitprice,qty) VALUES (999,77,26.20,15);
END TRY
BEGIN CATCH
	SELECT ERROR_NUMBER() AS ErrNum, ERROR_MESSAGE() AS ErrMsg;
END CATCH;

-- Step 4: Show that even with exception handling,
-- partial success occurred and some rows were inserted
SELECT  orderid, custid, empid, orderdate
FROM dbo.SimpleOrders;
SELECT  orderid, productid, unitprice, qty
FROM dbo.SimpleOrderDetails;


-- Step 5: Clean up demonstration tables
IF OBJECT_ID('dbo.SimpleOrderDetails','U') IS NOT NULL
	DROP TABLE dbo.SimpleOrderDetails;
IF OBJECT_ID('dbo.SimpleOrders','U') IS NOT NULL
	DROP TABLE dbo.SimpleOrders;
