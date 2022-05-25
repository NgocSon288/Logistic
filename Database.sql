CREATE DATABASE Logistic_Db
GO

USE Logistic_Db
GO

CREATE TABLE ItemType
(
	Id INT NOT NULL PRIMARY KEY,
	Name VARCHAR(255)
)
GO

CREATE TABLE Item
(
	Id INT NOT NULL PRIMARY KEY,
	Name VARCHAR(255),
	SafetyStock INT,
	Inventory INT,
	LeadTime INT,
	LotSize INT,
	ItemTypeId INT,
	FOREIGN KEY (ItemTypeId) REFERENCES ItemType(Id)
)
GO

CREATE TABLE ItemRelationship
(
	Id INT NOT NULL PRIMARY KEY, 
	ParentId INT NOT NULL,
	ChildId INT NOT NULL,
	Value INT,
	FOREIGN KEY (ParentId) REFERENCES Item(Id),
	FOREIGN KEY (ChildId) REFERENCES Item(Id)
)
GO
 
CREATE TABLE Orders
(
	Id INT NOT NULL PRIMARY KEY,
	Week INT,
	Year INT,
	Quantity INT,
	ItemId INT,
	FOREIGN KEY (ItemId) REFERENCES Item(Id)
)
GO

INSERT INTO ItemType VALUES (1, 'Finish Product');
INSERT INTO ItemType VALUES (2, 'Assembly');
INSERT INTO ItemType VALUES (3, 'Material');
GO

-- Insert Item							Safety	Invent	Lead	LotSize	
INSERT INTO Item VALUES (1,		'F1',	0,		2,		1,		0,		1)
INSERT INTO Item VALUES (2,		'F2',	0,		0,		1,		0,		1)
INSERT INTO Item VALUES (3,		'F3',	0,		1,		1,		0,		1)
INSERT INTO Item VALUES (4,		'F4',	0,		0,		1,		0,		1)
INSERT INTO Item VALUES (5,		'F5',	0,		0,		1,		0,		1)
GO

-- Insert W
INSERT INTO Item VALUES (6,		'WA',	0,		0,		1,		0,		2)
INSERT INTO Item VALUES (7,		'WB',	0,		2,		1,		0,		2)
INSERT INTO Item VALUES (8,		'WC',	0,		0,		1,		0,		2)
INSERT INTO Item VALUES (9,		'WD',	0,		1,		1,		0,		2)
INSERT INTO Item VALUES (10,	'WE',	0,		1,		1,		0,		2)
																		 
INSERT INTO Item VALUES (11,	'W1',	50,		0,			2,		0,		3)
INSERT INTO Item VALUES (12,	'W2',	50,		0,			2,		0,		3)
INSERT INTO Item VALUES (13,	'W3',	50,		500,		2,		0,		3)
INSERT INTO Item VALUES (14,	'W4',	50,		500,		2,		0,		3)
INSERT INTO Item VALUES (15,	'W5',	50,		500,		2,		0,		3)
INSERT INTO Item VALUES (16,	'W6',	50,		500,		2,		0,		3)
INSERT INTO Item VALUES (17,	'W7',	50,		500,		2,		0,		3)
INSERT INTO Item VALUES (18,	'W8',	50,		500,		2,		0,		3)
INSERT INTO Item VALUES (19,	'W9',	50,		500,		2,		0,		3)
INSERT INTO Item VALUES (20,	'W10',	50,		500,		2,		0,		3)
INSERT INTO Item VALUES (21,	'W11',	100,	1000,		2,		0,		3)
INSERT INTO Item VALUES (22,	'W12',	100,	1000,		2,		0,		3)
INSERT INTO Item VALUES (23,	'W13',	100,	1000,		2,		0,		3)
INSERT INTO Item VALUES (24,	'W14',	100,	1000,		2,		0,		3)
INSERT INTO Item VALUES (25,	'W15',	100,	1000,		2,		0,		3)
INSERT INTO Item VALUES (26,	'W16',	100,	1000,		2,		0,		3)
INSERT INTO Item VALUES (27,	'W17',	100,	1000,		2,		0,		3)
INSERT INTO Item VALUES (28,	'W18',	100,	1000,		2,		0,		3)
INSERT INTO Item VALUES (29,	'W19',	100,	1000,		2,		0,		3)
INSERT INTO Item VALUES (30,	'W20',	100,	1000,		2,		0,		3)
INSERT INTO Item VALUES (31,	'W21',	100,	1000,		2,		0,		3)
GO																		 
																		 
