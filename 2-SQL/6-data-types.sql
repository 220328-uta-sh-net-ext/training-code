-- CREATE TABLE Test (
--     Id INT PRIMARY KEY IDENTITY,
--     Data CHAR(3)
-- );

-- INSERT INTO Test (Data) VALUES
--     ('a'), ('ab'), ('abc');

-- SELECT *, LEN(Data) FROM Test;

-- numeric types
    -- whole number
        -- TINYINT (1-byte)
        -- SMALLINT (2-byte)
        -- INT (4-byte) - use unless having good reason
        -- BIGINT (8-byte)
    -- floating-point numbers
        -- FLOAT, REAL
        -- DECIMAL(n,p) aka NUMERIC(n,p)
            -- "n" is the number of digits
            -- "p" is the number of digits after the decimal point
            -- e.g. NUMERIC(10,2) would store numbers like 12345678.99
    -- currency
        -- MONEY, SMALLMONEY
        --  high precision, display with a $ (or something else depending
            -- on collation)
-- boolean
    -- BIT (0 or 1)
-- string/text types
    -- CHAR(n)     fixed-length non-Unicode string
    -- VARCHAR(n)  variable length up to n, non-Unicode string
    -- NCHAR(n)    fixed-length, Unicode string
    -- NVARCHAR(MAX) variable-length Unicode string - use unless with good reason
    -- we've got a variety of functions for strings e.g. LEN, SUBSTRING,
        -- CHARINDEX, REPLACE, LOWER, UPPER
    -- (indexing in SQL is 1-based, not 0-based)
-- date/time
    -- DATE for dates
    -- TIME(s) for times
    -- DATETIME - stores both date and time
    --    can't store a very wide range of dates
    -- DATETIME2(p) - store date and time with wide range, variable precision
    -- DATETIMEOFFSET - like DATETIME2 but with time zone awareness (good)
     -- can extract parts of the dates/times using functions like YEAR(),
     -- DATEPART(YEAR FROM '2019-01-01') or DATEPART(YEAR, '2019-01-01')

SELECT CONVERT(NVARCHAR, 1234);
-- type conversion with CONVERT
-- "string literals" like 'asdf' are VARCHAR
-- "string literals" like N'asdf' are NVARCHAR

-- NULL handling - = NULL doesn't work, use IS NULL
-- COALESCE function: provide replacement value in case of NULL
-- all rock songs, showing the name in the format 'ArtistName - SongName'
SELECT COALESCE(ar.Name, 'n/a') + ' - ' + t.Name AS Song
FROM Track AS t
	INNER JOIN Genre ON Genre.GenreId = t.GenreId
	LEFT JOIN Album AS al ON t.AlbumId = al.AlbumId
	LEFT JOIN Artist AS ar ON al.ArtistId = ar.ArtistId
WHERE Genre.Name = 'Rock';

-- collation
   -- database-wide settings for things like:
   -- - what encoding to use for non-Unicode strings
   -- - what currency symbol
   -- - what decimal point (,/.)
   -- - what default date format
   -- - whether (& how) strings compare (with case sensitivity, or not)