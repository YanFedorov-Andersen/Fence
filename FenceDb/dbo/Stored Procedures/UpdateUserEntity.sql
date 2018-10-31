CREATE PROC [dbo].[UpdateUserEntity]
@UserId int,
@FirstName NVARCHAR(20),
@LastName NVARCHAR(20),
@DateOfBirth DATETIME,
@Username NVARCHAR(20)

AS
BEGIN

UPDATE UserEntity
SET FirstName = @FirstName,
	LastName = @LastName,
	DateOfBirth = @DateOfBirth,
	Username = @Username
WHERE Id = @UserId

SELECT Id from UserEntity WHERE Id = @UserId
END