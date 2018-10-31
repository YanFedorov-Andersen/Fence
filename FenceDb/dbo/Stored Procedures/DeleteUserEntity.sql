CREATE PROC [dbo].[DeleteUserEntity]
@UserId int
AS
BEGIN
DELETE FROM UserEntity 
WHERE Id = @UserId

END