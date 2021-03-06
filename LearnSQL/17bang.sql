﻿----建库
--CREATE DATABASE _17Bang 

----建表
--USE _17Bang
--CREATE TABLE TUser(
--Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
--UserName NVARCHAR(10) NOT NULL,
--PassWord NVARCHAR(10) NOT NULL,
--IdentifyingCode NCHAR (10) NOT NULL,
--Inviter         NCHAR (10) NOT NULL,
--InvitationCode  NCHAR (10) NOT NULL,
--)
--CREATE TABLE TProblem(
--    [Id]         INT NOT NULL,       -- IDENTITY (1, 1) NOT NULL,
--    [Title]      NVARCHAR (50)  NOT NULL,
--    [Content]    NVARCHAR (100) NOT NULL,
--    --[Author]     NVARCHAR (10)  NOT NULL,
--    [Reward]     INT            DEFAULT ((10)) NOT NULL,
--    [NeedRemote] BIT           NOT NULL
--   -- CONSTRAINT [PK_TProblem] PRIMARY KEY ([Id])
--	CONSTRAINT _TUser_TProblem FOREIGN KEY (Id) REFERENCES TUser(Id) 
--)

----插入数据
--INSERT TUser (UserName,PassWord,IdentifyingCode,Inviter,InvitationCode)
--VALUES(N'luwei',6666,1224,N'feige',2332)
--INSERT TProblem VALUES(N'我模仿cw这个snippet添加一个console.writeline的Snippet，添加完成后在VS编辑器上输入cw然后Tab确实是出来代码了，看起来用作用了',
--N'feige',10,N'VS添加snippet后，输入代码时没有智能提示',1)

----修改列（类型）  增加，删除列（数量，约束）
--ALTER TABLE TUser DROP COLUMN UserName
--ALTER TABLE TUser ADD UserName NVARCHAR(10)
--ALTER TABLE TUser ALTER COLUMN UserName NVARCHAR(12)
--ALTER TABLE TProblem ADD CONSTRAINT _Id PRIMARY KEY(Id) 
--ALTER TABLE TProblem ADD CONSTRAINT Scope CHECK(Reward>5)
--ALTER  TABLE TProblem DROP Scope

----多列主键语法
--PRIMARY KEY CLUSTERED ([Author], [Title])

----外键
 --ALTER TABLE TProblem ADD CONSTRAINT FK_TUser_TProblem FOREIGN KEY (Id) REFERENCES TUser(Id)

 ----删除表（数据，行，数据，整张表，数据库）
 --DELETE TProblem
 --DELETE TProblem WHERE Id=1
 --TRUNCATE TABLE TProblem       不会产生日志
 --DROP TABLE TProblem
 --DROP TABLE 17Bang

 ----更新数据
 --UPDATE TUser SET PassWord=8888 WHERE PassWord=6666
-- ALTER TABLE TUser ADD Name NVARCHAR(10)
--UPDATE TUser SET Name=UserName 
--SELECT PassWOrd FROM TUser

----表单查找(分组,排序，LIKE通配符，聚合函数)
--SELECT TOP(3)WITH TIES Author,Reward,Content   FROM TProblem WHERE Author=N'feige'
--GROUP BY Author,Reward,Content  
--ORDER BY Author,Reward DESC
--SELECT Content FROM TProblem WHERE Content LIKE N'__[^九]%' 
--SELECT Author,COUNT(Content) AS 数量,SUM(Reward) AS 赏金总数,AVG(Reward) AS 赏金平均值 FROM TProblem 
--GROUP BY Author

