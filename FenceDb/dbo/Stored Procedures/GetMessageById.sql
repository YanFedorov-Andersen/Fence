--CREATE PROCEDURE GetAllMessages
--AS
--BEGIN
--SELECT * From MessageEntity
--END

CREATE PROCEDURE [dbo].[GetMessageById]
@Id INT
AS
BEGIN
SELECT * From MessageEntity WHERE MessageEntity.Id = @Id
END