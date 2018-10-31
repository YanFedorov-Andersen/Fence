CREATE PROCEDURE [dbo].[CreateUser]
@FirstName NVARCHAR(30),
@LastName NVARCHAR(30),
@DateOfBirth DATETIME,
@Username NVARCHAR(30),
@CustomerID INT
AS
BEGIN
INSERT INTO UserEntity (
FirstName,
LastName,
DateOfBirth,
Username)
VALUES (
@FirstName,
@LastName,
@DateOfBirth,
@Username)

SET @CustomerID = SCOPE_IDENTITY()

SELECT Id FROM UserEntity WHERE UserEntity.Id = @CustomerID
END
--DECLARE @date date = '12-21-16';  
--EXECUTE CreateUser
--@FirstName = "Jane",
--@LastName = "Peterson",
--@DateOfBirth = @date,
--@Username = "_janePet",
--@CustomerId = 0
