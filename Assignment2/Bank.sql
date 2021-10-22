--membuat database bank
CREATE DATABASE Bank;

--membuat tabel produclines
CREATE TABLE productlines (
	productLine INT IDENTITY(1,1) PRIMARY KEY,
	textDescription TEXT,
	htmlDescription TEXT,
	image VARCHAR(100)
);

--membuat tabel products
CREATE TABLE products (
	productCode INT IDENTITY(1,1) PRIMARY KEY,
	productName VARCHAR(100),
	productLine INT,
	productScale VARCHAR(100),
	productVendor VARCHAR(100),
	productDescription TEXT,
	quantityInStock INT,
	buyPrice VARCHAR(100),
	msrp VARCHAR(100)
);

--membuat tabel orders
CREATE TABLE orders (
	orderNumber INT IDENTITY(1,1) PRIMARY KEY,
	orderDate DATE,
	requiredDate DATE,
	shippedDate DATE,
	status VARCHAR(100),
	comments TEXT,
	customerNumber INT,
);

--membuat tabel orderdetails
CREATE TABLE orderdetails (
	orderNumber INT,
	productCode INT,
	quantityOrdered INT,
	priceEach VARCHAR(50),
	orderLineNumber VARCHAR(50),
);

--membuat tabel offices
CREATE TABLE offices (
	officeCode INT IDENTITY(1,1) PRIMARY KEY,
	city VARCHAR(20),
	phone VARCHAR(15),
	addressLine1 TEXT,
	addressLine2 TEXT,
	state VARCHAR(20),
	country VARCHAR(20),
	postalCode INT,
	territory VARCHAR(20)
);

--membuat tabel employees
CREATE TABLE employees (
	employeeNumber INT IDENTITY(1,1) PRIMARY KEY,
	lastname VARCHAR(20),
	firstname VARCHAR(20),
	extension VARCHAR(20),
	email VARCHAR(20),
	officeCode INT,
	reportsTo VARCHAR(20),
	jobTitle VARCHAR(20)
);

--membuat tabel customers
CREATE TABLE customers (
	customerNumber INT IDENTITY(1,1) PRIMARY KEY,
	customerName VARCHAR(50),
	contacLastName VARCHAR(50),
	contacFirstName VARCHAR(50),
	phone VARCHAR(15),
	addressLine1 TEXT,
	addressLine2 TEXT,
	city VARCHAR(50),
	state VARCHAR(50),
	postalCode INT,
	country VARCHAR(50),
	salesRepEmployeeNumber INT,
	creditLimit VARCHAR(20)
);

--membuat tabel payments
CREATE TABLE payments (
	customerNumber INT IDENTITY(1,1) PRIMARY KEY,
	checkNumber INT,
	paymentDate DATE,
	amount INT
);

--MEMBUAT RELASI TABEL (DENGAN KONDISI CASCADE)

ALTER TABLE products ADD FOREIGN KEY (productLine) REFERENCES productlines (productLine) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE orderdetails ADD FOREIGN KEY (productCode) REFERENCES products (productCode) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE orderdetails ADD FOREIGN KEY (orderNumber) REFERENCES orders (orderNumber) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE employees ADD FOREIGN KEY (officeCode) REFERENCES offices (officeCode) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE customers ADD FOREIGN KEY (salesRepEmployeeNumber) REFERENCES employees (employeeNumber) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE orders ADD FOREIGN KEY (customerNumber) REFERENCES customers (customerNumber) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE payments ADD FOREIGN KEY (checkNumber) REFERENCES customers (customerNumber) ON DELETE CASCADE ON UPDATE CASCADE;

--menambah data productlines
INSERT INTO productlines VALUES ('TEXT1', 'HTML1', 'IMAGE1');
INSERT INTO productlines VALUES ('TEXT2', 'HTML2', 'IMAGE2');
INSERT INTO productlines VALUES ('TEXT3', 'HTML3', 'IMAGE3');
INSERT INTO productlines VALUES ('TEXT4', 'HTML4', 'IMAGE4');
INSERT INTO productlines VALUES ('TEXT5', 'HTML5', 'IMAGE5');
INSERT INTO productlines VALUES ('TEXT6', 'HTML6', 'IMAGE6');
INSERT INTO productlines VALUES ('TEXT7', 'HTML7', 'IMAGE7');
INSERT INTO productlines VALUES ('TEXT8', 'HTML8', 'IMAGE8');
INSERT INTO productlines VALUES ('TEXT9', 'HTML9', 'IMAGE9');
INSERT INTO productlines VALUES ('TEXT10', 'HTML10', 'IMAGE10');

SELECT * FROM productlines;
SELECT TOP 3 * FROM productlines;

