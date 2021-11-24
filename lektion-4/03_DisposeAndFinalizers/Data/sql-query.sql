DECLARE @cmd nvarchar(1000) 
DECLARE @MyTableName nvarchar(100)
DECLARE @counter int SET @counter = 1
DECLARE @value nvarchar(50) SET @value= 'MyValue'

WHILE @counter < 200
BEGIN
	SET @MyTableName = 'TableNr' + CAST(@counter as nvarchar(100))
	SET @cmd = 'CREATE TABLE dbo.' + quotename(@MyTableName) + '( Id int not null identity primary key, Name nvarchar(50) not null );';
	EXEC(@cmd)

	
	SET @cmd = 'INSERT INTO' + quotename(@MyTableName) + 'VALUES('+ quotename(@value) +')'
	SET @counter = @counter + 1
END

SET @counter = 1
WHILE @counter < 200
BEGIN
	SET @MyTableName = 'TableNr' + CAST(@counter as nvarchar(100))
	SET @cmd = 'INSERT INTO' + quotename(@MyTableName) + '(Name) VALUES('+ @value +')'
	SET @counter = @counter + 1
END