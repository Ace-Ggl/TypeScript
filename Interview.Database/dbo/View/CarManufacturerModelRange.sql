CREATE VIEW CarManufacturerModelRange AS
	SELECT m.ManufacturerId,
		   m.ManufacturerName,
		   r.RangeId,
		   r.RangeName
		FROM Manufacturer m
		JOIN [Range] r ON r.ManufacturerId = m.ManufacturerId