--menambah data product
INSERT INTO products VALUES ('MOTOR1', '1', 'PRODUCT SCALE1', 'PRODUCT VENDOR1', 'INI MOTOR 1', '2', '1000', 'MSRP1');
INSERT INTO products VALUES ('MOTOR2', '1', 'PRODUCT SCALE2', 'PRODUCT VENDOR2', 'INI MOTOR 2', '2', '2000', 'MSRP2');
INSERT INTO products VALUES ('MOTOR3', '2', 'PRODUCT SCALE3', 'PRODUCT VENDOR3', 'INI MOTOR 3', '3', '3000', 'MSRP3');
INSERT INTO products VALUES ('MOTOR4', '2', 'PRODUCT SCALE4', 'PRODUCT VENDOR4', 'INI MOTOR 4', '2', '2500', 'MSRP4');
INSERT INTO products VALUES ('MOTOR5', '3', 'PRODUCT SCALE5', 'PRODUCT VENDOR5', 'INI MOTOR 5', '4', '4000', 'MSRP5');
INSERT INTO products VALUES ('MOTOR6', '3', 'PRODUCT SCALE6', 'PRODUCT VENDOR6', 'INI MOTOR 6', '5', '5000', 'MSRP6');
INSERT INTO products VALUES ('MOTOR7', '3', 'PRODUCT SCALE7', 'PRODUCT VENDOR7', 'INI MOTOR 7', '6', '6000', 'MSRP7');
INSERT INTO products VALUES ('MOTOR8', '4', 'PRODUCT SCALE8', 'PRODUCT VENDOR8', 'INI MOTOR 8', '7', '7000', 'MSRP8');
INSERT INTO products VALUES ('MOTOR9', '5', 'PRODUCT SCALE9', 'PRODUCT VENDOR9', 'INI MOTOR 9', '8', '8000', 'MSRP9');
INSERT INTO products VALUES ('MOTOR10', '6', 'PRODUCT SCALE10', 'PRODUCT VENDOR10', 'INI MOTOR 10', '2', '20000', 'MSRP10');

SELECT * FROM products;
SELECT * FROM products WHERE quantityInStock > 3;

--menambah data offices
INSERT INTO offices VALUES ('Medan', '082363109174', 'jl sisingamangaraja', 'jl pattimura', 'SUMUT', 'INDONESIA', '20141', 'Territory 1');
INSERT INTO offices VALUES ('Jakarta', '082363109175', 'jl sisingamangaraja 2', 'jl pattimura 2', 'SUMUT 1', 'INDONESIA', '20142', 'Territory 2');
INSERT INTO offices VALUES ('Bandung', '082363109176', 'jl sisingamangaraja 3', 'jl pattimura 3', 'SUMUT 2', 'INDONESIA', '20143', 'Territory 3');
INSERT INTO offices VALUES ('Malang', '082363109177', 'jl sisingamangaraja 4', 'jl pattimura 4', 'SUMUT 3', 'INDONESIA', '20144', 'Territory 4');
INSERT INTO offices VALUES ('Semarang', '082363109178', 'jl sisingamangaraja 5', 'jl pattimura 5', 'SUMUT 4', 'INDONESIA', '20145', 'Territory 5');
INSERT INTO offices VALUES ('Lampung', '082363109179', 'jl sisingamangaraja 6', 'jl pattimura 6', 'SUMUT 5', 'INDONESIA', '20146', 'Territory 6');
INSERT INTO offices VALUES ('Makassar', '082363109170', 'jl sisingamangaraja 7', 'jl pattimura 7', 'SUMUT 6', 'INDONESIA', '20147', 'Territory 7');
INSERT INTO offices VALUES ('Jambi', '082363109112', 'jl sisingamangaraja 8', 'jl pattimura 8', 'SUMUT 7', 'INDONESIA', '20148', 'Territory 8');
INSERT INTO offices VALUES ('Batam', '082363109113', 'jl sisingamangaraja 9', 'jl pattimura 9', 'SUMUT 8', 'INDONESIA', '20149', 'Territory 9');
INSERT INTO offices VALUES ('Maluku', '082363109114', 'jl sisingamangaraja 10', 'jl pattimura 10', 'SUMUT 9', 'INDONESIA', '20140', 'Territory 10');

SELECT * FROM offices;