----把一个表数据（列，行）插入新表（复制一个新表），在旧表插入另一个表数据（多行）
--SELECT *  INTO TNewProblem  FROM TProblem WHERE Author IS NOT NULL AND Reward IS NOT NULL
--INSERT TNewProblem  SELECT Title,Content, Reward,NeedRemote,TUserId,Author,PublishTime FROM TProblem WHERE Reward=27 
--SELECT ROW_NUMBER() OVER (PARTITION BY Author ORDER BY Author),Author FROM TProblem
--SELECT DISTINCT Author ,AVG(Reward) OVER(PARTITION BY Author) AS 平均值,
--MAX(Reward) OVER(PARTITION BY Author)AS最大值,
--MIN(Reward) OVER(PARTITION BY Author) AS 最小值 INTO TProblemStatus  FROM TProblem
--UPDATE TProblem SET NeedRemote=(CASE NeedRemote WHEN 1 THEN 0 ELSE 1 END )

----行列转换
--SELECT Name,MAX(CASE Subject  WHEN 'C#' THEN Score ELSE 0 END) AS C#,
--MAX(CASE Subject  WHEN 'SQL' THEN Score ELSE 0 END) AS SQL,
--MAX(CASE Subject  WHEN 'Javascript' THEN Score ELSE 0 END) AS Javascript 
--FROM TScore  
--GROUP BY Name

--SELECT PassWord,UserName INTO TNewUser FROM TUser
--INSERT TUser SELECT PassWord,UserName FROM TUser WHERE Id=1
----CASE表达式类，似于c#里的分支
--SELECT Author,CASE Reward WHEN 10 THEN 100 ELSE Reward END FROM TProblem

----OVER语法，排名函数（分组排序）
--SELECT ROW_NUMBER() OVER(PARTITION BY Author ORDER BY Author),Author FROM TProblem
--SELECT RANK() OVER(PARTITION BY Author ORDER BY Reward),Author,Reward FROM TProblem
--SELECT NTILE(2) OVER(PARTITION BY Author ORDER BY Reward),Author,Reward FROM TProblem

----联表JOIN（水平连接）UNION(纵向连接)
--SELECT DENSE_RANK() OVER(PARTITION BY Author ORDER BY Reward),Author,Reward FROM TProblem
--SELECT P.Id,P.Title,U.Id,U.UserName FROM TProblem P CROSS JOIN TUser U
--SELECT P.Id,P.Title,U.Id,U.UserName FROM TProblem P INNER JOIN TUser U ON P.Id=U.Id         后面可以加WHERE效果与AND相等
--SELECT P.Id,P.Title,U.Id,U.UserName FROM TProblem P RIGHT JOIN TUser U ON P.Id=U.Id          后面可加WHERE条件，但是加AND没有效果

----数据库（备份，恢复）
--USE master        确保当前数据库没有被使用
--GO              分批执行
--BACKUP DATABASE _17Bang TO DISK='path and file_name'(路径和文件夹名)  
--RESTORE DATABASE _17Bang FROM DISK='path and file_name'(路径和文件夹名)  

--JOIN和UNION
-- SELECT a.Title,b.UserName 
-- FROM TProblem a LEFT JOIN TUser b
--ON a.TUserId=b.Id
-- SELECT a.Title,b.UserName 
-- FROM TProblem a CROSS JOIN TUser b

--DELETE TUser 
--FROM TProblem a RIGHT JOIN TUser b
--ON a.TUserId=b.Id
--WHERE a.Id IS NULL

--SELECT a.UserName ,b.UserName
--FROM TUser a LEFT JOIN TUser b
--ON a.Inviter=b.Id
--SELECT Author,Title,Content,PublishTime FROM TProblem 
--WHERE Author=N'feige'
--UNION ALL
--SELECT Author,Title,Content,PublishTime FROM TArticle
--WHERE Author=N'feige'
--UNION ALL
--SELECT Author,Title,Content,PublishTime FROM TSuggest
--WHERE Author=N'feige'
--ORDER BY PublishTime DESC

--UPDATE TProblem SET Reward = (SELECT Reward FROM TProblem WHERE Id = 7),
--Title = (SELECT Title FROM TProblem WHERE Id = 7) 
-- WHERE Id = 8

--USE master
--GO
----BACKUP DATABASE _17Bang TO DISK ='C:\Users\自由之翼\source\repos\assignment\_17Bang备份'
--RESTORE DATABASE _17Bang FROM DISK='C:\Users\自由之翼\source\repos\assignment\_17Bang备份'

