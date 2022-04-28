-- some other objects SQL Server supports

-- we can introduce some abstraction to allow for a more convenient
--    interface into the data without violating normalization:
--    computed columns, views

-- we can have "computed columns"
-- the value is computed when read, not stored

-- with option PERSISTED
-- the value IS stored, but lazily
-- value is not recomputed until it needs to be

-- if i want the first letter of the pokemon types
ALTER TABLE Type ADD
    FirstLetter AS (SUBSTRING(Name, 1, 1)) PERSISTED;

-- public class PokemonType
-- {
--     public string Name { get; }
--     public string FirstLetter { get { return Name[0]; } }
--     public PokemonType (string name) { Name = name; }
-- }

SELECT * FROM Type;

UPDATE Type SET Name = 'Fire';

-- similar in spirit to computed columns, we have
-- computed tables, "views"

-- deleting can be problematic
--   sometimes instead of deleting, we have an Active BIT column

ALTER TABLE Pokemon ADD
    Active BIT NOT NULL DEFAULT 1;

GO
CREATE VIEW ActivePokemon AS
    SELECT * FROM Pokemon WHERE Active = 1;
GO

-- you can use views as tables is most contexts,
-- including some updates, inserts, deletes


UPDATE ActivePokemon SET Active = 0
WHERE Name = 'Snorlax';
GO

SELECT * FROM Pokemon;
SELECT * FROM ActivePokemon;

-- with schemabinding, you would get an error if you
-- tried to drop the referenced table or any of the referenced columns in that table

GO
CREATE VIEW WeirdView WITH SCHEMABINDING AS
    SELECT Name + '!' AS Name
    FROM dbo.Pokemon;
GO

-- DROP VIEW Poke.WeirdView;
-- DROP TABLE Poke.Pokemon;

-- WITH SCHEMABINDING sets up a "hard" reference from the view
-- to the table, such that the view prevents any changes
-- to that table that would break the view's query

SELECT * FROM Poke.WeirdView;
DELETE FROM Poke.WeirdView WHERE PokemonId = 2000;
UPDATE Poke.WeirdView SET Name = 'Charmander';

------------------
-- another view example with Chinook db
GO
CREATE VIEW TrackWithGenre AS (
	SELECT t.*, g.Name AS GenreName
	FROM Track AS t LEFT JOIN Genre AS g
		ON t.GenreId = g.GenreId
);
GO

SELECT * FROM TrackWithGenre;
----------------

-- sometimes we want to store intermediate values,
-- split queries into several parts
-- SQL Server supports scalar variables and table-valued variables
-- they only exist for the duration of that "batch" of commands

DECLARE @maxid INT;
SELECT @maxid = MAX(Id) FROM School.Course;
--SET @maxid = (SELECT MAX(Id) FROM School.Course); -- another way to set variable
INSERT INTO School.Course (Id, CourseNumber) VALUES (@maxid + 1, 'CS104');

--table-valued variables
DECLARE @mytable AS TABLE (
    Id INT,
    Name NVARCHAR(20)
);
INSERT INTO @mytable
    SELECT Id, CourseNumber FROM School.Course;

DECLARE @a FLOAT = (SELECT AVG(CAST(CustomerId AS FLOAT)) FROM Customer);
SELECT @a;
SELECT AVG(Total) FROM Invoice;
-- UPDATE SecondTable SET AVGValue = @i WHERE Id = 1

-- DECLARE @i INT = 0;
-- WHILE (@i < 5) BEGIN
--     SET @i = @i + 1;
--     SELECT @i;
-- END

-- user-defined functions in SQL Server

-- functions cannot modify the database in any way
-- pretty much just SELECT
GO
CREATE FUNCTION TotalNumberOfPokemon()
RETURNS INT
AS
BEGIN
    DECLARE @result INT;

    SELECT @result = COUNT(*) FROM Pokemon;

    RETURN @result;
END
GO

SELECT dbo.TotalNumberOfPokemon();

-- that was a scalar function (it returns a single value)

-- table-valued functions:
GO
CREATE FUNCTION PokemonWithNameOfLength(@length INT)
RETURNS TABLE
AS
    RETURN (
        SELECT * FROM Pokemon WHERE LEN(Name) = @length
    );
GO

SELECT * FROM PokemonWithNameOfLength(7);

-- functions cannot make any changes to the database at all
-- they have "read-only" access.

-- write a function that returns the initials of a customer based on his ID.
GO
CREATE FUNCTION CustomerInitials(@id INT)
RETURNS NCHAR(2)
AS
BEGIN
    RETURN (
        SELECT SUBSTRING(FirstName, 1, 1) + SUBSTRING(LastName, 1, 1)
        FROM Customer WHERE CustomerId = @id
    );
END
GO
-- all customers with the same initials as customer 20
SELECT * FROM Customer WHERE dbo.CustomerInitials(CustomerId) = dbo.CustomerInitials(20);
-- FUNCTIONs support WITH SCHEMABINDING

-- (stored) procedures are like functions, except you can
-- modify the DB, and you can't run them except with the EXECUTE statement.
-- also, they don't have return values, but they do have "out parameters"

-- procedure to update all the datemodified values to the current time
-- return the number of rows modified
GO
CREATE OR ALTER PROCEDURE School.UpdateAllDateModified(@param INT, @rowschanged INT OUTPUT)
AS
BEGIN
    BEGIN TRY
		IF (NOT EXISTS (SELECT * FROM School.Course))
		BEGIN
			RAISERROR ('No data found in table', 15, 1);
		END
		SET @rowschanged = (SELECT COUNT(*) FROM School.Course);
		UPDATE School.Course SET DateModified = SYSUTCDATETIME();
    END TRY
    BEGIN CATCH
        PRINT 'Error'
    END CATCH
END
GO

DECLARE @result INT;
EXECUTE School.UpdateAllDateModified 123, @result OUTPUT;
SELECT @result;

-- triggers
-- some code that will run instead of or after
-- you insert, update, or delete to a particular table.

-- idea from mark next time i teach this
--   updates/inserts/deletes to a table require approval
--   so trigger replaces them with inserts to the pending approvals table
--   then the admin can come in and update Approved = 1, which
--   a trigger transforms into applying the original operation
--   to the first table.
-- (hi associates)

-- a trigger that automatically maintains the DateModified column
-- for updates
GO
CREATE TRIGGER School.CourseDateModified ON School.Course
AFTER UPDATE
AS
BEGIN
    -- in a trigger, you have access to two special table-valued variables
    -- called Inserted and Deleted.
    UPDATE School.Course
	SET DateModified = SYSUTCDATETIME()
    WHERE Id IN (SELECT Id FROM Inserted);
    -- recursion in triggers is off by default
END

UPDATE School.Course SET CourseNumber = 'CS105' WHERE CourseNumber = 'CS104';

-- trigger that prevents deleting rows (on a Chinook table)
-- or maybe, replaces deleting rows with modifying the Active column
GO
CREATE TRIGGER PreventPokemonDeletes ON Pokemon
INSTEAD OF DELETE
AS
BEGIN
    -- RAISERROR('Deletes not allowed', 15, 1)
    UPDATE Pokemon SET Active = 0
    WHERE Name IN (SELECT Name FROM Deleted);
END

SELECT * FROM Pokemon;
DELETE FROM Pokemon WHERE Name = 'Pikachu';