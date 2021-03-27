CREATE TABLE Cars (
    Id int NOT NULL,
    BrandId int NOT NULL,
    ColorId int NOT NULL,
    CarName varchar(255) NOT NULL,
    ModelYear varchar(255) NOT NULL,
    DailyPrice decimal(18) NOT NULL,
    Description varchar(255) NOT NULL,
    CONSTRAINT PK_Cars PRIMARY KEY (Id)
);

CREATE TABLE Brands (
    BrandId int NOT NULL,
    BrandName varchar(255) NOT NULL,
    CONSTRAINT PK_Brands PRIMARY KEY (BrandId)
);

CREATE TABLE Colors (
    ColorId int NOT NULL,
    ColorName varchar(255) NOT NULL,
    CONSTRAINT PK_Colors PRIMARY KEY (ColorId)
);




INSERT INTO Cars(BrandId,ColorId,ModelYear,DailyPrice,Description)
VALUES
    (3,1,'2010','450','Dizel'),
	(1,3,'2000','550','Elektrikli'),
	(2,4,'2020','180','Hibrit'),
	(3,2,'2005','100','Hibrid');
	
	

INSERT INTO Colors(ColorName)
VALUES
	('Beyaz'),
	('Siyah'),
	('Lacivert'),
	('Kırmızı');


INSERT INTO Brands(BrandName)
VALUES
	('Range Rover'),
	('Toyota'),
	('Mercedes');