-- 1.ConstructionNode
IF EXISTS(SELECT * FROM sysobjects WHERE name='ConstructionNode') 
DROP TABLE ConstructionNode
GO
create table ConstructionNode(
    ID bigint identity(1,1) not null,
    ConstructionNo nvarchar(200) not null,
    Name nvarchar(100) not null,
    ConstructionStart nvarchar(200),
    CivilConstruction nvarchar(200),
    ElectricStart nvarchar(200),
    ElectronicTransfer nvarchar(200),
    PowerCut   nvarchar(200),
    PowerCut2    nvarchar(200),
    PowerCut3    nvarchar(200),
    InOperation    nvarchar(200),
    BeCompleted    nvarchar(200),
    CloseAnAccount    nvarchar(200),
    SendKnot    nvarchar(200),
    Archive    nvarchar(200)
 );
 
 -- 2.  AppendixFile
IF EXISTS(SELECT * FROM sysobjects WHERE name='AppendixFile') 
DROP TABLE AppendixFile
GO
create table AppendixFile(
    ID bigint identity(1,1) not null,
    ParentId bigint not null,
    FileOrder int,
    ConstructionNo nvarchar(200) not null,
    ConstructionField nvarchar(200),
    FileName nvarchar(200),
    FullFileName nvarchar(200),
    CreateDate nvarchar(200),
    FileType nvarchar(20),
    FileSize nvarchar(200),
    RemoteFilePath nvarchar(200),
    LocalFilePath nvarchar(200)
);

-- 3. ConstructionPlan
IF EXISTS(SELECT * FROM sysobjects WHERE name='ConstructionPlan') 
DROP TABLE ConstructionPlan
GO
create table ConstructionPlan(
    ID bigint identity(1,1) not null,
    ParentId bigint,
    ConstructionNo nvarchar(200) not null,
    PlanDate nvarchar(200),
    ConstructionItem nvarchar(200) not null,
    ConstructionPart nvarchar(100) not null,
    CivilWorks nvarchar(200),
    NumOfPerson nvarchar(10),
    Leader nvarchar(200),
    ConstructionMethod nvarchar(max),
    Remark nvarchar(200)
);

-- 4. ConstructionSubItem
IF EXISTS(SELECT * FROM sysobjects WHERE name='ConstructionSubItem') 
DROP TABLE ConstructionSubItem
GO
create table ConstructionSubItem(
ID bigint identity(1,1) not null,
ParentId bigint not null,
ItemName nvarchar(100) not null,
Feature nvarchar(200),
Unit nvarchar(200),
Part nvarchar(100),
WorkDone nvarchar(200),
DoneDate nvarchar(200)
);

-- 5. ConsturctionQuantity
IF EXISTS(SELECT * FROM sysobjects WHERE name='ConstructionQuantity') 
DROP TABLE ConstructionQuantity
GO
create table ConstructionQuantity(
ID bigint identity(1,1) not null,
ParentId bigint not null,
ConstructionNo nvarchar(200) not null,
ItemName nvarchar(100) not null,
ItemFeature nvarchar(200),
ItemUnit nvarchar(200),
DesignNum nvarchar(200),
ModifyNum nvarchar(200),
AllOfProcess nvarchar(200),
Reminder nvarchar(200)
);

-- 6. ConstructionOverallSchedule 施工总体进度
IF EXISTS(SELECT * FROM sysobjects WHERE name='ConstructionOverallSchedule') 
DROP TABLE ConstructionOverallSchedule
GO
create table ConstructionOverallSchedule(
ID bigint identity(1,1) not null,
ParentId bigint,
ProjectCode nvarchar(200) primary key not null,
ProjectName nvarchar(100),
ProjectSchedule nvarchar(100)
);

