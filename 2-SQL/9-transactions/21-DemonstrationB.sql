-- Demonstration B

-- Step 1: Open a new query window to the Chinook database

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

-- Step 3: Create a transaction to wrap around insertion statements
-- to create a single unit of work
BEGIN TRY
	BEGIN TRANSACTION
		INSERT INTO dbo.SimpleOrders(custid, empid, orderdate) VALUES (6,4,'2006-07-12');
		INSERT INTO dbo.SimpleOrderDetails(orderid,productid,unitprice,qty) VALUES (1, 2,15.20,20);
	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	SELECT ERROR_NUMBER() AS ErrNum, ERROR_MESSAGE() AS ErrMsg;
	ROLLBACK TRANSACTION
END CATCH;

-- Step 4: Verify success
SELECT  orderid, custid, empid, orderdate
FROM dbo.SimpleOrders;
SELECT  orderid, productid, unitprice, qty
FROM dbo.SimpleOrderDetails;

-- Step 5: Clear out rows from previous tests
DELETE FROM dbo.SimpleOrderDetails;
GO
DELETE FROM dbo.SimpleOrders;
GO

--Step 6: Execute with errors in data to test transaction handling
BEGIN TRY
	BEGIN TRANSACTION
		INSERT INTO dbo.SimpleOrders(custid, empid, orderdate) VALUES (8,3,'2006-07-15');
		INSERT INTO dbo.SimpleOrderDetails(orderid,productid,unitprice,qty) VALUES (999,77,26.20,15);
	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	SELECT ERROR_NUMBER() AS ErrNum, ERROR_MESSAGE() AS ErrMsg;
	ROLLBACK TRANSACTION
END CATCH;

-- you can make savepoints during a transaction - and then rollback to a particular savepoint
-- rather than the whole transaction at once.


-- in T-SQL, every statement by itself is already a transaction unto itself
--    with automatic rollback.
--UPDATE table
--	SET asdf = asdf
--	WHERE (condition matching 100 rows)

-- Step 7: Verify that no partial results remain
SELECT  orderid, custid, empid, orderdate
FROM dbo.SimpleOrders;
SELECT  orderid, productid, unitprice, qty
FROM dbo.SimpleOrderDetails;


-- Step 8: Clean up demonstration tables
IF OBJECT_ID('dbo.SimpleOrderDetails','U') IS NOT NULL
	DROP TABLE dbo.SimpleOrderDetails;
IF OBJECT_ID('dbo.SimpleOrders','U') IS NOT NULL
	DROP TABLE dbo.SimpleOrders;