--DELETE TProblem  WHERE Reward =(SELECT MIN(ipr.Reward) FROM TProblem ipr  WHERE Author=ipr.Author GROUP BY Author)

--SELECT UserName  FROM TUser 
--WHERE Id NOT IN(
--SELECT DISTINCT Inviter FROM TUser 
--WHERE Inviter IS NOT NULL
--)

--CREATE TABLE [dbo].[TRelation] (
--    [Id]        INT IDENTITY (1, 1) NOT NULL,
--    [TProblemId] INT NOT NULL,
--    [KeyId] INT NOT NULL,
--    PRIMARY KEY CLUSTERED ([Id] ASC),
--    CONSTRAINT [FK_TKeyId] FOREIGN KEY ([KeyId]) REFERENCES [dbo].[TKey] ([Id]),
--    CONSTRAINT [FK_TProblemId] FOREIGN KEY ([TProblemId]) REFERENCES [dbo].[TProblem] ([Id])
--);
--INSERT TRelation VALUES(1,1) INSERT TRelation VALUES(1,13) 
--INSERT TRelation VALUES(1,30) INSERT TRelation VALUES(1,22) 
--INSERT TRelation VALUES(4,1) INSERT TRelation VALUES(4,12) 
--INSERT TRelation VALUES(4,32) INSERT TRelation VALUES(4,20) 
--INSERT TRelation VALUES(5,4) INSERT TRelation VALUES(5,17) 
--INSERT TRelation VALUES(6,22) INSERT TRelation VALUES(7,29) 
--INSERT TRelation VALUES(7,9) INSERT TRelation VALUES(8,26) 
--INSERT TRelation VALUES(9,3) INSERT TRelation VALUES(10,11) 
--INSERT TRelation VALUES(10,3) INSERT TRelation VALUES(11,18) 
--INSERT TRelation VALUES(12,3) INSERT TRelation VALUES(12,17) 

--UPDATE TProblem SET Reward=Reward*2
--WHERE Id IN(SELECT a.Id FROM TProblem a  
--JOIN TRelation b ON a.Id=b.TProblemId 
--GROUP BY a.Id HAVING COUNT(a.Id)>3)

--SELECT * FROM TUser
--WHERE Id IN (SELECT Author FROM TProblem GROUP BY Author HAVING COUNT(Author)>1)
--SET STATISTICS IO ON
--SET STATISTICS TIME ON
--SELECT Title FROM TProblem opr
--WHERE opr.PublishTime =(SELECT MAX(ipr.PublishTime) 
--FROM TProblem ipr WHERE opr.Author=ipr.Author  GROUP BY Author)	
--SET STATISTICS IO OFF

--SET STATISTICS IO ON
--SELECT B.Id,Author,Title,PublishTime
--FROM TProblem B
--WHERE PublishTime = (SELECT MAX(PublishTime)
--FROM TProblem A WHERE A.Author=B.Author)
--SET STATISTICS IO OFF
--SELECT UserName FROM TUser
--WHERE Id IN (SELECT Author FROM TProblem GROUP BY Author HAVING MIN(Reward)>5)

----索引
--CREATE TABLE Message(
--Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
--FromUser NVARCHAR(10) NOT NULL,
--ToUser NVARCHAR(10) NOT NULL,
--UrgentLevel INT NOT NULL, 
--Kind NVARCHAR(10) NOT NULL,
--HasRead BIT NOT NULL, 
--IsDelete BIT NOT NULL,
--Content NVARCHAR(100)
--) 
--ALTER TABLE TMessage ADD CONSTRAINT AK_FromUser UNIQUE(FromUser)
--SELECT [name], [type],  is_unique, is_primary_key, is_unique_constraint
--FROM sys.indexes 
--WHERE [NAME]='AK_FromUser'

