CREATE PROCEDURE [dbo].[GetUserById]
@Id INT
AS
BEGIN
SELECT * From UserEntity WHERE UserEntity.Id = @Id
END