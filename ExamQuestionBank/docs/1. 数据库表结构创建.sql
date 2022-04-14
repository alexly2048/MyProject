

-- 1. 用户登录账户
IF (OBJECT_ID('USERS','U') IS NOT NULL)
    DROP TABLE USERS;
GO
CREATE TABLE USERS(
ID BIGINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
PARENT_ID BIGINT,
USERID NVARCHAR(30) NOT NULL,
USERNAME NVARCHAR(30) NOT NULL,
PWD NVARCHAR(30) NOT NULL
);
INSERT INTO USERS (USERID,USERNAME,PWD) VALUES ('admin','admin','admin');
GO
-- 2. 创建权限菜单表
IF (OBJECT_ID('FunctionItem','U') IS NOT NULL)
    DROP TABLE FunctionItem
GO
create table FunctionItem(
ID bigint identity(1,1) not null primary key,
OrderNo int not null,
ItemId nvarchar(200) not null,
ItemName nvarchar(200),
ItemType nvarchar(100),
ParentId nvarchar(200),
Description nvarchar(200)
);
GO

-- 3. Authorities
IF (OBJECT_ID('Authorities','U') IS NOT NULL)
    DROP TABLE Authorities
GO
create table Authorities(
ID bigint identity(1,1) not null primary key,
PARENT_ID BIGINT,
USER_ID nvarchar(200) not null,
USER_NAME nvarchar(200),
ITEM_ID nvarchar(200) not null,
ITEM_NAME nvarchar(200),
ITEM_TYPE NVARCHAR(30),
DESCRIPTION nvarchar(200)
);

-- 4. Course
IF (OBJECT_ID('T_COURSE','U') IS NOT NULL)
    DROP TABLE T_COURSE;
GO
CREATE TABLE T_COURSE(
ID BIGINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
COURSE_CODE NVARCHAR(30) NOT NULL,
COURSE_NAME NVARCHAR(30) NOT NULL
);

-- 5. Answer
IF (OBJECT_ID('T_ANSWER') IS NOT NULL)
    DROP TABLE T_ANSWER;
GO
CREATE TABLE T_ANSWER(
ID BIGINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
QUESTION_GUID NVARCHAR(150),
ANSWER_CONTENT NVARCHAR(MAX)
);

-- 6. QUESTION
IF (OBJECT_ID('T_QUESTION','U') IS NOT NULL)
DROP TABLE T_QUESTION
GO
CREATE TABLE T_QUESTION(
ID BIGINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
SUBJECT_GUID NVARCHAR(150) NOT NULL,
QUESTION_TYPE NVARCHAR(20) NOT NULL,
QUESTION_GUID NVARCHAR(1000) NOT NULL,
QUESTION_CONTENT NVARCHAR(500),
SCORE INT
);

-- 7. QUESTION_IMAGE
IF (OBJECT_ID('T_QUESTION_IMAGE','U') IS NOT NULL)
DROP TABLE T_QUESTION_IMAGE
GO
CREATE TABLE T_QUESTION_IMAGE(
ID BIGINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
QUESTION_GUID NVARCHAR(150) NOT NULL,
IMAGE_CONTENT NVARCHAR(MAX)
);

-- 8. T_QUESTION_ITEM
IF (OBJECT_ID('T_QUESTION_ITEM','U') IS NOT NULL)
DROP TABLE T_QUESTION_ITEM
GO
CREATE TABLE T_QUESTION_ITEM(
ID BIGINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
QUESTION_GUID NVARCHAR(150) NOT NULL,
QUESTION_ORDER INT,
ITEM_LABEL NVARCHAR(30),
ITEM_CONTENT NVARCHAR(500),
IS_ANSWER bit
);

-- 9. T_SUBJECT
IF (OBJECT_ID('T_SUBJECT','U') IS NOT NULL)
DROP TABLE T_SUBJECT
GO
CREATE TABLE T_SUBJECT(
ID BIGINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
SUBJECT_GUID NVARCHAR(150) NOT NULL,
SUBJECT_TYPE NVARCHAR(30) NOT NULL,
COURSE_CODE NVARCHAR(30) NOT NULL,
GRADE_CODE NVARCHAR(30) NOT NULL,
DIFFICULTY_LEVEL NVARCHAR(30),
IS_ENABLE BIT
);

-- 10. T_SUBJECT_DESCRIPTION
IF (OBJECT_ID('T_SUBJECT_DESCRIPTION','U') IS NOT NULL)
DROP TABLE T_SUBJECT_DESCRIPTION
GO
CREATE TABLE T_SUBJECT_DESCRIPTION(
ID BIGINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
SUBJECT_GUID NVARCHAR(150) NOT NULL,
DESCRIPTION NVARCHAR(MAX) NOT NULL
);

