SET STATISTICS PROFILE ON
SELECT OrderID
  FROM customers AS c INNER JOIN dbo.Orders AS o ON c.CustomerID = o.CustomerID
  