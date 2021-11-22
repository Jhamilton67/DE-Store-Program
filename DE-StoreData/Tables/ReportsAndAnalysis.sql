CREATE TABLE [dbo].[ReportsAndAnalysis]
(
	[Id] INT NOT NULL , 
    [ReportID] INT NOT NULL, 
    [ShopName ] NVARCHAR(50) NOT NULL, 
    [ShopLocation] NVARCHAR(50) NOT NULL, 
    [ItemsSold] INT NOT NULL, 
    [CustomerFootFall] INT NOT NULL, 
    [Date] DATE NOT NULL, 
    CONSTRAINT [PK_ReportsAndAnalysis] PRIMARY KEY ([Id])
)
