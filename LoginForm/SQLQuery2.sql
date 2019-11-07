CREATE PROC UserAdd
@UserID int,
@UserName varchar(50),
@Password varchar(50)
AS
	INSERT INTO LoginInfo(UserID, UserName, Password)
	VALUES(@UserID, @UserName, @Password)