--menambah data employees
INSERT INTO employees VALUES ('wijaya', 'febri', 'extension 1', 'febri@gmail.com', '1', 'Reports to 1', 'IT MANAGER 1');
INSERT INTO employees VALUES ('Iskandar', 'anggi', 'extension 2', 'anggi@gmail.com', '1', 'Reports to 2', 'IT MANAGER 2');
INSERT INTO employees VALUES ('roni', 'bayu', 'extension 3', 'bayu@gmail.com', '3', 'Reports to 3', 'IT MANAGER 3');
INSERT INTO employees VALUES ('susi', 'rode', 'extension 4', 'rode@gmail.com', '5', 'Reports to 4', 'IT MANAGER 4');
INSERT INTO employees VALUES ('angga', 'yunanda', 'extension 5', 'yunanda@gmail.com', '4', 'Reports to 5', 'IT MANAGER 5');
INSERT INTO employees VALUES ('hutagalung', 'joli', 'extension 6', 'joli@gmail.com', '3', 'Reports to 6', 'IT MANAGER 6');
INSERT INTO employees VALUES ('ahmad', 'risky', 'extension 7', 'risky@gmail.com', '7', 'Reports to 7', 'IT MANAGER 7');
INSERT INTO employees VALUES ('andreas', 'ajun', 'extension 8', 'ajun@gmail.com', '9', 'Reports to 8', 'IT MANAGER 8');
INSERT INTO employees VALUES ('juwita', 'simanjuntak', 'extension 9', 'juwita@gmail.com', '2', 'Reports to 9', 'IT MANAGER 9');
INSERT INTO employees VALUES ('lenny', 'susilowati', 'extension 10', 'lenny@gmail.com', '4', 'Reports to 10', 'IT MANAGER 10');

SELECT * FROM employees;

--menambah data customers
INSERT INTO customers VALUES ('wijaya', 'febri', 'hutagalung', '082363109174', 'Jalan 1', 'Jalan 2', 'Medan', 'sumut', '20142', 'indonesia', '1', 'credit limit 1');
INSERT INTO customers VALUES ('salim', 'irene', 'simanjuntak', '082363109171', 'Jalan 1a', 'Jalan 2a', 'Jakarta', 'jakarta', '20143', 'indonesia', '2', 'credit limit 2');
INSERT INTO customers VALUES ('luis', 'barker', 'simangunsong', '082363109172', 'Jalan 1b', 'Jalan 2b', 'Bandung', 'jabar', '20141', 'indonesia', '3', 'credit limit 3');
INSERT INTO customers VALUES ('july', 'nine', 'panggabean', '082363109173', 'Jalan 1c', 'Jalan 2c', 'pontianak', 'kaltim', '20144', 'indonesia', '4', 'credit limit 4');
INSERT INTO customers VALUES ('susi', 'vetricia', 'hutabarat', '082363109175', 'Jalan 1d', 'Jalan 2d', 'kalimantan barat', 'kalbar', '20145', 'indonesia', '5', 'credit limit 5');

SELECT * FROM customers;

--menambah data orders
INSERT INTO orders VALUES ('2021-10-01', '2021-11-01', '2021-12-01', 'paid', 'dibayar', '1');
INSERT INTO orders VALUES ('2021-10-02', '2021-11-02', '2021-12-02', 'paid', 'dibayar', '2');
INSERT INTO orders VALUES ('2021-10-03', '2021-11-03', '2021-12-03', 'paid', 'dibayar', '3');
INSERT INTO orders VALUES ('2021-10-04', '2021-11-04', '2021-12-04', 'paid', 'dibayar', '4');
INSERT INTO orders VALUES ('2021-10-05', '2021-11-05', '2021-12-05', 'paid', 'dibayar', '5');
INSERT INTO orders VALUES ('2021-10-06', '2021-11-06', '2021-12-06', 'paid', 'dibayar', '1');
INSERT INTO orders VALUES ('2021-10-07', '2021-11-07', '2021-12-07', 'paid', 'dibayar', '2');
INSERT INTO orders VALUES ('2021-10-08', '2021-11-08', '2021-12-08', 'paid', 'dibayar', '3');
INSERT INTO orders VALUES ('2021-10-09', '2021-11-09', '2021-12-09', 'paid', 'dibayar', '4');
INSERT INTO orders VALUES ('2021-10-10', '2021-11-10', '2021-12-10', 'paid', 'dibayar', '5');

SELECT * FROM orders;

--menambah data orderdetails
INSERT INTO orderdetails VALUES ('1', '1', '2', '10000', 'order line number');
INSERT INTO orderdetails VALUES ('2', '2', '3', '30000', 'order line number 1');
INSERT INTO orderdetails VALUES ('3', '2', '4', '40000', 'order line number 2');
INSERT INTO orderdetails VALUES ('4', '3', '5', '50000', 'order line number 3');
INSERT INTO orderdetails VALUES ('5', '3', '6', '60000', 'order line number 4');
INSERT INTO orderdetails VALUES ('2', '4', '2', '70000', 'order line number 5');

SELECT * FROM orderdetails;

--menambah data payments
INSERT INTO payments VALUES ('1', '2021-10-01', '2');
INSERT INTO payments VALUES ('2', '2021-10-02', '2');
INSERT INTO payments VALUES ('3', '2021-10-03', '4');
INSERT INTO payments VALUES ('4', '2021-10-04', '5');
INSERT INTO payments VALUES ('5', '2021-10-05', '2');
INSERT INTO payments VALUES ('1', '2021-10-06', '3');
INSERT INTO payments VALUES ('2', '2021-10-07', '2');

SELECT * FROM payments;