--ALTER TABLE TMessage DROP CONSTRAINT PK__TMessage__3214EC073CC4D4F9 
--CREATE CLUSTERED INDEX CL_ToUser ON TMessage(ToUser)
--ALTER TABLE TMessage ADD CONSTRAINT PK_Id PRIMARY KEY(Id) 
--CREATE UNIQUE NONCLUSTERED INDEX NCL_Id ON TMessage(Id)
--DROP INDEX TMessage.NCL_Id

--SELECT *
----[name], [type],  is_unique, is_primary_key, is_unique_constraint
--FROM sys.indexes 
--WHERE [NAME]='NCL_Id'

--ALTER TABLE TMessage ADD CONSTRAINT FK_UrgentLevel FOREIGN KEY (UrgentLevel) REFERENCES TUser(Id) 
--SELECT name,type,is_unique,is_primary_key,is_unique_constraint  FROM sys.indexes
--WHERE name='FK_UrgentLevel'

--SELECT TOP(1) * FROM TProblem GROUP BY Author
--SELECT Author,MAX(Id) FROM TProblem GROUP BY Author

----创建全文索引
--CREATE FULLTEXT CATALOG  CA_             --创建目录   
--DROP FULLTEXT CATALOG  CA_                 --删除全文索引

--CREATE FULLTEXT INDEX ON Message(...)
--KEY INDEX  FU_
--ON CA_

--作业
--SELECT *FROM TProblem otp JOIN  
--(SELECT MAX(ire.COKD) OVER(PARTITION BY Author)maxco,ire.TPD,
--ipr.Author AS Auth,COKD  FROM TProblem ipr JOIN
--(SELECT TProblemId TPD,COUNT(KeyId)COKD  FROM TRelation
--GROUP BY TProblemId) ire
--ON ipr.Id=ire.TPD
--) opr
--ON otp.Author=opr.Auth AND otp.Id=opr.TPD
--WHERE maxco=COKD
----
--SELECT * FROM
--(SELECT MAX(co) OVER(PARTITION BY Author) ma,* FROM
--(SELECT COUNT(*) co,TR.TProblemId ,Author
--FROM  TProblem TP JOIN TRelation TR
--ON TP.Id=TR.TProblemId
--GROUP BY Author,TR.TProblemId) A
--)B  JOIN TProblem C
--ON B.Author=C.Author AND B.TProblemId=C.Id
--WHERE B.ma=B.co
----公用表
--WITH A AS(SELECT COUNT(*) co,TR.TProblemId ,Author
--FROM  TProblem TP JOIN TRelation TR
--ON TP.Id=TR.TProblemId
--GROUP BY Author,TR.TProblemId)

--SELECT * FROM
--(SELECT MAX(co) OVER(PARTITION BY Author) ma,* FROM A
--)B  JOIN TProblem C
--ON B.Author=C.Author AND B.TProblemId=C.Id
--WHERE B.ma=B.co

----临时表
--CREATE TABLE #COUNT(
--co int,
--TProblemId int,
--Author int
--)
--INSERT #COUNT SELECT * FROM (SELECT COUNT(*) co,TR.TProblemId ,Author
--FROM  TProblem TP JOIN TRelation TR
--ON TP.Id=TR.TProblemId
--GROUP BY Author,TR.TProblemId)A

--SELECT * FROM
--(SELECT MAX(co) OVER(PARTITION BY Author) ma,* FROM tempdb.#COUNT
--)B  JOIN TProblem C
--ON B.Author=C.Author AND B.TProblemId=C.Id
--WHERE B.ma=B.co

----表变量
--DECLARE @TVariable TABLE(
--co int,
--TProblemId int,
--Author int
--)
--INSERT @TVariable SELECT * FROM (SELECT COUNT(*) co,TR.TProblemId ,Author
--FROM  TProblem TP JOIN TRelation TR
--ON TP.Id=TR.TProblemId
--GROUP BY Author,TR.TProblemId)A

----SELECT * FROM
----(SELECT MAX(co) OVER(PARTITION BY Author) ma,* FROM tempdb.#COUNT
----)B  JOIN TProblem C
----ON B.Author=C.Author AND B.TProblemId=C.Id
----WHERE B.ma=B.co

