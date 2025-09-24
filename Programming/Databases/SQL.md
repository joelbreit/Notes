# SQL

SQL is a language used to interact with databases. It is used to create, read, update, and delete data in a database.

## Command Categories

1. **Data Definition Language (DDL)**: Commands that define the structure of a database, including creating, altering, and dropping tables.
2. **Data Manipulation Language (DML)**: Commands that manipulate data in a database, including inserting, updating, and deleting records.
3. **Data Query Language (DQL)**: Commands that retrieve data from a database, including selecting, filtering, and sorting records.
4. **Data Control Language (DCL)**: Commands that control access to data in a database, including granting and revoking permissions.
5. **Transaction Control Language (TCL)**: Commands that manage transactions in a database, including committing and rolling back changes.

## Data Definition Language (DDL)

These commands are used to define or modify the structure of the database and its objects, such as tables, indexes, and views.

1. **CREATE**: command for adding new database objects, like tables or indexes
   1. CREATE **TABLE**
   2. CREATE **INDEX**
   3. CREATE **VIEW**
   4. CREATE **SEQUENCE**
   5. CREATE **SYNONYM**
   6. CREATE **SCHEMA**
   7. CREATE **DOMAIN**
2. **ALTER**: command for modifying an existing database object, like adding or dropping a column in a table
3. **DROP**: command for removing existing database objects
4. **TRUNCATE**: command for removing all records from a table while maintaining the table structure

## Data Manipulation Language (DML)

These commands are used to manipulate data in the database, such as inserting, updating, and deleting records.

1. **INSERT**: command for adding new records to a table
2. **UPDATE**: command for modifying existing records in a table
3. **DELETE**: command for removing records from a table
4. **MERGE**: command for performing an insert, update, or delete operation based on a condition

## Data Query Language (DQL)

These commands are used to retrieve data from the database.

1. **SELECT**: command for retrieving data from one or more tables

## Data Control Language (DCL)

These commands are used to control access to data in the database.

1. **GRANT**: command for giving users access privileges to database objects
2. **REVOKE**: command for taking away access privileges from users

## Transaction Control Language (TCL)

These commands are used to manage transactions in the database.

1. **COMMIT**: command for saving changes made during a transaction
2. **ROLLBACK**: command for undoing changes made during a transaction
3. **SAVEPOINT**: command for setting a point in a transaction to which you can later roll back
4. **SET TRANSACTION**: command for setting properties for a transaction

## Clauses

1. **WHERE**: clause for filtering rows in a result set
2. **ORDER BY**: clause for sorting rows in a result set
3. **GROUP BY**: clause for grouping rows in a result set
4. **HAVING**: clause for filtering groups in a result set
5. **LIMIT**: clause for limiting the number of rows in a result set
6. **OFFSET**: clause for skipping a specified number of rows in a result set
7. **JOIN**: clause for combining rows from two or more tables based on a related column between them
8. **ON**: clause for specifying the join condition in a JOIN clause
9. **AS**: clause for aliasing a column or table in a query
10. **DISTINCT**: clause for returning only distinct values in a result set
11. **LIKE**: clause for matching a pattern in a column
12. 

## Aggregate Functions

These functions are used to perform calculations on a set of values and return a single value.

1. **COUNT**: function for enumerating the number of non-null values in a result set
2. **SUM**: function for calculating the sum of a set of values
3. **AVG**: function for calculating the average of a set of values
4. **MIN**: function for finding the minimum value in a set of values
5. **MAX**: function for finding the maximum value in a set of values

## Rarer SQL Commands

1. **SELECT TOP**: command for getting a limited number of rows from a result set
2. **HAVING**: clause for filtering groups in a result set

## WHERE Clause Operators

1. **=**: equal to
2. **<>**: not equal to
3. **<**: less than
4. **>**: greater than
5. **<=**: less than or equal to
6. **>=**: greater than or equal to
7. **BETWEEN**: between a range of values
8. **LIKE**: matches a pattern
9. **IN**: matches any value in a list
10. **IS NULL**: checks for null values
11. **AND**: combines multiple conditions
12. **OR**: matches any condition
13. **NOT**: negates a condition
14. **EXISTS**: checks for the existence of rows in a subquery

