--a
CREATE DATABASE STAFF;

--b 
CREATE TABLE data_staff (
	NIK INT PRIMARY KEY,
	NAMA VARCHAR(50),
	ALAMAT VARCHAR(200),
	HANDPHONE VARCHAR(15)
);

--c dan d
INSERT INTO data_staff VALUES ('1202020', 'FEBRI WIJAYA', 'MEDAN', '08937');
INSERT INTO data_staff VALUES ('1202021', 'RANDI', 'MEDAN', '08934');


SELECT * FROM data_staff;
--e
ALTER TABLE data_staff ADD joindate DATE NULL;

INSERT INTO data_staff VALUES ('1202022', 'RUDI', 'BANDUNG', '08931', '2021-11-02');
INSERT INTO data_staff VALUES ('1202023', 'RONI', 'MEDAN', '08932', '2021-11-02');
INSERT INTO data_staff VALUES ('1202024', 'WIJAYA', 'JAKARTA', '08933', '2021-11-03');
INSERT INTO data_staff VALUES ('1202025', 'LINDA', 'MEDAN', '08935', '2021-11-04');
INSERT INTO data_staff VALUES ('1202026', 'ELSA', 'ACEH', '08936', '2021-11-05');
INSERT INTO data_staff VALUES ('1202027', 'LISA', 'LAMPUNG', '08938', '2021-11-01');

--f
SELECT TOP 2 * FROM data_staff;

--g
SELECT TOP 3 * FROM data_staff;

--h
CREATE TABLE staffoutsource (
	NIK INT,
	NAMA VARCHAR(50),
	ALAMAT VARCHAR(200),
	HANDPHONE VARCHAR(15),
	joindate DATE NULL
);

--i
INSERT INTO staffoutsource VALUES ('1202022', 'RUDI', 'BANDUNG', '08931', '2021-11-02');
INSERT INTO staffoutsource VALUES ('1202023', 'RONI', 'MEDAN', '08932', '2021-11-02');
INSERT INTO staffoutsource VALUES ('1202024', 'WIJAYA', 'JAKARTA', '08933', '2021-11-03');
INSERT INTO staffoutsource VALUES ('1202025', 'LINDA', 'MEDAN', '08935', '2021-11-04');
INSERT INTO staffoutsource VALUES ('1202026', 'ELSA', 'ACEH', '08936', '2021-11-05');
INSERT INTO staffoutsource VALUES ('1202027', 'LISA', 'LAMPUNG', '08938', '2021-11-01');
INSERT INTO staffoutsource VALUES ('1202028', 'ROY', 'MALANG', '08928', '2021-12-01');
INSERT INTO staffoutsource VALUES ('1202029', 'JOLY', 'RIAU', '08921', '2021-12-02');
INSERT INTO staffoutsource VALUES ('1202020', 'DANY', 'MAKASSAR', '08922', '2021-12-03');
INSERT INTO staffoutsource VALUES ('1202011', 'REBECCA', 'LAMPUNG', '08923', '2021-12-04');

SELECT * FROM staffoutsource;
--j
SELECT a.*, b.* FROM data_staff b JOIN staffoutsource a ON a.joindate = b.joindate WHERE a.joindate = b.joindate;
--k
SELECT a.*, b.* FROM data_staff a RIGHT JOIN staffoutsource b ON b.joindate = a.joindate;
--l
SELECT a.*, b.* FROM data_staff b LEFT JOIN staffoutsource a ON a.joindate = b.joindate;
--m
SELECT a.*, b.* FROM data_staff b FULL JOIN staffoutsource a ON a.joinDate = b.joinDate;