-- 11. T_GRADE
IF (OBJECT_ID('T_GRADE','U') IS NOT NULL)
DROP TABLE T_GRADE;
GO
CREATE TABLE T_GRADE(
ID BIGINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
GRADE_CODE NVARCHAR(30) NOT NULL,
GRADE_NAME NVARCHAR(50) NOT NULL
);

-- 12. T_EXAM_BANK
IF(OBJECT_ID('T_EXAM_BANK','U') IS NOT NULL)
DROP TABLE T_EXAM_BANK;
GO
CREATE TABLE T_EXAM_BANK(
ID BIGINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
COURSE_CODE NVARCHAR(30) NOT NULL,
GRADE_CODE NVARCHAR(30) NOT NULL,
EXAM_GUID NVARCHAR(150) NOT NULL,
SUBJECT_TYPE NVARCHAR(30) NOT NULL,
VERY_EASY INT DEFAULT(0),
EASY INT DEFAULT(0),
COMMON INT DEFAULT(0),
DIFFICULTY INT DEFAULT(0),
VERY_DIFFICULTY INT DEFAULT(0),
IS_ENABLE BIT DEFAULT(1)
);

-- 13. T_USER_EXAM
IF(OBJECT_ID('T_USER_EXAM','U') IS NOT NULL)
DROP TABLE T_USER_EXAM;
GO
CREATE TABLE T_USER_EXAM(
ID BIGINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
USER_ID NVARCHAR(30) NOT NULL,
USER_EXAM_GUID NVARCHAR(150) NOT NULL,
EXAM_GUID NVARCHAR(150) NOT NULL,
IS_COMPLETE BIT DEFAULT(0),
IS_ENABLE BIT,
CREATE_DATE NVARCHAR(20),
COMPLETE_DATE NVARCHAR(20)
);

-- 14. T_USER_EXAM_RESULT
IF(OBJECT_ID('T_USER_EXAM_RESULT','U') IS NOT NULL)
DROP TABLE T_USER_EXAM_RESULT
GO
CREATE TABLE T_USER_EXAM_RESULT(
ID BIGINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
USER_ID NVARCHAR(30) NOT NULL,
USER_EXAM_GUID NVARCHAR(150) NOT NULL,
SCORE DECIMAL(18,2),
EXAM_CONTENT NVARCHAR(MAX) NOT NULL
);

-- 15. T_USER_EXAM_SCORE
IF(OBJECT_ID('T_USER_EXAM_SCORE','U') IS NOT NULL)
DROP TABLE T_USER_EXAM_SCORE
GO
CREATE TABLE T_USER_EXAM_SCORE(
ID BIGINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
USER_ID NVARCHAR(30) NOT NULL,
USER_NAME NVARCHAR(30) NOT NULL,
USER_EXAM_GUID NVARCHAR(150) NOT NULL,
SINGLE_SELECT_SCORE DECIMAL(20,2) DEFAULT(0),
MULTI_SELECT_SCORE DECIMAL(20,2) DEFAULT(0),
JUDGE_SCORE DECIMAL(20,2) DEFAULT(0),
READER_SCORE DECIMAL(20,2) DEFAULT(0),
EASSAY_SCORE DECIMAL(20,2) DEFAULT(0),
WRITING_SCORE DECIMAL(20,2) DEFAULT(0),
FILL_BANK_SCORE DECIMAL(20,2) DEFAULT(0),
TOTAL_SCORE DECIMAL(20,2) DEFAULT(0)
);


-- 17. T_USER_EXAM_HISTORY
IF(OBJECT_ID('T_USER_EXAM_HISTORY','U') IS NOT NULL)
DROP TABLE T_USER_EXAM_HISTORY
GO
CREATE TABLE T_USER_EXAM_HISTORY(
ID BIGINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
USER_ID NVARCHAR(30) NOT NULL,
USER_NAME NVARCHAR(30) NOT NULL,
USER_EXAM_GUID NVARCHAR(150) NOT NULL,
QUESTION_GUID NVARCHAR(150) NOT NULL,
QUESTION_TYPE NVARCHAR(20),
QUESTION_ORDER INT,
QUESTION_CONTENT NVARCHAR(500),
ANSWER NVARCHAR(500),
SCORE DECIMAL(18,2),
USER_ANSWER NVARCHAR(MAX),
USER_SCORE DECIMAL(18,2),
ANSWER_STATUS NVARCHAR(10)
);