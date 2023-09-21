USE [GadgetApp]
AS

CREATE DATABASE Store
CREATE TABLE Store(
Name VARCHAR(50) NOT NULL,
Id INT NOT NULL,
Address NVARCHAR(70) NOT NULL,
City NVARCHAR(70) NOT NULL
)

INSERT INTO Store VALUES ('Tikvesko',143,'14','Skopje')

CREATE TABLE Article(
Id INT NOT NULL AUTO_INCREMENT,
Price INT NOT NULL,
Name VARCHAR(50) NOT NULL,
Subspecies NVARCHAR(60) NOT NULL
)

INSERT INTO Article VALUES (1143,5300,'Milk','G')

CREATE TABLE Receipts(SerialID INT NOT NULL)

INSERT INTO Receipts VALUES (115326)

CREATE TABLE Sales(
Id INT NOT NULL AUTO_INCREMENT,
SalesId INT NOT NULL,
ArticleID INT NOT NULL,
StoreID INT NOT NULL,
Date DATETIME NOT NULL,
Amount INT NOT NULL,
CashierID INT NOT NULL
)

INSERT INTO Sales VALUES (11534,4326,45267,134065
,'2022/12/14',30,1145)

SELECT *
FROM Article
UPDATE SET Name = 'Still'
WHERE Name = 'Milk'

SELECT *
FROM Article
UPDATE SET Id = 1142
WHERE Id = 1143

SELECT *
FROM Article
WHERE Price > 5000

SELECT *
FROM Article
UPDATE SET Subspecies = 'K'
WHERE Subspecies = 'G'

INNER JOIN Store ON Store.Name == Subspecies.Name
AND Store.Id == Subspecies.Address

CREATE INDEX Equals
ON Store(Name) AND Article(Price)

SELECT *
FROM Store
UPDATE SET Name = '%o'
WHERE Name = 'i%'

SELECT *
FROM Store
UPDATE SET Address = '14'
WHERE Address = '11'

SELECT *
FROM Store
UPDATE SET City = 'Skopje'
WHERE City = 'Gevgelija'

Store = ['Ohritel','Ohraevo','Ohudovo']
Article = 'Milk'

SELECT COUNT(SUM) OF Store WHERE Store = 'OHR%'
AND AVG(Article) > 5000 
IN 2014
GROUP BY Store DESC