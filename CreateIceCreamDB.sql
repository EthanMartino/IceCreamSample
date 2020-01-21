DROP DATABASE IF EXISTS IceCream
GO

CREATE DATABASE IceCream
GO

USE IceCream
GO

CREATE TABLE IceCream
(
	IceCreamId		int				PRIMARY	KEY	IDENTITY
	, Flavor		varchar(20)		NOT NULL
	, Scoops		int				NOT NULL
	, Container		varchar(5)		NOT NULL
)