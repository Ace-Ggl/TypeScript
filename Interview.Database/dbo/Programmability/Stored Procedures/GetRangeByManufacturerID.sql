CREATE PROCEDURE GetRangeByManufacturerID (@manufacturerID Integer) AS
BEGIN
	SELECT *
		FROM [Range]
		WHERE ManufacturerID = @manufacturerID
END;