-- Insert G																 
INSERT INTO Item VALUES (32,	'GA',	0,		0,			1,		0,		2)
INSERT INTO Item VALUES (33,	'GB',	0,		0,			2,		0,		2)
INSERT INTO Item VALUES (34,	'G1',	60,		100,		3,		0,		3)
INSERT INTO Item VALUES (35,	'G2',	60,		100,		3,		0,		3)
INSERT INTO Item VALUES (36,	'G3',	60,		100,		3,		0,		3)
INSERT INTO Item VALUES (37,	'G4',	60,		100,		3,		0,		3)
INSERT INTO Item VALUES (38,	'G5',	60,		100,		3,		0,		3)
INSERT INTO Item VALUES (39,	'G6',	60,		100,		3,		0,		3) 
GO																		 
																		 
-- Insert S				  												 
INSERT INTO Item VALUES (40,	'SA',	0,		1,		2,		0,		2)
INSERT INTO Item VALUES (41,	'SB',	0,		1,		2,		0,		2)
INSERT INTO Item VALUES (42,	'SC',	0,		1,		2,		0,		2)
INSERT INTO Item VALUES (43,	'SD',	0,		1,		2,		0,		2)
																		 
INSERT INTO Item VALUES (44,	'S1',	20,		400,		2,		0,		3)
INSERT INTO Item VALUES (45,	'S2',	20,		400,		2,		0,		3)
INSERT INTO Item VALUES (46,	'S3',	20,		400,		2,		0,		3)
INSERT INTO Item VALUES (47,	'S4',	20,		400,		2,		0,		3)
INSERT INTO Item VALUES (48,	'S5',	20,		400,		2,		0,		3)
INSERT INTO Item VALUES (49,	'S6',	20,		400,		2,		0,		3)
INSERT INTO Item VALUES (50,	'S7',	20,		400,		2,		0,		3)
INSERT INTO Item VALUES (51,	'S8',	20,		400,		2,		0,		3)
GO

-- Insert ItemRelationship		Parent	Child
-- Product F1
INSERT INTO ItemRelationship VALUES (1,		1,		6	, 1)		-- WA - F1
INSERT INTO ItemRelationship VALUES (2,		1,		32	, 1)		-- GA - F1
INSERT INTO ItemRelationship VALUES (3,		1,		40	, 1)		-- SA - F1
														
INSERT INTO ItemRelationship VALUES (4,		6,		11	, 2)		-- W1 - WA
INSERT INTO ItemRelationship VALUES (5,		6,		12	, 2)		-- W2 - WA
INSERT INTO ItemRelationship VALUES (6,		6,		13	, 2)		-- W3 - WA
INSERT INTO ItemRelationship VALUES (7,		6,		14	, 2)		-- W4 - WA
INSERT INTO ItemRelationship VALUES (8,		6,		15	, 2)		-- W5 - WA
INSERT INTO ItemRelationship VALUES (9,		6,		16	, 2)		-- W6 - WA
INSERT INTO ItemRelationship VALUES (10,	6,		17	, 2)		-- W7 - WA
														
INSERT INTO ItemRelationship VALUES (11,	32,		34	, 2)		-- G1 - GA
INSERT INTO ItemRelationship VALUES (12,	32,		35	, 2)		-- G2 - GA
														
INSERT INTO ItemRelationship VALUES (13,	40,		44	, 3)		-- S1 - SA
INSERT INTO ItemRelationship VALUES (14,	40,		45	, 3)		-- S2 - SA
INSERT INTO ItemRelationship VALUES (15,	40,		46	, 3)		-- S3 - SA
INSERT INTO ItemRelationship VALUES (16,	40,		47	, 3)		-- S4 - SA
INSERT INTO ItemRelationship VALUES (17,	40,		48	, 3)		-- S5 - SA
INSERT INTO ItemRelationship VALUES (18,	40,		49	, 3)		-- S6 - SA
GO			

-- Product FItemRelationship
INSERT INTO ItemRelationship VALUES (19,	2,		7 , 1)		-- WB - F2
INSERT INTO ItemRelationship VALUES (20,	2,		33, 1)		-- GB - F2
INSERT INTO ItemRelationship VALUES (21,	2,		41, 1)		-- SB - F2

INSERT INTO ItemRelationship VALUES (22,	7,		18, 2)		-- W8 -  WB
INSERT INTO ItemRelationship VALUES (23,	7,		19, 2)		-- W9 -  WB
INSERT INTO ItemRelationship VALUES (24,	7,		20, 2)		-- W10 - WB
INSERT INTO ItemRelationship VALUES (25,	7,		21, 2)		-- W11 - WB
INSERT INTO ItemRelationship VALUES (26,	7,		22, 2)		-- W12 - WB
INSERT INTO ItemRelationship VALUES (27,	7,		23, 2)		-- W13 - WB  

INSERT INTO ItemRelationship VALUES (28,	33,		36, 3)		-- G3 - GB
INSERT INTO ItemRelationship VALUES (29,	33,		37, 3)		-- G4 - GB
INSERT INTO ItemRelationship VALUES (30,	33,		38, 3)		-- G5 - GB 

