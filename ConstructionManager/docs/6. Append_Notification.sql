IF(OBJECT_ID('T_NOTIFICATION_INFO','U') IS NOT NULL)
DROP TABLE T_NOTIFICATION_INFO;
CREATE TABLE T_NOTIFICATION_INFO(
ID BIGINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
KEYWORD NVARCHAR(30) NOT NULL,
CONTENT NVARCHAR(30) NOT NULL
);

INSERT INTO T_NOTIFICATION_INFO (KEYWORD,CONTENT) VALUES ('NOTIFICATION_PWD','123456');