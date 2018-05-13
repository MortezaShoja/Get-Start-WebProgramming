CREATE PROC DEL_Phone @ID INT AS
	DELETE Phones
	WHERE ID=@ID
------------------------
CREATE PROC INS_Phone @F VARCHAR(50),
@N VARCHAR(50),@P VARCHAR(50)AS
INSERT INTO Phones(family,[name],phone)
VALUES(@F,@N,@P)
------------------------
CREATE PROC UPD_Phone @ID INT,@F VARCHAR(50),
@N VARCHAR(50),@P VARCHAR(50) WITH ENCRYPTION AS
	UPDATE phones
	SET family=@F
	,[Name]=@N,
	phone=@P
	WHERE ID=@ID
-------------------------
CREATE FUNCTION GetPhone(@F VARCHAR(50),@N VARCHAR(50))
RETURNS @T TABLE(Family VARCHAR(50),
[name] VARCHAR(50),Phone VARCHAR(50)) AS
BEGIN
	INSERT INTO @T
	SELECT family,[name],phone
	FROM phones
	WHERE family=@F AND [name]=@N
RETURN
END

DROP FUNCTION getphone

SELECT * 
FROM dbo.getphone('ramezani','shahram')