## JOIN Types

1. **INNER JOIN**: SQL clause that returns rows from 2 tables where their related columns matche
2. **LEFT JOIN**: SQL clause that returns all rows from the first table and the matched rows from the second table (or null values if no match)
3. **RIGHT JOIN**: SQL clause that returns all rows from the second table and the matched rows from the first table (or null values if no match)
4. **FULL [OUTER] JOIN**: SQL clause that returns all rows from both tables and null values where one is missing a match

## Options

1. **all CREATE options**: DATABASE, TABLE, VIEW, INDEX, USER, TRIGGER, PROCEDURE, FUNCTION, EVENT, TABLESPACE, LOGFILE, SERVER, 

## Example SQL Commands

1. **create a table based on the structure of another table**: `CREATE TABLE new_table LIKE existing_table;`
2. **creates a table that exists only for the duration of the session**: `CREATE TEMPORARY TABLE table_name (column1 datatype, column2 datatype, ...);`
3. **fetch all data from a table**: `SELECT * FROM table_name;`
4. **fetch id and name columns from the city table**: `SELECT id, name FROM city;`
5. **fetch city names sorted by the rating column in ascending order**: `SELECT name FROM city ORDER BY rating [ASC];`
6. **fetch city names sorted by the rating column in descending order**: `SELECT name FROM city ORDER BY rating DESC;`
7. **fetch a column with an alias in the result set**: `SELECT name AS city_name FROM city;`
8. **get names from city and country tables using table aliases**: `SELECT ci.name, co.name FROM city [AS] ci JOIN country [AS] co ON c.country_id = co.id;`
9. **fetch names of cities that have a rating above 3**: `SELECT name FROM city WHERE rating > 3;`
10. **fetch names of cities that are neither Berlin nor Madrid**: `SELECT name FROM city WHERE name != 'Berlin' AND name <> 'Madrid';`
11. **fetch names of cities that start with a 'P' or end with an 's'**: `SELECT name FROM city WHERE name LIKE 'P%' OR name LIKE '%s';`
12. **fetch names of cities that start with any letter followed by 'ublin'**: `SELECT name FROM city WHERE name LIKE '_ublin';`
13. **fetch names of cities that have a population between 500K and 5M**: `SELECT name FROM city WHERE population BETWEEN 500000 AND 5000000;`
14. **fetch names of cities that don't miss a rating value**: `SELECT name FROM city WHERE rating IS NOT NULL;`
15. **fetch names of cities that are in countries with IDs 1, 4, 7, or 8**: `SELECT name FROM city WHERE country_id IN (1, 4, 7, 8);`
16. **return rows that have matching values in both tables**: `SELECT * FROM table1 [INNER] JOIN table2 ON table1.column_name = table2.column_name;`
17. **return all rows from the first table with corresponding rows from the second with nulls where the second has no match**: `SELECT * FROM table1 LEFT JOIN table2 ON table1.column_name = table2.column_name;`
18. **return all rows from the second table with corresponding rows from the first with nulls where the first has no match**: `SELECT * FROM table1 RIGHT JOIN table2 ON table1.column_name = table2.column_name;`
19. **return all rows from both tables with nulls where there is no match in one of the tables**: `SELECT * FROM table1 FULL [OUTER] JOIN table2 ON table1.column_name = table2.column_name;`
20. **return all possible combinations of rows from both tables**: `SELECT * FROM table1 [CROSS JOIN] table2;`
21. **find out number of cities**: `SELECT COUNT(*) FROM city;`
22. **find out the number of cities with non-null ratings**: `SELECT COUNT(rating) FROM city;`
23. **find out the number of distinctive country values**: `SELECT COUNT(DISTINCT country_id) FROM city;`
24. **find out the smallest and the greatest country populations**: `SELECT MIN(population), MAX(population) FROM city;`
25. **find out the total population of cities in respective countries**: `SELECT country_id, SUM(population) FROM city GROUP BY country_id;`
26. **find out the average rating for cities in respective countries if the average is above 3.0**: `SELECT country_id, AVG(rating) FROM city GROUP BY country_id HAVING AVG(rating) > 3.0;`
27. **find cities with the same rating as Paris**: `SELECT name FROM city WHERE rating = (SELECT rating FROM city WHERE name = 'Paris');`
28. **find cities in countries that have a population above 20M**: `SELECT name FROM city WHERE country_id IN (SELECT id FROM country WHERE population > 20000000);`
29. **find cities with a population greater than the average population in the country**: `SELECT name FROM city [AS] main_city WHERE population > (SELECT AVG(population) FROM city [AS] average_city WHERE main_city.country_id = average_city.country_id);`
30. **find countries that have at least one city**: `SELECT name FROM country WHERE EXISTS (SELECT * FROM city WHERE country_id = country.id);`
31. **return admin emails together with user emails removing duplicates**: `SELECT email FROM admin UNION SELECT email FROM user;`
32. **return admin emails together with user emails including duplicates**: `SELECT email FROM admin UNION ALL SELECT email FROM user;`
33. **return admin emails that are not in the user table**: `SELECT email FROM admin EXCEPT SELECT email FROM user;`
34. **return admin emails that are also in the user table**: `SELECT email FROM admin INTERSECT SELECT email FROM user;`


