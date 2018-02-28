CREATE DATABASE booksDB
ON PRIMARY
(NAME = 'booksDB_DATA',
FILENAME = 'C:\Users\ww\数据库系统\booksDB.MDF',
SIZE = 5MB,
MAXSIZE = 30MB,
FILEGROWTH = 20%)
LOG ON
(NAME = 'booksDB_LOG',
FILENAME = 'C:\Users\ww\数据库系统\booksDB.LDF',
SIZE = 5MB,
MAXSIZE = 30MB,
FILEGROWTH =3MB)
USE booksDB
GO
CREATE TABLE ReaderType(  
rdType         INT PRIMARY KEY,    --读者类别号  
rdTypeName    VARCHAR(20),         --读者类别名称  
canLendQty    INT,                 --可借书数量  
canLendDay    INT)                 --可借书天数
CREATE TABLE reader(
rdID		 char(9)primary key,				--读者编号
rdType       INT REFERENCES ReaderType(rdType),			--读者类别
rdName       VARCHAR(20),					--读者姓名  
rdDept       VARCHAR(40),					--读者单位  
rdQQ         VARCHAR(13),					--读者QQ  
rdBorrowQty  INT  DEFAULT 0 CHECK(rdBorrowQty BETWEEN 0 AND 10))--已借书数量
CREATE TABLE Book( 
bkID        CHAR(9)  PRIMARY KEY,   --书号  
bkName		VARCHAR(50),			--书名  
bkAuthor    VARCHAR(50),			--作者  
bkPress     VARCHAR(50),			--出版社  
bkPrice     DECIMAL(5,2),			--单价  
bkStatus    INT DEFAULT 1)			--是否在馆，1：在馆， 0：不在馆
CREATE TABLE Borrow(  
rdID            CHAR(9)  REFERENCES Reader(rdID),       --读者编号  
bkID            CHAR(9)  REFERENCES Book(bkID),         --书号  
DateBorrow      DateTime,         --借书日期  
DateLendPlan    DateTime,         --应还日期  
DateLendAct     DateTime,         --实际还书日期  
PRIMARY KEY(rdID, bkID) ) 
USE booksDB
GO
INSERT INTO ReaderType
VALUES
('1','教师','10','60'),
('2','本科生','5','30'),
('3','硕士研究生','6','40'),
('4','博士研究生','8','50')
USE booksDB
GO
INSERT INTO Reader
VALUES
('rd2017001','1','王桃群','计算机科学学院','3635751','0'),
('rd2017002','2','孙小美','英语学院','11223344','0'),
('rd2017003','3','连小燕','管理学院','5599663','0'),
('rd2017004','4','徐苗','物理学院','88552277','0')

INSERT INTO Book
VALUES
('bk2017001','数据库原理','王丽艳','机械工业出版社','33.00','1'),
('bk2017002','高等数学','同济大学数学系','高等教育出版社','37.00','1'),
('bk2017003','当代教育心理学','陈琦','北京师范大学','37.20','1'),
('bk2017004','古代汉语','王力','中华书局','20.40','1')

SELECT rdID,rdName FROM Reader

SELECT 编号=rdID,姓名=rdName,单位=rdDept FROM Reader

SELECT * FROM Reader

SELECT rdID FROM Reader
WHERE rdBorrowQty > 0

SELECT bkID,bkName FROM Book
WHERE bkPrice > 30

SELECT rdName,rdQQ FROM Reader
WHERE rdDept NOT IN ('管理学院','物理学院')

SELECT rdName,rdQQ,rdDept FROM Reader
WHERE rdName LIKE ('王%')

SELECT rdName,rdQQ,rdDept FROM Reader
WHERE rdName NOT LIKE ('王%')

SELECT rdName,rdQQ,rdDept FROM Reader
WHERE rdName LIKE('__')

SELECT Borrow.rdID,Borrow.bkID,Borrow.DateBorrow,Borrow.DateLendAct,Borrow.DateLendPlan
FROM Borrow INNER JOIN Book
ON Borrow.bkID = Book.bkID AND Book.bkStatus = 0

SELECT COUNT(*)AS'读者人数'FROM Reader

SELECT COUNT(DISTINCT rdID)AS'已借阅书人数'FROM Reader

SELECT MAX(bkprice)AS'最高单价'FROM Book

SELECT rdDept,COUNT(rdID)AS'读者人数'FROM Reader
GROUP BY rdDept

SELECT rdDept,COUNT (rdID)AS'读者人数'FROM Reader
GROUP BY rdDept
HAVING COUNT(rdDept) > 40

SELECT rdName,rdDept from reader 
WHERE rdType = '1'

SELECT Reader.rdID,Reader.rdName,ReaderType.canLendQty
FROM ReaderType,Reader
WHERE Reader.rdType = ReaderType.rdType AND Reader.rdDept = '管理学院'

SELECT Reader.rdName,ReaderType.canLendQty,ReaderType.canLendDay
FROM Reader,Borrow,ReaderType
WHERE Reader.rdType = ReaderType.rdType AND Reader.rdID = Borrow.rdID AND Borrow.bkID = '2017001'

SELECT *
FROM ReaderType FULL JOIN Reader ON ReaderType.rdType = Reader.rdType FULL JOIN Borrow ON Borrow.rdID = Reader.rdID

SELECT * FROM Reader
WHERE rdDept = (SELECT rdDept FROM Reader WHERE rdName = '连晓燕'

SELECT Reader.rdID,Reader.rdName
FROM Reader,Borrow,Book
WHERE Reader.rdID = Borrow.rdID AND Book.bkID = Borrow.bkID AND Book.bkName = '高等数学'

SELECT rdName 
FROM Reader
WHERE rdID NOT IN (SELECT rdID FROM Borrow WHERE bkID = 'bk2017004'

SELECT rdName FROM Reader WHERE rdDept = '管理学院'
UNION
SELECT rdName FROM Reader WHERE rdBorrowQty < 4

SELECT rdName FROM Reader WHERE rdDept = '管理学院'
INTERSECT
SELECT rdName FROM Reader WHERE rdBorrowQty < 4

SELECT rdName FROM Reader WHERE rdDept = '管理学院'
EXCEPT
SELECT rdName FROM Reader WHERE rdBorrowQty < 4

INSERT INTO Reader
VALUES ('2017007','1','卢小川','计算机科学学院','932200777',

INSERT INTO Borrow
VALUES ('2017007','bk2017004','2017-3-8')

UPDATE Reader
SET rdQQ = '3635763'
WHERE rdID = 'rd2017001'

UPDATE Reader
SET rdType = '2'
WHERE rdID = 'rd2017001'

TRUNCATE TABLE Borrow