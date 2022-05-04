# Introduction to SQL
* Structured Query Language
* Just a language made to be really good at storing and querying (grabbing data) information from a database
* Now it isn't really a programming language (I know confusing) since it lacks basic tools that a normal programming language has
    * Control flow statements? HA non-existent
    * To re-cap, control flow statements are the for loops and if statements
* It is just a query langauge because it is a language made to get data
* However, down the line, people didn't like this so they created multiple versions of SQL that acts like a proper programming language 
    * Ex: Pl/pgSQL, T-SQL, PL-SQL, etc. (<- you don't need to know the different type of SQL except for T-SQL)
## Database
* It is just an organized collection of data stored in some format
* They allow us to input, manage, organize, and retrieve data quickly
* With most databases, they are organized into tables and each table will have a row and a column
    * Think of a Microsoft Excel sheet
    * Data is the actual intersection between a row and column 
## Relational Database Management System (RDBMS)
* A more advance form of a database with an even fancier name.
* So instead of just storing data like a database, it gives "relationships" between data
    * Look at Multiplicity section to showcase "relationship" between data

## SQL Sublanguages
* Essentially, people decided to organized what each statement (They decided to call it statements instead of functions so... start thinking they are the same thing) does in our RDBMS
## Data Definition Langauge (DDL)
* It is used for the creation/alteration of tables, 
* CREATE - most commonly used to create tables
* ALTER - used to alter/modify existing tables
* TRUNCATE - removes all data in a table, **cannot rollback the changes**
* DROP - removes the table structure from the database
## Data Manipulation Langauge (DML)
* It is for changing/manipulating/modifying the data within a table
* INSERT - Adds data(rows) to your table
* SELECT - Retrieves the data from a table for us to read
* UPDATE - Modify/updates the data from a table
    - You can use the where clause to select/filter the data in a table
* DELETE - Deletes a row from a table
    - You can use the where clause to select/filter which data to remove

# Constraints
* They are a way for us to limit the data that will come into your table (hence the name "constraints")
* It will specify either one or more rules that the data you are inputting in that column must follow
## some commonly used constraints
1. Type - Restricts what datatype you can store in a column
2. Unique - Every data in a column cannot have repeating values
3. Not null - Ensures every data in a column must have a value
4. Check - Adds an extra condition on the data
    * Ex: age column must be above 18
```SQL
CREATE TABLE Person (
    Age int CHECK (Age >= 18)
)
```
5. Primary Key
    * Implicitly Unique and Not null
    * Acts as the unique identifier for the rows in a table
6. Foreign Key
    * Data in this column references the primary key of another table
    * Establishes relationships between 2 columns in the same table or different tables

# Multiplicity
* It is a way to describe the relationships between 2 tables
* We will use the primary and foreign keys to established these relationships
## Three main categories of relationships
* One to One
    * When one row in Table A is directly related to one row in Table B and vice versa
    * You must use the unique constraint in the foreign key to ensure that only one row in Table B will be related to one row in Table A
    * Ex: One person can only have one heart
* One to Many
    * When one row in Table A is related to multiple rows in Table B
    * Ex: One person has many fingers but only one finger is related to one person (you cannot share fingers!)
* Many to Many
    * Many rows in Table A is related to many rows in Table B
    * You must construct a join table to achieve many to many relationship
        * Join tables must at least consists of two columns that are both foreign keys that either points to Table A and Table B
        * Essentially, one column references Table A and one column references Table B
    * Ex: A pokemon can have many abilities and An ability can have many pokemon
        * Basically Tackle can exist to many pokemons and can share it and pokemon can have many abilities beyond just tackle

# [Normalization](https://www.guru99.com/database-normalization.html)
* It is a design pattern that reduces/eliminates
    - Data redundancy
    - Insert, Update, Delete anamolies.
- Normalization rules divides larger tables into smaller tables and links them using relationships. 
* Ensures that every data we put in our database won't be repeating to save valuable memory space
* Must always ensure Referential Integrity Atomic data
    * Referential Integerity - a foreign key will always point to a primary key **(it is entirely possible for a foreign key column to also point to a null value but that isn't good practice)**
    * Atomic data - every data you store must be at its smallest form
* Here is a list of Normal Forms
    1. 1NF (First Normal Form)
    2. 2NF (Second Normal Form)
    3. 3NF (Third Normal Form)
    4. BCNF (Boyce-Codd Normal Form)
    5. 4NF (Fourth Normal Form)
    6. 5NF (Fifth Normal Form)
    7. 6NF (Sixth Normal Form)
## 0NF - Zero Normal Form
* No normalization is applied
## 1NF - First Normal Form
* Every table must have a primary key
* The Fancy way of saying is that every table structure must have an identifiable row
* All data must be atomic
## 2NF - Second Normal Form
* Table needs to be in 1NF
* Removes any partial dependencies
    * Easier way of thinking about it is just avoid composite primary keys and by default, you are in 2NF
    * Fancy way is that every column defined in a table must be dependent on both composite primary keys
## 3NF - Third Normal Form
* Table needs to be in 2NF
* Remove transitive dependencies
    * Ensure that every column in a table is related to the primary key
    * Ex: customerId should have columns that is related to customer, adding managerName or storeName as a column will break 3NF
    * Just put it on a different table instead if you see unrelated data together so it should be Customer Table, Manager Table, and Store Table