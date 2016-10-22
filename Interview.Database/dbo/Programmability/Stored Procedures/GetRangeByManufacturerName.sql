CREATE PROCEDURE GetRangeByManufacturerName (@manufacturerName nVarchar(50)) AS
BEGIN
	SELECT *
		FROM [Range] r
		WHERE ManufacturerID = (SELECT ManufacturerID FROM Manufacturer WHERE ManufacturerName = @manufacturerName)
END;
