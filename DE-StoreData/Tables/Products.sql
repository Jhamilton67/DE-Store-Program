CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL , 
    [ProductID] INT NOT NULL, 
    [SaleID] INT NOT NULL, 
    [ProductName] NVARCHAR(50) NOT NULL, 
    [Price ] MONEY NOT NULL, 
    [Quantity] INT NOT NULL, 
    CONSTRAINT [PK_Products] PRIMARY KEY ([Id])
)
