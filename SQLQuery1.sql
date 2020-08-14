Create Table tblOrder (
	ID int identity,
	CusName nvarchar(20),
	Total float,
	Status nvarchar(20))

Create Table tblOrderDetails (
	ID int identity,
	OrderID int,
	ItemID varchar(50),
	ItemName varchar(50),
	ItemPrice float,
	ItemQuantity int)

	Insert into [dbo].[tblOrder] values('cus',500,'Pending') ;SELECT SCOPE_IDENTITY();