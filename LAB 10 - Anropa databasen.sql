SELECT ProductName, UnitPrice, CategoryName
FROM Products
JOIN Categories ON Products.CategoryID = Products.CategoryID
ORDER BY CategoryName, ProductName


SELECT Customers.CompanyName, Count(*) AS TotalOrders 
FROM Orders
JOIN Customers ON Orders.CustomerID = Customers.CustomerID
GROUP BY CompanyName
ORDER BY TotalOrders DESC

SELECT FirstName, LastName, Title, TerritoryDescription 
FROM Employees
JOIN EmployeeTerritories ON Employees.EmployeeID = EmployeeTerritories.EmployeeID
JOIN Territories ON EmployeeTerritories.TerritoryID = Territories.TerritoryID
ORDER BY FirstName