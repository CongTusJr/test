create database webmvc
go
CREATE TABLE product (
    idproduct int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    nameproduct NVARCHAR(300) NOT NULL,
    price DECIMAL(10, 0) NOT NULL,
    imageurl NVARCHAR(300) NOT NULL,
    introduction NVARCHAR(300)
)

INSERT INTO dbo.product (nameproduct, price, imageurl, introduction)
VALUES 
    ('Product 1', 100, '/images/product1.jpg', 'Introduction 1'),
    ('Product 2', 150, '/images/product2.jpg', 'Introduction 2'),
    ('Product 3', 200, '/images/product3.jpg', 'Introduction 3'),
    ('Product 4', 200, '/images/product3.jpg', 'Introduction 3'),
	('Product 5', 200, '/images/product3.jpg', 'Introduction 3'),
	('Product 6', 200, '/images/product3.jpg', 'Introduction 3'),
	('Product 7', 200, '/images/product3.jpg', 'Introduction 3'),
	('Product 8', 200, '/images/product3.jpg', 'Introduction 3'),
	('Product 9', 200, '/images/product3.jpg', 'Introduction 3'),
	('Product 10', 200, '/images/product3.jpg', 'Introduction 3'),
    ('Product 11', 500, '/images/product10.jpg', 'Introduction 10');