## Data Types

1. **INT**: integer data type
2. **VARCHAR**: variable-length character string
3. **DATE**: date data type
4. **FLOAT**: floating-point number data type
5. **CHAR**: fixed-length character string
6. **TEXT**: text data type
7. **BLOB**: binary large object data type
8. **BOOLEAN**: boolean data type
9. **DECIMAL**: decimal number data type
10. **ENUM**: enumeration data type
11. **SET**: set data type
12. **TIME**: time data type
13. **TIMESTAMP**: timestamp data type
14. **YEAR**: year data type
15. **JSON**: JSON data type

## SQL Terms

1. **result set**: group of rows returned by a query
2. **index**: feature for improving the speed of data retrieval operations created on columns that are often searched
3.  **subquery**: query nested inside another query that can be used in `SELECT`, `FROM`, `WHERE`, or `JOIN` clauses
4.  **aggregate function**: operators that work on multiple values to produce a single result
5.  **transaction**: set of SQL statements that are executed as a unit which ensures that all operations are completed successfully, or none are applied
6.  **VIEW**: a virtual table created by a query. It does not store the data itself but acts as a saved query for convenience.
7.  **schema**: The structure of a database, defined by tables, relationships, indexes, etc.
8.  **common table expressions**: temporary result sets that can be referenced within a SELECT, INSERT, UPDATE, or DELETE statement
9.  **field**: vertical entity in a table that contains data of a specific type
10. **record/entry**: horizontal entity in a table that contains data for a single data item
11. **correlated subquery**: a subquery that references a column from the outer query
12. **set operations**: functions that combine the result sets of two or more SELECT statements with similar structures (UNION, UNION ALL, INTERSECT, EXCEPT)
13. **alias**: a temporary name assigned to a table or column for the duration of a query
14. **aggregate functions**: SQL operations used on a set of values to return a single value including SUM, AVG, COUNT, MIN, MAX
15. **Constraint**: A rule applied to table columns to enforce data integrity. Common constraints include `NOT NULL`, `UNIQUE`, `PRIMARY KEY`, and `FOREIGN KEY`.
16. **Trigger**: A stored procedure that automatically executes when a specified event occurs in the database, such as an `INSERT`, `UPDATE`, or `DELETE`.
17. **projection**: *selecting specific columns from a table in a query*

These are some foundational terms to help understand SQL's structure and concepts better.

- [ ] Indexes, views, object, causes, triggers, sequences, synonyms, schemas, domains, and users
- [ ] ANY, ALL, SOME, EXISTS, and UNIQUE
- [ ] ASC DESC, NULLS FIRST, NULLS LAST
- [ ] What are all the operators
- [x] ACID properties
- [x] Views
- [ ] CREATE ALGORITHM
- [ ] CREATE SEQUNCE
- [ ] CREATE RESOURCE GROUP
- [ ] CREATE FULLTEXT INDEX
- [ ] All ALTER contexts
- [ ] All NOT NULL contexts