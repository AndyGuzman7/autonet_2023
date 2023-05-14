use BDDAUTONET;


USE BDDAUTONET;
SELECT TABLE_NAME
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE';


SELECT * FROM Person;
INSERT INTO Person(dni, names, Surname, secondSurname, birthDate, address, phone) 
VALUES(12345678, 'admin', 'admin', 'admin', Current_timestamp, 'Calle 1', 12345678)

SELECT * FROM Employee;