-- 7. Acceptance
IF EXISTS(SELECT * FROM sysobjects WHERE name='Acceptance') 
DROP TABLE Acceptance
GO
create table Acceptance(
ID bigint identity(1,1) not null primary key,
ProjectNo nvarchar(200),
ProjectName nvarchar(200),
ProjectKind nvarchar(1),
ItemName nvarchar(200),
ItemFeature nvarchar(200),
ItemUnit nvarchar(200),
Remark1 nvarchar(200),
Remark2 nvarchar(200),
Remark3 nvarchar(200),
Description nvarchar(200),
Question nvarchar(100),
Rectify nvarchar(200)
);

-- 8. AcceptanceImage
IF EXISTS(SELECT * FROM sysobjects WHERE name='AcceptanceImage') 
DROP TABLE AcceptanceImage
GO
create table AcceptanceImage(
ID bigint identity(1,1) not null primary key,
ParentId bigint,
ProjectNo nvarchar(200),
FileName nvarchar(200),
FullFileName nvarchar(100),
RemoteFilePath nvarchar(2000),
Description nvarchar(200),
ImageKind nvarchar(1)
);

-- 9. SubItemImage
IF EXISTS(SELECT * FROM sysobjects WHERE name='SubItemImage') 
DROP TABLE SubItemImage
GO
create table SubItemImage(
ID bigint identity(1,1) primary key not null,
ParentId bigint not null,
ImageName nvarchar(100),
ImageFullName nvarchar(100),
ImageRemotePath nvarchar(2000),
ImageType nvarchar(200),
ThumbnailRemotePath nvarchar(2000),
LocalPath nvarchar(2000),
Description nvarchar(200)
);

-- 10. SubItemFile
IF EXISTS(SELECT * FROM sysobjects WHERE name='SubItemFile') 
DROP TABLE SubItemFile
GO
create table SubItemFile(
ID bigint identity(1,1) primary key not null,
ParentId bigint not null,
FileName nvarchar(100),
FullFileName nvarchar(100),
FileType nvarchar(200),
RemoteFilePath nvarchar(2000),
LocalPath nvarchar(2000),
Description nvarchar(200)
);

-- 11. Notification

IF EXISTS(SELECT * FROM sysobjects WHERE name='Notification') 
DROP TABLE Notification
GO
create table Notification(
ID bigint identity(1,1) not null primary key,
Title nvarchar(100),
CreateDate nvarchar(20),
ModifyDate nvarchar(20),
Content nvarchar(max)
);

-- 12 LoginUser
IF EXISTS(SELECT * FROM sysobjects WHERE name='LoginUser') 
DROP TABLE LoginUser
GO
create table LoginUser(
ID bigint identity(1,1) not null primary key,
UserId nvarchar(200) not null,
UserName nvarchar(200) not null,
Pwd nvarchar(200)
);

INSERT INTO LOGINUSER (USERID,USERNAME,PWD) VALUES ('admin','admin','admin');

-- 13. MenuItem
IF EXISTS(SELECT * FROM sysobjects WHERE name='MenuItem') 
DROP TABLE MenuItem
GO
create table MenuItem(
ID bigint identity(1,1) not null primary key,
OrderNo int not null,
ItemId nvarchar(200) not null,
ItemName nvarchar(200),
ItemType nvarchar(100),
ParentId nvarchar(200),
Description nvarchar(200)
);

-- 14. Authority
IF EXISTS(SELECT * FROM sysobjects WHERE name='Authority') 
DROP TABLE Authority
GO
create table Authority(
ID bigint identity(1,1) not null primary key,
UserId nvarchar(200) not null,
UserName nvarchar(200),
ItemId nvarchar(200) not null,
ItemName nvarchar(200),
Description nvarchar(200)
);

-- 15. ConstructionLog
IF EXISTS(SELECT * FROM sysobjects WHERE name='ConstructionLog') 
DROP TABLE ConstructionLog
GO
create table ConstructionLog(
ID bigint identity(1,1) primary key,
ConstructionCode nvarchar(200) not null,
ConstructionName nvarchar(200) not null,
LogDate nvarchar(200),
Weather nvarchar(200),
Temperature nvarchar(10),
ConstructionEvent nvarchar(200),
Wind nvarchar(10),
People nvarchar(10),
ConstructionDescription nvarchar(1000),
SecurityLog nvarchar(1000)
);