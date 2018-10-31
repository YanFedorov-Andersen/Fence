--CREATE PROCEDURE GetAllMessages
--AS
--BEGIN
--SELECT * From MessageEntity
--END

CREATE PROCEDURE [dbo].[GetAllUserMessages]
@UserId INT
AS
BEGIN
SELECT * From MessageEntity WHERE MessageEntity.UserEntityId = @UserId
END