--SELECT * FROM @TVariable

----事物(显示事物)
--ALTER TABLE TUser ADD CONSTRAINT CK_Positive  CHECK(Balance>0)  

--SELECT * FROM TUser

--SET XACT_ABORT ON
--BEGIN TRANSACTION

--	UPDATE TUser SET Balance = Balance + 150 WHERE Id = 1
--	UPDATE TUser SET Balance = Balance + 150 WHERE Id = 6
--COMMIT TRANSACTION
--SET XACT_ABORT OFF

----作业
--BEGIN TRANSACTION 
--BEGIN TRY  
--INSERT  TProblem VALUES(N'看完',N'健康度',50,1,2,'2019/4/14') 
--UPDATE  TUser SET   balance=balance-50 WHERE Id=2	
--COMMIT TRANSACTION
--END TRY
--BEGIN CATCH
--IF @@TRANCOUNT>0
--ROLLBACK;
--THROW
--END CATCH
----隐式事物
--SET IMPLICIT_TRANSACTIONS ON
--	UPDATE TUser SET Balance = Balance + 150 WHERE Id = 1
--	UPDATE TUser SET Balance = Balance + 150 WHERE Id = 6
--	COMMIT TRAN
--SET IMPLICIT_TRANSACTIONS OFF
--COMMIT TRAN           --一定要结束，不然整个表就被索在事物里面了
--SELECT * FROM TUser

------锁
----(查看工具)
--EXEC sp_lock
----SELECT * FROM sys.dm_tran_locks
--SELECT 
--request_mode,request_session_id,request_status,
--request_type,resource_database_id 
--FROM sys.dm_tran_locks
--ORDER BY request_session_id
----作业
--UPDATE TUser SET Balance = Balance - 50 WHERE Id = 6
--SELECT  * FROM TUser
--UPDATE TUser SET Balance =100
--SELECT * FROM TUser
----1，丢失的更新
--BEGIN TRAN
----A想更新Balance为250
--	UPDATE TUser WITH(HOLDLOCK) SET Balance = Balance + 150 WHERE Id = 6
----B想更新Balance为200
--	UPDATE TUser SET Balance = Balance - 50 WHERE Id = 6
--COMMIT 
----2，脏读
--BEGIN TRAN
--	UPDATE TUser WITH(HOLDLOCK) SET Balance = Balance + 150 WHERE Id = 6
--	SELECT  * FROM TUser
--	ROLLBACK
----3,不可重复读
--BEGIN TRAN
--    SELECT  * FROM TUser WITH(HOLDLOCK)
--	UPDATE TUser SET Balance = Balance + 150 WHERE Id = 6	
--	COMMIT
--	SELECT  * FROM TUser
----4,幻影读
--BEGIN TRAN
--    SELECT  * FROM TUser WITH(HOLDLOCK)
--	DELETE TUser WHERE Id=7
--	INSERT TUser VALUES(6523,4,2637,N'luwei',100)
--	COMMIT
--	SELECT  * FROM TUser

--	SET TRANSACTION ISOLATION LEVEL  READ COMMITTED    --REPEATABLE READ

	--快照
--	SELECT * FROM sys.dm_tran_version_store 
--	DBCC USEROPTIONS
--	--（1，快照隔离）
--	ALTER DATABASE _17Bang SET ALLOW_SNAPSHOT_ISOLATION ON
--	ALTER DATABASE _17Bang SET ALLOW_SNAPSHOT_ISOLATION OFF
--	SET TRANSACTION ISOLATION LEVEL SNAPSHOT
--	BEGIN TRAN	
--	UPDATE TUser  SET Balance = Balance + 150 WHERE Id = 6
--	ROLLBACK
--		SELECT  * FROM TUser
--	--（2，基于快照的提交读）
--	ALTER DATABASE _17Bang SET READ_COMMITTED_SNAPSHOT ON  
--	ALTER DATABASE _17Bang SET READ_COMMITTED_SNAPSHOT OFF
--	SET TRANSACTION ISOLATION LEVEL  READ COMMITTED

