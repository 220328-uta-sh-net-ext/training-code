-- DDL -
-- CREATE, ALTER, DROP
-- e.g. CREATE TABLE, ALTER TABLE, DROP TABLE

--CREATE DATABASE ChinookNumberTwo;

-- schema is like namespace in C#
CREATE SCHEMA ChatApp;
GO
-- in SQL Server, the default schema is dbo

CREATE TABLE ChatApp.Person (
	Username NVARCHAR(100) UNIQUE CHECK (LEN(Username) >= 5),
    AccountCreated DATETIME2 NOT NULL DEFAULT (SYSUTCDATETIME())
);

SELECT * FROM ChatApp.Person;

ALTER TABLE ChatApp.Person ADD
	AccountCreated DATETIME2;

-- ALTER TABLE ChatApp.Person ADD
-- 	CONSTRAINT DF_AccountCreated DEFAULT SYSUTCDATETIME() FOR AccountCreated;

INSERT INTO ChatApp.Person(Username, AccountCreated) VALUES
	('user123', SYSUTCDATETIME());

SELECT MONTH(AccountCreated) FROM ChatApp.Person;

-- we can put constraints on table columns.
-- NOT NULL vs NULL.
-- normally, by default, all columns can accept NULL as a possible value (and as their default).
--   this can be explicitly marked by putting NULL after the column definition.
--   it's good practice to always explicitly mark NULL or NOT NULL, because
--   database settings and other circumstances could change the default of NULL.

-- NOT NULL prevents NULL, and leaves the column without a default value.

-- CHECK constraint
--  define an arbitrary expression about one column's value, or relating the
--     values of several columns, that must be true for every row after every modification

-- DEFAULT
--   provide a different default to the column apart from NULL
--     could be any expression, like calling functions, doesn't have to be constant/literal

-- UNIQUE
--   all the rows in this table must have unique values for that column.
--   can also put it on multiple columns taken together, like (City,State)

-- IDENTITY
--   prevents manually setting the column's value; auto-incrementing value
--   for each new row.

-- PRIMARY KEY
--   implies NOT NULL and UNIQUE
--   the column that will identify the row from the point of view of other rows.
--   adds a clustered index by default on the column
--     (the table will be stored in primary key order)

-- FOREIGN KEY
--   allow this column to reference another row, possibly in another table

DROP TABLE ChatApp.Person;

CREATE TABLE ChatApp.Person (
	Id INT NOT NULL IDENTITY,
	Username NVARCHAR(100) NOT NULL CHECK(LEN(Username) > 4) UNIQUE,
	AccountCreated DATETIME2 NULL
		CHECK(AccountCreated < SYSUTCDATETIME())
		DEFAULT (SYSUTCDATETIME()),
	CONSTRAINT PK_Id PRIMARY KEY (Id)
);

-- the database is the performance bottleneck
--    (because the database is hard to scale, the app code is easy to scale)

ALTER TABLE ChatApp.Person DROP CONSTRAINT CK__Person__AccountC__1F98B2C1;

INSERT INTO ChatApp.Person(Username) VALUES
	('fred123');

SELECT * FROM ChatApp.Person;

CREATE TABLE ChatApp.Message (
	Id INT NOT NULL IDENTITY,
	Contents NVARCHAR(1000) NOT NULL,
	SenderId INT NOT NULL,
	ReceiverId INT NOT NULL,
	CHECK (SenderId != ReceiverId)
);

ALTER TABLE ChatApp.Message ADD CHECK (SenderId != ReceiverId);

ALTER TABLE ChatApp.Message ADD CONSTRAINT
	FK_Message_Sender_Person FOREIGN KEY (SenderId) REFERENCES ChatApp.Person(Id);

ALTER TABLE ChatApp.Message ADD CONSTRAINT
	FK_Message_Receiver_Person FOREIGN KEY (ReceiverId) REFERENCES ChatApp.Person(Id);

INSERT INTO ChatApp.Person(Username) VALUES
	('nick456');

INSERT INTO ChatApp.Message(Contents, SenderId, ReceiverId) VALUES
	('hello',
		(SELECT Id FROM ChatApp.Person WHERE Username = 'fred123'),
		(SELECT Id FROM ChatApp.Person WHERE Username = 'nick456'));

SELECT * FROM ChatApp.Message;
SELECT * FROM ChatApp.Person;

-- multiplicity of a relationship between data/entities
--   1-to-1 (one-to-one)
		-- in SQL: put the data for both entities in the same table/row
		--      or, put it in a separate table, and have a UNIQUE FOREIGN KEY on one of them.

--   1-to-n (one-to-many)
		-- in SQL: two tables, with a FK on the "many" side.

--   n-to-n (many-to-many)
		-- in SQL: "sql doesn't support many-to-many relationship"
		--        we can simulate it with two 1-to-many relationships
		--    introduce a new table, give it two foreign keys to the two preexisting tables.
		--      we call this "join table" or "junction table"





-- FK can be created with ON DELETE and ON UPDATE behaviors
--   to control what happens when the referenced PK value changes/is deleted.

-- ON DELETE CASCADE
--   if the target of the FK is deleted, this row should also delete itself.
-- ON DELETE SET NULL
--                                       this column's value should turn itself NULL
-- ON UPDATE   "  "



-- public class Table
-- {
--     private List<string> rows = new List<string>();
--     private HashSet<string> valueIndex = new HashSet<string>();

--     public void Insert(string data)
--     {
--         rows.Add(data);
--         valueIndex.Add(data);
--     }

--     public bool FindValue(string value)
--     {
--         return valueIndex.Contains(value);
--     }
--     public bool FindSubstring(string value)
--     {
--         return rows.Any(s => s.Contains(value));
--     }
-- }

-- indexes
-- data structures that we can have sql server maintain during writes
-- so that reads can be faster.

-- in SQL Server:
   -- clustered index
        -- tells sql server what order to 'physically' arrange the table in.
		-- can only be one
		-- by default, PRIMARY KEY sets CLUSTERED INDEX.
   -- nonclustered index
		-- maintains a separate data structure analogous to an index at the end of
		-- and enyclopedia
		-- we can have many of these.
		-- UNIQUE sets nonclustered index by default

-- you want indexes on the columns/sets of columns that you usually reference
-- in the JOIN or WHERE conditions. (foreign keys are a good candidate)

--Dictionary<int, Data>
--Dictionary<string, List<Data>>