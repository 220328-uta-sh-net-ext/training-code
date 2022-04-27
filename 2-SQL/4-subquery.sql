-- sometimes the most natural way to express a query
-- is with a condition based on another query

-- we have some operators for subqueries --
-- IN, NOT IN, EXISTS, ANY, ALL.

-- bit contrived example of ALL:
-- the artist who made the album with the longest title.
DECLARE @id INT;
SELECT TOP(1) @id = AlbumId FROM Album ORDER BY LEN(Title) DESC;
SELECT ar.*
FROM Artist as ar INNER JOIN Album as al ON ar.ArtistId = al.ArtistId
WHERE al.AlbumId = @id;

SELECT * FROM Artist WHERE ArtistId = (
    SELECT ArtistId FROM Album WHERE
        LEN(Title) >= ALL(SELECT LEN(Title) FROM Album)
);

-- every track that has never been purchased.

-- subquery version
SELECT *
FROM Track
WHERE TrackId NOT IN (
    SELECT TrackId FROM InvoiceLine
);

-- there is a syntax called "common table expression" (CTE)
-- it lets you run one query in advance, put it in a temporary variable,
-- and use it in the "main query"
WITH purchased_tracks AS (
    SELECT TrackId FROM InvoiceLine
)
SELECT * FROM Track WHERE TrackId NOT IN (
    SELECT * FROM purchased_tracks
);

-- join version
SELECT Track.*
FROM Track LEFT JOIN InvoiceLine ON Track.TrackId = InvoiceLine.TrackId
WHERE InvoiceLine.InvoiceLineId IS NULL;

-- you can't do "= NULL" in SQL, it will always be false
-- - we have IS NULL and IS NOT NULL

-- set operator version (but we only get the IDs)
SELECT TrackId FROM Track
EXCEPT
SELECT TrackId FROM InvoiceLine;

-------

-- exercises

-- solve these with a mixture of joins, subqueries, CTE, and set operators.
-- solve at least one of them in two different ways, and see if the execution
-- plan for them is the same, or different.

-- 1. which artists did not make any albums at all?
SELECT Artist.*
FROM Artist LEFT JOIN Album ON Artist.ArtistID = Album.ArtistID
WHERE Album.AlbumID IS NULL;

SELECT ArtistId FROM Artist
EXCEPT
SELECT ArtistId FROM Album;

SELECT ArtistId, Artist.Name
FROM Artist
WHERE ArtistId NOT IN (
    SELECT ArtistId FROM Album
);

-- 2. which artists did not record any tracks of the Latin genre?
SELECT *
FROM Artist
WHERE ArtistId NOT IN ( -- all the artists who wrote such an album
	SELECT ArtistId FROM Album WHERE AlbumId IN ( -- all the albums with a latin song
		SELECT AlbumId
		FROM Track           -- all the genres named latin
		WHERE GenreId IN (SELECT GenreId FROM Genre WHERE Name = 'Latin')
	)
);

-- join + set-op version
SELECT * FROM Artist
EXCEPT
SELECT ar.*
FROM Artist AS ar
	INNER JOIN Album AS al ON ar.ArtistId = al.ArtistId
	INNER JOIN Track AS t ON al.AlbumId = t.AlbumId
	INNER JOIN Genre AS g ON t.GenreId = g.GenreId
WHERE g.Name = 'Latin';

-- 3. which video track has the longest length? (use media type table)
SELECT * FROM Track WHERE Milliseconds = (
	SELECT MAX(t.Milliseconds)
	FROM Track AS t
		INNER JOIN MediaType AS mt ON mt.MediaTypeId = t.MediaTypeId
	WHERE mt.Name LIKE '%video%');

SELECT * FROM Track WHERE Milliseconds >= ALL (
	SELECT t.Milliseconds
	FROM Track AS t
		INNER JOIN MediaType AS mt ON mt.MediaTypeId = t.MediaTypeId
	WHERE mt.Name LIKE '%video%'); -- not exactly right

-- 4. find the names of the customers who live in the same city as the
--    boss employee (the one who reports to nobody)

-- 5. how many audio tracks were bought by German customers, and what was
--    the total price paid for them?
SELECT SUM(il.UnitPrice * il.Quantity) AS TotalPricePaid
FROM Track AS t
	INNER JOIN MediaType AS mt ON mt.MediaTypeId = t.MediaTypeId
	INNER JOIN InvoiceLine AS il ON il.TrackId = t.TrackId
	INNER JOIN Invoice AS i ON i.InvoiceId = il.InvoiceId
	INNER JOIN Customer AS c ON c.CustomerId = i.CustomerId
WHERE mt.Name LIKE '%audio%' AND c.Country = 'Germany'
GROUP BY t.TrackId;

SELECT SUM(il.UnitPrice * il.Quantity) AS TotalPricePaid
FROM Track AS t
	INNER JOIN MediaType AS mt ON mt.MediaTypeId = t.MediaTypeId
	INNER JOIN InvoiceLine AS il ON il.TrackId = t.TrackId
	INNER JOIN Invoice AS i ON i.InvoiceId = il.InvoiceId
	INNER JOIN Customer AS c ON c.CustomerId = i.CustomerId
WHERE mt.Name LIKE '%audio%' AND c.Country = 'Germany'
GROUP BY t.TrackId;

-- 6. list the names and countries of the customers supported by an employee
--    who was hired younger than 35.