--	--查询当前事物数量
--	SELECT @@TRANCOUNT
--	--查询当前进程数量
--	SELECT * FROM sys.sysprocesses
--select * from master.dbo.sysprocesses
--where dbid = DB_ID('_17bang')

----视图
--CREATE VIEW VTproblem 
--AS
--SELECT *  FROM TProblem
--WHERE Reward>50 WITH CHECK OPTION
--UPDATE VTproblem SET Reward=500 WHERE Id=5
--SELECT * FROM VTproblem


--CREATE VIEW V_TProblem_TUser
--AS
--SELECT A.Title,A.Reward,B.Id,B.UserName FROM TProblem A JOIN TUser B 
--ON A.Author=B.Id
----UPDATE V_TProblem_TUser SET Reward=100,UserName=N'fei'   
----WHERE Id=1          -- (错误示范，视图是JOIN语句构成时不能同时影响多个基表)

----作业
--1
--CREATE TABLE TResponse(
--Id int PRIMARY KEY identity(1,1), 
--Content Ntext NOT NULL,
--AuthorId int NOT NULL,
--ProblemId int NOT NULL,
--CreateTime DATE NOT NULL
--CONSTRAINT FK_ProblemId FOREIGN KEY (AuthorId) REFERENCES TUser(Id)
--) 
--INSERT TResponse VALUES(N'是第一位看',2,1,'2019/4/10')
--INSERT TResponse VALUES(N'回房间',3,4,'2019/4/11')
--INSERT TResponse VALUES(N'的合体时间',4,5,'2019/4/12')
--INSERT TResponse VALUES(N'水库位于',2,6,'2019/4/13')
--INSERT TResponse VALUES(N'圣维特u哦',6,7,'2019/4/14')
--INSERT TResponse VALUES(N'雷人剧场版',5,8,'2019/4/15')
--2
--ALTER VIEW  VResponse(ResponseId, Content, AuthorId,
--AuthorName, ProblemId,PrAuthorName, ProblemTitle,Reward, CreateTime)WITH ENCRYPTION, SCHEMABINDING
--AS
--SELECT TR.Id,TR.Content,TR.AuthorId,TU.UserName,TR.ProblemId,TUs.UserName,TP.Title,TP.Reward,TR.CreateTime 
--FROM dbo.TResponse TR 
--JOIN dbo.TUser TU ON TR.AuthorId=TU.Id
--JOIN dbo.TProblem TP ON TR.ProblemId=TP.Id 
--JOIN dbo.TUser TUs ON TP.Author=TUs.Id
--WHERE Reward>5 

--WITH CHECK OPTION
--DROP VIEW VResponse
--EXEC sp_helptext 'VResponse'
--3,4
--INSERT VResponse(Content, AuthorId,
-- ProblemId) VALUES ('dddddd',8,11)
-- SELECT  * FROM VResponse
--5
--CREATE VIEW VProblemKeyword(
--ProblemId , ProblemTitle, ProblemReward, KeywordAmount)WITH SCHEMABINDING 
--AS 
--SELECT TP.Id,TP.Title,TP.Reward,COUNT_BIG(*)COU
--FROM dbo.TProblem TP JOIN dbo.TRelation TR ON TP.Id=TR.TProblemId
--GROUP BY TP.Id,TP.Title,TP.Reward

--DROP VIEW VProblemKeyword
--CREATE UNIQUE CLUSTERED INDEX UCI_ProblemId ON VProblemKeyword(ProblemId)
--CREATE NONCLUSTERED INDEX NC_ProblemReward ON VProblemKeyword(ProblemReward)
--6
--INSERT  TProblem VALUES('SWD','健康度',50,1,2,'2019/4/16')
--INSERT TResponse(Content, AuthorId,
-- ProblemId) VALUES ('CCCC',7,15)
--SELECT * FROM VResponse                      ???