INSERT INTO ItemRelationship VALUES (31,	41,		50,2)		-- S7 - SB
INSERT INTO ItemRelationship VALUES (32,	41,		51,2)		-- S8 - SB 
GO			

-- Product FItemRelationship
INSERT INTO ItemRelationship VALUES (33,	3,		8 , 1)		-- WC - F3 
INSERT INTO ItemRelationship VALUES (34,	3,		33, 1)		-- GB - F3 
INSERT INTO ItemRelationship VALUES (35,	3,		42, 1)		-- SC - F3
									 
INSERT INTO ItemRelationship VALUES (36,	8,		11,2)		-- W1 -  WC
INSERT INTO ItemRelationship VALUES (37,	8,		12,2)		-- W2 -  WC
INSERT INTO ItemRelationship VALUES (38,	8,		14,2)		-- W4 -  WC
INSERT INTO ItemRelationship VALUES (39,	8,		16,2)		-- W6 -  WC
INSERT INTO ItemRelationship VALUES (30,	8,		17,2)		-- W7 -  WC
INSERT INTO ItemRelationship VALUES (41,	8,		20,2)		-- W10 - WC 
INSERT INTO ItemRelationship VALUES (42,	8,		30,2)		-- W20 - WC  
									 
INSERT INTO ItemRelationship VALUES (43,	42,		44,3)		-- S1 - SC
INSERT INTO ItemRelationship VALUES (44,	42,		46,3)		-- S3 - SC 
INSERT INTO ItemRelationship VALUES (45,	42,		48,3)		-- S5 - SC
INSERT INTO ItemRelationship VALUES (46,	42,		51,3)		-- S8 - SC 
GO

-- Insert Order					Week	Year	Quantity	ItemId
-- F1
INSERT INTO Orders VALUES (1,	4,		2019,	160,		1)
INSERT INTO Orders VALUES (2,	8,		2019,	207,		1)
INSERT INTO Orders VALUES (3,	12,		2019,	187,		1)
INSERT INTO Orders VALUES (4,	16,		2019,	450,		1)
INSERT INTO Orders VALUES (5,	20,		2019,	500,		1)
INSERT INTO Orders VALUES (6,	4,		2020,	222,		1)
INSERT INTO Orders VALUES (7,	8,		2020,	249,		1)
INSERT INTO Orders VALUES (8,	12,		2020,	229,		1)
INSERT INTO Orders VALUES (9,	16,		2020,	541,		1)
INSERT INTO Orders VALUES (10,	20,		2020,	527,		1)
INSERT INTO Orders VALUES (11,	4,		2021,	246,		1)
INSERT INTO Orders VALUES (12,	8,		2021,	251,		1)
INSERT INTO Orders VALUES (13,	12,		2021,	241,		1)
INSERT INTO Orders VALUES (14,	16,		2021,	537,		1)
INSERT INTO Orders VALUES (15,	20,		2021,	551,		1)

-- F2
INSERT INTO Orders VALUES (16,	4,		2019,	157,		2)
INSERT INTO Orders VALUES (17,	8,		2019,	197,		2)
INSERT INTO Orders VALUES (18,	12,		2019,	165,		2)
INSERT INTO Orders VALUES (19,	16,		2019,	478,		2)
INSERT INTO Orders VALUES (20,	20,		2019,	476,		2)
INSERT INTO Orders VALUES (21,	4,		2020,	226,		2)
INSERT INTO Orders VALUES (22,	8,		2020,	239,		2)
INSERT INTO Orders VALUES (23,	12,		2020,	198,		2)
INSERT INTO Orders VALUES (24,	16,		2020,	504,		2)
INSERT INTO Orders VALUES (25,	20,		2020,	490,		2)
INSERT INTO Orders VALUES (26,	4,		2021,	261,		2)
INSERT INTO Orders VALUES (27,	8,		2021,	266,		2)
INSERT INTO Orders VALUES (28,	12,		2021,	243,		2)
INSERT INTO Orders VALUES (29,	16,		2021,	598,		2)
INSERT INTO Orders VALUES (30,	20,		2021,	567,		2)

-- F3
INSERT INTO Orders VALUES (31,	4,		2019,	200,		3)
INSERT INTO Orders VALUES (32,	8,		2019,	196,		3)
INSERT INTO Orders VALUES (33,	4,		2020,	223,		3)
INSERT INTO Orders VALUES (34,	8,		2020,	217,		3)
INSERT INTO Orders VALUES (35,	8,		2021,	262,		3)
INSERT INTO Orders VALUES (36,	12,		2021,	243,		3)

 
 --	Id INT NOT NULL PRIMARY KEY,
	--Week INT,
	--Year INT,
	--Quantity INT,
	--ItemId INT,
	--FOREIGN KEY (ItemId) REFERENCES Item(Id)