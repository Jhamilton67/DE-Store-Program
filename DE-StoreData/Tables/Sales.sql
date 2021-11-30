CREATE TABLE [dbo].[Sales]
(
	[Id] INT NOT NULL , 
    [SaleID] INT NOT NULL, 
    [SaleTypes] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Sales] PRIMARY KEY ([Id])
)
