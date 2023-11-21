-- CREATE DATABASE Nov21
-- USE Nov21

ALTER FUNCTION FormatNumber(@number VARCHAR(50))
RETURNS VARCHAR(40)
BEGIN
DECLARE @checklength int = NULL;

IF  @number LIKE '+994[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
	SET @checklength = 4;
ELSE IF @number LIKE '0[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
	SET @checklength = 1;
ELSE
	RETURN 'Invalid input!';

DECLARE @country_code char(4) = '+994';
DECLARE @carrier_code char(2) = SUBSTRING(@number,@checklength+1,2);
DECLARE @numbers1 char(3) = SUBSTRING(@number,@checklength+3,3); 
DECLARE @numbers2 char(2) = SUBSTRING(@number,@checklength+6,2);
DECLARE @numbers3 char(2) = SUBSTRING(@number,@checklength+8,2);

RETURN concat(@country_code,' (',@carrier_code,') ',@numbers1,'-',@numbers2,'-',@numbers3);
END


SELECT dbo.FormatNumber('0518209676');
