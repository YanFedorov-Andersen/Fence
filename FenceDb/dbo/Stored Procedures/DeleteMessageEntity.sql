--CREATE PROCEDURE GetAllMessages
--AS
--BEGIN
--SELECT * From MessageEntity
--END

--CREATE PROCEDURE GetAllUserMessages
--@UserId INT
--AS
--BEGIN
--SELECT * From MessageEntity WHERE MessageEntity.UserEntityId = @UserId
--END

--CREATE PROC UpdateMessageEntity
--@MessageId int,
--@TextField NVARCHAR(20),
--@LeaveDate DATETIME,
--@LengthField INT,
--@Stars SMALLINT,
--@PaidMessage BIT

--AS
--BEGIN

--UPDATE MessageEntity
--SET TextField = @TextField,
--	LeaveDate = @LeaveDate,
--	LengthField = @LengthField,
--	Stars = @Stars,
--	PaidMessage = @PaidMessage
--WHERE Id = @MessageId

--SELECT Id from MessageEntity WHERE Id = @MessageId
--END

--CREATE PROCEDURE CreateMessage
--@MessageId int,
--@TextField NVARCHAR(20),
--@LeaveDate DATETIME,
--@LengthField INT,
--@Stars SMALLINT,
--@PaidMessage BIT
--AS
--BEGIN
--INSERT INTO MessageEntity (
--TextField,
--LeaveDate,
--LengthField,
--Stars,
--PaidMessage )
--VALUES (
--@TextField,
--@LeaveDate,
--@LengthField,
--@Stars,
--@PaidMessage
--)

--SET @MessageId = SCOPE_IDENTITY()

--SELECT Id FROM MessageEntity WHERE MessageEntity.Id = @MessageId
--END

CREATE PROC [dbo].[DeleteMessageEntity]
@MessageId int
AS
BEGIN
DELETE FROM MessageEntity 
WHERE Id = @MessageId

END