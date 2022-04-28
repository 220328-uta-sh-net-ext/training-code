-- pretending that a pokemon can only have one type, so treating it as one-to-many relationship.
--DROP TABLE Type;
CREATE TABLE Type (
    Name NVARCHAR(50) NOT NULL PRIMARY KEY
);

-- SQL Server uses the primary key to order the data in the physical storage of the table
-- (that's why looking up a row by the PK is the fastest)

-- PRIMARY KEY implies NOT NULL and also UNIQUE
-- (FOREIGN KEY does not imply either of those necessarily)

-- a PRIMARY KEY could be two columns at once, instead of one column.
-- e.g. (City, State) together, in a table about cities in the US.

SELECT * FROM Pokemon;

CREATE TABLE City
(
    Name NVARCHAR(50) NOT NULL,
    State CHAR(2) NOT NULL,
    PRIMARY KEY (Name, State) -- composite key example
);

-- for various reasons, it's often a good idea
-- to introduce a new unique ID for each row
-- that doesn't have any business meaning.
--   could be... autoincrement integer,
--               GUID (random string),
--               fanncy things like hi-lo sequence
-- IDENTITY is a constraint that makes that column
--    (1) disallow inserting values manually
--    (2) automatically increment values to the next highest number

-- values default to NULL in SQL
-- if you dont want that...
--   put "NOT NULL" on the column

--DROP TABLE Pokemon;
CREATE TABLE Pokemon (
    -- Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(50) NOT NULL PRIMARY KEY,
    Type NVARCHAR(50) NOT NULL FOREIGN KEY REFERENCES Type (Name),
    Level INT NOT NULL,
    Attack INT NOT NULL,
    Defense INT NOT NULL,
    Health INT NOT NULL,
    INDEX IX_Type NONCLUSTERED ON Type
);

-- if the Type FK had ON DELETE CASCADE, then...
--   if i delete Lightning type, automatically, all LIghtning pokemon will also be deleted

-- Posts
-- Comments
--     FK -> PostId

-- "referential integrity": SQL enforces that every FK value does point to an existing PK value

-- don't want to keep ability information in
-- the pokemon row, too clumsy, violates first normal form

-- like in visual studio,
-- Ctrl+K, Ctrl+C to comment
-- Ctrl+K, Ctrl+U to uncomment

CREATE TABLE Ability (
    Name NVARCHAR(100) PRIMARY KEY,
    PP INT,
    Power INT,
    Accuracy INT
);

-- junction table
CREATE TABLE PokemonAbility (
    Pokemon NVARCHAR(50) FOREIGN KEY REFERENCES Pokemon (Name),
    Ability NVARCHAR(100) FOREIGN KEY REFERENCES Ability (Name),
    PRIMARY KEY (Pokemon, Ability)
);

SELECT * FROM Pokemon WHERE Type = 'Normal';

--ALTER TABLE Pokemon ADD PRIMARY KEY (Name);
CREATE INDEX IX_Pokemon_Type ON Pokemon (Type);

INSERT INTO Type (Name) VALUES
    ('Normal'),
    ('Electric'),
    ('Fire');

-- uh oh, pokemon can have multiple types, what do?
--  1. can we just say "electric/poison"?
--      this probably violates first normal form.
--      it would be hard to run a query like "get all electric type pokemon" if this was your design.
--  2. can we do "type1" "type2" separate columns?
--      this probably violates first normal form.
--      it would still be hard to run a query like "get all electric type pokemon" if this was your design.
--  3. the better answer is generally: model it as a many to many relationship.
--       (to enforce max 2 types... either rely on .NET code for that, or, use a TRIGGER on INSERT to check.)


-- how do you store addresses in a db?
--  break it up into street, city, state, etc?
--    advantage: query by city
--    disadvantage: hard to represent all possible address forms, international etc
-- keep it as one string!
--    this is less normalized but that's ok sometimes
--     especially if we never need to break up that value and query on part of it.

INSERT INTO Pokemon (Name, Type, Level, Attack, Defense, Health) VALUES
    ('Ditto', 'Normal', 1, 50, 51, 52),
    ('Pikachu', 'Electric', 4, 40, 45, 50),
    ('Charmandar', 'Fire', 2, 55, 55, 55),
    ('Snorlax', 'Normal', 15, 55, 55, 55);

-- in SQL, unless you specify an ORDER BY clause on our SELECT statement
--   technically the order of results is undefined, could be anything.
--  in practice, it will usually be based on the PK order.
SELECT * FROM Pokemon;
SELECT * FROM Ability;
SELECT * FROM PokemonAbility;

INSERT INTO Ability (Name, PP, Power, Accuracy) VALUES
    ('Tackle', 40, 40, 80),
    ('ThunderBolt', 15, 90, 100);


INSERT INTO PokemonAbility (Pokemon, Ability) VALUES
    ('Ditto', 'Tackle'),
    ('Pikachu', 'ThunderBolt'),
    ('Charmandar', 'Tackle'),
    ('Snorlax', 'Tackle');

-- all pokemon with the tackle ability
-- (using a join)
SELECT p.*
FROM Pokemon AS p
    INNER JOIN PokemonAbility AS pa ON pa.Pokemon = p.Name
WHERE pa.Ability = 'Tackle';

-- common problem:
-- your .net object model has a ton of references between different things.
--  for example, in .the .net code, every pokemon is assumed to have its list of abilites present.