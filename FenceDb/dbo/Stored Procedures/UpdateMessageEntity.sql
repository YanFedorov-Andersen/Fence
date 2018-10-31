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

CREATE PROC [dbo].[UpdateMessageEntity]
@MessageId int,
@TextField NVARCHAR(20),
@LeaveDate DATETIME,
@LengthField INT,
@Stars SMALLINT,
@PaidMessage BIT

AS
BEGIN

UPDATE MessageEntity
SET TextField = @TextField,
	LeaveDate = @LeaveDate,
	LengthField = @LengthField,
	Stars = @Stars,
	PaidMessage = @PaidMessage
WHERE Id = @MessageId

SELECT Id from MessageEntity WHERE Id = @MessageId
END