CREATE TABLE [dbo].[BuyNowPayLater]
(
	[ID] INT NOT NULL  IDENTITY, 
    [CustomerID] INT NOT NULL, 
    [FirstName] NCHAR(50) NOT NULL, 
    [LastName] NCHAR(50) NOT NULL, 
    [Email] NVARCHAR(MAX) NOT NULL, 
    [ConfirmEmail] NVARCHAR(MAX) NOT NULL, 
    [Employeed] BIT NOT NULL, 
    [BuyNowPayLater] BIT NOT NULL, 
    CONSTRAINT [PK_BuyNowPayLater] PRIMARY KEY ([ID])
)
